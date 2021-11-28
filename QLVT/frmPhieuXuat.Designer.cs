
namespace QLVT
{
    partial class frmPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuXuat));
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
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
            this.bdsPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT.DSTableAdapters.TableAdapterManager();
            this.phieuXuatGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QLVT.DSTableAdapters.CTPXTableAdapter();
            this.cTPXGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMAPX = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            nGAYLabel = new System.Windows.Forms.Label();
            mAPXLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_61f010f8_1727_4c85_b1f1_f68abad8014b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControl8.Location = new System.Drawing.Point(0, 535);
            this.barDockControl8.Manager = this.barManager1;
            this.barDockControl8.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControl9
            // 
            this.barDockControl9.CausesValidation = false;
            this.barDockControl9.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl9.Location = new System.Drawing.Point(0, 40);
            this.barDockControl9.Manager = this.barManager1;
            this.barDockControl9.Size = new System.Drawing.Size(0, 495);
            // 
            // barDockControl10
            // 
            this.barDockControl10.CausesValidation = false;
            this.barDockControl10.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl10.Location = new System.Drawing.Point(800, 40);
            this.barDockControl10.Manager = this.barManager1;
            this.barDockControl10.Size = new System.Drawing.Size(0, 495);
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
            // bdsPhieuXuat
            // 
            this.bdsPhieuXuat.DataMember = "PhieuXuat";
            this.bdsPhieuXuat.DataSource = this.dS;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // phieuXuatGridControl
            // 
            this.phieuXuatGridControl.DataSource = this.bdsPhieuXuat;
            this.phieuXuatGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.phieuXuatGridControl.Location = new System.Drawing.Point(0, 40);
            this.phieuXuatGridControl.MainView = this.gridView1;
            this.phieuXuatGridControl.MenuManager = this.barManager1;
            this.phieuXuatGridControl.Name = "phieuXuatGridControl";
            this.phieuXuatGridControl.Size = new System.Drawing.Size(800, 220);
            this.phieuXuatGridControl.TabIndex = 5;
            this.phieuXuatGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.phieuXuatGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "BẢNG PHIẾU XUẤT";
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "MÃ PHIẾU XUẤT";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "NGÀY";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "TÊN KHÁCH HÀNG";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
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
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_PhieuXuat_CTPX";
            this.bdsCTPX.DataSource = this.bdsPhieuXuat;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // cTPXGridControl
            // 
            this.cTPXGridControl.DataSource = this.bdsCTPX;
            this.cTPXGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTPXGridControl.Location = new System.Drawing.Point(571, 260);
            this.cTPXGridControl.MainView = this.gridView2;
            this.cTPXGridControl.MenuManager = this.barManager1;
            this.cTPXGridControl.Name = "cTPXGridControl";
            this.cTPXGridControl.Size = new System.Drawing.Size(229, 275);
            this.cTPXGridControl.TabIndex = 5;
            this.cTPXGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.cTPXGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "CHI TIẾT PHIẾU XUẤT";
            // 
            // colMAPX1
            // 
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(mAKHOLabel);
            this.panel1.Controls.Add(this.txtMaKho);
            this.panel1.Controls.Add(mANVLabel);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(hOTENKHLabel);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(mAPXLabel);
            this.panel1.Controls.Add(this.txtMAPX);
            this.panel1.Controls.Add(nGAYLabel);
            this.panel1.Controls.Add(this.txtNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 275);
            this.panel1.TabIndex = 6;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuXuat, "NGAY", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(150, 130);
            this.txtNgay.MenuManager = this.barManager1;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Properties.Appearance.Options.UseFont = true;
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtNgay.Properties.Name = "nGAYDateEdit";
            this.txtNgay.Size = new System.Drawing.Size(100, 26);
            this.txtNgay.TabIndex = 3;
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLabel.Location = new System.Drawing.Point(41, 133);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(45, 19);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:";
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPXLabel.Location = new System.Drawing.Point(41, 41);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(103, 19);
            mAPXLabel.TabIndex = 3;
            mAPXLabel.Text = "Mã Phiếu Xuất:";
            // 
            // txtMAPX
            // 
            this.txtMAPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "MAPX", true));
            this.txtMAPX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAPX.Location = new System.Drawing.Point(150, 38);
            this.txtMAPX.Name = "txtMAPX";
            this.txtMAPX.Size = new System.Drawing.Size(100, 26);
            this.txtMAPX.TabIndex = 4;
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENKHLabel.Location = new System.Drawing.Point(274, 41);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(115, 19);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "Tên Khách Hàng:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "HOTENKH", true));
            this.txtTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(410, 38);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 26);
            this.txtTenKH.TabIndex = 5;
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(41, 213);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(101, 19);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã Nhân Viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "MANV", true));
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(150, 210);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 26);
            this.txtMaNV.TabIndex = 7;
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOLabel.Location = new System.Drawing.Point(325, 133);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(64, 19);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuXuat, "MAKHO", true));
            this.txtMaKho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKho.Location = new System.Drawing.Point(410, 130);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(100, 26);
            this.txtMaKho.TabIndex = 9;
            // 
            // object_61f010f8_1727_4c85_b1f1_f68abad8014b
            // 
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.Appearance.Options.UseFont = true;
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.EditFormat.FormatString = "dd/MM/yyyy";
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.Mask.EditMask = "dd/MM/yyyy";
            this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.Name = "object_61f010f8_1727_4c85_b1f1_f68abad8014b";
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.cTPXGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.phieuXuatGridControl);
            this.Controls.Add(this.barDockControl9);
            this.Controls.Add(this.barDockControl10);
            this.Controls.Add(this.barDockControl8);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuXuat";
            this.Text = "frmPhieuXuat";
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPXGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_61f010f8_1727_4c85_b1f1_f68abad8014b.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.object_61f010f8_1727_4c85_b1f1_f68abad8014b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
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
        private System.Windows.Forms.BindingSource bdsPhieuXuat;
        private DS dS;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl phieuXuatGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private DevExpress.XtraGrid.GridControl cTPXGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMAPX;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit object_61f010f8_1727_4c85_b1f1_f68abad8014b;
    }
}