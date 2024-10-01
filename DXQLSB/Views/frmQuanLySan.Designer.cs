namespace DXQLSB.Views
{
    partial class frmQuanLySan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControlSan = new DevExpress.XtraGrid.GridControl();
            this.sanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanDataSet = new DXQLSB.sanDataSet();
            this.gridViewSan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltensan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colloaisan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisdangdat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sanTableAdapter = new DXQLSB.sanDataSetTableAdapters.sanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSan)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlSan
            // 
            this.gridControlSan.DataSource = this.sanBindingSource;
            this.gridControlSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSan.EmbeddedNavigator.Buttons.Append.Hint = "Thêm";
            this.gridControlSan.EmbeddedNavigator.Buttons.CancelEdit.Hint = "Huỷ sửa";
            this.gridControlSan.EmbeddedNavigator.Buttons.Edit.Hint = "Sửa";
            this.gridControlSan.EmbeddedNavigator.Buttons.EndEdit.Hint = "Lưu";
            this.gridControlSan.EmbeddedNavigator.Buttons.Remove.Hint = "Xoá";
            this.gridControlSan.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlSan_EmbeddedNavigator_ButtonClick);
            this.gridControlSan.Location = new System.Drawing.Point(0, 0);
            this.gridControlSan.MainView = this.gridViewSan;
            this.gridControlSan.Name = "gridControlSan";
            this.gridControlSan.Size = new System.Drawing.Size(1114, 525);
            this.gridControlSan.TabIndex = 0;
            this.gridControlSan.UseEmbeddedNavigator = true;
            this.gridControlSan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSan});
            this.gridControlSan.Load += new System.EventHandler(this.gridControlSan_Load);
            // 
            // sanBindingSource
            // 
            this.sanBindingSource.DataMember = "san";
            this.sanBindingSource.DataSource = this.sanDataSet;
            // 
            // sanDataSet
            // 
            this.sanDataSet.DataSetName = "sanDataSet";
            this.sanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewSan
            // 
            this.gridViewSan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coltensan,
            this.colloaisan,
            this.coldongia,
            this.colisdangdat});
            this.gridViewSan.GridControl = this.gridControlSan;
            this.gridViewSan.Name = "gridViewSan";
            this.gridViewSan.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewSan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewSan.OptionsFind.AlwaysVisible = true;
            this.gridViewSan.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm ...";
            this.gridViewSan.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gridViewSan.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewSan.OptionsView.ShowFooter = true;
            this.gridViewSan.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewSan_InitNewRow);
            this.gridViewSan.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewSan_RowUpdated);
            // 
            // colid
            // 
            this.colid.AppearanceCell.Options.UseTextOptions = true;
            this.colid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid.AppearanceHeader.Options.UseTextOptions = true;
            this.colid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 147;
            // 
            // coltensan
            // 
            this.coltensan.AppearanceCell.Options.UseTextOptions = true;
            this.coltensan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltensan.AppearanceHeader.Options.UseTextOptions = true;
            this.coltensan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltensan.Caption = "Tên sân";
            this.coltensan.FieldName = "tensan";
            this.coltensan.MinWidth = 25;
            this.coltensan.Name = "coltensan";
            this.coltensan.Visible = true;
            this.coltensan.VisibleIndex = 1;
            this.coltensan.Width = 233;
            // 
            // colloaisan
            // 
            this.colloaisan.AppearanceCell.Options.UseTextOptions = true;
            this.colloaisan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colloaisan.AppearanceHeader.Options.UseTextOptions = true;
            this.colloaisan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colloaisan.Caption = "Loại sân";
            this.colloaisan.FieldName = "loaisan";
            this.colloaisan.MinWidth = 25;
            this.colloaisan.Name = "colloaisan";
            this.colloaisan.Visible = true;
            this.colloaisan.VisibleIndex = 2;
            this.colloaisan.Width = 233;
            // 
            // coldongia
            // 
            this.coldongia.AppearanceCell.Options.UseTextOptions = true;
            this.coldongia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldongia.AppearanceHeader.Options.UseTextOptions = true;
            this.coldongia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldongia.Caption = "Đơn giá";
            this.coldongia.FieldName = "dongia";
            this.coldongia.MinWidth = 25;
            this.coldongia.Name = "coldongia";
            this.coldongia.Visible = true;
            this.coldongia.VisibleIndex = 3;
            this.coldongia.Width = 233;
            // 
            // colisdangdat
            // 
            this.colisdangdat.AppearanceCell.Options.UseTextOptions = true;
            this.colisdangdat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisdangdat.AppearanceHeader.Options.UseTextOptions = true;
            this.colisdangdat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisdangdat.Caption = "Đang đặt";
            this.colisdangdat.FieldName = "isdangdat";
            this.colisdangdat.MinWidth = 25;
            this.colisdangdat.Name = "colisdangdat";
            this.colisdangdat.OptionsColumn.ReadOnly = true;
            this.colisdangdat.Visible = true;
            this.colisdangdat.VisibleIndex = 4;
            this.colisdangdat.Width = 238;
            // 
            // sanTableAdapter
            // 
            this.sanTableAdapter.ClearBeforeFill = true;
            // 
            // frmQuanLySan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlSan);
            this.Name = "frmQuanLySan";
            this.Size = new System.Drawing.Size(1114, 525);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlSan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSan;
        private System.Windows.Forms.BindingSource sanBindingSource;
        private sanDataSet sanDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coltensan;
        private DevExpress.XtraGrid.Columns.GridColumn colloaisan;
        private DevExpress.XtraGrid.Columns.GridColumn coldongia;
        private DevExpress.XtraGrid.Columns.GridColumn colisdangdat;
        private sanDataSetTableAdapters.sanTableAdapter sanTableAdapter;
    }
}
