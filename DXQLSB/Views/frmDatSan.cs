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
    public partial class frmDatSan : DevExpress.XtraEditors.XtraUserControl
    {
        public static DataTable tableSan = null;
        public frmDatSan()
        {
            InitializeComponent();
        }

        private void frmDatSan_Load(object sender, EventArgs e)
        {
            if(tableSan == null)
            {
                MessageBox.Show("Lấy thông tin sân thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                
                foreach (DataRow row in tableSan.Rows)
                {
                    
                    string tensan =  row["tensan"].ToString();
                    int id = int.Parse(row["id"].ToString());
                    PanelControl pnSan = new PanelControl();
                    pnSan = addSan(id, tensan);
                    if(row["isdangdat"].ToString() == "True")
                    {
                        pnSan.Enabled = false;
                    }
                    flowLayoutPanel.Controls.Add(pnSan);
                    
                    
                }
                /*for (int i = 0; i < 50; i++)
                {
                    PanelControl pnSan = new PanelControl();
                    pnSan = addSan(i);
                    flowLayoutPanel.Controls.Add(pnSan);
                }*/
            }
            
        }
        
        // Hàm quản lý sự kiện click button được tạo ra, Quản lý sự kiện đặt sân ở đây
        void btnSanClick(Object sender, EventArgs e)
        {
            
            SimpleButton currSan = (SimpleButton)sender;
            frmThongTinDatSan frmTTDS = null;


            if (frmTTDS == null || frmTTDS.IsDisposed)
            {
                frmTTDS = new frmThongTinDatSan();
                // Mã sân
                frmTTDS.txtMaSan.Font = new Font(frmTTDS.txtMaSan.Font, FontStyle.Bold);
                frmTTDS.txtMaSan.Text = currSan.Text;
                //MessageBox.Show(currSan.Text);
                // Lấy thông tin sân để đặt bằng ID
                DataTable tableSan = null;
                tableSan = Controller.LayThongTinSanCtrl.LayThongTinSanDeDat(Int32.Parse(currSan.Text));
                // Đổ dữ liệu ra
                foreach (DataRow row in tableSan.Rows)
                {
                // Tên sân
                
                    frmTTDS.txtTenSan.Font = new Font(frmTTDS.txtTenSan.Font, FontStyle.Bold);
                    if (row["tensan"].ToString().StartsWith("VIP"))
                    {
                        frmTTDS.txtTenSan.Text = row["tensan"].ToString();
                        frmTTDS.txtTenSan.ForeColor = Color.Blue;
                        //frmTTDS.txtTenSan.BackColor = Color.Gray;
                    }
                    else if (row["tensan"].ToString().StartsWith("VVIP"))
                    {
                        frmTTDS.txtTenSan.Text = row["tensan"].ToString();
                        frmTTDS.txtTenSan.ForeColor = Color.Red;
                        //frmTTDS.txtTenSan.BackColor = Color.Gray;
                    }
                    else if (row["tensan"].ToString().StartsWith("SVIP"))
                    {
                        frmTTDS.txtTenSan.Text = row["tensan"].ToString();
                        frmTTDS.txtTenSan.ForeColor = Color.Yellow;
                        frmTTDS.txtTenSan.BackColor = Color.Black;
                    }
                    frmTTDS.txtTenSan.Text = row["tensan"].ToString();
                    // Loại sân
                    frmTTDS.txtLoaiSan.Text = row["loaisan"].ToString();
                    frmTTDS.txtLoaiSan.Font = new Font(frmTTDS.txtLoaiSan.Font, FontStyle.Bold);
                    // Đơn giá
                    int dongia = Int32.Parse(row["dongia"].ToString());
                    frmTTDS.txtDonGia.Tag = dongia;
                    frmTTDS.txtDonGia.Text = String.Format("{0:#,###0}", dongia);
                    frmTTDS.txtDonGia.Font = new Font(frmTTDS.txtDonGia.Font, FontStyle.Bold);
                }
            }
            Check_DatSan:
            if (frmTTDS.ShowDialog() == DialogResult.OK)
            {
                if(frmTTDS.txtHoTenKhachHang.Text == "" || frmTTDS.txtSDT.Text == "" || frmTTDS.txtSDT.Text == "")
                {
                    XtraMessageBox.Show("Thông tin khách hàng không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto Check_DatSan;
                }
                else
                {
                    string hotenkhachhang = frmTTDS.txtHoTenKhachHang.Text;
                    string cmnd = frmTTDS.txtCMND.Text;
                    string sdt = frmTTDS.txtSDT.Text;
                    int masan = Int32.Parse(frmTTDS.txtMaSan.Text);
                    int dongia = Int32.Parse(frmTTDS.txtDonGia.Tag.ToString());
                    string thoigian = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
                    string nhanvienphutrach = formMain.tendangnhap;
                    //MessageBox.Show("Đơn giá " + dongia + " thời gian " + thoigian + " nhân viên " + nhanvienphutrach);
                    string result = "";
                    result = Controller.DatSanCtrl.ThemThongTinNguoiDatSan(hotenkhachhang, cmnd, sdt,
                        masan, dongia, thoigian, nhanvienphutrach);
                    //MessageBox.Show(result);
                    if(result == "0")
                    {
                        XtraMessageBox.Show("Đặt sân thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        currSan.Enabled = false;
                        XtraMessageBox.Show("Đặt sân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        PanelControl addSan(int i, string tensan)
        {
            //Panel chính chứa button và label
            PanelControl panelMain = new PanelControl();
            panelMain.Width = 265;
            panelMain.Height = 210;
            panelMain.Name = "pnSan" + i.ToString();
            // Tạo button Sân
            SimpleButton btn = new SimpleButton();
            btn = btnSan(i);
            // Tạo panel có chứa label mô tả tên sân
            // PanelControl pn4Label = new PanelControl();
            // pn4Label = pnLabelSan(i);
            LabelControl label = new LabelControl();
            label = lblSan(i, tensan, panelMain.Width, panelMain.Height, btn.Height);
            // Add 2 cái trên vô 1 panel
            panelMain.Controls.Add(btn);
            panelMain.Controls.Add(label);

            return panelMain;

        }
        SimpleButton btnSan(int i)
        {
            SimpleButton btnSan = new SimpleButton();
            btnSan.Name = "btnSan" + i.ToString();
            btnSan.Width = 260;
            btnSan.Height = 178;
            btnSan.ImageOptions.Image = DXQLSB.Properties.Resources.football_field_256;
            btnSan.Margin = new Padding(5);
            btnSan.Dock = DockStyle.Top;
            btnSan.Text = i.ToString();

            btnSan.Click += new EventHandler(this.btnSanClick);

            return btnSan;
        }

        LabelControl lblSan(int i, string tensan, int pnMainWidth, int pnMainHeight, int btnSanHeight)
        {
            // PanelControl pn4Label = new PanelControl();
            // pn4Label.Dock = DockStyle.Bottom;
            //pn4Label.Size = new Size(pnSanWidth, pnSanHeight);
            //Tạo label để tí add dô 
            LabelControl label = new LabelControl();
            label.Name = "lblSan" + i.ToString();
            label.Width = pnMainWidth;
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Dock = DockStyle.Bottom;
            label.Height = 20;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Margin = new Padding(10);
            //label.Location = new Point(((pnMainWidth - label.Width )/ 2) + 30  , (pnMainHeight - label.Height - 5));
            label.Font = new Font("Tahoma", 10, FontStyle.Bold);
            label.Text = tensan;
            if(tensan.StartsWith("VIP"))
            {
                 label.ForeColor = Color.Blue;
                //label.BackColor = Color.Gray;
            }
            else if (tensan.StartsWith("VVIP"))
            {
                label.ForeColor = Color.Red;
                //label.BackColor = Color.Gray;
            }
            else if (tensan.StartsWith("SVIP"))
            {
                label.ForeColor = Color.Yellow;
                label.BackColor = Color.Black;
            }

            //  pn4Label.Controls.Add(label);
            return label;
        }
    }
}
