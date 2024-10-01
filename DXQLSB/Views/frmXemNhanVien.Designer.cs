namespace DXQLSB.Views
{
    partial class frmXemNhanVien
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
            this.nhanVienDataSet = new DXQLSB.NhanVienDataSet();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new DXQLSB.NhanVienDataSetTableAdapters.nhanvienTableAdapter();
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmsnv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaytao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanVienDataSet
            // 
            this.nhanVienDataSet.DataSetName = "NhanVienDataSet";
            this.nhanVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.nhanVienDataSet;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.DataSource = this.nhanvienBindingSource;
            this.gridControlNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhanVien.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridControlNhanVien.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControlNhanVien.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gridControlNhanVien_EmbeddedNavigator_ButtonClick);
            this.gridControlNhanVien.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridControlNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gridControlNhanVien.MainView = this.gridViewNhanVien;
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.Size = new System.Drawing.Size(1114, 525);
            this.gridControlNhanVien.TabIndex = 0;
            this.gridControlNhanVien.UseEmbeddedNavigator = true;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien,
            this.layoutView1});
            this.gridControlNhanVien.Load += new System.EventHandler(this.gridControlNhanVien_Load);
            // 
            // gridViewNhanVien
            // 
            this.gridViewNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmsnv,
            this.colhoten,
            this.colgioitinh,
            this.coldiachi,
            this.colngaytao});
            this.gridViewNhanVien.GridControl = this.gridControlNhanVien;
            this.gridViewNhanVien.Name = "gridViewNhanVien";
            this.gridViewNhanVien.OptionsFind.AlwaysVisible = true;
            this.gridViewNhanVien.OptionsFind.FindNullPrompt = "Nhập để tìm kiếm ...";
            this.gridViewNhanVien.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colmsnv
            // 
            this.colmsnv.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colmsnv.AppearanceHeader.Options.UseFont = true;
            this.colmsnv.AppearanceHeader.Options.UseTextOptions = true;
            this.colmsnv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmsnv.Caption = "MSNV";
            this.colmsnv.FieldName = "msnv";
            this.colmsnv.MinWidth = 25;
            this.colmsnv.Name = "colmsnv";
            this.colmsnv.Visible = true;
            this.colmsnv.VisibleIndex = 0;
            this.colmsnv.Width = 108;
            // 
            // colhoten
            // 
            this.colhoten.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colhoten.AppearanceHeader.Options.UseFont = true;
            this.colhoten.AppearanceHeader.Options.UseTextOptions = true;
            this.colhoten.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhoten.Caption = "HỌ TÊN";
            this.colhoten.FieldName = "hoten";
            this.colhoten.MinWidth = 25;
            this.colhoten.Name = "colhoten";
            this.colhoten.Visible = true;
            this.colhoten.VisibleIndex = 1;
            this.colhoten.Width = 242;
            // 
            // colgioitinh
            // 
            this.colgioitinh.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colgioitinh.AppearanceHeader.Options.UseFont = true;
            this.colgioitinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colgioitinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgioitinh.Caption = "GIỚI TÍNH (tick là nam)";
            this.colgioitinh.FieldName = "gioitinh";
            this.colgioitinh.MinWidth = 25;
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.Visible = true;
            this.colgioitinh.VisibleIndex = 2;
            this.colgioitinh.Width = 242;
            // 
            // coldiachi
            // 
            this.coldiachi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.coldiachi.AppearanceHeader.Options.UseFont = true;
            this.coldiachi.AppearanceHeader.Options.UseTextOptions = true;
            this.coldiachi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldiachi.Caption = "ĐỊA CHỈ";
            this.coldiachi.FieldName = "diachi";
            this.coldiachi.MinWidth = 25;
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.Visible = true;
            this.coldiachi.VisibleIndex = 3;
            this.coldiachi.Width = 242;
            // 
            // colngaytao
            // 
            this.colngaytao.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colngaytao.AppearanceHeader.Options.UseFont = true;
            this.colngaytao.AppearanceHeader.Options.UseTextOptions = true;
            this.colngaytao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colngaytao.Caption = "NGÀY TẠO";
            this.colngaytao.FieldName = "ngaytao";
            this.colngaytao.MinWidth = 25;
            this.colngaytao.Name = "colngaytao";
            this.colngaytao.Visible = true;
            this.colngaytao.VisibleIndex = 4;
            this.colngaytao.Width = 250;
            // 
            // layoutView1
            // 
            this.layoutView1.GridControl = this.gridControlNhanVien;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = null;
            // 
            // frmXemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlNhanVien);
            this.Name = "frmXemNhanVien";
            this.Size = new System.Drawing.Size(1114, 525);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private NhanVienDataSet nhanVienDataSet;
        private NhanVienDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colmsnv;
        private DevExpress.XtraGrid.Columns.GridColumn colhoten;
        private DevExpress.XtraGrid.Columns.GridColumn colgioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn coldiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colngaytao;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
    }
}
