﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLVT.reporting;

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
           
        }

        private void btnNhanVien_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDDH));
            if (frm != null) frm.Activate();
            else
            {
                frmDDH f = new frmDDH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoLogin f = new frmTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                frmVatTu f = new frmVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBangKeChiTietNhapXuat ctnx = new frmBangKeChiTietNhapXuat();
            ctnx.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTongHopNhapXuat ctnx = new frmTongHopNhapXuat();
            ctnx.Show();
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuNhap f = new frmPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho f = new frmKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuXuat f = new frmPhieuXuat();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
