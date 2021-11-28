using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVT.formCon;

namespace QLVT
{
    public partial class frmPhieuXuat : Form
    {
        public String maPX = "";
        private int viTri;
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private int kiemTraRangBuoc(TextBox TB, string str)
        {
            if (TB.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TB.Focus();
                return 0;
            }
            return 1;
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPhieuXuat.Position;
            this.bdsPhieuXuat.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnCTPN.Enabled = phieuXuatGridControl.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = panel1.Enabled = true;
            txtMaNV.Text = Program.userName;
            txtNgay.DateTime = DateTime.Now;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maPX = "";
            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa Phiếu Nhập!!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa phiếu này chứ?", "XÁC NHẬN",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    maPX = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position])["MAPX"].ToString();
                    bdsPhieuXuat.RemoveCurrent();
                    phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    phieuXuatTableAdapter.Update(this.dS.PhieuXuat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu nhập! \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
                    bdsPhieuXuat.Position = bdsPhieuXuat.Find("MAPN", maPX);
                    return;
                }
            }
            if (bdsPhieuXuat.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraRangBuoc(txtMAPX, "Không được bỏ trống Mã Phiếu Nhập") == 0) return;
            if (txtTenKH.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng điền tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            } else if (txtMaKho.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }
            int kiemTraTonTai = bdsPhieuXuat.Find("MAPN", txtMAPX.Text);
            if (kiemTraTonTai != -1)
            {
                MessageBox.Show("Đã có Mã Phiếu Nhập này. Vui lòng chọn mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn ghi dữ liệu vào database?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnCTPN.Enabled = phieuXuatGridControl.Enabled = true;
                    btnGhi.Enabled = btnUndo.Enabled = panel1.Enabled = false;
                    bdsPhieuXuat.EndEdit();
                    this.phieuXuatTableAdapter.Update(this.dS.PhieuXuat);
                    bdsPhieuXuat.Position = viTri;
                }
                catch (Exception ex)
                {
                    bdsPhieuXuat.RemoveCurrent();
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnCTPN.Enabled = phieuXuatGridControl.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = panel1.Enabled = false;
            bdsPhieuXuat.CancelEdit();
            bdsPhieuXuat.Position = viTri;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPhieuXuat.Position;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            bdsPhieuXuat.Position = viTri;
        }

        private void btnCTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCTPX ctpx = new frmCTPX();
            ctpx.maPX = ((DataRowView)this.bdsPhieuXuat[this.bdsPhieuXuat.Position])["MAPN"].ToString();
            ctpx.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
