using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT.reporting
{
    public partial class DanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
            string macn = (Program.mChinhanh == 0) ? "CN1" : "CN2";
            lblChiNhanh.Text = (Program.mChinhanh == 0) ? "Chi Nhánh 1 - Hà Nội" : "Chi Nhánh 2 - TP.Hồ Chí Minh";
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;

            this.sqlDataSource1.Queries[0].Parameters[0].Value = Program.mGroup;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = macn;
            this.sqlDataSource1.Fill();
        }

        public DanhSachNhanVien(string macn, string tencn)
        {
            InitializeComponent();
            lblChiNhanh.Text = tencn;
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;

            this.sqlDataSource1.Queries[0].Parameters[0].Value = Program.mGroup;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = macn;
            this.sqlDataSource1.Fill();
        }
    }
}
