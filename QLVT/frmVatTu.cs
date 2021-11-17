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
    public partial class frmVatTu : Form
    {
        int viTri;
        public frmVatTu()
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

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            this.cTPXTableAdapter.Fill(this.dS.CTPX);

            if (Program.mGroup.Equals("CONGTY"))
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            }
            btnUndo.Enabled = btnGhi.Enabled = panelVT.Enabled = false;
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsVatTu.Position;
            this.bdsVatTu.AddNew();
            btnThem.Enabled = btnXoa.Enabled = gcVatTu.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = panelVT.Enabled = btnUndo.Enabled = true;
            nuSLT.Value = 0;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsVatTu.Position;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = panelVT.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maVT = "";
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư vì đã lập đơn hàng!!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư vì đã lập phiếu nhập!!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư vì đã lập phiếu xuất!!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu vật tư này? ", "XÁC NHẬN",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    maVT = ((DataRowView)bdsVatTu[bdsVatTu.Position])["MAVT"].ToString();// giữ lại mã vật tư
                    bdsVatTu.RemoveCurrent();
                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.dS.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư hãy xóa lại! \n" + ex.Message, "Thông báo lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.vattuTableAdapter.Fill(this.dS.Vattu);
                    bdsVatTu.Position = bdsVatTu.Find("MAVT", maVT);
                    return;
                }
            }
            if (bdsVatTu.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemTraRangBuoc(txtMAVT, "Mã VT không được để trống!") == 0) return;
            if (kiemTraRangBuoc(txtTENVT, "Tên VT không được để trống!") == 0) return;
            if (kiemTraRangBuoc(txtDVT, "Đơn vị tính không được để trống!") == 0) return;
            if (txtMAVT.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã VT không được quá 4 ký tự!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtMAVT.Text.Contains(" "))
            {
                MessageBox.Show("Mã VT không được chứa khoảng trắng!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kiemTraViTriTenVT = bdsVatTu.Find("TENVT", txtTENVT.Text);
            if (kiemTraViTriTenVT != -1 && (kiemTraViTriTenVT != bdsVatTu.Position))
            {
                MessageBox.Show("Đã có tên Vật Tư này. Vui lòng chọn tên khác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "DECLARE @result int " +
                "EXEC @result = SP_KiemTraMa @p1, @p2 " +
                "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.conn);
            sqlCommand.Parameters.AddWithValue("@p1", txtMAVT.Text);
            sqlCommand.Parameters.AddWithValue("@p2", "MAVT");
            if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
            SqlDataReader dataReader;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataReader.Read();
            int kq = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            int viTriMAVT = bdsVatTu.Find("MAVT", txtMAVT.Text);
            int viTriHienTai = bdsVatTu.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
            if (kq == 1 && (viTriMAVT != viTriHienTai))
            {
                MessageBox.Show("Mã VT đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        Program.coTatFormVT = true; //Bật cờ cho phép tắt Form NV
                        btnThem.Enabled = btnXoa.Enabled = gcVatTu.Enabled = btnReload.Enabled = btnSua.Enabled = true;
                        btnUndo.Enabled = btnGhi.Enabled = gbVatTu.Enabled = false;
                        this.bdsVatTu.EndEdit();
                        this.vattuTableAdapter.Update(this.dS.Vattu);
                        bdsVatTu.Position = viTri;
                    }
                    catch (Exception ex)
                    {
                        //Khi Update database lỗi thì xóa record vừa thêm trong bds
                        bdsVatTu.RemoveCurrent();
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = gcVatTu.Enabled = btnReload.Enabled = true;
            btnUndo.Enabled = panelVT.Enabled = btnGhi.Enabled = false;
            bdsVatTu.CancelEdit();
            bdsVatTu.Position = viTri;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsVatTu.Position;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            bdsVatTu.Position = viTri;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
