using QLVT.formCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmPhieuNhap : Form
    {
        public String maPN = "";
        DonHang dh;
        private int viTri;
        bool flagDH = false;
        public frmPhieuNhap()
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
        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            this.cTPNTableAdapter.Fill(this.dS.CTPN);

            if (Program.mGroup.Equals("CONGTY"))
            {
                btnThem.Enabled = btnXoa.Enabled = btnCTPN.Enabled = false;
            }
            btnGhi.Enabled = btnUndo.Enabled = panel1.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPN.Position;
            this.bdsPN.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnCTPN.Enabled = gcPN.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = panel1.Enabled = true;
            txtMANV.Text = Program.userName;
            txtNgay.DateTime = DateTime.Now;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maPN = "";
            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa Phiếu Nhập!!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa phiếu này chứ?", "XÁC NHẬN",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    maPN = ((DataRowView)bdsPN[bdsPN.Position])["MAPN"].ToString();
                    bdsPN.RemoveCurrent();
                    phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    phieuNhapTableAdapter.Update(this.dS.PhieuNhap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu nhập! \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
                    bdsPN.Position = bdsPN.Find("MAPN", maPN);
                    return;
                }
            }
            if (bdsPN.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraRangBuoc(txtMAPN, "Không được bỏ trống Mã Phiếu Nhập") == 0) return;
            if (txtMADDH.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng chọn Mã Đơn Hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMADDH.Focus();
                return;
            }
            int kiemTraTonTai = bdsPN.Find("MAPN", txtMAPN.Text);
            if (kiemTraTonTai != -1)
            {
                MessageBox.Show("Đã có Mã Phiếu Nhập này. Vui lòng chọn mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn ghi dữ liệu vào database?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnCTPN.Enabled = gcPN.Enabled = true;
                    btnGhi.Enabled = btnUndo.Enabled = panel1.Enabled = false;
                    bdsPN.EndEdit();
                    this.phieuNhapTableAdapter.Update(this.dS.PhieuNhap);
                    bdsPN.Position = viTri;
                }
                catch (Exception ex)
                {
                    bdsPN.RemoveCurrent();
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnCTPN.Enabled = gcPN.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = panel1.Enabled = false;
            bdsPN.CancelEdit();
            bdsPN.Position = viTri;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPN.Position;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            bdsPN.Position = viTri;
        }

        private void btnCTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CTPN ctpn = new CTPN();
            ctpn.maPN = ((DataRowView)this.bdsPN[this.bdsPN.Position])["MAPN"].ToString();
            ctpn.maDDH = ((DataRowView)this.bdsPN[this.bdsPN.Position])["MasoDDH"].ToString();
            ctpn.Show();
            Program.frmChinh.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtMADDH_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(txtMADDH.Text.Equals(""))
            {
                flagDH = true;
                dh = new DonHang();
                dh.Show();
                Program.frmChinh.Enabled = false;
            }
        }

        private void frmPhieuNhap_EnabledChanged(object sender, EventArgs e)
        {
            if (flagDH)
            {
                if (!dh.maKho.Equals("")) txtMAKHO.Text = dh.maKho;
                if (!dh.maDDH.Equals("")) txtMADDH.Text = dh.maDDH;
                flagDH = false;
            }
        }
    }
}
