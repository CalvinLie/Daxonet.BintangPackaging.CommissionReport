
namespace Daxonet.BintangPackaging.CommissionReport._Plugin
{
    partial class FormSalesAgent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FromDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPaymentReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Percentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Commission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FromDayIncentive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToDayIncentive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalSalesReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Percentage2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Incentive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Month = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalesAgent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonthlySalesTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonthlySalesAchieved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SalesResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.BtnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnInquiry = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ToDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.FromDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ucSalesAgentSelector1 = new AutoCount.Controls.FilterUI.UCSalesAgentSelector();
            this.panelHeader1 = new AutoCount.Controls.PanelHeader();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FromDay,
            this.ToDay,
            this.TotalPaymentReceived,
            this.Percentage,
            this.Commission});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // FromDay
            // 
            this.FromDay.AppearanceCell.Options.UseTextOptions = true;
            this.FromDay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FromDay.AppearanceHeader.Options.UseTextOptions = true;
            this.FromDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FromDay.Caption = "From (Day)";
            this.FromDay.FieldName = "FromDay";
            this.FromDay.MinWidth = 22;
            this.FromDay.Name = "FromDay";
            this.FromDay.Visible = true;
            this.FromDay.VisibleIndex = 0;
            this.FromDay.Width = 82;
            // 
            // ToDay
            // 
            this.ToDay.AppearanceCell.Options.UseTextOptions = true;
            this.ToDay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ToDay.AppearanceHeader.Options.UseTextOptions = true;
            this.ToDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ToDay.Caption = "To (Day)";
            this.ToDay.FieldName = "ToDay";
            this.ToDay.MinWidth = 22;
            this.ToDay.Name = "ToDay";
            this.ToDay.Visible = true;
            this.ToDay.VisibleIndex = 1;
            this.ToDay.Width = 82;
            // 
            // TotalPaymentReceived
            // 
            this.TotalPaymentReceived.AppearanceCell.Options.UseTextOptions = true;
            this.TotalPaymentReceived.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalPaymentReceived.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalPaymentReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalPaymentReceived.Caption = "Total Payment Received";
            this.TotalPaymentReceived.FieldName = "TotalPaymentReceived";
            this.TotalPaymentReceived.MinWidth = 22;
            this.TotalPaymentReceived.Name = "TotalPaymentReceived";
            this.TotalPaymentReceived.Visible = true;
            this.TotalPaymentReceived.VisibleIndex = 2;
            this.TotalPaymentReceived.Width = 82;
            // 
            // Percentage
            // 
            this.Percentage.AppearanceCell.Options.UseTextOptions = true;
            this.Percentage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Percentage.AppearanceHeader.Options.UseTextOptions = true;
            this.Percentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Percentage.Caption = "Percentage (%)";
            this.Percentage.FieldName = "Percentage";
            this.Percentage.MinWidth = 22;
            this.Percentage.Name = "Percentage";
            this.Percentage.Visible = true;
            this.Percentage.VisibleIndex = 3;
            this.Percentage.Width = 82;
            // 
            // Commission
            // 
            this.Commission.AppearanceCell.Options.UseTextOptions = true;
            this.Commission.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Commission.AppearanceHeader.Options.UseTextOptions = true;
            this.Commission.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Commission.Caption = "Commission";
            this.Commission.FieldName = "Commission";
            this.Commission.MinWidth = 22;
            this.Commission.Name = "Commission";
            this.Commission.Visible = true;
            this.Commission.VisibleIndex = 4;
            this.Commission.Width = 82;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.LevelTemplate = this.gridView3;
            gridLevelNode2.RelationName = "Level2";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(2, 191);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(954, 353);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.gridView1,
            this.gridView2});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FromDayIncentive,
            this.ToDayIncentive,
            this.TotalSalesReceived,
            this.Percentage2,
            this.Incentive});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            // 
            // FromDayIncentive
            // 
            this.FromDayIncentive.AppearanceCell.Options.UseTextOptions = true;
            this.FromDayIncentive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FromDayIncentive.AppearanceHeader.Options.UseTextOptions = true;
            this.FromDayIncentive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FromDayIncentive.Caption = "From (Day)";
            this.FromDayIncentive.FieldName = "FromDayIncentive";
            this.FromDayIncentive.MinWidth = 22;
            this.FromDayIncentive.Name = "FromDayIncentive";
            this.FromDayIncentive.Visible = true;
            this.FromDayIncentive.VisibleIndex = 0;
            this.FromDayIncentive.Width = 82;
            // 
            // ToDayIncentive
            // 
            this.ToDayIncentive.AppearanceCell.Options.UseTextOptions = true;
            this.ToDayIncentive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ToDayIncentive.AppearanceHeader.Options.UseTextOptions = true;
            this.ToDayIncentive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ToDayIncentive.Caption = "To (Day)";
            this.ToDayIncentive.FieldName = "ToDayIncentive";
            this.ToDayIncentive.MinWidth = 22;
            this.ToDayIncentive.Name = "ToDayIncentive";
            this.ToDayIncentive.Visible = true;
            this.ToDayIncentive.VisibleIndex = 1;
            this.ToDayIncentive.Width = 82;
            // 
            // TotalSalesReceived
            // 
            this.TotalSalesReceived.AppearanceCell.Options.UseTextOptions = true;
            this.TotalSalesReceived.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalSalesReceived.AppearanceHeader.Options.UseTextOptions = true;
            this.TotalSalesReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TotalSalesReceived.Caption = "Total Sales Received";
            this.TotalSalesReceived.FieldName = "TotalSalesReceived";
            this.TotalSalesReceived.MinWidth = 22;
            this.TotalSalesReceived.Name = "TotalSalesReceived";
            this.TotalSalesReceived.Visible = true;
            this.TotalSalesReceived.VisibleIndex = 2;
            this.TotalSalesReceived.Width = 82;
            // 
            // Percentage2
            // 
            this.Percentage2.AppearanceCell.Options.UseTextOptions = true;
            this.Percentage2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Percentage2.AppearanceHeader.Options.UseTextOptions = true;
            this.Percentage2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Percentage2.Caption = "Percentage (%)";
            this.Percentage2.FieldName = "Percentage2";
            this.Percentage2.MinWidth = 22;
            this.Percentage2.Name = "Percentage2";
            this.Percentage2.Visible = true;
            this.Percentage2.VisibleIndex = 3;
            this.Percentage2.Width = 82;
            // 
            // Incentive
            // 
            this.Incentive.AppearanceCell.Options.UseTextOptions = true;
            this.Incentive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Incentive.AppearanceHeader.Options.UseTextOptions = true;
            this.Incentive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Incentive.Caption = "Incentive";
            this.Incentive.FieldName = "Incentive";
            this.Incentive.MinWidth = 22;
            this.Incentive.Name = "Incentive";
            this.Incentive.Visible = true;
            this.Incentive.VisibleIndex = 4;
            this.Incentive.Width = 82;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Month,
            this.SalesAgent,
            this.MonthlySalesTarget,
            this.MonthlySalesAchieved,
            this.SalesResult});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Month
            // 
            this.Month.AppearanceCell.Options.UseTextOptions = true;
            this.Month.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Month.AppearanceHeader.Options.UseTextOptions = true;
            this.Month.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Month.Caption = "Month";
            this.Month.FieldName = "Month";
            this.Month.MinWidth = 22;
            this.Month.Name = "Month";
            this.Month.Visible = true;
            this.Month.VisibleIndex = 0;
            this.Month.Width = 82;
            // 
            // SalesAgent
            // 
            this.SalesAgent.AppearanceCell.Options.UseTextOptions = true;
            this.SalesAgent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalesAgent.AppearanceHeader.Options.UseTextOptions = true;
            this.SalesAgent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalesAgent.Caption = "Sales Agent";
            this.SalesAgent.FieldName = "SalesAgent";
            this.SalesAgent.MinWidth = 22;
            this.SalesAgent.Name = "SalesAgent";
            this.SalesAgent.Visible = true;
            this.SalesAgent.VisibleIndex = 1;
            this.SalesAgent.Width = 82;
            // 
            // MonthlySalesTarget
            // 
            this.MonthlySalesTarget.AppearanceCell.Options.UseTextOptions = true;
            this.MonthlySalesTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MonthlySalesTarget.AppearanceHeader.Options.UseTextOptions = true;
            this.MonthlySalesTarget.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MonthlySalesTarget.Caption = "Monthly Sales Target";
            this.MonthlySalesTarget.FieldName = "MonthlySalesTarget";
            this.MonthlySalesTarget.MinWidth = 22;
            this.MonthlySalesTarget.Name = "MonthlySalesTarget";
            this.MonthlySalesTarget.Visible = true;
            this.MonthlySalesTarget.VisibleIndex = 2;
            this.MonthlySalesTarget.Width = 82;
            // 
            // MonthlySalesAchieved
            // 
            this.MonthlySalesAchieved.AppearanceCell.Options.UseTextOptions = true;
            this.MonthlySalesAchieved.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MonthlySalesAchieved.AppearanceHeader.Options.UseTextOptions = true;
            this.MonthlySalesAchieved.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MonthlySalesAchieved.Caption = "Monthly Sales Achieved";
            this.MonthlySalesAchieved.FieldName = "MonthlySalesAchieved";
            this.MonthlySalesAchieved.MinWidth = 22;
            this.MonthlySalesAchieved.Name = "MonthlySalesAchieved";
            this.MonthlySalesAchieved.Visible = true;
            this.MonthlySalesAchieved.VisibleIndex = 3;
            this.MonthlySalesAchieved.Width = 82;
            // 
            // SalesResult
            // 
            this.SalesResult.AppearanceCell.Options.UseTextOptions = true;
            this.SalesResult.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalesResult.AppearanceHeader.Options.UseTextOptions = true;
            this.SalesResult.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SalesResult.Caption = "Result";
            this.SalesResult.FieldName = "SalesResult";
            this.SalesResult.MinWidth = 22;
            this.SalesResult.Name = "SalesResult";
            this.SalesResult.Visible = true;
            this.SalesResult.VisibleIndex = 4;
            this.SalesResult.Width = 82;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Sales Agent:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Date:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.panelHeader1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(958, 546);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.BtnPreview);
            this.panelControl3.Controls.Add(this.BtnPrint);
            this.panelControl3.Controls.Add(this.BtnRefresh);
            this.panelControl3.Controls.Add(this.BtnClose);
            this.panelControl3.Controls.Add(this.BtnInquiry);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 148);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(954, 43);
            this.panelControl3.TabIndex = 5;
            // 
            // BtnPreview
            // 
            this.BtnPreview.Location = new System.Drawing.Point(98, 6);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(82, 29);
            this.BtnPreview.TabIndex = 0;
            this.BtnPreview.Text = "Preview";
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(186, 6);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(84, 29);
            this.BtnPrint.TabIndex = 1;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(276, 6);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(82, 29);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(364, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(82, 29);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnInquiry
            // 
            this.BtnInquiry.Location = new System.Drawing.Point(10, 6);
            this.BtnInquiry.Name = "BtnInquiry";
            this.BtnInquiry.Size = new System.Drawing.Size(82, 29);
            this.BtnInquiry.TabIndex = 0;
            this.BtnInquiry.Text = "Inquiry";
            this.BtnInquiry.Click += new System.EventHandler(this.BtnInquiry_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.ToDateEdit);
            this.panelControl2.Controls.Add(this.FromDateEdit);
            this.panelControl2.Controls.Add(this.ucSalesAgentSelector1);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 57);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(954, 91);
            this.panelControl2.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(224, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(11, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "to";
            // 
            // ToDateEdit
            // 
            this.ToDateEdit.EditValue = null;
            this.ToDateEdit.Location = new System.Drawing.Point(241, 13);
            this.ToDateEdit.Name = "ToDateEdit";
            this.ToDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ToDateEdit.Size = new System.Drawing.Size(109, 22);
            this.ToDateEdit.TabIndex = 6;
            // 
            // FromDateEdit
            // 
            this.FromDateEdit.EditValue = null;
            this.FromDateEdit.Location = new System.Drawing.Point(109, 13);
            this.FromDateEdit.Name = "FromDateEdit";
            this.FromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FromDateEdit.Size = new System.Drawing.Size(109, 22);
            this.FromDateEdit.TabIndex = 5;
            // 
            // ucSalesAgentSelector1
            // 
            this.ucSalesAgentSelector1.Location = new System.Drawing.Point(109, 47);
            this.ucSalesAgentSelector1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucSalesAgentSelector1.Name = "ucSalesAgentSelector1";
            this.ucSalesAgentSelector1.Size = new System.Drawing.Size(592, 36);
            this.ucSalesAgentSelector1.TabIndex = 4;
            this.ucSalesAgentSelector1.UseSearchLookup = false;
            // 
            // panelHeader1
            // 
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader1.Header = "By Sales Agent ";
            this.panelHeader1.Location = new System.Drawing.Point(2, 2);
            this.panelHeader1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(954, 55);
            this.panelHeader1.TabIndex = 0;
            // 
            // FormSalesAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 546);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormSalesAgent";
            this.Text = "Monthly Commission and Incentive Report";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private AutoCount.Controls.PanelHeader panelHeader1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnInquiry;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private AutoCount.Controls.FilterUI.UCSalesAgentSelector ucSalesAgentSelector1;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn Month;
        private DevExpress.XtraGrid.Columns.GridColumn SalesAgent;
        private DevExpress.XtraGrid.Columns.GridColumn MonthlySalesTarget;
        private DevExpress.XtraGrid.Columns.GridColumn MonthlySalesAchieved;
        private DevExpress.XtraGrid.Columns.GridColumn SalesResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn FromDay;
        private DevExpress.XtraGrid.Columns.GridColumn ToDay;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPaymentReceived;
        private DevExpress.XtraGrid.Columns.GridColumn Percentage;
        private DevExpress.XtraGrid.Columns.GridColumn Commission;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn FromDayIncentive;
        private DevExpress.XtraGrid.Columns.GridColumn ToDayIncentive;
        private DevExpress.XtraGrid.Columns.GridColumn TotalSalesReceived;
        private DevExpress.XtraGrid.Columns.GridColumn Percentage2;
        private DevExpress.XtraGrid.Columns.GridColumn Incentive;
        private DevExpress.XtraEditors.DateEdit FromDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit ToDateEdit;
        private DevExpress.XtraEditors.SimpleButton BtnPreview;
        private DevExpress.XtraEditors.SimpleButton BtnPrint;
    }
}