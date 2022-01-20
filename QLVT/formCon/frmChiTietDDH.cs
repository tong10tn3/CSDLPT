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

namespace QLVT.formCon
{
    public partial class frmChiTietDDH : DevExpress.XtraEditors.XtraForm
    {
        public frmDDH frmDDH;
        public String MSDDH;
        public String maVT;
        public int soLuong;
        public Double donGia;
        String ddh1;

        public frmChiTietDDH()
        {
            InitializeComponent();
        }
        public frmChiTietDDH(String MSDDH, frmDDH a)
        {
            this.MSDDH = MSDDH;
            frmDDH = a;
            InitializeComponent();
        }
        private void cTDDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCTDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChiTietDDH_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
            cbTenVT.DataSource = bdsVatTu;
            cbTenVT.DisplayMember = "TENVT";
            cbTenVT.ValueMember = "MAVT";
            bdsCTDDH.AddNew();
            txtMSDDH.Text = this.MSDDH;
            txtMaVT.Text = (string)cbTenVT.SelectedValue;

        }

        private void tENVTLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nSoLuong.Value <= 0)
            {

            }
            if (txtDonGia.Text == "")
            {

            }
            bool kt = false;
            for (int i = 0; i < bdsCTDDH.Count - 1; i++)
            {

                if (((DataRowView)bdsCTDDH[i])["MasoDDH"].ToString() == txtMSDDH.Text && ((DataRowView)bdsCTDDH[i])["MAVT"].ToString() == txtMaVT.Text)
                {
                    kt = true;
                    break;
                }
            }

            if (kt == true)
            {
                MessageBox.Show("Đã tồn tại mã vật tư cùng với mã đơn hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.maVT = txtMaVT.Text.Trim();
            this.soLuong = Convert.ToInt32(nSoLuong.Value);
            this.donGia = Convert.ToDouble(txtDonGia.Text);
            ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MasoDDH"] = this.MSDDH.Trim();
            ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MAVT"] = this.maVT.Trim();
            ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["SOLUONG"] = this.soLuong;
            ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["DONGIA"] = this.donGia;

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    bdsCTDDH.EndEdit();
                    this.cTDDHTableAdapter.Update(this.DS.CTDDH);// chỗ này có lỗi nếu trùng
                    frmDDH.reloadCTDDH();
                    this.Close();
                }
                catch (Exception ex)
                {
                    //bdsCTDDH.RemoveCurrent();
                    //frmDDH.reloadCTDDH();
                    //this.Close();
                    MessageBox.Show("Thêm CTDDH Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dONGIALabel_Click(object sender, EventArgs e)
        {

        }

        private void txtMaVT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbTenVT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaVT_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtMaVT_EditValueChanged_2(object sender, EventArgs e)
        {

        }

        private void cbTenVT_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                txtMaVT.Text = (string)cbTenVT.SelectedValue;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}