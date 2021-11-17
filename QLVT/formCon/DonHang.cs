using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.formCon
{
    public partial class DonHang : Form
    {
        public string maKho = "";
        public string maDDH = "";
        public DonHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Đơn Hàng đã được lập phiếu nhập! Vui lòng chọn Đơn Hàng khác.", "Thông Báo",
                    MessageBoxButtons.OK);
                return;
            }
            maDDH = ((DataRowView)bdsDDH[bdsDDH.Position])["MasoDDH"].ToString().Trim();
            maKho = ((DataRowView)bdsDDH[bdsDDH.Position])["MAKHO"].ToString().Trim();
            this.Close();
        }

        private void DonHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }
    }
}
