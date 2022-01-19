using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoLogin()
        {
            InitializeComponent();
        }

        private void hOTENNVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsHoTen.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.NhanVien' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'DS.NhanVien' table. You can move, or remove it, as needed.

            DS.EnforceConstraints = false;
            this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOTENNVTableAdapter.Fill(this.DS.HOTENNV);
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);



            for (int i = 0; i < bdsHoTen.Count; i++)
            {

                if (((DataRowView)bdsNhanVien[i])["TrangThaiXoa"].ToString() == "1")
                {
                    bdsHoTen.RemoveAt(i);
                    bdsNhanVien.RemoveAt(i);
                    i--;
                }


            }


            cbHoTenNV.DataSource = bdsHoTen;
            cbHoTenNV.DisplayMember = "HOTENNV";
            cbHoTenNV.ValueMember = "MANV";
            if (Program.mGroup == "CONGTY")
            {
                rdbChiNhanh.Visible = rdbUser.Visible = false;
            }
        }

        private void btnTaoLogin_Click(object sender, EventArgs e)
        {
            if (txtTenLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên Login khong duoc thieu !", "", MessageBoxButtons.OK);
                txtTenLogin.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật Khẩu khong duoc thieu !", "", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return;
            }
            String role = "";
            if (rdbUser.Checked == true) role = "USER";
            if (rdbCongTy.Checked == true) role = "CONGTY";
            if (rdbChiNhanh.Checked == true) role = "CHINHANH";
            string strLenh = "EXEC dbo.SP_TAOLOGIN '" + txtTenLogin.Text.Trim() + "','" + txtMatKhau.Text.Trim() + "','" + txtMaNV.Text.Trim() + "','" + role + "'";
            if (Program.KetNoi() == 0) return;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            MessageBox.Show("TẠO LOGIN THÀNH CÔNG", "", MessageBoxButtons.OK);

        }
    }
}