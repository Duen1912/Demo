using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXQLSB.Views
{
    public partial class frmDatDichVu : DevExpress.XtraEditors.XtraUserControl
    {
        public static DataTable loaiDichVuTable = null;
        public frmDatDichVu()
        {
            InitializeComponent();
        }

        private void frmDatDichVu_Load(object sender, EventArgs e)
        {
            if(loaiDichVuTable == null)
            {
                XtraMessageBox.Show("Lấy thông tin dịch vụ thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //XtraMessageBox.Show("Lấy thông tin dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (DataRow row in loaiDichVuTable.Rows)
                {
                    int id = Int32.Parse(row["madichvu"].ToString());
                    string tenloai = row["tenloai"].ToString();
                    PanelControl pnDV = new PanelControl();
                    pnDV = addDichVu(id, tenloai);
                    flLoPnDatDichVu.Controls.Add(pnDV);


                }
            }
        }

        // Hàm quản lý sự kiện click button được tạo ra, Quản lý sự kiện đặt dị ở đây
        void btnDichVuClick(Object sender, EventArgs e)
        {

            SimpleButton crrLoaiDichVu = (SimpleButton)sender;
            frmChonDichVu frmCDV = null;


            if (frmCDV == null || frmCDV.IsDisposed)
            {
                frmCDV = new frmChonDichVu();
                // Lấy mã dịch vụ của cái button vừa chọn
                int madichvu = Int32.Parse(crrLoaiDichVu.Text);

                // Đầu tiên lấy dữ liệu mấy sân đang có người đặt ra trước
                DataTable tbSanDaDat = null;
                tbSanDaDat = Controller.LayThongTinSanCtrl.LayThongTinSanDaDat();

                //Cái thứ 2 là lấy danh sách sản phẩm của loại dịch vụ ra từ cái mã dịch vụ lúc nãy
                DataTable tbSanPham = null;
                tbSanPham = Controller.LayLoaiDichVuCtrl.LayThongTinSanPham(madichvu);

                // Đổ table sân lúc nãy ra 3 cái đầu nếu có
                if(tbSanDaDat.Rows.Count != 0)
                {
                    foreach (DataRow row in tbSanDaDat.Rows)
                    {
                        //nè add dô
                        frmCDV.cbbSanDaDat.Properties.Items.Add(row["tensan"].ToString());
                        frmCDV.cbbLoaiSan.Properties.Items.Add(row["loaisan"].ToString());
                        frmCDV.cbbMaSan.Properties.Items.Add(row["id"].ToString());
                    }
                }
                else
                {
                    frmCDV.cbbSanDaDat.Properties.Items.Add("Chưa có sân nào đang sử dụng");
                    frmCDV.cbbSanDaDat.Enabled = false;
                    frmCDV.cbbLoaiSan.Enabled = false;
                    frmCDV.cbbMaSan.Enabled = false;
                    frmCDV.btnDatNgay.Enabled = false;
                }
                
                //Add xong rồi thì set index của 3 cái lại bằng 0 cho hiển thị item đầu tiên
                frmCDV.cbbSanDaDat.SelectedIndex = 0;
                frmCDV.cbbLoaiSan.SelectedIndex = 0;
                frmCDV.cbbMaSan.SelectedIndex = 0;

                // Bây giờ đổ thông tin sản phẩm ra
                if(tbSanPham.Rows.Count == 0 )
                {
                    frmCDV.cbbSanPham.Properties.Items.Add("Dịch vụ này chưa có sản phẩm nào");
                    frmCDV.cbbSanPham.Enabled = false;
                    frmCDV.cbbDonGia.Properties.Items.Add("0");
                    frmCDV.btnDatNgay.Enabled = false;
                }
                else
                {
                    foreach (DataRow row in tbSanPham.Rows)
                    {
                        //nè add dô
                        frmCDV.cbbSanPham.Properties.Items.Add(row["tensanpham"].ToString());
                        // Add dô cbb
                        frmCDV.cbbDonGia.Properties.Items.Add(
                        String.Format("{0:#,###0}", Int32.Parse(row["dongia"].ToString())));

                    }
                }
               
                // Bước quen thuộc , set index cho nó
                frmCDV.cbbSanPham.SelectedIndex = 0;
                frmCDV.cbbDonGia.SelectedIndex = 0;
                //MessageBox.Show(String.Format("{0:####0}", frmCDV.cbbDonGia.Text));
                //DataTable tableSan = null;
                // tableSan = Controller.LayThongTinSanCtrl.LayThongTinSanDeDat(Int32.Parse(currSan.Text));
                // Đổ dữ liệu ra
                /*foreach (DataRow row in tableSan.Rows)
                {
                   
                }*/
            }
        Check_DatDichVu:
            if (frmCDV.ShowDialog() == DialogResult.OK)
            {
                string tensan = frmCDV.cbbSanDaDat.Text;
                //XtraMessageBox.Show(crrLoaiDichVu.Text);
                int masan = Int32.Parse(frmCDV.cbbMaSan.Text);
                int madichvu = Int32.Parse(crrLoaiDichVu.Text);
                string tensanpham = frmCDV.cbbSanPham.Text;
                int donGia = Int32.Parse(frmCDV.cbbDonGia.Text, System.Globalization.NumberStyles.AllowThousands);
                int soluong = Int32.Parse(frmCDV.txtSoLuong.Value.ToString());
                int thanhtien = Int32.Parse(frmCDV.txtThanhTien.Text, System.Globalization.NumberStyles.AllowThousands);

                // Xét điều kiện
                if(soluong == 0)
                {
                    XtraMessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto Check_DatDichVu;
                }
                else
                {
                    if(XtraMessageBox.Show("Đặt dịch vụ cho sân: "+tensan+"\n"+ "Sản phẩm: "+tensanpham+"\nSố lượng: "+soluong.ToString()+"\nThành tiền: "+thanhtien.ToString(),
                        "Xác Nhận",MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string result = "";
                        result = Controller.DatDichVuCtrl.ThemDichVuVaoSan(masan, madichvu, tensanpham, donGia, soluong, thanhtien);
                        if(result != "")
                        {
                            XtraMessageBox.Show("Đặt dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Đặt dịch vụ thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto Check_DatDichVu;
                        }
                    }
                }
            }

        }

        SimpleButton btnDichVu(int i, string tenloai)
        {
            SimpleButton btnDichVu = new SimpleButton();
            btnDichVu.Name = "btnSan" + i.ToString();
            btnDichVu.Width = 265;
            btnDichVu.Height = 250;
            if(tenloai.StartsWith("Nước uống"))
            {
                btnDichVu.ImageOptions.Image = DXQLSB.Properties.Resources.water;
            }else if(tenloai.StartsWith("Đồ ăn"))
            {
                btnDichVu.ImageOptions.Image = DXQLSB.Properties.Resources.hot_dog;
            }else if(tenloai.StartsWith("Trái cây"))
            {
                btnDichVu.ImageOptions.Image = DXQLSB.Properties.Resources.fruit;
            }
            else
            {
                btnDichVu.ImageOptions.Image = DXQLSB.Properties.Resources.service;
            }

            btnDichVu.Margin = new Padding(5);
            btnDichVu.Dock = DockStyle.Top;
            btnDichVu.Text = i.ToString();

            btnDichVu.Click += new EventHandler(this.btnDichVuClick);

            return btnDichVu;
        }

        LabelControl lblTenLoaiDichVu(int i, string tenloai, int pnMainWidth, int pnMainHeight)
        {
            // PanelControl pn4Label = new PanelControl();
            // pn4Label.Dock = DockStyle.Bottom;
            //pn4Label.Size = new Size(pnSanWidth, pnSanHeight);
            //Tạo label để tí add dô 
            LabelControl label = new LabelControl();
            label.Name = "lblDichVu" + i.ToString();
            label.Width = pnMainWidth;
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Dock = DockStyle.Bottom;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Height = 20;
            label.Margin = new Padding(10);
            //label.Location = new Point(((pnMainWidth - label.Width) / 2), (pnMainHeight - label.Height));
            label.Font = new Font("Tahoma", 10, FontStyle.Bold);
            
            label.Text = tenloai;
            
            label.ForeColor = Color.Yellow;
            label.BackColor = Color.Black;


            //  pn4Label.Controls.Add(label);
            return label;
        }

        PanelControl addDichVu(int i, string tenLoai)
        {
            //Panel chính chứa button và label
            PanelControl panelMain = new PanelControl();
            panelMain.Width = 270;
            panelMain.Height = 280;
            panelMain.Name = "pnDichVu" + i.ToString();
            
            // Tạo button Sân
            SimpleButton btn = new SimpleButton();
            btn = btnDichVu(i, tenLoai);
            // Tạo panel có chứa label mô tả tên sân
            // PanelControl pn4Label = new PanelControl();
            // pn4Label = pnLabelSan(i);
            LabelControl label = new LabelControl();
            label = lblTenLoaiDichVu(i, tenLoai, panelMain.Width, panelMain.Height);
            // Add 2 cái trên vô 1 panel
            panelMain.Controls.Add(btn);
            panelMain.Controls.Add(label);
            
            return panelMain;

        }
    }
}
