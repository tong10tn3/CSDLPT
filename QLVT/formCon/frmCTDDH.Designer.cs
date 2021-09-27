
namespace QLVT.formCon
{
    partial class frmCTDDH
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
            this.btnThem = new System.Windows.Forms.Button();
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
            masoDDHLabel.Location = new System.Drawing.Point(39, 49);
            masoDDHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(115, 22);
            masoDDHLabel.TabIndex = 1;
            masoDDHLabel.Text = "Mã Số DDH:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(39, 133);
            tENVTLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(75, 22);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên VT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(39, 210);
            sOLUONGLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(93, 22);
            sOLUONGLabel.TabIndex = 5;
            sOLUONGLabel.Text = "Số Lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(39, 284);
            dONGIALabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
            this.txtMSDDH.Location = new System.Drawing.Point(170, 46);
            this.txtMSDDH.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMSDDH.Name = "txtMSDDH";
            this.txtMSDDH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSDDH.Properties.Appearance.Options.UseFont = true;
            this.txtMSDDH.Properties.ReadOnly = true;
            this.txtMSDDH.Size = new System.Drawing.Size(190, 28);
            this.txtMSDDH.TabIndex = 2;
            this.txtMSDDH.EditValueChanged += new System.EventHandler(this.txtMSDDH_EditValueChanged);
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
            this.cbTenVT.Location = new System.Drawing.Point(170, 125);
            this.cbTenVT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTenVT.Name = "cbTenVT";
            this.cbTenVT.Size = new System.Drawing.Size(182, 30);
            this.cbTenVT.TabIndex = 3;
            this.cbTenVT.SelectedIndexChanged += new System.EventHandler(this.cbTenVT_SelectedIndexChanged);
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(385, 127);
            this.txtMaVT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Properties.Appearance.Options.UseFont = true;
            this.txtMaVT.Properties.ReadOnly = true;
            this.txtMaVT.Size = new System.Drawing.Size(93, 28);
            this.txtMaVT.TabIndex = 5;
            this.txtMaVT.EditValueChanged += new System.EventHandler(this.txtMaVT_EditValueChanged);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTDDH, "SOLUONG", true));
            this.nudSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(170, 202);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(183, 30);
            this.nudSoLuong.TabIndex = 6;
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "DONGIA", true));
            this.txtDonGia.Location = new System.Drawing.Point(170, 281);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.DisplayFormat.FormatString = "n0";
            this.txtDonGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Properties.EditFormat.FormatString = "n0";
            this.txtDonGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGia.Size = new System.Drawing.Size(190, 28);
            this.txtDonGia.TabIndex = 8;
            this.txtDonGia.EditValueChanged += new System.EventHandler(this.txtDonGia_EditValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(170, 351);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(190, 31);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmCTDDH
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 431);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.txtMaVT);
            this.Controls.Add(tENVTLabel);
            this.Controls.Add(this.cbTenVT);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.txtMSDDH);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCTDDH";
            this.Text = "frmCTDDH";
            this.Load += new System.EventHandler(this.frmCTDDH_Load);
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
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMSDDH;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private System.Windows.Forms.ComboBox cbTenVT;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private System.Windows.Forms.Button btnThem;
    }
}