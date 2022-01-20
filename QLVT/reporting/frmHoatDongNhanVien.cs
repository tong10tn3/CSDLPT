using DevExpress.XtraEditors;
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
    public partial class frmHoatDongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmHoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOTENNVTableAdapter.Fill(this.DS.HOTENNV);
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            cbHoTenNV.DataSource = bdsHoTenNV;
            cbHoTenNV.DisplayMember = "HOTENNV";
            cbHoTenNV.ValueMember = "MANV";

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("MALP");
            dt.Columns.Add("TENLP");
            DataRow col1 = dt.NewRow();
            col1["MALP"] = "N";
            col1["TENLP"] = "NHẬP";
            dt.Rows.Add(col1);
            DataRow col2 = dt.NewRow();
            col2["MALP"] = "X";
            col2["TENLP"] = "XUẤT";
            dt.Rows.Add(col2);
            cbLP.DataSource = dt;
            cbLP.DisplayMember = "TENLP";
            cbLP.ValueMember = "MALP";

            dTuNgay.DateTime = DateTime.Today;
            dDenNgay.DateTime = DateTime.Today;
            if (Program.mGroup == "CONGTY")
            {
                cbHoTenNV.Enabled = true;
            }
            else
            {
                cbHoTenNV.Text = Program.mHoten;
                txtMaNV.Text = Program.userName;
            }

        }

        private void mANVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = cbHoTenNV.SelectedValue.ToString();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            int index = bdsNhanVien.Find("MANV", txtMaNV.Text);
            int maNV = int.Parse(((DataRowView)bdsNhanVien[index])["MANV"].ToString());
            String hoTenNV = cbHoTenNV.Text.ToString();

            String ngaySinh = ((DataRowView)bdsNhanVien[index])["NGAYSINH"].ToString();
            String diaChi = ((DataRowView)bdsNhanVien[index])["DIACHI"].ToString();
            String luong = ((DataRowView)bdsNhanVien[index])["LUONG"].ToString();
            String tuNgay = dTuNgay.Text;
            String denNgay = dDenNgay.Text;
            String loaiPhieu = cbLP.Text.Trim();
            if (loaiPhieu.Equals("NHẬP"))
            {
                loaiPhieu = "N";
            }
            else
            {
                loaiPhieu = "X";
                Console.WriteLine("X");
            }
            Console.WriteLine("tong");
            RPHoatDongNhanVien rpt = new RPHoatDongNhanVien(maNV, hoTenNV, ngaySinh, diaChi, luong, tuNgay, denNgay, loaiPhieu);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}