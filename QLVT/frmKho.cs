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
    public partial class frmKho : Form
    {
        string macn;
        int viTri;
        public frmKho()
        {
            InitializeComponent();
        }

        private int kiemTraRangBuoc(TextBox TB, string str)
        {
            if (TB.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TB.Focus();
                return 0;
            }
            return 1;
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);

            macn = ((DataRowView)bdsKho[0])["MACN"].ToString();// lấy mã chi nhánh mà đang đứng
            cbChiNhanh.DataSource = Program.bds_dspm;// sao chep bds_dspm da load o form DANGNHAP
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            cbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Links[0].Visible = btnXoa.Links[0].Visible = btnGhi.Links[0].Visible = false;
                btnSua.Links[0].Visible = btnUndo.Links[0].Visible = false;
            }
            else if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                panelChiNhanh.Visible = false;
            }
            btnUndo.Enabled = btnGhi.Enabled = panelKho.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsKho.Position;
            this.bdsKho.AddNew();
            mACNTextBox.Text = macn;
            btnThem.Enabled = btnXoa.Enabled = khoGridControl.Enabled = false;
            btnReload.Enabled = btnSua.Enabled = false;
            btnUndo.Enabled = panelKho.Enabled = btnGhi.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsKho.Position;
            btnSua.Enabled = khoGridControl.Enabled = btnThem.Enabled = false;
            btnXoa.Enabled = btnReload.Enabled = false;
            panelKho.Enabled = btnUndo.Enabled = btnGhi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string makho = "";
            if (bdsKho.Position != -1)
            {
                makho = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu!", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //Kiểm tra MAKHO có tồn tại trong các Phiếu
                    string query = "DECLARE	@result int " +
                          "EXEC @result = sp_CheckID '" + mAKHOTextBox.Text.Trim() + 
                          "', 'MAKHO_EXIST" + "SELECT 'result' = @result";
                    SqlDataReader myReader = Program.ExecSqlDataReader(query);
                    myReader.Read();
                    int result = int.Parse(myReader.GetValue(0).ToString());
                    if (result == 1)
                    {
                        MessageBox.Show("Kho này đã tồn tại trong các Phiếu, không thể xóa. Vui lòng kiểm tra lại!\n", "Notification",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    bdsKho.RemoveCurrent();
                    this.khoTableAdapter.Update(this.dS.Kho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Kho hãy xóa lại! \n" + ex.Message, "Thông báo lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.khoTableAdapter.Fill(this.dS.Kho);
                    bdsKho.Position = bdsKho.Find("MAKHO", makho);
                    return;
                }
            }
            if (bdsKho.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraRangBuoc(mAKHOTextBox, "Mã Kho is not empty!") == 0) return;
            if (kiemTraRangBuoc(tENKHOTextBox, "Tên Kho is not empty!") == 0) return;
            if (kiemTraRangBuoc(dIACHITextBox, "Địa chỉ is not empty!") == 0) return;
            if (mAKHOTextBox.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã KHO không được quá 4 kí tự!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (mAKHOTextBox.Text.Contains(" "))
            {
                MessageBox.Show("Mã KHO không được chứa khoảng trắng!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection conn = new SqlConnection();
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID '" + mAKHOTextBox.Text + "', 'MAKHO'" +
                           "SELECT 'result' = @result";
            SqlDataReader myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            int resultMAKHO = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();

            query = "DECLARE @result int " +
                    "EXEC @result = SP_CheckID '" + tENKHOTextBox.Text + "', 'TENKHO'" +
                    "SELECT 'result' = @result";
            myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            int resultTENKHO = int.Parse(myReader.GetValue(0).ToString());
            myReader.Close();

            int positionMAKHO = bdsKho.Find("MAKHO", mAKHOTextBox.Text);
            int postionTENKHO = bdsKho.Find("TENKHO", tENKHOTextBox.Text);
            int postionCurrent = bdsKho.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
            if (resultMAKHO == 1 && (positionMAKHO != postionCurrent))
            {
                MessageBox.Show("Mã KHO đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultTENKHO == 1 && (postionTENKHO != postionCurrent))
            {
                MessageBox.Show("Tên Kho đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultMAKHO == 2)
            {
                MessageBox.Show("Mã KHO đã tồn tại ở Chi Nhánh khác!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultTENKHO == 2)
            {
                MessageBox.Show("Tên Kho đã tồn tại ở Chi Nhánh khác!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        btnThem.Enabled = btnXoa.Enabled = khoGridControl.Enabled = true;
                        btnReload.Enabled = btnSua.Enabled = true;
                        btnUndo.Enabled = panelKho.Enabled = btnGhi.Enabled = false;
                        this.bdsKho.EndEdit();
                        this.khoTableAdapter.Update(this.dS.Kho);
                        bdsKho.Position = viTri;
                    }
                    catch (Exception ex)
                    {
                        //Khi Update database lỗi thì xóa record vừa thêm trong bds
                        bdsKho.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = khoGridControl.Enabled = true;
            btnReload.Enabled = btnSua.Enabled = true;
            btnUndo.Enabled = panelKho.Enabled = btnGhi.Enabled = false;
            bdsKho.CancelEdit();
            bdsKho.Position = viTri;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int position = bdsKho.Position;
            this.khoTableAdapter.Fill(this.dS.Kho);
            bdsKho.Position = position;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.serverName = cbChiNhanh.SelectedValue.ToString();
            if (cbChiNhanh.SelectedIndex != Program.mChinhanh)
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
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.dS.Kho);
                macn = (((DataRowView)bdsKho[0])["MACN"].ToString());

            }
        }
    }
}
