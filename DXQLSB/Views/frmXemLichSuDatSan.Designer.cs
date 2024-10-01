namespace DXQLSB.Views
{
    partial class frmXemLichSuDatSan
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
            this.gridControlLichSuSan = new DevExpress.XtraGrid.GridControl();
            this.thongtindatsanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinDatSanDataSet = new DXQLSB.ThongTinDatSanDataSet();
            this.gridViewLichSuSan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhotenkhachhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcmnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthoigian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnhanvienphutrach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisdathanhtoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thongtindatsanTableAdapter = new DXQLSB.ThongTinDatSanDataSetTableAdapters.thongtindatsanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtindatsanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinDatSanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuSan)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlLichSuSan
            // 
            this.gridControlLichSuSan.DataSource = this.thongtindatsanBindingSource;
            this.gridControlLichSuSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLichSuSan.Location = new System.Drawing.Point(0, 0);
            this.gridControlLichSuSan.MainView = this.gridViewLichSuSan;
            this.gridControlLichSuSan.Name = "gridControlLichSuSan";
            this.gridControlLichSuSan.Size = new System.Drawing.Size(1114, 525);
            this.gridControlLichSuSan.TabIndex = 0;
            this.gridControlLichSuSan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLichSuSan});
            this.gridControlLichSuSan.Load += new System.EventHandler(this.gridControlLichSuSan_Load);
            // 
            // thongtindatsanBindingSource
            // 
            this.thongtindatsanBindingSource.DataMember = "thongtindatsan";
            this.thongtindatsanBindingSource.DataSource = this.thongTinDatSanDataSet;
            // 
            // thongTinDatSanDataSet
            // 
            this.thongTinDatSanDataSet.DataSetName = "ThongTinDatSanDataSet";
            this.thongTinDatSanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewLichSuSan
            // 
            this.gridViewLichSuSan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colhotenkhachhang,
            this.colcmnd,
            this.colsdt,
            this.colmasan,
            this.coldongia,
            this.colthoigian,
            this.colnhanvienphutrach,
            this.colisdathanhtoan});
            this.gridViewLichSuSan.GridControl = this.gridControlLichSuSan;
            this.gridViewLichSuSan.Name = "gridViewLichSuSan";
            this.gridViewLichSuSan.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewLichSuSan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewLichSuSan.OptionsBehavior.Editable = false;
            this.gridViewLichSuSan.OptionsFind.AlwaysVisible = true;
            this.gridViewLichSuSan.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm...";
            this.gridViewLichSuSan.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gridViewLichSuSan.OptionsView.ShowFooter = true;
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
            this.colid.Width = 69;
            // 
            // colhotenkhachhang
            // 
            this.colhotenkhachhang.AppearanceCell.Options.UseTextOptions = true;
            this.colhotenkhachhang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhotenkhachhang.AppearanceHeader.Options.UseTextOptions = true;
            this.colhotenkhachhang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhotenkhachhang.Caption = "Họ tên";
            this.colhotenkhachhang.FieldName = "hotenkhachhang";
            this.colhotenkhachhang.MinWidth = 25;
            this.colhotenkhachhang.Name = "colhotenkhachhang";
            this.colhotenkhachhang.Visible = true;
            this.colhotenkhachhang.VisibleIndex = 1;
            this.colhotenkhachhang.Width = 100;
            // 
            // colcmnd
            // 
            this.colcmnd.AppearanceCell.Options.UseTextOptions = true;
            this.colcmnd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcmnd.AppearanceHeader.Options.UseTextOptions = true;
            this.colcmnd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcmnd.Caption = "CMND";
            this.colcmnd.FieldName = "cmnd";
            this.colcmnd.MinWidth = 25;
            this.colcmnd.Name = "colcmnd";
            this.colcmnd.Visible = true;
            this.colcmnd.VisibleIndex = 2;
            this.colcmnd.Width = 100;
            // 
            // colsdt
            // 
            this.colsdt.AppearanceCell.Options.UseTextOptions = true;
            this.colsdt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsdt.AppearanceHeader.Options.UseTextOptions = true;
            this.colsdt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsdt.Caption = "SĐT";
            this.colsdt.FieldName = "sdt";
            this.colsdt.MinWidth = 25;
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 3;
            this.colsdt.Width = 100;
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
            this.colmasan.VisibleIndex = 4;
            this.colmasan.Width = 100;
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
            this.coldongia.VisibleIndex = 5;
            this.coldongia.Width = 100;
            // 
            // colthoigian
            // 
            this.colthoigian.AppearanceCell.Options.UseTextOptions = true;
            this.colthoigian.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colthoigian.AppearanceHeader.Options.UseTextOptions = true;
            this.colthoigian.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colthoigian.Caption = "Thời gian đặt";
            this.colthoigian.FieldName = "thoigian";
            this.colthoigian.MinWidth = 25;
            this.colthoigian.Name = "colthoigian";
            this.colthoigian.Visible = true;
            this.colthoigian.VisibleIndex = 6;
            this.colthoigian.Width = 100;
            // 
            // colnhanvienphutrach
            // 
            this.colnhanvienphutrach.AppearanceCell.Options.UseTextOptions = true;
            this.colnhanvienphutrach.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnhanvienphutrach.AppearanceHeader.Options.UseTextOptions = true;
            this.colnhanvienphutrach.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnhanvienphutrach.Caption = "Thu ngân";
            this.colnhanvienphutrach.FieldName = "nhanvienphutrach";
            this.colnhanvienphutrach.MinWidth = 25;
            this.colnhanvienphutrach.Name = "colnhanvienphutrach";
            this.colnhanvienphutrach.Visible = true;
            this.colnhanvienphutrach.VisibleIndex = 7;
            this.colnhanvienphutrach.Width = 100;
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
            this.colisdathanhtoan.Width = 115;
            // 
            // thongtindatsanTableAdapter
            // 
            this.thongtindatsanTableAdapter.ClearBeforeFill = true;
            // 
            // frmXemLichSuDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlLichSuSan);
            this.Name = "frmXemLichSuDatSan";
            this.Size = new System.Drawing.Size(1114, 525);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichSuSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongtindatsanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinDatSanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLichSuSan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlLichSuSan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLichSuSan;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colhotenkhachhang;
        private DevExpress.XtraGrid.Columns.GridColumn colcmnd;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
        private DevExpress.XtraGrid.Columns.GridColumn colmasan;
        private DevExpress.XtraGrid.Columns.GridColumn coldongia;
        private DevExpress.XtraGrid.Columns.GridColumn colthoigian;
        private DevExpress.XtraGrid.Columns.GridColumn colnhanvienphutrach;
        private DevExpress.XtraGrid.Columns.GridColumn colisdathanhtoan;
        private System.Windows.Forms.BindingSource thongtindatsanBindingSource;
        private ThongTinDatSanDataSet thongTinDatSanDataSet;
        private ThongTinDatSanDataSetTableAdapters.thongtindatsanTableAdapter thongtindatsanTableAdapter;
    }
}
