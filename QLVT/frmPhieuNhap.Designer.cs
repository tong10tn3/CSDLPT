
namespace QLVT
{
    partial class frmPhieuNhap
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
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl9 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl10 = new DevExpress.XtraBars.BarDockControl();
            this.btnThem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnThemPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemCTPN = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new QLVT.DS();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.gcPN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMAKHO = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtMADDH = new DevExpress.XtraEditors.ButtonEdit();
            this.txtMAPN = new System.Windows.Forms.TextBox();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new QLVT.DSTableAdapters.CTPNTableAdapter();
            this.cTPNGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT.DSTableAdapters.KhoTableAdapter();
            nGAYLabel = new System.Windows.Forms.Label();
            mAPNLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMADDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLabel.Location = new System.Drawing.Point(55, 120);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(45, 19);
            nGAYLabel.TabIndex = 0;
            nGAYLabel.Text = "Ngày:";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPNLabel.Location = new System.Drawing.Point(55, 45);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(108, 19);
            mAPNLabel.TabIndex = 2;
            mAPNLabel.Text = "Mã Phiếu Nhập:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(395, 44);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(99, 19);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Mã Đơn Hàng:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(55, 197);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(101, 19);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã Nhân Viên:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOLabel.Location = new System.Drawing.Point(395, 123);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(64, 19);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControl8);
            this.barManager1.DockControls.Add(this.barDockControl9);
            this.barManager1.DockControls.Add(this.barDockControl10);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnXoa,
            this.btnGhi,
            this.btnUndo,
            this.btnReload,
            this.btnThoat,
            this.btnThem1,
            this.btnThemPN,
            this.btnThemCTPN,
            this.btnThem,
            this.btnCTPN});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 13;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 11;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(0, 40);
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(0, 40);
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Hoàn tác";
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(0, 40);
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Làm mới";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(0, 40);
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnCTPN
            // 
            this.btnCTPN.Caption = "Chi tiết phiếu";
            this.btnCTPN.Id = 12;
            this.btnCTPN.Name = "btnCTPN";
            this.btnCTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCTPN_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(0, 40);
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 40);
            // 
            // barDockControl8
            // 
            this.barDockControl8.CausesValidation = false;
            this.barDockControl8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl8.Location = new System.Drawing.Point(0, 557);
            this.barDockControl8.Manager = this.barManager1;
            this.barDockControl8.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControl9
            // 
            this.barDockControl9.CausesValidation = false;
            this.barDockControl9.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl9.Location = new System.Drawing.Point(0, 40);
            this.barDockControl9.Manager = this.barManager1;
            this.barDockControl9.Size = new System.Drawing.Size(0, 517);
            // 
            // barDockControl10
            // 
            this.barDockControl10.CausesValidation = false;
            this.barDockControl10.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl10.Location = new System.Drawing.Point(800, 40);
            this.barDockControl10.Manager = this.barManager1;
            this.barDockControl10.Size = new System.Drawing.Size(0, 517);
            // 
            // btnThem1
            // 
            this.btnThem1.Caption = "Thêm";
            this.btnThem1.Id = 8;
            this.btnThem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemPN),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemCTPN)});
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(0, 40);
            // 
            // btnThemPN
            // 
            this.btnThemPN.Caption = "Thêm Phiếu Nhập";
            this.btnThemPN.Id = 9;
            this.btnThemPN.Name = "btnThemPN";
            // 
            // btnThemCTPN
            // 
            this.btnThemCTPN.Caption = "Thêm Chi Tiết Phiếu Nhập";
            this.btnThemCTPN.Id = 10;
            this.btnThemCTPN.Name = "btnThemCTPN";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "PhieuNhap";
            this.bdsPN.DataSource = this.dS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.HOTENNVTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gcPN
            // 
            this.gcPN.DataSource = this.bdsPN;
            this.gcPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPN.Location = new System.Drawing.Point(0, 87);
            this.gcPN.MainView = this.gridView1;
            this.gcPN.MenuManager = this.barManager1;
            this.gcPN.Name = "gcPN";
            this.gcPN.Size = new System.Drawing.Size(800, 220);
            this.gcPN.TabIndex = 5;
            this.gcPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcPN;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "BẢNG PHIẾU NHẬP";
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "MÃ PHIẾU NHẬP";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "NGÀY LẬP";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "MÃ ĐƠN HÀNG";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NHÂN VIÊN";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "MÃ KHO";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(mAKHOLabel);
            this.panel1.Controls.Add(this.txtMAKHO);
            this.panel1.Controls.Add(mANVLabel);
            this.panel1.Controls.Add(this.txtMANV);
            this.panel1.Controls.Add(masoDDHLabel);
            this.panel1.Controls.Add(this.txtMADDH);
            this.panel1.Controls.Add(mAPNLabel);
            this.panel1.Controls.Add(this.txtMAPN);
            this.panel1.Controls.Add(nGAYLabel);
            this.panel1.Controls.Add(this.txtNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 250);
            this.panel1.TabIndex = 10;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MAKHO", true));
            this.txtMAKHO.Enabled = false;
            this.txtMAKHO.Location = new System.Drawing.Point(500, 124);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(100, 20);
            this.txtMAKHO.TabIndex = 9;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Location = new System.Drawing.Point(169, 198);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 20);
            this.txtMANV.TabIndex = 7;
            // 
            // txtMADDH
            // 
            this.txtMADDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MasoDDH", true));
            this.txtMADDH.Location = new System.Drawing.Point(500, 41);
            this.txtMADDH.MenuManager = this.barManager1;
            this.txtMADDH.Name = "txtMADDH";
            this.txtMADDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtMADDH.Size = new System.Drawing.Size(100, 20);
            this.txtMADDH.TabIndex = 5;
            this.txtMADDH.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtMADDH_ButtonClick);
            // 
            // txtMAPN
            // 
            this.txtMAPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MAPN", true));
            this.txtMAPN.Location = new System.Drawing.Point(169, 44);
            this.txtMAPN.Name = "txtMAPN";
            this.txtMAPN.Size = new System.Drawing.Size(100, 20);
            this.txtMAPN.TabIndex = 3;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "NGAY", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Enabled = false;
            this.txtNgay.Location = new System.Drawing.Point(169, 121);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(100, 20);
            this.txtNgay.TabIndex = 1;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_PhieuNhap_CTPN";
            this.bdsCTPN.DataSource = this.bdsPN;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNGridControl
            // 
            this.cTPNGridControl.DataSource = this.bdsCTPN;
            this.cTPNGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTPNGridControl.Location = new System.Drawing.Point(711, 307);
            this.cTPNGridControl.MainView = this.gridView2;
            this.cTPNGridControl.MenuManager = this.barManager1;
            this.cTPNGridControl.Name = "cTPNGridControl";
            this.cTPNGridControl.Size = new System.Drawing.Size(89, 250);
            this.cTPNGridControl.TabIndex = 10;
            this.cTPNGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.cTPNGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "BẢNG CHI TIẾT PHIẾU NHẬP";
            // 
            // colMAPN1
            // 
            this.colMAPN1.Caption = "MÃ PHIẾU NHẬP";
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "MÃ VẬT TƯ";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "SỐ LƯỢNG";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "ĐƠN GIÁ";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChiNhanh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(800, 47);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(173, 13);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(289, 27);
            this.cbChiNhanh.TabIndex = 3;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbMaChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHI NHÁNH: ";
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.dS;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.cTPNGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gcPN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControl9);
            this.Controls.Add(this.barDockControl10);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            this.EnabledChanged += new System.EventHandler(this.frmPhieuNhap_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMADDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnCTPN;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.BarDockControl barDockControl9;
        private DevExpress.XtraBars.BarDockControl barDockControl10;
        private DevExpress.XtraBars.BarSubItem btnThem1;
        private DevExpress.XtraBars.BarButtonItem btnThemPN;
        private DevExpress.XtraBars.BarButtonItem btnThemCTPN;
        private System.Windows.Forms.BindingSource bdsPN;
        private DS dS;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private DevExpress.XtraGrid.GridControl cTPNGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.TextBox txtMAKHO;
        private System.Windows.Forms.TextBox txtMANV;
        private DevExpress.XtraEditors.ButtonEdit txtMADDH;
        private System.Windows.Forms.TextBox txtMAPN;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
    }
}