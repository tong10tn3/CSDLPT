using DevExpress.XtraEditors;
using QLVT.formCon;
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
    public partial class frmDDH : DevExpress.XtraEditors.XtraForm
    {
        public string macn = "";
        public bool dangthem = false;
        public int vitri = 0;
        public frmDDH()
        {
            InitializeComponent();
        }

        public void reloadCTDDH()
        {
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
            addTenVT();
        }
        public void readOnlyForm(Boolean dk)
        {
            txtMSDDH.ReadOnly = dk;
            txtNhaCC.ReadOnly = dk;
            dNgay.ReadOnly = dk;
            if (dk == false) cbTenKho.Enabled = true;
            else cbTenKho.Enabled = false;
        }
        public void addTenVT()
        {
            foreach (DataGridViewRow row in cTDDHDataGridView.Rows)
            {
                DataGridViewCell cell = row.Cells[2];
                int vt = bdsVatTu.Find("MAVT", row.Cells[1].Value.ToString());
                String tenVT = ((DataRowView)bdsVatTu[vt])["TENVT"].ToString();
                cell.Value = tenVT;
            }
        }
        public String layMSDDH()
        {
            String lastMS = ((DataRowView)bdsDatHang[bdsDatHang.Count - 2])["MaSoDDH"].ToString();
            String stt = lastMS.Substring(4);

            int soTT = Convert.ToInt32(stt);
            if (soTT < 10)
            {
                return "MDDH0" + (soTT + 2).ToString();
            }
            else
            {
                return "MDDH" + (soTT + 2).ToString();
            }
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmDDH_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOTENNVTableAdapter.Fill(this.DS.HOTENNV);
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            this.khoTableAdapter.Fill(this.DS.Kho);
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            cbTenKho.DataSource = bdsKho;
            cbTenKho.DisplayMember = "TENKHO";
            cbTenKho.ValueMember = "MAKHO";



            cbHoTenNV.DataSource = bdsHoTenNV;
            cbHoTenNV.DisplayMember = "HOTENNV";
            cbHoTenNV.ValueMember = "MANV";


            macn = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();
            cbMaChiNhanh.DataSource = Program.bds_dspm;// sao chep bds_dspm da load o form DANGNHAP
            cbMaChiNhanh.DisplayMember = "TENCN";
            cbMaChiNhanh.ValueMember = "TENSERVER";
            cbMaChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                cbMaChiNhanh.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
                contextMenuStrip1.Enabled = false;
                contextMenuStrip2.Enabled = false;
            }
            else //bat tat theo phan quyen
            {
                btnThem.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = false;
                cbMaChiNhanh.Enabled = false;
            }

            cbHoTenNV.SelectedValue = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"];
            ((DataRowView)bdsDatHang[bdsDatHang.Position])["MAKHO"] = txtMaKho.Text;
            cbTenKho.SelectedValue = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MAKHO"];
            readOnlyForm(true);
            addTenVT();

        }

        private void datHangBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void masoDDHTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void masoDDHLabel_Click(object sender, EventArgs e)
        {

        }

        private void nGAYLabel_Click(object sender, EventArgs e)
        {

        }

        private void hOTENNVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hOTENNVLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDatHang.Position;
            gcDatHang.Enabled = false;
            bdsDatHang.AddNew();
            dNgay.EditValue = DateTime.Today;
            cbHoTenNV.Text = Program.mHoten;
            txtMaNV.Text = Program.userName;
            txtMSDDH.Text = layMSDDH();
            this.dangthem = true;
            readOnlyForm(false);

            ((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"] = Program.userName;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
        }

        private void cbMaChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMaChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.serverName = cbMaChiNhanh.SelectedValue.ToString();
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

                DS.EnforceConstraints = false;
                this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOTENNVTableAdapter.Fill(this.DS.HOTENNV);
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                this.khoTableAdapter.Fill(this.DS.Kho);

                this.datHangTableAdapter.Fill(this.DS.DatHang);



                bdsDatHang.DataSource = this.DS.DatHang;
                Console.WriteLine("dathang: " + bdsDatHang.Count);


                cbHoTenNV.SelectedValue = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"];
                cbTenKho.SelectedValue = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MAKHO"];

            }
        }

        private void gcDatHang_Click(object sender, EventArgs e)
        {
            cbHoTenNV.SelectedValue = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"].ToString();
            cbTenKho.SelectedValue = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MAKHO"].ToString();
            addTenVT();
        }

        private void cbHoTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbTenKho_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ((DataRowView)bdsDatHang[bdsDatHang.Position])["MAKHO"] = cbTenKho.SelectedValue;
            Console.WriteLine(cbTenKho.SelectedValue + " " + ((DataRowView)bdsDatHang[bdsDatHang.Position])["MAKHO"]);

        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
                addTenVT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi Tai Lai: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDatHang.CancelEdit();
            bdsDatHang.Position = vitri;
            gcDatHang.Enabled = true;
            readOnlyForm(true);

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"].ToString() != Program.userName)
            {
                MessageBox.Show("Chỉ có thể Xóa Đơn Đặt Hàng của chính mình\n", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Khong the xoa Đơn Đặt Hàng này nay vi da lap Phieu Nhap", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Khong the xoa Đơn Đặt hàng này  vi da lap CTDDH", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Ban co that su muon xoa Đơn Đặt Hàng nay ??", "Xac Nhan", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String msddh = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MaSoDDH"].ToString(); ;
                try
                {
                    bdsDatHang.RemoveCurrent();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.DS.DatHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi Xoa Don Dat Hang. Ban Hay Xoa Lai\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.datHangTableAdapter.Fill(this.DS.DatHang);
                    bdsDatHang.Position = bdsDatHang.Find("MaSoDDH", msddh);
                    return;
                }
            }
            if (bdsDatHang.Count == 0) btnXoa.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Program.KetNoi() == 0)
                {
                    return;
                }

                Program.myReader = Program.ExecSqlDataReader("DECLARE @result int " +
                           "exec @result =  sp_CheckID '" +
                    "" + txtMSDDH.Text.Trim() + "','MADDH'" +
                           "SELECT 'result' = @result");
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                if (Program.myReader == null)
                {
                    MessageBox.Show("Lỗi Thực Thi Kiểm tra Check_ID\n", "", MessageBoxButtons.OK);
                    return;
                }

                if (result == 2)
                {
                    MessageBox.Show("Mã Đơn Đặt Hàng Đã Tồn Tại ở Chi Nhánh Khác\n", "", MessageBoxButtons.OK);
                    return;
                }
                ((DataRowView)bdsDatHang[bdsDatHang.Position])["MAKHO"] = txtMaKho.Text;
                ((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"] = txtMaNV.Text;

                bdsDatHang.EndEdit();
                bdsDatHang.ResetCurrentItem();
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Update(this.DS.DatHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ghi Dat Hang\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            this.dangthem = false;
            gcDatHang.Enabled = true;
            readOnlyForm(true);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled == true;
            btnGhi.Enabled = false;
        }

        private void cbTenKho_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKho_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ((DataRowView)bdsDatHang[bdsDatHang.Position])["MAKHO"] = txtMaKho.Text;
            ((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"] = txtMaNV.Text;
            bdsDatHang.EndEdit();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled == true;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnThemCTDDH_DATHANG_Click(object sender, EventArgs e)
        {
            if (((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"].ToString() != Program.userName)
            {
                MessageBox.Show("Chỉ có thể thêm CTDDH của chính mình\n", "", MessageBoxButtons.OK);
            }
            else
            {
                String MSDDH = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MaSoDDH"].ToString();
                frmChiTietDDH a = new frmChiTietDDH(MSDDH, this);
                a.Show();
            }


        }

        private void btnSuaCTDDH_Click(object sender, EventArgs e)
        {
            if (((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"].ToString() != Program.userName)
            {
                MessageBox.Show("Chỉ có thể Sửa CTDDH của chính mình\n", "", MessageBoxButtons.OK);
            }
            else
            {
                String MSDDH = ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MaSoDDH"].ToString();
                String maVT = ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MAVT"].ToString();
                int soLuong = Convert.ToInt32(((DataRowView)bdsCTDDH[bdsCTDDH.Position])["SOLUONG"].ToString());
                double donGia = Convert.ToDouble(((DataRowView)bdsCTDDH[bdsCTDDH.Position])["DONGIA"].ToString());
                frmCTDDHSua a = new frmCTDDHSua(MSDDH, maVT, this);
                a.Show();
            }


        }

        private void btnXoaCTDDH_Click(object sender, EventArgs e)
        {
            if (((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"].ToString() != Program.userName)
            {
                MessageBox.Show("Chỉ có thể Xóa CTDDH của chính mình\n", "", MessageBoxButtons.OK);
            }
            else
            {
                bdsCTDDH.RemoveCurrent();
                this.cTDDHTableAdapter.Update(this.DS.CTDDH);// chỗ này có lỗi nếu trùng
            }


        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcDatHang_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            readOnlyForm(false);
            if (((DataRowView)bdsDatHang[bdsDatHang.Position])["MANV"].ToString() != Program.userName)
            {
                MessageBox.Show("Chỉ có thể Sửa Đơn Đặt Hàng của chính mình\n", "", MessageBoxButtons.OK);
            }
            else
            {
                vitri = bdsDatHang.Position;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnTaiLai.Enabled = btnThoat.Enabled = false;
                btnGhi.Enabled = btnPhucHoi.Enabled = true;
                gcDatHang.Enabled = false;
            }

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cTDDHDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.cTDDHTableAdapter.FillBy(this.DS.CTDDH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cTDDHDataGridView_ParentChanged(object sender, EventArgs e)
        {
            addTenVT();
        }
    }
}