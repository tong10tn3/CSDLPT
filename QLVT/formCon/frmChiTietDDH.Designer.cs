
namespace QLVT.formCon
{
    partial class frmChiTietDDH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label masoDDHLabel;
            this.DS = new QLVT.DS();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.txtMSDDH = new DevExpress.XtraEditors.TextEdit();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.cbTenVT = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.nSoLuong = new System.Windows.Forms.NumericUpDown();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dONGIALabel.Location = new System.Drawing.Point(57, 190);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(78, 19);
            dONGIALabel.TabIndex = 17;
            dONGIALabel.Text = "ĐƠN GIÁ:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGLabel.Location = new System.Drawing.Point(57, 131);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(93, 19);
            sOLUONGLabel.TabIndex = 15;
            sOLUONGLabel.Text = "SỐ LƯỢNG:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENVTLabel.Location = new System.Drawing.Point(57, 78);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(102, 19);
            tENVTLabel.TabIndex = 14;
            tENVTLabel.Text = "TÊN VẬT TƯ:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(57, 30);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(103, 19);
            masoDDHLabel.TabIndex = 12;
            masoDDHLabel.Text = "MÃ SỐ ĐĐH :";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "CTDDH";
            this.bdsCTDDH.DataSource = this.DS;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.HOTENNVTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // txtMSDDH
            // 
            this.txtMSDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "MasoDDH", true));
            this.txtMSDDH.Location = new System.Drawing.Point(196, 27);
            this.txtMSDDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMSDDH.Name = "txtMSDDH";
            this.txtMSDDH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSDDH.Properties.Appearance.Options.UseFont = true;
            this.txtMSDDH.Size = new System.Drawing.Size(107, 26);
            this.txtMSDDH.TabIndex = 13;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // txtMaVT
            // 
            this.txtMaVT.Location = new System.Drawing.Point(372, 78);
            this.txtMaVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Properties.Appearance.Options.UseFont = true;
            this.txtMaVT.Properties.ReadOnly = true;
            this.txtMaVT.Size = new System.Drawing.Size(107, 26);
            this.txtMaVT.TabIndex = 21;
            // 
            // cbTenVT
            // 
            this.cbTenVT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenVT.FormattingEnabled = true;
            this.cbTenVT.Location = new System.Drawing.Point(196, 77);
            this.cbTenVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTenVT.Name = "cbTenVT";
            this.cbTenVT.Size = new System.Drawing.Size(151, 27);
            this.cbTenVT.TabIndex = 20;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(199, 238);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 37);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "DONGIA", true));
            this.txtDonGia.Location = new System.Drawing.Point(191, 185);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.DisplayFormat.FormatString = "n0";
            this.txtDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Properties.EditFormat.FormatString = "n0";
            this.txtDonGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Size = new System.Drawing.Size(143, 26);
            this.txtDonGia.TabIndex = 18;
            // 
            // nSoLuong
            // 
            this.nSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTDDH, "SOLUONG", true));
            this.nSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSoLuong.Location = new System.Drawing.Point(196, 131);
            this.nSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nSoLuong.Name = "nSoLuong";
            this.nSoLuong.Size = new System.Drawing.Size(143, 26);
            this.nSoLuong.TabIndex = 16;
            // 
            // frmChiTietDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 303);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(tENVTLabel);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.txtMSDDH);
            this.Controls.Add(this.txtMaVT);
            this.Controls.Add(this.cbTenVT);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.nSoLuong);
            this.Name = "frmChiTietDDH";
            this.Text = "frmChiTietDDH";
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMSDDH;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private System.Windows.Forms.ComboBox cbTenVT;
        private System.Windows.Forms.Button btnThem;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private System.Windows.Forms.NumericUpDown nSoLuong;
    }
}