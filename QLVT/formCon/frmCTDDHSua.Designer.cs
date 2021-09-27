
namespace QLVT.formCon
{
    partial class frmCTDDHSua
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            this.DS = new QLVT.DS();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT.DSTableAdapters.CTDDHTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.vattuTableAdapter = new QLVT.DSTableAdapters.VattuTableAdapter();
            this.txtMSDDH = new DevExpress.XtraEditors.TextEdit();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.cbTenVT = new System.Windows.Forms.ComboBox();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.btnSua = new System.Windows.Forms.Button();
            masoDDHLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(35, 47);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(115, 22);
            masoDDHLabel.TabIndex = 1;
            masoDDHLabel.Text = "Mã Số DDH:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENVTLabel.Location = new System.Drawing.Point(35, 108);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(75, 22);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên VT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOLUONGLabel.Location = new System.Drawing.Point(35, 183);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(93, 22);
            sOLUONGLabel.TabIndex = 5;
            sOLUONGLabel.Text = "Số Lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dONGIALabel.Location = new System.Drawing.Point(35, 238);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(84, 22);
            dONGIALabel.TabIndex = 7;
            dONGIALabel.Text = "Đơn Giá:";
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
            this.txtMSDDH.Location = new System.Drawing.Point(156, 40);
            this.txtMSDDH.Name = "txtMSDDH";
            this.txtMSDDH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSDDH.Properties.Appearance.Options.UseFont = true;
            this.txtMSDDH.Properties.ReadOnly = true;
            this.txtMSDDH.Size = new System.Drawing.Size(191, 28);
            this.txtMSDDH.TabIndex = 2;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // cbTenVT
            // 
            this.cbTenVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVatTu, "TENVT", true));
            this.cbTenVT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenVT.FormattingEnabled = true;
            this.cbTenVT.Location = new System.Drawing.Point(156, 103);
            this.cbTenVT.Name = "cbTenVT";
            this.cbTenVT.Size = new System.Drawing.Size(191, 30);
            this.cbTenVT.TabIndex = 3;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(360, 105);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Properties.Appearance.Options.UseFont = true;
            this.txtMaVT.Properties.ReadOnly = true;
            this.txtMaVT.Size = new System.Drawing.Size(80, 28);
            this.txtMaVT.TabIndex = 5;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTDDH, "SOLUONG", true));
            this.nudSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(156, 175);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(191, 30);
            this.nudSoLuong.TabIndex = 6;
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "DONGIA", true));
            this.txtDonGia.Location = new System.Drawing.Point(156, 231);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.DisplayFormat.FormatString = "n0";
            this.txtDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Properties.EditFormat.FormatString = "n0";
            this.txtDonGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Size = new System.Drawing.Size(191, 28);
            this.txtDonGia.TabIndex = 8;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(130, 303);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 44);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "SỬA ĐỔI";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmCTDDHSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 411);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.txtMaVT);
            this.Controls.Add(tENVTLabel);
            this.Controls.Add(this.cbTenVT);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.txtMSDDH);
            this.Name = "frmCTDDHSua";
            this.Text = "frmCTDDHSua";
            this.Load += new System.EventHandler(this.frmCTDDHSua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS DS;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit txtMSDDH;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private System.Windows.Forms.ComboBox cbTenVT;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private System.Windows.Forms.Button btnSua;
    }
}