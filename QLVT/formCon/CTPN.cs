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
    public partial class CTPN : Form
    {
        public String maPN = "";
        public String maDDH = "";
        public CTPN()
        {
            InitializeComponent();
        }

        private void CTPN_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);

            bdsCTDDH.Filter = "MasoDDH='" + maDDH + "'";
            nuSL.Value = 1;
            nuDonGia.Value = 0;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMAVT.Text = ((DataRowView)this.bdsCTDDH[this.bdsCTDDH.Position])["MAVT"].ToString().Trim();
            nuSL.Maximum = int.Parse(((DataRowView)this.bdsCTDDH[this.bdsCTDDH.Position])["SOLUONG"].ToString().Trim());
            nuSL.Value = int.Parse(((DataRowView)this.bdsCTDDH[this.bdsCTDDH.Position])["SOLUONG"].ToString().Trim());
            nuDonGia.Value = int.Parse(((DataRowView)this.bdsCTDDH[this.bdsCTDDH.Position])["DONGIA"].ToString().Trim());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.bdsCTPN.Find("MAPN", txtMAPN.Text) != -1 && this.bdsCTPN.Find("MAVT", txtMAVT.Text) != -1)
            {
                MessageBox.Show("Chi tiết này đã được lập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn ghi vào cơ sở dữ liệu?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string maVT = txtMAVT.Text;
                int SL = int.Parse(nuSL.Value.ToString());
                String sqlCapNhat = "Update Vattu set SOLUONGTON = (SOLUONGTON + " + SL + ") where Vattu.MAVT ='" + maVT + "'";
                try
                {
                    this.bdsCTPN.EndEdit();
                    this.cTPNTableAdapter.Update(this.dS.CTPN);
                    int kq = Program.ExecSqlNonQuery(sqlCapNhat);
                    if (kq != 0)
                    {
                        bdsCTPN.CancelEdit();
                        MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ghi dữ liệu thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CTPN_Shown(object sender, EventArgs e)
        {
            this.bdsCTPN.AddNew();
            txtMAPN.Text = maPN;
        }

        private void CTPN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }
    }
}
