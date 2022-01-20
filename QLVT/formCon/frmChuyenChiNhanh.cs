using DevExpress.XtraEditors;
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

namespace QLVT.formCon
{
    public partial class frmChuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public String maNVCu;
        public string maNVMoi;
        public string ho;
        public string ten;
        public string ngaySinh;
        public string diaChi;
        public string luong;
        public frmNhanVien nv;
        public int pos;
     
        public frmChuyenChiNhanh()
        {
            InitializeComponent();
        }
        public frmChuyenChiNhanh(String maNhanVienCu,int vt,String maNhanVienMoi1, String ho1, String ten1,String ngaySinh, String diaChi1, String luong1,frmNhanVien a)
        {
            this.maNVCu = maNhanVienCu;
            this.pos = vt;
            this.maNVMoi = maNhanVienMoi1;
            this.ho = ho1;
            this.ten = ten1;
            this.diaChi = diaChi1;
            this.luong = luong1;
            this.ngaySinh = ngaySinh;
            this.nv = a;
            
            InitializeComponent();
        }

        private void lUONGLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtLuong_EditValueChanged(object sender, EventArgs e)
        {

        }
        
        private void frmChuyenChiNhanh_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = this.maNVMoi;
            txtHo.Text = this.ho;
            txtTen.Text = this.ten;
            txtDiaChi.Text = this.diaChi;
            txtLuong.Text = this.luong;
            dNgaySinh.Text = this.ngaySinh;
            String cmd = "exec sp_timMaCN ";

            SqlConnection conn = new SqlConnection();

            if (Program.KetNoi(conn) == 0) return;
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            dt.Rows[Program.mChinhanh].Delete();
            cbChiNhanhMoi.DataSource = dt;
            cbChiNhanhMoi.DisplayMember = "TENCN"; cbChiNhanhMoi.ValueMember = "MACN";

            cbChiNhanhMoi.SelectedIndex = 0;
            Program.serverName = cbChiNhanhMoi.SelectedValue.ToString();

            cbChiNhanhMoi.SelectedIndex = 0;
            Program.serverName = cbChiNhanhMoi.SelectedValue.ToString();
        }

        private void cbChiNhanhMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnXacNhanChuyen_Click(object sender, EventArgs e)
        {
            //Kiểm tra điều kiện mấy cái txt không được trống
            if(txtMaNhanVien.Text.Trim()=="")
            {
                MessageBox.Show("Mã Nhân Viên Không được trống !");
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ Không được trống !");
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên Không được trống !");
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa Chỉ Không được trống !");
                return;
            }
            if (dNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Ngày Sinh Không được trống !");
                return;
            }
            if (txtLuong.Text.Trim() == "")
            {
                MessageBox.Show("Lương Không được trống !");
                return;
            }
            if (dNgaySinh.DateTime > DateTime.Today)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh cho đúng !");
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection();
                if (Program.KetNoi(conn) == 0)
                {
                    return;
                }

                SqlDataReader myReader = Program.ExecSqlDataReader("DECLARE @result int " +
                           "exec @result =  sp_CheckID '" +
                    "" + txtMaNhanVien.Text.Trim() + "','MANV'" +
                           "SELECT 'result' = @result", conn);
                myReader.Read();
                int result = int.Parse(myReader.GetValue(0).ToString());
                if (myReader == null)
                {
                    MessageBox.Show("Lỗi Thực Thi Kiểm tra Check_ID\n", "", MessageBoxButtons.OK);
                    return;
                }
                if (result == 1)
                {
                    MessageBox.Show("Mã Nhân Viên Đã Tồn Tại ở Chi Nhánh hiện Tại\n", "", MessageBoxButtons.OK);
                    return;
                }
                else if (result == 2)
                {
                    MessageBox.Show("Mã Nhân Viên Đã Tồn Tại ở Chi Nhánh Khác\n", "", MessageBoxButtons.OK);
                    return;
                }
                conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra mã nhân viên\n" + ex.Message);
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection();

                if (Program.KetNoi(conn) == 0) return;
                
                try
                {
                    int kq = Program.ExecSqlNonQuery("exec xoaLoginTuMNV '" + this.maNVCu + "'", conn);
                    if (kq != 0)
                    {
                        MessageBox.Show("Lỗi Xóa Login");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi Xoa Login. Ban Hay Xoa Lai\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }


                if (conn.State == ConnectionState.Closed) conn.Open();
                String cmd = "exec sp_chuyenChiNhanh " + int.Parse(txtMaNhanVien.Text.Trim()) + ",'" + txtHo.Text.Trim() + "','" + txtTen.Text.Trim() + "','" + txtDiaChi.Text.Trim() + "','" + dNgaySinh.Text.Trim() + "'," + float.Parse(txtLuong.Text.Trim()) + ",'" + cbChiNhanhMoi.SelectedValue + "'";
                int result = Program.ExecSqlNonQuery(cmd,conn);
                conn.Close();
              
                try
                {
                    ((DataRowView)this.nv.bdsNhanVien[this.pos])["TrangThaiXoa"] = 1;
                    this.nv.bdsNhanVien.EndEdit();
                    this.nv.bdsNhanVien.ResetCurrentItem();
                    this.nv.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nv.nhanVienTableAdapter.Update(this.nv.DS.NhanVien);
                    MessageBox.Show("Chuyển Chi Nhánh Thành Công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đổi trạng thái xóa NV ở chuyển chi nhánh\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }


                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi xác nhận chuyển chi nhánh\n"+ex.Message);
            }

        }

        private void dNgaySinh_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}