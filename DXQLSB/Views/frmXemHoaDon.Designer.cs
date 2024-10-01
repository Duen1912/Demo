namespace DXQLSB.Views
{
    partial class frmXemHoaDon
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonDataSet = new DXQLSB.HoaDonDataSet();
            this.gridViewXemHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltensan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltongtiensan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltongtiendichvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltongcong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaytao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnguoitao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoadonTableAdapter = new DXQLSB.HoaDonDataSetTableAdapters.hoadonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXemHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hoadonBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridViewXemHoaDon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1114, 525);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewXemHoaDon});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.hoaDonDataSet;
            // 
            // hoaDonDataSet
            // 
            this.hoaDonDataSet.DataSetName = "HoaDonDataSet";
            this.hoaDonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewXemHoaDon
            // 
            this.gridViewXemHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coltensan,
            this.colmasan,
            this.coltongtiensan,
            this.coltongtiendichvu,
            this.coltongcong,
            this.colngaytao,
            this.colnguoitao});
            this.gridViewXemHoaDon.GridControl = this.gridControl1;
            this.gridViewXemHoaDon.Name = "gridViewXemHoaDon";
            this.gridViewXemHoaDon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewXemHoaDon.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewXemHoaDon.OptionsBehavior.Editable = false;
            this.gridViewXemHoaDon.OptionsFind.AlwaysVisible = true;
            this.gridViewXemHoaDon.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm ...";
            this.gridViewXemHoaDon.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.GroupPanel;
            this.gridViewXemHoaDon.OptionsView.ShowFooter = true;
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
            this.coltensan.Width = 140;
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
            this.colmasan.VisibleIndex = 2;
            this.colmasan.Width = 140;
            // 
            // coltongtiensan
            // 
            this.coltongtiensan.AppearanceCell.Options.UseTextOptions = true;
            this.coltongtiensan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltongtiensan.AppearanceHeader.Options.UseTextOptions = true;
            this.coltongtiensan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltongtiensan.Caption = "Tổng tiền sân";
            this.coltongtiensan.DisplayFormat.FormatString = "{0:#,###0}";
            this.coltongtiensan.FieldName = "tongtiensan";
            this.coltongtiensan.MinWidth = 25;
            this.coltongtiensan.Name = "coltongtiensan";
            this.coltongtiensan.Visible = true;
            this.coltongtiensan.VisibleIndex = 3;
            this.coltongtiensan.Width = 140;
            // 
            // coltongtiendichvu
            // 
            this.coltongtiendichvu.AppearanceCell.Options.UseTextOptions = true;
            this.coltongtiendichvu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltongtiendichvu.AppearanceHeader.Options.UseTextOptions = true;
            this.coltongtiendichvu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltongtiendichvu.Caption = "Tổng tiền dịch vụ";
            this.coltongtiendichvu.DisplayFormat.FormatString = "{0:#,###0}";
            this.coltongtiendichvu.FieldName = "tongtiendichvu";
            this.coltongtiendichvu.MinWidth = 25;
            this.coltongtiendichvu.Name = "coltongtiendichvu";
            this.coltongtiendichvu.Visible = true;
            this.coltongtiendichvu.VisibleIndex = 4;
            this.coltongtiendichvu.Width = 140;
            // 
            // coltongcong
            // 
            this.coltongcong.AppearanceCell.Options.UseTextOptions = true;
            this.coltongcong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltongcong.AppearanceHeader.Options.UseTextOptions = true;
            this.coltongcong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltongcong.Caption = "Tổng cộng";
            this.coltongcong.DisplayFormat.FormatString = "{0:#,###0}";
            this.coltongcong.FieldName = "tongcong";
            this.coltongcong.MinWidth = 25;
            this.coltongcong.Name = "coltongcong";
            this.coltongcong.Visible = true;
            this.coltongcong.VisibleIndex = 5;
            this.coltongcong.Width = 140;
            // 
            // colngaytao
            // 
            this.colngaytao.AppearanceCell.Options.UseTextOptions = true;
            this.colngaytao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colngaytao.AppearanceHeader.Options.UseTextOptions = true;
            this.colngaytao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colngaytao.Caption = "Ngày tạo";
            this.colngaytao.FieldName = "ngaytao";
            this.colngaytao.MinWidth = 25;
            this.colngaytao.Name = "colngaytao";
            this.colngaytao.Visible = true;
            this.colngaytao.VisibleIndex = 6;
            this.colngaytao.Width = 140;
            // 
            // colnguoitao
            // 
            this.colnguoitao.AppearanceCell.Options.UseTextOptions = true;
            this.colnguoitao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnguoitao.AppearanceHeader.Options.UseTextOptions = true;
            this.colnguoitao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnguoitao.Caption = "Người tạo";
            this.colnguoitao.FieldName = "nguoitao";
            this.colnguoitao.MinWidth = 25;
            this.colnguoitao.Name = "colnguoitao";
            this.colnguoitao.Visible = true;
            this.colnguoitao.VisibleIndex = 7;
            this.colnguoitao.Width = 150;
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // frmXemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "frmXemHoaDon";
            this.Size = new System.Drawing.Size(1114, 525);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXemHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewXemHoaDon;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private HoaDonDataSet hoaDonDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coltensan;
        private DevExpress.XtraGrid.Columns.GridColumn colmasan;
        private DevExpress.XtraGrid.Columns.GridColumn coltongtiensan;
        private DevExpress.XtraGrid.Columns.GridColumn coltongtiendichvu;
        private DevExpress.XtraGrid.Columns.GridColumn coltongcong;
        private DevExpress.XtraGrid.Columns.GridColumn colngaytao;
        private DevExpress.XtraGrid.Columns.GridColumn colnguoitao;
        private HoaDonDataSetTableAdapters.hoadonTableAdapter hoadonTableAdapter;
    }
}
