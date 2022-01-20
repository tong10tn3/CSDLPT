
namespace QLVT.reporting
{
    partial class frmHoatDongNhanVien
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
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.bdsHoTenNV = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QLVT.DS();
            this.hOTENNVTableAdapter = new QLVT.DSTableAdapters.HOTENNVTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.nhanVienTableAdapter = new QLVT.DSTableAdapters.NhanVienTableAdapter();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.cbHoTenNV = new System.Windows.Forms.ComboBox();
            this.cbLP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.hOTENNVLabel = new System.Windows.Forms.Label();
            this.mANVLabel = new System.Windows.Forms.Label();
            this.dDenNgay = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDenNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHoTenNV, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(159, 62);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Properties.Appearance.Options.UseFont = true;
            this.txtMaNV.Size = new System.Drawing.Size(144, 26);
            this.txtMaNV.TabIndex = 43;
            // 
            // bdsHoTenNV
            // 
            this.bdsHoTenNV.DataMember = "HOTENNV";
            this.bdsHoTenNV.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOTENNVTableAdapter
            // 
            this.hOTENNVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.HOTENNVTableAdapter = this.hOTENNVTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NhanVien";
            this.bdsNhanVien.DataSource = this.DS;
            // 
            // cbHoTenNV
            // 
            this.cbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTenNV, "HOTENNV", true));
            this.cbHoTenNV.DataSource = this.bdsHoTenNV;
            this.cbHoTenNV.DisplayMember = "HOTENNV";
            this.cbHoTenNV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoTenNV.FormattingEnabled = true;
            this.cbHoTenNV.Location = new System.Drawing.Point(516, 60);
            this.cbHoTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHoTenNV.Name = "cbHoTenNV";
            this.cbHoTenNV.Size = new System.Drawing.Size(164, 27);
            this.cbHoTenNV.TabIndex = 42;
            this.cbHoTenNV.ValueMember = "MANV";
            // 
            // cbLP
            // 
            this.cbLP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLP.FormattingEnabled = true;
            this.cbLP.Location = new System.Drawing.Point(159, 156);
            this.cbLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLP.Name = "cbLP";
            this.cbLP.Size = new System.Drawing.Size(145, 27);
            this.cbLP.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Loại Phiếu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(201, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 27);
            this.label3.TabIndex = 39;
            this.label3.Text = "HOẠT ĐỘNG NHÂN VIÊN";
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPreview.Location = new System.Drawing.Point(309, 196);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(104, 29);
            this.btnPreview.TabIndex = 38;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Đến Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Từ Ngày:";
            // 
            // dTuNgay
            // 
            this.dTuNgay.EditValue = new System.DateTime(2021, 10, 2, 22, 36, 32, 0);
            this.dTuNgay.Location = new System.Drawing.Point(159, 110);
            this.dTuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTuNgay.Name = "dTuNgay";
            this.dTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTuNgay.Properties.Appearance.Options.UseFont = true;
            this.dTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dTuNgay.Size = new System.Drawing.Size(144, 26);
            this.dTuNgay.TabIndex = 34;
            // 
            // hOTENNVLabel
            // 
            this.hOTENNVLabel.AutoSize = true;
            this.hOTENNVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTENNVLabel.Location = new System.Drawing.Point(353, 61);
            this.hOTENNVLabel.Name = "hOTENNVLabel";
            this.hOTENNVLabel.Size = new System.Drawing.Size(138, 19);
            this.hOTENNVLabel.TabIndex = 33;
            this.hOTENNVLabel.Text = "Họ Tên Nhân Viên:";
            // 
            // mANVLabel
            // 
            this.mANVLabel.AutoSize = true;
            this.mANVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANVLabel.Location = new System.Drawing.Point(37, 61);
            this.mANVLabel.Name = "mANVLabel";
            this.mANVLabel.Size = new System.Drawing.Size(112, 19);
            this.mANVLabel.TabIndex = 32;
            this.mANVLabel.Text = "Mã Nhân Viên:";
            // 
            // dDenNgay
            // 
            this.dDenNgay.EditValue = null;
            this.dDenNgay.Location = new System.Drawing.Point(516, 114);
            this.dDenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dDenNgay.Name = "dDenNgay";
            this.dDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dDenNgay.Properties.Appearance.Options.UseFont = true;
            this.dDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dDenNgay.Size = new System.Drawing.Size(164, 26);
            this.dDenNgay.TabIndex = 36;
            // 
            // frmHoatDongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 240);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.cbHoTenNV);
            this.Controls.Add(this.cbLP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dDenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTuNgay);
            this.Controls.Add(this.hOTENNVLabel);
            this.Controls.Add(this.mANVLabel);
            this.Name = "frmHoatDongNhanVien";
            this.Text = "frmHoatDongNhanVien";
            this.Load += new System.EventHandler(this.frmHoatDongNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDenNgay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private System.Windows.Forms.BindingSource bdsHoTenNV;
        private DS DS;
        private DSTableAdapters.HOTENNVTableAdapter hOTENNVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private System.Windows.Forms.ComboBox cbHoTenNV;
        private System.Windows.Forms.ComboBox cbLP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dTuNgay;
        private System.Windows.Forms.Label hOTENNVLabel;
        private System.Windows.Forms.Label mANVLabel;
        private DevExpress.XtraEditors.DateEdit dDenNgay;
    }
}