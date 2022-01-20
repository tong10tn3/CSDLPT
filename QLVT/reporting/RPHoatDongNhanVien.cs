using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace QLVT.reporting
{
    public partial class RPHoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        private int maNV;
        private String hoTenNV;
        private String ngaySinh;
        private String diaChi;
        private String luong;
        private String tuNgay;
        private String denNgay;
        private String loaiPhieu;

        public RPHoatDongNhanVien(int manv, String hoTenNV, String ngaySinh, String diaChi, String luong,
            String ngayBD, String ngayKT, String loaiPhieu)
        {
            this.maNV = manv;
            this.hoTenNV = hoTenNV;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.luong = luong;
            this.tuNgay = ngayBD;
            this.denNgay = ngayKT;
            this.loaiPhieu = loaiPhieu;

            InitializeComponent();
            lbMaNhanVien.Text = this.maNV.ToString();
            lbHoTenNV.Text = this.hoTenNV;
            lbNgaySinh.Text = this.ngaySinh;
            lbDiaChi.Text = this.diaChi;
            lbLuong.Text = this.luong;
            lbTuNgay.Text = this.tuNgay;
            lbDenNgay.Text = this.denNgay;

            string dateString = this.denNgay;
            string format = "dd/mm/yyyy";
            DateTime dateTime = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            string strNewDate = dateTime.ToString("yyyy/mm/dd");


            string dateStringTuNgay = this.tuNgay;
            DateTime dateTimeTuNgay = DateTime.ParseExact(dateStringTuNgay, format, CultureInfo.InvariantCulture);
            string strNewDateTuNgay = dateTimeTuNgay.ToString("yyyy/mm/dd");

            Console.WriteLine(loaiPhieu);
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = this.maNV;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = strNewDateTuNgay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = strNewDate;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = this.loaiPhieu;
            this.sqlDataSource1.Fill();

        }

    }
}
