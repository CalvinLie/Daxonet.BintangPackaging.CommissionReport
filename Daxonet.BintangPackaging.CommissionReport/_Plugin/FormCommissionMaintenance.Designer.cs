
namespace Daxonet.BintangPackaging.CommissionReport._Plugin
{
    partial class FormCommissionMaintenance
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelHeader1 = new AutoCount.Controls.PanelHeader();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KPIFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.KPITo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Percentage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader1
            // 
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader1.Header = "Commission Maintenance (Day)";
            this.panelHeader1.Location = new System.Drawing.Point(0, 0);
            this.panelHeader1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Size = new System.Drawing.Size(901, 55);
            this.panelHeader1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.BtnClose);
            this.panelControl1.Controls.Add(this.BtnSave);
            this.panelControl1.Controls.Add(this.BtnAdd);
            this.panelControl1.Controls.Add(this.BtnDelete);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(48);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(897, 40);
            this.panelControl1.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(351, 2);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(48);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(102, 34);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(122, 2);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(48);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(99, 34);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(11, 2);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(48);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(91, 34);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(236, 2);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(48);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(95, 34);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(48);
            this.gridControl1.Location = new System.Drawing.Point(2, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(48);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(897, 412);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KPIFrom,
            this.KPITo,
            this.Percentage});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(0, 346, 4557, 4717);
            this.gridView1.DetailHeight = 5077;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // KPIFrom
            // 
            this.KPIFrom.AppearanceCell.Options.UseTextOptions = true;
            this.KPIFrom.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KPIFrom.AppearanceHeader.Options.UseTextOptions = true;
            this.KPIFrom.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KPIFrom.Caption = "From (Day)";
            this.KPIFrom.ColumnEdit = this.repositoryItemSpinEdit1;
            this.KPIFrom.FieldName = "KPIFrom";
            this.KPIFrom.MinWidth = 290;
            this.KPIFrom.Name = "KPIFrom";
            this.KPIFrom.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.KPIFrom.Visible = true;
            this.KPIFrom.VisibleIndex = 0;
            this.KPIFrom.Width = 1084;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // KPITo
            // 
            this.KPITo.AppearanceCell.Options.UseTextOptions = true;
            this.KPITo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KPITo.AppearanceHeader.Options.UseTextOptions = true;
            this.KPITo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KPITo.Caption = "To (Day)";
            this.KPITo.ColumnEdit = this.repositoryItemSpinEdit1;
            this.KPITo.FieldName = "KPITo";
            this.KPITo.MinWidth = 290;
            this.KPITo.Name = "KPITo";
            this.KPITo.Visible = true;
            this.KPITo.VisibleIndex = 1;
            this.KPITo.Width = 1084;
            // 
            // Percentage
            // 
            this.Percentage.AppearanceCell.Options.UseTextOptions = true;
            this.Percentage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Percentage.AppearanceHeader.Options.UseTextOptions = true;
            this.Percentage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Percentage.Caption = "Percentage (%)";
            this.Percentage.ColumnEdit = this.repositoryItemSpinEdit1;
            this.Percentage.FieldName = "Percentage";
            this.Percentage.MinWidth = 290;
            this.Percentage.Name = "Percentage";
            this.Percentage.Visible = true;
            this.Percentage.VisibleIndex = 2;
            this.Percentage.Width = 1084;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Controls.Add(this.panelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 55);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(48);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(901, 456);
            this.panelControl3.TabIndex = 3;
            // 
            // FormCommissionMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 511);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelHeader1);
            this.Name = "FormCommissionMaintenance";
            this.Text = "Monthly Payment Received and Commission Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AutoCount.Controls.PanelHeader panelHeader1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraGrid.Columns.GridColumn KPIFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn KPITo;
        private DevExpress.XtraGrid.Columns.GridColumn Percentage;
    }
}