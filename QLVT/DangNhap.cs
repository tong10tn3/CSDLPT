using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class DangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public DangNhap()
        {
            InitializeComponent();
        }
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbChiNhanh.DataSource = dt;
            cbChiNhanh.DisplayMember = "TENCN";cbChiNhanh.ValueMember = "TENSERVER";
           
            
        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Loi ket noi csdl goc\nXem lai ten server cua publisher va ten csdl trong chuoi ketnoi");
                return 0;
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("select * from  Get_Subscribes");

            cbChiNhanh.SelectedIndex = 0;
            Program.serverName = cbChiNhanh.SelectedValue.ToString();
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cbChiNhanh.SelectedValue.ToString();
            }
            catch(Exception)
            { }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text.Trim()==""||txtMatKhau.Text.Trim()=="")
            {
                MessageBox.Show("Tai khoan mat khau khong hop le", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            if (Program.KetNoi() == 0) return;

            Program.mChinhanh = cbChiNhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_LAY_THONG_TIN_NV_TU_LOGIN '" + Program.mlogin + "'";
            
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.userName = Program.myReader.GetString(0);
            
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("login  ban nhap  khong co quyen truy cap du lieu\nban xem lai username,password");
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MANV.Caption = "MA NV: " + Program.userName;
            Program.frmChinh.TEN.Caption = "HO TEN: " + Program.mHoten;
            Program.frmChinh.NHOM.Caption = "NHOM: " + Program.mGroup;
            Program.frmChinh.ShowDialog();
            this.Close();
            
        }
    }
}
