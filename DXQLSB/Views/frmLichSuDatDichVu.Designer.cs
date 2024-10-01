namespace DXQLSB.Views
{
    partial class frmLichSuDatDichVu
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
            this.gridControlLichSuDatDichVu = new DevExpress.XtraGrid.GridControl();
            this.thongtindatdichvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinDatdichVuDataSet = new DXQLSB.ThongTinDatdichVuDataSet();
            this.gridViewLichSuDatDichVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmadichvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltensanpham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaytao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisdathanhtoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thongtindatdichvuTableAdapter = new DXQLSB.ThongTinDatdichVuDataSetTableAdapters.thongtindatdichvuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuDatDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtindatdichvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinDatdichVuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuDatDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlLichSuDatDichVu
            // 
            this.gridControlLichSuDatDichVu.DataSource = this.thongtindatdichvuBindingSource;
            this.gridControlLichSuDatDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLichSuDatDichVu.Location = new System.Drawing.Point(0, 0);
            this.gridControlLichSuDatDichVu.MainView = this.gridViewLichSuDatDichVu;
            this.gridControlLichSuDatDichVu.Name = "gridControlLichSuDatDichVu";
            this.gridControlLichSuDatDichVu.Size = new System.Drawing.Size(1114, 525);
            this.gridControlLichSuDatDichVu.TabIndex = 0;
            this.gridControlLichSuDatDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLichSuDatDichVu});
            this.gridControlLichSuDatDichVu.Load += new System.EventHandler(this.gridControlLichSuDatDichVu_Load);
            // 
            // thongtindatdichvuBindingSource
            // 
            this.thongtindatdichvuBindingSource.DataMember = "thongtindatdichvu";
            this.thongtindatdichvuBindingSource.DataSource = this.thongTinDatdichVuDataSet;
            // 
            // thongTinDatdichVuDataSet
            // 
            this.thongTinDatdichVuDataSet.DataSetName = "ThongTinDatdichVuDataSet";
            this.thongTinDatdichVuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewLichSuDatDichVu
            // 
            this.gridViewLichSuDatDichVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colmasan,
            this.colmadichvu,
            this.coltensanpham,
            this.coldongia,
            this.colsoluong,
            this.colthanhtien,
            this.colngaytao,
            this.colisdathanhtoan});
            this.gridViewLichSuDatDichVu.GridControl = this.gridControlLichSuDatDichVu;
            this.gridViewLichSuDatDichVu.Name = "gridViewLichSuDatDichVu";
            this.gridViewLichSuDatDichVu.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewLichSuDatDichVu.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewLichSuDatDichVu.OptionsBehavior.Editable = false;
            this.gridViewLichSuDatDichVu.OptionsFind.AlwaysVisible = true;
            this.gridViewLichSuDatDichVu.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm ...";
            this.gridViewLichSuDatDichVu.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gridViewLichSuDatDichVu.OptionsView.ShowFooter = true;
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
            this.colid.Width = 94;
            // 
            // colmasan
            // 
            this.colmasan.AppearanceCell.Options.UseTextOptions = true;
            this.colmasan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmasan.AppearanceHeader.Options.UseTextOptions = true;
            this.colmasan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmasan.Caption = "Mã sân";
            this.colmasan.FieldName = "masan";
            this.colmasan.MinWidth = 25;
            this.colmasan.Name = "colmasan";
            this.colmasan.Visible = true;
            this.colmasan.VisibleIndex = 1;
            this.colmasan.Width = 94;
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
            this.colmadichvu.VisibleIndex = 2;
            this.colmadichvu.Width = 94;
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
            this.coltensanpham.VisibleIndex = 3;
            this.coltensanpham.Width = 94;
            // 
            // coldongia
            // 
            this.coldongia.AppearanceCell.Options.UseTextOptions = true;
            this.coldongia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldongia.AppearanceHeader.Options.UseTextOptions = true;
            this.coldongia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldongia.Caption = "Đơn giá";
            this.coldongia.DisplayFormat.FormatString = "{0:#,###0}";
            this.coldongia.FieldName = "dongia";
            this.coldongia.MinWidth = 25;
            this.coldongia.Name = "coldongia";
            this.coldongia.Visible = true;
            this.coldongia.VisibleIndex = 4;
            this.coldongia.Width = 94;
            // 
            // colsoluong
            // 
            this.colsoluong.AppearanceCell.Options.UseTextOptions = true;
            this.colsoluong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsoluong.AppearanceHeader.Options.UseTextOptions = true;
            this.colsoluong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsoluong.Caption = "Số lượng";
            this.colsoluong.FieldName = "soluong";
            this.colsoluong.MinWidth = 25;
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.Visible = true;
            this.colsoluong.VisibleIndex = 5;
            this.colsoluong.Width = 94;
            // 
            // colthanhtien
            // 
            this.colthanhtien.AppearanceCell.Options.UseTextOptions = true;
            this.colthanhtien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colthanhtien.AppearanceHeader.Options.UseTextOptions = true;
            this.colthanhtien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colthanhtien.Caption = "Thành tiền";
            this.colthanhtien.FieldName = "thanhtien";
            this.colthanhtien.MinWidth = 25;
            this.colthanhtien.Name = "colthanhtien";
            this.colthanhtien.Visible = true;
            this.colthanhtien.VisibleIndex = 6;
            this.colthanhtien.Width = 94;
            // 
            // colngaytao
            // 
            this.colngaytao.AppearanceCell.Options.UseTextOptions = true;
            this.colngaytao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colngaytao.AppearanceHeader.Options.UseTextOptions = true;
            this.colngaytao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colngaytao.Caption = "Ngày tạo";
            this.colngaytao.DisplayFormat.FormatString = "{0:MM/dd/yyyy}";
            this.colngaytao.FieldName = "ngaytao";
            this.colngaytao.MinWidth = 25;
            this.colngaytao.Name = "colngaytao";
            this.colngaytao.Visible = true;
            this.colngaytao.VisibleIndex = 7;
            this.colngaytao.Width = 127;
            // 
            // colisdathanhtoan
            // 
            this.colisdathanhtoan.AppearanceCell.Options.UseTextOptions = true;
            this.colisdathanhtoan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisdathanhtoan.AppearanceHeader.Options.UseTextOptions = true;
            this.colisdathanhtoan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisdathanhtoan.Caption = "Đã thanh toán";
            this.colisdathanhtoan.FieldName = "isdathanhtoan";
            this.colisdathanhtoan.MinWidth = 25;
            this.colisdathanhtoan.Name = "colisdathanhtoan";
            this.colisdathanhtoan.Visible = true;
            this.colisdathanhtoan.VisibleIndex = 8;
            this.colisdathanhtoan.Width = 94;
            // 
            // thongtindatdichvuTableAdapter
            // 
            this.thongtindatdichvuTableAdapter.ClearBeforeFill = true;
            // 
            // frmLichSuDatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlLichSuDatDichVu);
            this.Name = "frmLichSuDatDichVu";
            this.Size = new System.Drawing.Size(1114, 525);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuDatDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtindatdichvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinDatdichVuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuDatDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlLichSuDatDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLichSuDatDichVu;
        private System.Windows.Forms.BindingSource thongtindatdichvuBindingSource;
        private ThongTinDatdichVuDataSet thongTinDatdichVuDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colmasan;
        private DevExpress.XtraGrid.Columns.GridColumn colmadichvu;
        private DevExpress.XtraGrid.Columns.GridColumn coltensanpham;
        private DevExpress.XtraGrid.Columns.GridColumn coldongia;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colthanhtien;
        private DevExpress.XtraGrid.Columns.GridColumn colngaytao;
        private DevExpress.XtraGrid.Columns.GridColumn colisdathanhtoan;
        private ThongTinDatdichVuDataSetTableAdapters.thongtindatdichvuTableAdapter thongtindatdichvuTableAdapter;
    }
}
