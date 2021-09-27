
namespace QLVT.formCon
{
    partial class frmChuyenChiNhanh
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
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mANVLabel;
            this.cbChiNhanhMoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLuong = new DevExpress.XtraEditors.TextEdit();
            this.dNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.btnXacNhanChuyen = new System.Windows.Forms.Button();
            lUONGLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lUONGLabel.Location = new System.Drawing.Point(23, 343);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(85, 22);
            lUONGLabel.TabIndex = 26;
            lUONGLabel.Text = "LƯƠNG:";
            lUONGLabel.Click += new System.EventHandler(this.lUONGLabel_Click);
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYSINHLabel.Location = new System.Drawing.Point(22, 239);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(121, 22);
            nGAYSINHLabel.TabIndex = 24;
            nGAYSINHLabel.Text = "NGÀY SINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dIACHILabel.Location = new System.Drawing.Point(23, 298);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(87, 22);
            dIACHILabel.TabIndex = 22;
            dIACHILabel.Text = "ĐỊA CHỈ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(23, 191);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(54, 22);
            tENLabel.TabIndex = 20;
            tENLabel.Text = "TÊN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(20, 145);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(44, 22);
            hOLabel.TabIndex = 18;
            hOLabel.Text = "HỌ:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(20, 86);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(121, 22);
            mANVLabel.TabIndex = 16;
            mANVLabel.Text = "MÃ NV MỚI:";
            // 
            // cbChiNhanhMoi
            // 
            this.cbChiNhanhMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanhMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChiNhanhMoi.FormattingEnabled = true;
            this.cbChiNhanhMoi.Location = new System.Drawing.Point(204, 29);
            this.cbChiNhanhMoi.Name = "cbChiNhanhMoi";
            this.cbChiNhanhMoi.Size = new System.Drawing.Size(186, 31);
            this.cbChiNhanhMoi.TabIndex = 0;
            this.cbChiNhanhMoi.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanhMoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI NHÁNH MỚI:";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(206, 340);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Properties.Appearance.Options.UseFont = true;
            this.txtLuong.Properties.DisplayFormat.FormatString = "n0";
            this.txtLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLuong.Size = new System.Drawing.Size(189, 28);
            this.txtLuong.TabIndex = 27;
            this.txtLuong.EditValueChanged += new System.EventHandler(this.txtLuong_EditValueChanged);
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.EditValue = null;
            this.dNgaySinh.Location = new System.Drawing.Point(206, 236);
            this.dNgaySinh.Name = "dNgaySinh";
            this.dNgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dNgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgaySinh.Size = new System.Drawing.Size(186, 28);
            this.dNgaySinh.TabIndex = 25;
            this.dNgaySinh.EditValueChanged += new System.EventHandler(this.dNgaySinh_EditValueChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(206, 292);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(189, 28);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(204, 188);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(189, 28);
            this.txtTen.TabIndex = 21;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(204, 142);
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Size = new System.Drawing.Size(189, 28);
            this.txtHo.TabIndex = 19;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(204, 83);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(186, 28);
            this.txtMaNhanVien.TabIndex = 17;
            // 
            // btnXacNhanChuyen
            // 
            this.btnXacNhanChuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanChuyen.Location = new System.Drawing.Point(100, 409);
            this.btnXacNhanChuyen.Name = "btnXacNhanChuyen";
            this.btnXacNhanChuyen.Size = new System.Drawing.Size(215, 29);
            this.btnXacNhanChuyen.TabIndex = 28;
            this.btnXacNhanChuyen.Text = "XÁC NHẬN CHUYỂN";
            this.btnXacNhanChuyen.UseVisualStyleBackColor = true;
            this.btnXacNhanChuyen.Click += new System.EventHandler(this.btnXacNhanChuyen_Click);
            // 
            // frmChuyenChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 468);
            this.Controls.Add(this.btnXacNhanChuyen);
            this.Controls.Add(lUONGLabel);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(nGAYSINHLabel);
            this.Controls.Add(this.dNgaySinh);
            this.Controls.Add(dIACHILabel);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(tENLabel);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(hOLabel);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(mANVLabel);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChiNhanhMoi);
            this.Name = "frmChuyenChiNhanh";
            this.Text = "frmChuyenChiNhanh";
            this.Load += new System.EventHandler(this.frmChuyenChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChiNhanhMoi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtLuong;
        private DevExpress.XtraEditors.DateEdit dNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private System.Windows.Forms.Button btnXacNhanChuyen;
    }
}