using DevExpress.XtraEditors;
using QLVT.formCon;
using System;
using System.Collections;
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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        //public Stack stackNhanVien = new Stack();

        public string macn = "";
        public int vitri = 0;
        public bool dangthem = false;


        /*public int maNVTam;
        public String hoTam;
        public String tenTam;
        public String diaChiTam;
        public String ngaySinhTam;
        public float luongTam;*/

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        public void ReadOnlyTextEdit(bool a)
        {
            txtMaNhanVien.ReadOnly = a;
            txtHo.ReadOnly = a;
            txtTen.ReadOnly = a;
            txtDiaChi.ReadOnly = a;
            dNgaySinh.ReadOnly = a;
            txtLuong.ReadOnly = a;
            if (a == true)
                ckbTrangThaiXoa.Enabled = false;
            else ckbTrangThaiXoa.Enabled = true;
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            /// Load tất cả các bindingsource
            DS.EnforceConstraints = false;// nếu không có cái này thì nó kiểm tra khóa ngoại
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            macn = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();// lấy mã chi nhánh mà đang đứng
            cbMaChiNhanh.DataSource = Program.bds_dspm;// sao chep bds_dspm da load o form DANGNHAP
            cbMaChiNhanh.DisplayMember = "TENCN";
            cbMaChiNhanh.ValueMember = "TENSERVER";
            cbMaChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cbMaChiNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnChuyenChiNhanh.Enabled = false;
                ReadOnlyTextEdit(true);
            }
            else //bat tat theo phan quyen
            {
                btnThem.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = btnChuyenChiNhanh.Enabled = true;
                cbMaChiNhanh.Enabled = false;

                ReadOnlyTextEdit(true);
            }

            gvNhanVien.Columns["MANV"].Caption = "MÃ NHÂN VIÊN";
            gvNhanVien.Columns["HO"].Caption = "HỌ";
            gvNhanVien.Columns["TEN"].Caption = "TÊN";
            gvNhanVien.Columns["DIACHI"].Caption = "ĐỊA CHỈ";
            gvNhanVien.Columns["NGAYSINH"].Caption = "NGÀY SINH";
            gvNhanVien.Columns["LUONG"].Caption = "LƯƠNG";
            gvNhanVien.Columns["MACN"].Caption = "MÃ CHI NHÁNH";
            gvNhanVien.Columns["TrangThaiXoa"].Caption = "TRẠNG THÁI XÓA";


        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReadOnlyTextEdit(false);
            vitri = bdsNhanVien.Position;
            dangthem = true;
            bdsNhanVien.AddNew();
            txtMaCN.Text = macn;
            dNgaySinh.EditValue = "";

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Console.WriteLine(txtLuong.Text.Trim().ToString());
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Ma Nhan Vien khong duoc thieu !", "", MessageBoxButtons.OK);
                txtMaNhanVien.Focus();
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Ho nhan vien khong duoc thieu !", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (long.Parse(txtLuong.Text.Trim().Replace(",", "")) < 4000000)
            {
                Console.WriteLine(int.Parse(txtLuong.Text.Trim().Replace(",", "")));
                MessageBox.Show("Lương Phải lớn hơn 4 triệu!", "", MessageBoxButtons.OK);
                txtLuong.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Ten Nhan Vien khong duoc thieu !", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (txtMaCN.Text.Trim() == "")
            {
                MessageBox.Show("Ten Mã Chi Nhánh khong duoc thieu !", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if (dNgaySinh.Text == "")
            {
                MessageBox.Show("Ngày Sinh khong duoc thieu !", "", MessageBoxButtons.OK);
                txtTen.Focus();
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
                if (dangthem == true)
                {

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
                }
                conn.Close();
                bdsNhanVien.EndEdit();
                bdsNhanVien.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                /*if(dangthem==true)
                {
                    this.stackNhanVien.Push("delete from NHANVIEN where MANV="+txtMaNhanVien.Text.Trim());   
                    //STACK


                }
                else
                {
                    this.stackNhanVien.Push("Update NHANVIEN set MANV=" + this.maNVTam + ",HO='" 
                        + this.hoTam + "',TEN='" + this.tenTam + "',DIACHI='" + this.diaChiTam 
                        + "',LUONG=" + this.luongTam + " WHERE MANV="+txtMaNhanVien.Text.Trim());
                    //STACK
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi Nhân Viên\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNhanVien.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            dangthem = false;
            ReadOnlyTextEdit(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String trangThaiXoa = (((DataRowView)bdsNhanVien[bdsNhanVien.Position])["TrangThaiXoa"].ToString());
            if (trangThaiXoa.Trim().Equals("1"))
            {
                MessageBox.Show("Nhân Viên đã bị xóa không thể Xóa nữa ! \n", "", MessageBoxButtons.OK);
                return;
            }

            Int32 manv = 0;
            if (bdsDatHang.Count > 0)
            {
                try
                {
                    ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["TrangThaiXoa"] = 1;
                    bdsNhanVien.EndEdit();
                    bdsNhanVien.ResetCurrentItem();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                    MessageBox.Show("Đổi trạng thái xóa thành công , NV này đã lập ĐĐH nên không xóa hẵn", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đổi trạng thái xóa NV\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                return;
            }
            if (bdsPhieuNhap.Count > 0)
            {
                try
                {
                    ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["TrangThaiXoa"] = 1;
                    bdsNhanVien.EndEdit();
                    bdsNhanVien.ResetCurrentItem();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                    MessageBox.Show("Đổi trạng thái xóa thành công , NV này đã lập Phiếu Nhập nên không xóa hẵn", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đổi trạng thái xóa NV\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                return;
            }
            if (bdsPhieuXuat.Count > 0)
            {
                try
                {
                    ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["TrangThaiXoa"] = 1;
                    bdsNhanVien.EndEdit();
                    bdsNhanVien.ResetCurrentItem();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                    MessageBox.Show("Đổi trạng thái xóa thành công , NV này đã lập Phiếu Xuất nên không xóa hẵn", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đổi trạng thái xóa NV\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                return;
            }
            if (MessageBox.Show("Ban co that su muon xoa Nhan Vien nay ??", "Xac Nhan", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                /*//SET STACK
                this.maNVTam = int.Parse((String)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"]);
                this.hoTam = (String)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["HO"];
                this.tenTam = (String)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["TEN"];
                this.diaChiTam = (String)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["DIACHI"];
                this.luongTam = float.Parse((String)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["LUONG"]);
*/
                try
                {
                    SqlConnection conn = new SqlConnection();
                    if (Program.KetNoi(conn) == 0)
                    {
                        MessageBox.Show("Lỗi Kết nối sql");
                        return;
                    }
                    Console.WriteLine("Mã Nhân viên: " + ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString());
                    try
                    {
                        int kq = Program.ExecSqlNonQuery("exec xoaLoginTuMNV '" + ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString() + "'", conn);
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

                    manv = int.Parse(((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString());
                    bdsNhanVien.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi Xoa Nhan vien. Ban Hay Xoa Lai\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNhanVien.Count == 0) btnXoa.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcNhanVien.Enabled = true;
            if (dangthem == true) bdsNhanVien.RemoveCurrent();
            bdsNhanVien.CancelEdit();
            if (btnThem.Enabled == false) bdsNhanVien.Position = vitri;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            dangthem = false;
            ReadOnlyTextEdit(true);
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi Tai Lai: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cbMaChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.serverName = cbMaChiNhanh.SelectedValue.ToString();
            Console.WriteLine("serverName: " + Program.serverName);

            if (cbMaChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;

            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;

            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Loi ket noi ve chi nhanh  moi", "", MessageBoxButtons.OK);

            }
            else
            {

                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                Console.WriteLine("connstr: " + Program.connstr);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.DS.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

                Console.WriteLine("số lượng : " + bdsNhanVien.Count);
                Console.WriteLine("số lượng dh: " + bdsDatHang.Count);

                /*for (int i = 0; i < bdsNhanVien.Count; i++)
                {
                    Console.WriteLine("index: " + i);
                    Console.WriteLine("CHINHANH: "+(string)((DataRowView)bdsNhanVien[i])["MACN"]);
                    Console.WriteLine("MNV: " + ((DataRowView)bdsNhanVien[i])["MANV"]);
                }

                Console.WriteLine("Không lỗi: " + ((string)((DataRowView)bdsNhanVien[0])["MACN"]));

                macn = ((string)((DataRowView)bdsNhanVien[0])["MACN"]);*/

            }
        }

        private void pnThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaNhanVien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dIACHILabel_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void trangThaiXoaLabel_Click(object sender, EventArgs e)
        {

        }

        private void dNgaySinh_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtHo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void hOLabel_Click(object sender, EventArgs e)
        {

        }

        private void mANVLabel_Click(object sender, EventArgs e)
        {

        }

        private void nGAYSINHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lUONGLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtLuong_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaCN_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mACNLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcNhanVien_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void gcNhanVien_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void gvNhanVien_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void bdsNhanVien_ListChanged(object sender, ListChangedEventArgs e)
        {


        }

        private void bdsNhanVien_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void bdsNhanVien_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void bdsNhanVien_BindingComplete(object sender, BindingCompleteEventArgs e)
        {

        }

        private void bdsNhanVien_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void bdsNhanVien_CurrentItemChanged(object sender, EventArgs e)
        {

        }

        private void gcNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0)
            {
                return;
            }
            Program.myReader = Program.ExecSqlDataReader("exec sp_TimNV " + txtMaNhanVien.Text.Trim());
            if (Program.myReader != null)
            {
                MessageBox.Show("Mã Nhân Viên Đã tồn tại !\n", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String trangThaiXoa = (((DataRowView)bdsNhanVien[bdsNhanVien.Position])["TrangThaiXoa"].ToString());
            if (trangThaiXoa.Trim().Equals("1"))
            {
                MessageBox.Show("Nhân Viên đã bị xóa không thể sửa ! \n", "", MessageBoxButtons.OK);
                return;
            }
            ReadOnlyTextEdit(false);
            vitri = bdsNhanVien.Position;
            dangthem = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;

            /*//SET STACK
            this.maNVTam=int.Parse((String)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"]);
            this.hoTam= (String)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["HO"];
            this.tenTam = (String)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["TEN"];
            this.diaChiTam = (String)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["DIACHI"];
            this.luongTam =float.Parse((String)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["LUONG"]);
*/
        }
        private int taoMaNhanVien()
        {
            SqlConnection conn = new SqlConnection();
            if (Program.KetNoi(conn) == 0)
            {
                return -1;
            }
            try
            {
                SqlDataReader myReader;
                myReader = Program.ExecSqlDataReader("DECLARE @result int " +
                       "exec @result =  sp_timMaNhanVienMax " +
                       "SELECT 'result' = @result", conn);
                myReader.Read();
                int result = int.Parse(myReader.GetValue(0).ToString()) + 1;
                return result;
            }
            catch (Exception ex)
            {
                return -1;
            }

        }

        private void btnChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String trangThaiXoa = (((DataRowView)bdsNhanVien[bdsNhanVien.Position])["TrangThaiXoa"].ToString());
            if (trangThaiXoa.Trim().Equals("1"))
            {
                MessageBox.Show("Nhân Viên đã bị xóa ! \n", "", MessageBoxButtons.OK);
                return;
            }

            /* DataTable dt = new DataTable();
             dt = (DataTable)Program.bds_dspm.DataSource;
             for (int i = 0; i < dt.Rows.Count - 1; i++)
             {
                 DataRow dr = dt.Rows[i];
                 if (dr["TENSERVER"] == cbMaChiNhanh.SelectedValue)
                     dr.Delete();
             }*/


            frmChuyenChiNhanh a = new frmChuyenChiNhanh(((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString(), bdsNhanVien.Position, taoMaNhanVien().ToString(), txtHo.Text.ToString().Trim(), txtTen.Text.Trim(), dNgaySinh.Text, txtDiaChi.Text.Trim(), (((DataRowView)bdsNhanVien[bdsNhanVien.Position])["LUONG"].ToString()), this);
            a.Show();
        }
    }
}