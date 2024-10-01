namespace DXQLSB.Views
{
    partial class frmBangDichVu
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
            this.gridControlXemDichVu = new DevExpress.XtraGrid.GridControl();
            this.dichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dichVuDataSet = new DXQLSB.DichVuDataSet();
            this.gridViewXemDichVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmadichvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltensanpham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dichvuTableAdapter = new DXQLSB.DichVuDataSetTableAdapters.dichvuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXemDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXemDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlXemDichVu
            // 
            this.gridControlXemDichVu.DataSource = this.dichvuBindingSource;
            this.gridControlXemDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlXemDichVu.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridControlXemDichVu.EmbeddedNavigator.Buttons.Append.Hint = "Thêm";
            this.gridControlXemDichVu.EmbeddedNavigator.Buttons.CancelEdit.Hint = "Huỷ sửa";
            this.gridControlXemDichVu.EmbeddedNavigator.Buttons.Edit.Hint = "Sửa";
            this.gridControlXemDichVu.EmbeddedNavigator.Buttons.EndEdit.Hint = "Lưu";
            this.gridControlXemDichVu.EmbeddedNavigator.Buttons.Remove.Hint = "Xoá";
            this.gridControlXemDichVu.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlXemDichVu_EmbeddedNavigator_ButtonClick);
            this.gridControlXemDichVu.Location = new System.Drawing.Point(0, 0);
            this.gridControlXemDichVu.MainView = this.gridViewXemDichVu;
            this.gridControlXemDichVu.Name = "gridControlXemDichVu";
            this.gridControlXemDichVu.Size = new System.Drawing.Size(1114, 525);
            this.gridControlXemDichVu.TabIndex = 0;
            this.gridControlXemDichVu.UseEmbeddedNavigator = true;
            this.gridControlXemDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewXemDichVu});
            this.gridControlXemDichVu.Load += new System.EventHandler(this.gridControlXemDichVu_Load);
            // 
            // dichvuBindingSource
            // 
            this.dichvuBindingSource.DataMember = "dichvu";
            this.dichvuBindingSource.DataSource = this.dichVuDataSet;
            // 
            // dichVuDataSet
            // 
            this.dichVuDataSet.DataSetName = "DichVuDataSet";
            this.dichVuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewXemDichVu
            // 
            this.gridViewXemDichVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colmadichvu,
            this.coltensanpham,
            this.coldongia});
            this.gridViewXemDichVu.GridControl = this.gridControlXemDichVu;
            this.gridViewXemDichVu.Name = "gridViewXemDichVu";
            this.gridViewXemDichVu.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewXemDichVu.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewXemDichVu.OptionsFind.AlwaysVisible = true;
            this.gridViewXemDichVu.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm";
            this.gridViewXemDichVu.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gridViewXemDichVu.OptionsView.ShowFooter = true;
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
            this.colid.Width = 132;
            // 
            // colmadichvu
            // 
            this.colmadichvu.AppearanceCell.Options.UseTextOptions = true;
            this.colmadichvu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmadichvu.AppearanceHeader.Options.UseTextOptions = true;
            this.colmadichvu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmadichvu.Caption = "Mã dịch vụ";
            this.colmadichvu.FieldName = "madichvu";
            this.colmadichvu.MinWidth = 25;
            this.colmadichvu.Name = "colmadichvu";
            this.colmadichvu.Visible = true;
            this.colmadichvu.VisibleIndex = 1;
            this.colmadichvu.Width = 166;
            // 
            // coltensanpham
            // 
            this.coltensanpham.AppearanceCell.Options.UseTextOptions = true;
            this.coltensanpham.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltensanpham.AppearanceHeader.Options.UseTextOptions = true;
            this.coltensanpham.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltensanpham.Caption = "Tên sản phẩm";
            this.coltensanpham.FieldName = "tensanpham";
            this.coltensanpham.MinWidth = 25;
            this.coltensanpham.Name = "coltensanpham";
            this.coltensanpham.Visible = true;
            this.coltensanpham.VisibleIndex = 2;
            this.coltensanpham.Width = 392;
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
            this.coldongia.Width = 394;
            // 
            // dichvuTableAdapter
            // 
            this.dichvuTableAdapter.ClearBeforeFill = true;
            // 
            // frmBangDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlXemDichVu);
            this.Name = "frmBangDichVu";
            this.Size = new System.Drawing.Size(1114, 525);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXemDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXemDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlXemDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewXemDichVu;
        private System.Windows.Forms.BindingSource dichvuBindingSource;
        private DichVuDataSet dichVuDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colmadichvu;
        private DevExpress.XtraGrid.Columns.GridColumn coltensanpham;
        private DevExpress.XtraGrid.Columns.GridColumn coldongia;
        private DichVuDataSetTableAdapters.dichvuTableAdapter dichvuTableAdapter;
    }
}
