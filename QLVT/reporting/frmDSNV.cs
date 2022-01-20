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
    public partial class frmDSNV : Form
    {
        public frmDSNV()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("MACN");
            dt.Columns.Add("TENCN");
            DataRow col1 = dt.NewRow();
            col1["MACN"] = "CN1";
            col1["TENCN"] = "Chi Nhánh 1 - Hà Nội";
            dt.Rows.Add(col1);
            col1 = dt.NewRow();
            col1["MACN"] = "CN2";
            col1["TENCN"] = "Chi Nhánh 2 - Hồ Chí Minh";
            dt.Rows.Add(col1);

            cbChiNhanh.DataSource = dt;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "MACN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien rpt = new DanhSachNhanVien(cbChiNhanh.SelectedValue.ToString(), cbChiNhanh.Text.Trim());
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
