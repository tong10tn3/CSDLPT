using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.reporting
{
    public partial class frmBangKeChiTietNhapXuat : Form
    {
        public frmBangKeChiTietNhapXuat()
        {
            InitializeComponent();
            cbLoai.SelectedIndex = 0;
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
                string loai = (cbLoai.SelectedItem.ToString().Equals("Nhập")) ? "Nhap" : "Xuat";
                DateTime ngaybd = new DateTime(dateBD.DateTime.Year, dateBD.DateTime.Month, 1);
                int dayOfMounthKT = DateTime.DaysInMonth(dateKT.DateTime.Year, dateKT.DateTime.Month);
                DateTime ngaykt = new DateTime(dateKT.DateTime.Year, dateKT.DateTime.Month, dayOfMounthKT);
                BangKeChiTiet rpt = new BangKeChiTiet(loai, ngaybd, ngaykt);

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
        }
    }
}
