using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLVT.reporting
{
    public partial class BangKeChiTiet : DevExpress.XtraReports.UI.XtraReport
    {
        string loai;
        string ngaybd;
        string ngaykt;
        public BangKeChiTiet(String loai, DateTime ngaybd, DateTime ngaykt)
        {
            InitializeComponent();
            this.loai = loai;
            this.ngaybd = ngaybd.ToString("MM-dd-yyyy");    
            this.ngaykt = ngaykt.ToString("MM-dd-yyyy");
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            Console.WriteLine(this.sqlDataSource1.Connection.ConnectionString);
            this.sqlDataSource1.Queries[0].Parameters[0].Value = Program.mGroup;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = this.loai;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = this.ngaybd;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = this.ngaykt;
            this.sqlDataSource1.Fill();
        }

        private void BangKeChiTiet_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            lblTieuDe.Text = (this.loai == "NHAP") ? "BẢNG KÊ CHI TIẾT HÀNG NHẬP " : "BẢNG KÊ CHI TIẾT HÀNG XUẤT";
            string[] ngayHT = DateTime.Now.ToString("dd/MM/yyyy").Split('/');
            lblNgay.Text = "Ngày " + ngayHT[0] + " Tháng " + ngayHT[1] + " Năm " + ngayHT[2];
            String[] arrNgayBD = this.ngaybd.Split('-');
            String[] arrNgayKT = this.ngaykt.Split('-');
            lblThoiGian.Text = "Từ tháng " + arrNgayBD[0] + "/" + arrNgayBD[2];
            lblThoiGian.Text += " đến tháng " + arrNgayKT[0] + "/" + arrNgayKT[2];

            if (Program.mGroup == "CONGTY")
            {
                lblChiNhanh.Text = "CN1:Hà Nội - CN2:TPHCM";
            }
            else
            { 
                lblChiNhanh.Text = (Program.mChinhanh==0) ? "Chi Nhánh 1 - Hà Nội" : "Chi Nhánh 2 - TP.Hồ Chí Minh";
            }
        }
    }
}
