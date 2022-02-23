
namespace NtbSoft.ERP.Win.Modules.LinhKienForm
{
    partial class frmDsLinhKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDsLinhKien));
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btSave = new DevExpress.XtraBars.BarButtonItem();
            this.btDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.dgrDsLinhKien = new DevExpress.XtraGrid.GridControl();
            this.gridViewLinhKien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLinhKien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLinhKien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRepoTxtSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDsLinhKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLinhKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colRepoTxtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.LookAndFeel.SkinMaskColor = System.Drawing.Color.DodgerBlue;
            this.barAndDockingController1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btDelete,
            this.btSave,
            this.btCancel,
            this.barButtonItem5,
            this.barButtonItem6});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btSave
            // 
            this.btSave.Caption = "Lưu";
            this.btSave.Id = 2;
            this.btSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.Image")));
            this.btSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.LargeImage")));
            this.btSave.Name = "btSave";
            this.btSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSave_ItemClick);
            // 
            // btDelete
            // 
            this.btDelete.Caption = "Xóa";
            this.btDelete.Id = 1;
            this.btDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.ImageOptions.Image")));
            this.btDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btDelete.ImageOptions.LargeImage")));
            this.btDelete.Name = "btDelete";
            this.btDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btDelete_ItemClick);
            // 
            // btCancel
            // 
            this.btCancel.Caption = "Nạp lại";
            this.btCancel.Id = 3;
            this.btCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.ImageOptions.Image")));
            this.btCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btCancel.ImageOptions.LargeImage")));
            this.btCancel.Name = "btCancel";
            this.btCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btCancel_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Phiếu nhập";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Phiếu xuất";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1363, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 621);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1363, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 592);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1363, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 592);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Xóa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Lưu";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Nạp lại";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1363, 29);
            this.barDockControl4.Manager = null;
            this.barDockControl4.Size = new System.Drawing.Size(0, 592);
            // 
            // dgrDsLinhKien
            // 
            this.dgrDsLinhKien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrDsLinhKien.Location = new System.Drawing.Point(0, 0);
            this.dgrDsLinhKien.LookAndFeel.UseWindowsXPTheme = true;
            this.dgrDsLinhKien.MainView = this.gridViewLinhKien;
            this.dgrDsLinhKien.MenuManager = this.barManager1;
            this.dgrDsLinhKien.Name = "dgrDsLinhKien";
            this.dgrDsLinhKien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colRepoTxtSoLuong});
            this.dgrDsLinhKien.Size = new System.Drawing.Size(692, 592);
            this.dgrDsLinhKien.TabIndex = 9;
            this.dgrDsLinhKien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLinhKien});
            // 
            // gridViewLinhKien
            // 
            this.gridViewLinhKien.ColumnPanelRowHeight = 30;
            this.gridViewLinhKien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMaLinhKien,
            this.colTenLinhKien,
            this.colSoLuong,
            this.colGhiChu});
            this.gridViewLinhKien.GridControl = this.dgrDsLinhKien;
            this.gridViewLinhKien.Name = "gridViewLinhKien";
            this.gridViewLinhKien.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewLinhKien.OptionsView.ShowGroupPanel = false;
            this.gridViewLinhKien.RowHeight = 25;
            this.gridViewLinhKien.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewLinhKien_CellValueChanged);
            this.gridViewLinhKien.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewLinhKien_ValidatingEditor);
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.AppearanceHeader.Options.UseTextOptions = true;
            this.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colMaLinhKien
            // 
            this.colMaLinhKien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMaLinhKien.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colMaLinhKien.AppearanceHeader.Options.UseFont = true;
            this.colMaLinhKien.AppearanceHeader.Options.UseForeColor = true;
            this.colMaLinhKien.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaLinhKien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaLinhKien.Caption = "Mã linh kiện";
            this.colMaLinhKien.FieldName = "MaLK";
            this.colMaLinhKien.MaxWidth = 150;
            this.colMaLinhKien.Name = "colMaLinhKien";
            this.colMaLinhKien.Visible = true;
            this.colMaLinhKien.VisibleIndex = 0;
            // 
            // colTenLinhKien
            // 
            this.colTenLinhKien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTenLinhKien.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colTenLinhKien.AppearanceHeader.Options.UseFont = true;
            this.colTenLinhKien.AppearanceHeader.Options.UseForeColor = true;
            this.colTenLinhKien.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenLinhKien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenLinhKien.Caption = "Tên linh kiện";
            this.colTenLinhKien.FieldName = "TenLK";
            this.colTenLinhKien.MaxWidth = 150;
            this.colTenLinhKien.Name = "colTenLinhKien";
            this.colTenLinhKien.Visible = true;
            this.colTenLinhKien.VisibleIndex = 1;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoLuong.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colSoLuong.AppearanceHeader.Options.UseFont = true;
            this.colSoLuong.AppearanceHeader.Options.UseForeColor = true;
            this.colSoLuong.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.ColumnEdit = this.colRepoTxtSoLuong;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.MaxWidth = 150;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            // 
            // colRepoTxtSoLuong
            // 
            this.colRepoTxtSoLuong.AutoHeight = false;
            this.colRepoTxtSoLuong.Mask.EditMask = "n0";
            this.colRepoTxtSoLuong.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.colRepoTxtSoLuong.Name = "colRepoTxtSoLuong";
            // 
            // colGhiChu
            // 
            this.colGhiChu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGhiChu.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colGhiChu.AppearanceHeader.Options.UseFont = true;
            this.colGhiChu.AppearanceHeader.Options.UseForeColor = true;
            this.colGhiChu.AppearanceHeader.Options.UseTextOptions = true;
            this.colGhiChu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.MaxWidth = 200;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 29);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.dgrDsLinhKien);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1363, 592);
            this.splitContainerControl1.SplitterPosition = 692;
            this.splitContainerControl1.TabIndex = 15;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.textEdit2);
            this.layoutControl1.Controls.Add(this.textEdit3);
            this.layoutControl1.Controls.Add(this.textEdit4);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(661, 77);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(661, 77);
            this.Root.TextVisible = false;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(117, 12);
            this.textEdit1.MaximumSize = new System.Drawing.Size(200, 0);
            this.textEdit1.MenuManager = this.barManager1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(200, 20);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(309, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(426, 12);
            this.textEdit2.MaximumSize = new System.Drawing.Size(200, 0);
            this.textEdit2.MenuManager = this.barManager1;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(200, 20);
            this.textEdit2.StyleController = this.layoutControl1;
            this.textEdit2.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(309, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(117, 36);
            this.textEdit3.MaximumSize = new System.Drawing.Size(200, 0);
            this.textEdit3.MenuManager = this.barManager1;
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(200, 20);
            this.textEdit3.StyleController = this.layoutControl1;
            this.textEdit3.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit3;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(309, 33);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(426, 36);
            this.textEdit4.MaximumSize = new System.Drawing.Size(200, 0);
            this.textEdit4.MenuManager = this.barManager1;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(200, 20);
            this.textEdit4.StyleController = this.layoutControl1;
            this.textEdit4.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit4;
            this.layoutControlItem4.Location = new System.Drawing.Point(309, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(332, 33);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            // 
            // frmDsLinhKien
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 621);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmDsLinhKien";
            this.Text = "Quản lý linh kiện";
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDsLinhKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLinhKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colRepoTxtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btDelete;
        private DevExpress.XtraBars.BarButtonItem btSave;
        private DevExpress.XtraBars.BarButtonItem btCancel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl dgrDsLinhKien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLinhKien;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLinhKien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLinhKien;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colRepoTxtSoLuong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}