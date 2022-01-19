using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QLVT.reporting
{
    public partial class RPDDH : DevExpress.XtraReports.UI.XtraReport
    {
        public RPDDH()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            BindingSource bdsCN = Program.bds_dspm;
            lbChiNhanh.Text = (((System.Data.DataRowView)bdsCN[bdsCN.Position])["TENCN"].ToString());
            this.sqlDataSource1.Fill();
        }
        public RPDDH(String tenChiNhanh)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;

            lbChiNhanh.Text = tenChiNhanh;
            this.sqlDataSource1.Fill();
        }


    }
}
