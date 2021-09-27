
namespace QLVT
{
    partial class frmTaoLogin
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
            System.Windows.Forms.Label hOTENNVLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLogin = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.rdbChiNhanh = new System.Windows.Forms.RadioButton();
            this.rdbCongTy = new System.Windows.Forms.RadioButton();
            this.rdbUser = new System.Windows.Forms.RadioButton();
            this.DS = new QLVT.DS();
            this.bdsHoTen = new System.Windows.Forms.BindingSource(this.components);
            this.hOTENNVTableAdapter = new QLVT.DSTableAdapters.HOTENNVTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.btnTaoLogin = new System.Windows.Forms.Button();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.cbHoTenNV = new System.Windows.Forms.ComboBox();
            hOTENNVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN LOGIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "MẬT KHẨU:";
            // 
            // txtTenLogin
            // 
            this.txtTenLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLogin.Location = new System.Drawing.Point(195, 25);
            this.txtTenLogin.Name = "txtTenLogin";
            this.txtTenLogin.Size = new System.Drawing.Size(311, 34);
            this.txtTenLogin.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(195, 82);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(311, 34);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // rdbChiNhanh
            // 
            this.rdbChiNhanh.AutoSize = true;
            this.rdbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChiNhanh.Location = new System.Drawing.Point(109, 214);
            this.rdbChiNhanh.Name = "rdbChiNhanh";
            this.rdbChiNhanh.Size = new System.Drawing.Size(165, 31);
            this.rdbChiNhanh.TabIndex = 4;
            this.rdbChiNhanh.Text = "CHI NHÁNH";
            this.rdbChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rdbCongTy
            // 
            this.rdbCongTy.AutoSize = true;
            this.rdbCongTy.Checked = true;
            this.rdbCongTy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCongTy.Location = new System.Drawing.Point(308, 214);
            this.rdbCongTy.Name = "rdbCongTy";
            this.rdbCongTy.Size = new System.Drawing.Size(137, 31);
            this.rdbCongTy.TabIndex = 5;
            this.rdbCongTy.TabStop = true;
            this.rdbCongTy.Text = "CÔNG TY";
            this.rdbCongTy.UseVisualStyleBackColor = true;
            // 
            // rdbUser
            // 
            this.rdbUser.AutoSize = true;
            this.rdbUser.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUser.Location = new System.Drawing.Point(475, 214);
            this.rdbUser.Name = "rdbUser";
            this.rdbUser.Size = new System.Drawing.Size(92, 31);
            this.rdbUser.TabIndex = 6;
            this.rdbUser.Text = "USER";
            this.rdbUser.UseVisualStyleBackColor = true;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHoTen
            // 
            this.bdsHoTen.DataMember = "HOTENNV";
            this.bdsHoTen.DataSource = this.DS;
            // 
            // hOTENNVTableAdapter
            // 
            this.hOTENNVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.HOTENNVTableAdapter = this.hOTENNVTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // hOTENNVLabel
            // 
            hOTENNVLabel.AutoSize = true;
            hOTENNVLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENNVLabel.Location = new System.Drawing.Point(33, 147);
            hOTENNVLabel.Name = "hOTENNVLabel";
            hOTENNVLabel.Size = new System.Drawing.Size(141, 27);
            hOTENNVLabel.TabIndex = 8;
            hOTENNVLabel.Text = "HỌ TÊN NV:";
            // 
            // btnTaoLogin
            // 
            this.btnTaoLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoLogin.Location = new System.Drawing.Point(262, 275);
            this.btnTaoLogin.Name = "btnTaoLogin";
            this.btnTaoLogin.Size = new System.Drawing.Size(257, 52);
            this.btnTaoLogin.TabIndex = 11;
            this.btnTaoLogin.Text = "TẠO LOGIN";
            this.btnTaoLogin.UseVisualStyleBackColor = true;
            this.btnTaoLogin.Click += new System.EventHandler(this.btnTaoLogin_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHoTen, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(554, 144);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(84, 32);
            this.txtMaNV.TabIndex = 10;
            // 
            // cbHoTenNV
            // 
            this.cbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTen, "HOTENNV", true));
            this.cbHoTenNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoTenNV.FormattingEnabled = true;
            this.cbHoTenNV.Location = new System.Drawing.Point(195, 144);
            this.cbHoTenNV.Name = "cbHoTenNV";
            this.cbHoTenNV.Size = new System.Drawing.Size(311, 34);
            this.cbHoTenNV.TabIndex = 12;
            // 
            // frmTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 348);
            this.Controls.Add(this.cbHoTenNV);
            this.Controls.Add(this.btnTaoLogin);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(hOTENNVLabel);
            this.Controls.Add(this.rdbUser);
            this.Controls.Add(this.rdbCongTy);
            this.Controls.Add(this.rdbChiNhanh);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoLogin";
            this.Text = "frmTaoLogin";
            this.Load += new System.EventHandler(this.frmTaoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLogin;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.RadioButton rdbChiNhanh;
        private System.Windows.Forms.RadioButton rdbCongTy;
        private System.Windows.Forms.RadioButton rdbUser;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsHoTen;
        private DSTableAdapters.HOTENNVTableAdapter hOTENNVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnTaoLogin;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.ComboBox cbHoTenNV;
    }
}