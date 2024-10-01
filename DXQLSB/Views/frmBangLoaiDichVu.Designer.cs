namespace DXQLSB.Views
{
    partial class frmBangLoaiDichVu
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
            this.gridControlBangLoaiDichVu = new DevExpress.XtraGrid.GridControl();
            this.loaidichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiDichVuDataSet = new DXQLSB.LoaiDichVuDataSet();
            this.gridViewBangLoaiDichVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmadichvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenloai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loaidichvuTableAdapter = new DXQLSB.LoaiDichVuDataSetTableAdapters.loaidichvuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBangLoaiDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaidichvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDichVuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBangLoaiDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlBangLoaiDichVu
            // 
            this.gridControlBangLoaiDichVu.DataSource = this.loaidichvuBindingSource;
            this.gridControlBangLoaiDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBangLoaiDichVu.EmbeddedNavigator.Buttons.Append.Hint = "Thêm";
            this.gridControlBangLoaiDichVu.EmbeddedNavigator.Buttons.CancelEdit.Hint = "Huỷ sửa";
            this.gridControlBangLoaiDichVu.EmbeddedNavigator.Buttons.Edit.Hint = "Sửa";
            this.gridControlBangLoaiDichVu.EmbeddedNavigator.Buttons.EndEdit.Hint = "Lưu";
            this.gridControlBangLoaiDichVu.EmbeddedNavigator.Buttons.Remove.Hint = "Xoá";
            this.gridControlBangLoaiDichVu.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlBangLoaiDichVu_EmbeddedNavigator_ButtonClick);
            this.gridControlBangLoaiDichVu.Location = new System.Drawing.Point(0, 0);
            this.gridControlBangLoaiDichVu.MainView = this.gridViewBangLoaiDichVu;
            this.gridControlBangLoaiDichVu.Name = "gridControlBangLoaiDichVu";
            this.gridControlBangLoaiDichVu.Size = new System.Drawing.Size(1114, 525);
            this.gridControlBangLoaiDichVu.TabIndex = 0;
            this.gridControlBangLoaiDichVu.UseEmbeddedNavigator = true;
            this.gridControlBangLoaiDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBangLoaiDichVu});
            this.gridControlBangLoaiDichVu.Load += new System.EventHandler(this.gridControlBangLoaiDichVu_Load);
            // 
            // loaidichvuBindingSource
            // 
            this.loaidichvuBindingSource.DataMember = "loaidichvu";
            this.loaidichvuBindingSource.DataSource = this.loaiDichVuDataSet;
            // 
            // loaiDichVuDataSet
            // 
            this.loaiDichVuDataSet.DataSetName = "LoaiDichVuDataSet";
            this.loaiDichVuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewBangLoaiDichVu
            // 
            this.gridViewBangLoaiDichVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmadichvu,
            this.coltenloai});
            this.gridViewBangLoaiDichVu.GridControl = this.gridControlBangLoaiDichVu;
            this.gridViewBangLoaiDichVu.Name = "gridViewBangLoaiDichVu";
            this.gridViewBangLoaiDichVu.OptionsFind.AlwaysVisible = true;
            this.gridViewBangLoaiDichVu.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm ...";
            this.gridViewBangLoaiDichVu.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gridViewBangLoaiDichVu.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewBangLoaiDichVu.OptionsView.ShowFooter = true;
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
            this.colmadichvu.VisibleIndex = 0;
            this.colmadichvu.Width = 94;
            // 
            // coltenloai
            // 
            this.coltenloai.AppearanceCell.Options.UseTextOptions = true;
            this.coltenloai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenloai.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenloai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenloai.Caption = "Tên loại dịch vụ";
            this.coltenloai.FieldName = "tenloai";
            this.coltenloai.MinWidth = 25;
            this.coltenloai.Name = "coltenloai";
            this.coltenloai.Visible = true;
            this.coltenloai.VisibleIndex = 1;
            this.coltenloai.Width = 94;
            // 
            // loaidichvuTableAdapter
            // 
            this.loaidichvuTableAdapter.ClearBeforeFill = true;
            // 
            // frmBangLoaiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlBangLoaiDichVu);
            this.Name = "frmBangLoaiDichVu";
            this.Size = new System.Drawing.Size(1114, 525);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBangLoaiDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaidichvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDichVuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBangLoaiDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlBangLoaiDichVu;
        private System.Windows.Forms.BindingSource loaidichvuBindingSource;
        private LoaiDichVuDataSet loaiDichVuDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBangLoaiDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn colmadichvu;
        private DevExpress.XtraGrid.Columns.GridColumn coltenloai;
        private LoaiDichVuDataSetTableAdapters.loaidichvuTableAdapter loaidichvuTableAdapter;
    }
}
