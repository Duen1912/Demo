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
    public partial class frmTraSan : DevExpress.XtraEditors.XtraUserControl
    {
        public static string userWorking;
        public static DataTable sanDangDatTable = null;
        public frmTraSan()
        {
            InitializeComponent();
        }

        private void frmTraSan_Load(object sender, EventArgs e)
        {
            if (sanDangDatTable == null)
            {
                MessageBox.Show("Lấy thông tin sân thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                foreach (DataRow row in sanDangDatTable.Rows)
                {

                    string tensan = row["tensan"].ToString();
                    int id = int.Parse(row["id"].ToString());
                    PanelControl pnSan = new PanelControl();
                    pnSan = addSan(id, tensan);
                    if (row["isdangdat"].ToString() == "False")
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
            frmThongTinTraSan frmTTTS = null;
            int _masan = Int32.Parse(currSan.Text);
            // XtraMessageBox.Show(currSan.Text);
            int tongtiensan = 0;
            int tongtiendichvu = 0;
            int tongcong = 0;
            if (frmTTTS == null || frmTTTS.IsDisposed)
            {
                frmTTTS = new frmThongTinTraSan();
                DataTable thongTinDatSan = null;
                thongTinDatSan = Controller.LayThongTinDatSanCtrl.LayThongTinDatSan(_masan);

                DateTime thoigianbatdau;
                DateTime thoigianhientai = DateTime.Now;
                TimeSpan thoigiansudung;

                
                //San
                foreach (DataRow row in thongTinDatSan.Rows)
                {
                    frmTTTS.lblMaSan.Text = row["masan"].ToString();
                    frmTTTS.lblHoTen.Text = row["hotenkhachhang"].ToString();
                    frmTTTS.lblCMND.Text = row["cmnd"].ToString();
                    frmTTTS.lblSDT.Text = row["sdt"].ToString();
                    int dongia = Int32.Parse(row["dongia"].ToString());
                    frmTTTS.lblDonGia.Text = String.Format("{0:#,###0}", dongia);
                    
                    thoigianbatdau = DateTime.Parse(row["thoigian"].ToString());
                    thoigiansudung = (thoigianhientai - thoigianbatdau);
                    double sotiengsudung = Math.Ceiling(thoigiansudung.TotalHours);
                    frmTTTS.lblThoiGianSuDung.Text = sotiengsudung.ToString()+" tiếng (giờ lẻ tính thành 1 giờ)";

                    tongtiensan = (int)sotiengsudung * dongia;
                    frmTTTS.lblTTSan.Text = String.Format("{0:#,###0}", tongtiensan);
                }
                DataTable tenSan = Controller.LayThongTinSanCtrl.LayThongTinSanDeDat(_masan);
                foreach (DataRow row in tenSan.Rows)
                {
                    frmTTTS.lblTenSan.Text = row["tensan"].ToString();
                }

                    //Dich vu
                    DataTable thongTinDatDichVuTable = Controller.LayThongTinDatDichVuCtrl.LayThongTinDatDichVu(_masan);
                if(thongTinDatDichVuTable.Rows.Count == 0)
                {
                    frmTTTS.lblTTDichVu.Text = "0";
                }
                else
                {
                    foreach (DataRow row in thongTinDatDichVuTable.Rows)
                    {
                        string tensanpham = row["tensanpham"].ToString();
                        int dongia = Int32.Parse(row["dongia"].ToString());
                        int soluong = Int32.Parse(row["soluong"].ToString());
                        int thanhtien = Int32.Parse(row["thanhtien"].ToString());
                        frmTTTS.dichvuGrid.Rows.Add(tensanpham, String.Format("{0:#,###0}", dongia),
                            String.Format("{0:#,###0}", soluong), String.Format("{0:#,###0}", thanhtien));

                        tongtiendichvu += thanhtien;
                        
                        frmTTTS.lblTTDichVu.Text = String.Format("{0:#,###0}", tongtiendichvu);

                    }
                }
                // Tổng tiền
                tongcong = tongtiensan + tongtiendichvu;
                frmTTTS.lblTongCong.Text = String.Format("{0:#,###0}", tongcong);

            }
            if (frmTTTS.ShowDialog() == DialogResult.OK)
            {
                if(MessageBox.Show("Bạn có chắc muốn thanh toán sân này", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string tensan = frmTTTS.lblTenSan.Text;
                    int masan = Int32.Parse(frmTTTS.lblMaSan.Text);
                    string ngaytao = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
                    string nguoitao = userWorking;

                    //Làm trống sân
                    string lamtrongsan = Controller.TraSanCtrl.LamTrongSan(masan);
                    string thanhtoansan = Controller.TraSanCtrl.ThanhToanSan(masan);
                    string thanhtoandichvu = Controller.TraSanCtrl.ThanhToanDichVu(masan);
                    string taohoadon = Controller.TraSanCtrl.TaoHoaDon(tensan, masan, tongtiensan,
                        tongtiendichvu, tongcong, ngaytao, nguoitao);
                    if(lamtrongsan != "" && thanhtoansan != "" & thanhtoandichvu != "" && taohoadon != "")
                    {
                        XtraMessageBox.Show("Thanh toán và trả sân thành công", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        currSan.Enabled = false;
                    }
                    else
                    {
                        XtraMessageBox.Show("Thanh toán và trả sân thất bại", "Lỗi",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (tensan.StartsWith("VIP"))
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
