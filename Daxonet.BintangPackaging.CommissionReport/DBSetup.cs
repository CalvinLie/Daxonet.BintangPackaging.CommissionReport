using AutoCount;
using AutoCount.Application;
using AutoCount.Data;
using AutoCount.UDF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Daxonet.BintangPackaging.CommissionReport
{
    public class DBSetup
    {
        private DBSetting myDBSetting { get; set; }
        private Dictionary<string, List<Field>> myFields = new Dictionary<string, List<Field>>();
        private Dictionary<string, string> mySqlScripts = new Dictionary<string, string>();
        private List<AutoCount.UDF.List> myLists = new List<AutoCount.UDF.List>();

        public static DBSetup Create(DBSetting dbSetting)
        {
            DBSetup command = null;
            if (dbSetting.ServerType == DBServerType.SQL2000)
            {
                command = new DBSetup();
            }
            else
            {
                dbSetting.ThrowServerTypeNotSupportedException();
            }
            command.myDBSetting = dbSetting;
            return command;
        }

        private void RegisterField(string tableName, Field field)
        {
            if (!myFields.ContainsKey(tableName))
                myFields.Add(tableName, new List<Field>());

            myFields[tableName].Add(field);
        }

        private Field RegisterField(string tableName, string fieldName, string caption, UDFType type, bool required, bool unique)
        {
            var field = new Field() { Name = fieldName, Caption = caption, Type = type };

            field.Properties.Required = required;
            field.Properties.Unique = unique;
            RegisterField(tableName, field);
            return field;
        }

        public void RegisterTextField(string tableName, string fieldName, string caption, int size, string listName = null, bool limitToList = false, MaskType maskType = MaskType.None, string inputMask = null, string defaultValue = null, bool required = false, bool unique = false)
        {
            var field = RegisterField(tableName, fieldName, caption, UDFType.Text, required, unique);

            if (defaultValue != null)
                field.TextProperties.DefaultValue = defaultValue;

            field.TextProperties.Size = size;

            if (listName != null)
                field.TextProperties.ListName = listName;

            field.TextProperties.LimitToList = limitToList;

            if (inputMask != null)
                field.TextProperties.InputMask = inputMask;
            field.TextProperties.MaskType = maskType;
        }

        public void RegisterDecimalField(string tableName, string fieldName, string caption, int scale = 0, int precision = 18, string formula = null, decimal? defaultValue = null, bool required = false, bool unique = false)
        {
            var field = RegisterField(tableName, fieldName, caption, UDFType.Decimal, required, unique);
            if (defaultValue != null)
                field.DecimalProperties.DefaultValue = defaultValue;

            if (formula != null)
                field.DecimalProperties.Formula = formula;
            field.DecimalProperties.Precision = precision;
            field.DecimalProperties.Scale = scale;
        }

        public void RegisterIntegerField(string tableName, string fieldName, string caption, int? defaultValue = null, bool required = false, bool unique = false)
        {
            var field = RegisterField(tableName, fieldName, caption, UDFType.Integer, required, unique);
            if (defaultValue != null)
                field.IntegerProperties.DefaultValue = defaultValue;
        }

        public void RegisterDateField(string tableName, string fieldName, string caption, DateType dateType, object defaultValue = null, bool required = false, bool unique = false)
        {
            var field = RegisterField(tableName, fieldName, caption, UDFType.Date, required, unique);
            if (defaultValue != null)
                field.DateProperties.DefaultValue = defaultValue;

            field.DateProperties.DateType = dateType;
        }

        public void RegisterBooleanField(string tableName, string fieldName, string caption, bool? defaultValue = null, bool required = false, bool unique = false)
        {
            var field = RegisterField(tableName, fieldName, caption, UDFType.Boolean, required, unique);
            if (defaultValue != null)
                field.BooleanProperties.DefaultValue = defaultValue;
        }

        public void RegisterMemoField(string tableName, string fieldName, string caption, string defaultValue = null, bool required = false, bool unique = false)
        {
            var field = RegisterField(tableName, fieldName, caption, UDFType.Memo, required, unique);
            if (defaultValue != null)
                field.MemoProperties.DefaultValue = defaultValue;
        }

        public void RegisterImageLinkField(string tableName, string fieldName, string caption, string defaultValue = null, bool required = false, bool unique = false)
        {
            var field = RegisterField(tableName, fieldName, caption, UDFType.ImageLink, required, unique);
            if (defaultValue != null)
                field.ImageLinkProperties.DefaultValue = defaultValue;
        }

        public void RegisterRichTextField(string tableName, string fieldName, string caption, string defaultValue = null, bool required = false, bool unique = false)
        {
            var field = RegisterField(tableName, fieldName, caption, UDFType.RichText, required, unique);
            if (defaultValue != null)
                field.Properties.DefaultValue = defaultValue;
        }

        public void RegisterSystemField(string tableName, string fieldName, string caption, string customDataType, bool showLabel = false, string defaultValue = null, bool required = false, bool unique = false)
        {
            var field = RegisterField(tableName, fieldName, caption, UDFType.System, required, unique);
            if (defaultValue != null)
                field.SystemProperties.DefaultValue = defaultValue;

            field.SystemProperties.CustomDataType = customDataType;
            field.SystemProperties.ShowLabel = showLabel;
        }

        public void RegisterTable(string tableName, string createTableSql)
        {
            RegisterSQLScript(string.Format("select count(*) from dbo.sysobjects where id = object_id('{0}') and OBJECTPROPERTY(id, N'IsUserTable') = 1", tableName), createTableSql);
        }

        public void RegisterField(string tableName, string fieldName, string createFieldSql)
        {
            RegisterSQLScript(string.Format("select count(*) from INFORMATION_SCHEMA.columns where TABLE_NAME = N'{0}' AND COLUMN_NAME = N'{1}' ", tableName, fieldName), createFieldSql);
        }

        public void RegisterSQLScript(string checkSql, string executeSql)
        {
            mySqlScripts.Add(checkSql, executeSql);
        }

        public void RegisterList(List list)
        {
            myLists.Add(list);
        }

        public void RegisterList(string listName, string[] items)
        {
            var list = new List();
            list.Name = listName;
            list.SetItems(items);
            myLists.Add(list);
        }

        public bool SetupDatabase(string title)
        {
            if (!CheckUpdateList() ||
                !CheckUpdateUDF() ||
                !CheckUpdateTable())
            {
                if (!AppMessage.ShowConfirmMessage(string.Format("Do you want to install {0} to this database?", title)))
                    return false;

                CheckUpdateList(false);
                CheckUpdateUDF(false);
                CheckUpdateTable(false);
            }
            return true;
        }

        private bool CheckUpdateList(bool checkOnly = true)
        {
            UDFList udfList = new UDFList(myDBSetting);
            bool result = true;
            bool updated = false;

            foreach (var list in myLists)
            {
                var dbList = udfList[list.Name];
                if (dbList == null)
                {
                    result = false;
                    if (checkOnly)
                        break;
                }
                else
                {
                    var dbItems = new List<string>(dbList.GetItems());
                    var items = list.GetItems();
                    foreach (var item in items)
                    {
                        if (!dbItems.Contains(item))
                        {
                            result = false;
                            if (checkOnly)
                                break;
                        }
                    }
                }

                if (checkOnly == false && result == false)
                {
                    if (dbList == null)
                    {
                        udfList.Add(list);
                    }
                    else
                    {
                        dbList.SetItems(list.GetItems());
                    }

                    updated = true;
                    result = true;
                }
            }
            if (updated)
                udfList.Save();

            return result;
        }

        private bool CheckUpdateUDF(bool checkOnly = true)
        {
            bool result = true;
            bool updated = false;

            foreach (var table in myFields)
            {
                UDFTable dbTable = new UDFTable(table.Key, myDBSetting);
                foreach (var field in table.Value)
                {
                    var dbField = dbTable[field.Name];
                    if (dbField == null)
                    {
                        result = false;
                        if (checkOnly)
                            break;
                    }
                    else
                    {
                        /*
                        foreach (DataColumn property in dbTable.Table.Columns)
                        {
                            if (!field.myRow.Table.Columns.Contains(property.ColumnName))
                                continue;
                            if (dbField.myRow[property.ColumnName] != field.myRow[property.ColumnName])
                            {
                                result = false;
                                if (checkOnly)
                                    break;
                            }
                        }*/
                    }

                    if (checkOnly == false && result == false)
                    {
                        if (dbField == null)
                        {
                            dbTable.Add(field);
                        }
                        else
                        {

                            foreach (DataColumn property in dbTable.Table.Columns)
                            {
                                if (!field.myRow.Table.Columns.Contains(property.ColumnName))
                                    continue;
                                dbField.myRow[property.ColumnName] = field.myRow[property.ColumnName];
                            }
                        }
                        updated = true;
                        result = true;
                    }
                }

                if (updated)
                {
                    dbTable.Save();
                    updated = false;
                }
            }
            return result;
        }

        private bool CheckUpdateTable(bool checkOnly = true)
        {
            bool result = true;

            foreach (var table in mySqlScripts)
            {
                if (AutoCount.Converter.ToInt32(myDBSetting.ExecuteScalar(table.Key)) == 0)
                {
                    result = false;
                    if (checkOnly)
                        break;
                }

                if (checkOnly == false && result == false)
                {
                    myDBSetting.ExecuteNonQuery(table.Value, null);
                    result = true;
                }
            }

            return result;
        }


        public void RegisterCommonSetupTable()
        {
            this.RegisterTable("DaxonetPlugInsSetupV2", @"CREATE TABLE [dbo].[DaxonetPlugInsSetupV2](
	[GUID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Value] [varchar](max) NULL
PRIMARY KEY NONCLUSTERED 
(
	[GUID] ASC,
	[Name] ASC
)) ON [PRIMARY]");
        }

        public static string GetSetupValue(DBSetting dbSetting, Guid guid, string name)
        {
            var obj = dbSetting.ExecuteScalar("SELECT Value From DaxonetPlugInsSetupV2 Where GUID = ? AND Name =?", guid, name);
            return obj == null ? null : obj.ToString();
        }

        public static void SetSetupValue(DBSetting dbSetting, Guid guid, string name, string value)
        {
            var table = dbSetting.GetDataTable("SELECT GUID,Name,Value From DaxonetPlugInsSetupV2 Where GUID = ? AND Name =?", true, guid, name);

            if (table.Rows.Count == 0)
            {
                table.Rows.Add(guid, name, value);
            }
            else
            {
                table.Rows[0]["Value"] = value;
            }

            dbSetting.SimpleSaveDataTable(table, "SELECT GUID,Name,Value From DaxonetPlugInsSetupV2 ");
        }

    }
}
