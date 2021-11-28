using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.reporting
{
    public partial class TongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        string ngayBD, ngayKT;
        public TongHopNhapXuat(DateTime ngaybd, DateTime ngaykt)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngaybd;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngaykt;
            this.sqlDataSource1.Fill();
            this.ngayBD = ngaybd.ToString("dd/MM/yyyy");
            this.ngayKT = ngaykt.ToString("dd/MM/yyyy");
        }

        private void TongHopNhapXuat_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblChiNhanh.Text = (Program.mChinhanh == 0) ? "Chi Nhánh 1 - Hà Nội" : "Chi Nhánh 2 - TP.Hồ Chí Minh";
            lblThoiGianBD.Text = ngayBD;
            lblThoiGianKT.Text = ngayKT;
        }
    }
}
