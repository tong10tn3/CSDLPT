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
    public partial class frmCTPX : Form
    {
        public string maPX;

        public frmCTPX()
        {
            InitializeComponent();
        }

        private void frmCTPX_Load(object sender, EventArgs e)
        {
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            this.vattuTableAdapter.Fill(this.dS.Vattu);

            numSL.Value = 1;
            numDONGIA.Value = 0;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtMAVT.Text = ((DataRowView)this.bdsVatTu[this.bdsVatTu.Position])["MAVT"].ToString().Trim();
            numSL.Maximum = int.Parse(((DataRowView)this.bdsVatTu[this.bdsVatTu.Position])["SOLUONG"].ToString().Trim());
        }

        private void frmCTPX_Shown(object sender, EventArgs e)
        {
            this.bdsCTPX.AddNew();
            txtMAPX.Text = maPX;
        }

        private void frmCTPX_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.bdsCTPX.Find("MAPX", txtMAPX.Text) != -1 && this.bdsCTPX.Find("MAVT", txtMAVT.Text) != -1)
            {
                MessageBox.Show("Chi tiết này đã được lập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn ghi vào cơ sở dữ liệu?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string maVT = txtMAVT.Text;
                int SL = int.Parse(numSL.Value.ToString());
                String sqlCapNhat = "Update Vattu set SOLUONGTON = (SOLUONGTON - " + SL + ") where Vattu.MAVT ='" + maVT + "'";
                try
                {
                    this.bdsCTPX.EndEdit();
                    this.cTPXTableAdapter.Update(this.dS.CTPX);
                    int kq = Program.ExecSqlNonQuery(sqlCapNhat);
                    if (kq != 0)
                    {
                        bdsCTPX.CancelEdit();
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
    }
}
