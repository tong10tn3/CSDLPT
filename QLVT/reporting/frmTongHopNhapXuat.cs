using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.reporting
{
    public partial class frmTongHopNhapXuat : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public frmTongHopNhapXuat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateBD.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn tháng năm bắt đầu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateBD.Focus();
            }
            else if (dateKT.EditValue == null)
            {
                MessageBox.Show("Vui lòng chọn tháng năm kết thúc!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateKT.Focus();
            }
            else if (DateTime.Compare(dateBD.DateTime, dateKT.DateTime) > 0)
            {
                MessageBox.Show("Tháng năm kết thúc < Tháng năm bắt đầu. Vui lòng kiểm tra lại!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateKT.Focus();
            }
            else
            {
                TongHopNhapXuat rpNhapXuat = new TongHopNhapXuat(dateBD.DateTime, dateKT.DateTime);
                ReportPrintTool rpt = new ReportPrintTool(rpNhapXuat);
                rpNhapXuat.ShowPreviewDialog();
            }
        }

        private void frmTongHopNhapXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }
    }
}
