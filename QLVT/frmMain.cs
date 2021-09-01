using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        
        public void hienThiMenu()
        {
            MANV.Caption = "MANV: " + Program.userName;
            TEN.Caption = "HO TEN: " + Program.mHoten;
            NHOM.Caption = "NHOM: " + Program.mGroup;


        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Form frm = this.CheckExists(typeof(NhanVien));
             if (frm != null) frm.Activate();
             else
             {
                 NhanVien f = new NhanVien();
                 f.MdiParent = this;
                 f.Show();
             }*/
        }

        private void btnNhanVien_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Form frm = this.CheckExists(typeof(NhanVien));
             if (frm != null) frm.Activate();
             else
             {
                 NhanVien f = new NhanVien();
                 f.MdiParent = this;
                 f.Show();
             }*/
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Form frm = this.CheckExists(typeof(NhanVien));
            if (frm != null) frm.Activate();
            else
            {
                NhanVien f = new NhanVien();
                f.MdiParent = this;
                f.Show();
            }*/
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Form frm = this.CheckExists(typeof(DangNhap));
            if (frm != null) frm.Activate();
            else
            {
                DangNhap f = new DangNhap();
                f.MdiParent = this;
                f.Show();
            }*/
        }
    }
}
