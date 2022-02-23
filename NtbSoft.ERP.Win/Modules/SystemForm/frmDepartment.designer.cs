namespace NtbSoft.ERP.Win.Modules.SystemForm
{
    partial class frmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbGroup = new DevExpress.XtraEditors.LabelControl();
            this.cbsaw = new DevExpress.XtraEditors.CheckEdit();
            this.cbCut = new DevExpress.XtraEditors.CheckEdit();
            this.cbPack = new DevExpress.XtraEditors.CheckEdit();
            this.cbService = new DevExpress.XtraEditors.CheckEdit();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.tlcolDepID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcolDepName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcolNoWorked = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.tlcolParentID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcolPhoneDep = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcolIsChain = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcolIsChainSaw = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcolIsChainCut = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcolIsChainPackage = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcolIsWarehouse = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcolIsLocalDep = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcolSort = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.rItemBTAudio = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btSave = new DevExpress.XtraBars.BarButtonItem();
            this.btCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbsaw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemBTAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.treeList1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 29);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(844, 602);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbGroup);
            this.panelControl1.Controls.Add(this.cbsaw);
            this.panelControl1.Controls.Add(this.cbCut);
            this.panelControl1.Controls.Add(this.cbPack);
            this.panelControl1.Controls.Add(this.cbService);
            this.panelControl1.Location = new System.Drawing.Point(7, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(830, 20);
            this.panelControl1.TabIndex = 5;
            // 
            // lbGroup
            // 
            this.lbGroup.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbGroup.Location = new System.Drawing.Point(553, 2);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(46, 16);
            this.lbGroup.TabIndex = 4;
            this.lbGroup.Text = "Nhóm : ";
            // 
            // cbsaw
            // 
            this.cbsaw.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbsaw.Location = new System.Drawing.Point(599, 2);
            this.cbsaw.Name = "cbsaw";
            this.cbsaw.Properties.Caption = "May";
            this.cbsaw.Size = new System.Drawing.Size(50, 19);
            this.cbsaw.TabIndex = 0;
            this.cbsaw.CheckedChanged += new System.EventHandler(this.cbsaw_CheckedChanged);
            // 
            // cbCut
            // 
            this.cbCut.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbCut.Location = new System.Drawing.Point(649, 2);
            this.cbCut.Name = "cbCut";
            this.cbCut.Properties.Caption = "Cắt";
            this.cbCut.Size = new System.Drawing.Size(51, 19);
            this.cbCut.TabIndex = 1;
            this.cbCut.CheckedChanged += new System.EventHandler(this.cbCut_CheckedChanged);
            // 
            // cbPack
            // 
            this.cbPack.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbPack.Location = new System.Drawing.Point(700, 2);
            this.cbPack.Name = "cbPack";
            this.cbPack.Properties.Caption = "Đóng thùng";
            this.cbPack.Size = new System.Drawing.Size(68, 19);
            this.cbPack.TabIndex = 2;
            this.cbPack.CheckedChanged += new System.EventHandler(this.cbPack_CheckedChanged);
            // 
            // cbService
            // 
            this.cbService.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbService.Location = new System.Drawing.Point(768, 2);
            this.cbService.Name = "cbService";
            this.cbService.Properties.Caption = "Dịch vụ";
            this.cbService.Size = new System.Drawing.Size(60, 19);
            this.cbService.TabIndex = 3;
            this.cbService.CheckedChanged += new System.EventHandler(this.cbService_CheckedChanged);
            // 
            // treeList1
            // 
            this.treeList1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeList1.Appearance.HeaderPanel.Options.UseFont = true;
            this.treeList1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.treeList1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.treeList1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcolDepID,
            this.tlcolDepName,
            this.tlcolNoWorked,
            this.tlcolParentID,
            this.tlcolPhoneDep,
            this.tlcolIsChain,
            this.tlcolIsChainSaw,
            this.tlcolIsChainCut,
            this.tlcolIsChainPackage,
            this.tlcolIsWarehouse,
            this.tlcolIsLocalDep,
            this.tlcolSort});
            this.treeList1.ImageIndexFieldName = "0";
            this.treeList1.KeyFieldName = "DepID";
            this.treeList1.Location = new System.Drawing.Point(7, 31);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsNavigation.EnterMovesNextColumn = true;
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rItemBTAudio,
            this.repositoryItemSpinEdit1});
            this.treeList1.Size = new System.Drawing.Size(830, 564);
            this.treeList1.TabIndex = 4;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.treeList1.FocusedColumnChanged += new DevExpress.XtraTreeList.FocusedColumnChangedEventHandler(this.treeList1_FocusedColumnChanged);
            this.treeList1.CustomDrawNodeButton += new DevExpress.XtraTreeList.CustomDrawNodeButtonEventHandler(this.treeList1_CustomDrawNodeButton);
            this.treeList1.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler(this.treeList1_CellValueChanged);
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            // 
            // tlcolDepID
            // 
            this.tlcolDepID.Caption = "Mã";
            this.tlcolDepID.FieldName = "DepID";
            this.tlcolDepID.Name = "tlcolDepID";
            this.tlcolDepID.Visible = true;
            this.tlcolDepID.VisibleIndex = 0;
            this.tlcolDepID.Width = 118;
            // 
            // tlcolDepName
            // 
            this.tlcolDepName.Caption = "Phòng ban";
            this.tlcolDepName.FieldName = "DepName";
            this.tlcolDepName.Name = "tlcolDepName";
            this.tlcolDepName.Visible = true;
            this.tlcolDepName.VisibleIndex = 1;
            this.tlcolDepName.Width = 198;
            // 
            // tlcolNoWorked
            // 
            this.tlcolNoWorked.Caption = "Số NV";
            this.tlcolNoWorked.ColumnEdit = this.repositoryItemSpinEdit1;
            this.tlcolNoWorked.FieldName = "NoWorked";
            this.tlcolNoWorked.Name = "tlcolNoWorked";
            this.tlcolNoWorked.Visible = true;
            this.tlcolNoWorked.VisibleIndex = 2;
            this.tlcolNoWorked.Width = 80;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // tlcolParentID
            // 
            this.tlcolParentID.Caption = "ParentID";
            this.tlcolParentID.FieldName = "ParentID";
            this.tlcolParentID.Name = "tlcolParentID";
            // 
            // tlcolPhoneDep
            // 
            this.tlcolPhoneDep.Caption = "Số điện thoại";
            this.tlcolPhoneDep.FieldName = "PhoneDep";
            this.tlcolPhoneDep.Name = "tlcolPhoneDep";
            this.tlcolPhoneDep.Visible = true;
            this.tlcolPhoneDep.VisibleIndex = 3;
            this.tlcolPhoneDep.Width = 126;
            // 
            // tlcolIsChain
            // 
            this.tlcolIsChain.Caption = "Sản xuất";
            this.tlcolIsChain.FieldName = "IsChain";
            this.tlcolIsChain.Name = "tlcolIsChain";
            this.tlcolIsChain.Visible = true;
            this.tlcolIsChain.VisibleIndex = 4;
            this.tlcolIsChain.Width = 104;
            // 
            // tlcolIsChainSaw
            // 
            this.tlcolIsChainSaw.Caption = "Nhóm may";
            this.tlcolIsChainSaw.FieldName = "IsChainSaw";
            this.tlcolIsChainSaw.Name = "tlcolIsChainSaw";
            this.tlcolIsChainSaw.Width = 60;
            // 
            // tlcolIsChainCut
            // 
            this.tlcolIsChainCut.Caption = "Nhóm cắt";
            this.tlcolIsChainCut.FieldName = "IsChainCut";
            this.tlcolIsChainCut.Name = "tlcolIsChainCut";
            this.tlcolIsChainCut.Width = 60;
            // 
            // tlcolIsChainPackage
            // 
            this.tlcolIsChainPackage.Caption = "Nhóm Đóng thùng";
            this.tlcolIsChainPackage.FieldName = "IsChainPackage";
            this.tlcolIsChainPackage.Name = "tlcolIsChainPackage";
            this.tlcolIsChainPackage.Width = 60;
            // 
            // tlcolIsWarehouse
            // 
            this.tlcolIsWarehouse.Caption = "Kho";
            this.tlcolIsWarehouse.FieldName = "IsWarehouse";
            this.tlcolIsWarehouse.Name = "tlcolIsWarehouse";
            this.tlcolIsWarehouse.Visible = true;
            this.tlcolIsWarehouse.VisibleIndex = 6;
            this.tlcolIsWarehouse.Width = 85;
            // 
            // tlcolIsLocalDep
            // 
            this.tlcolIsLocalDep.Caption = "Đ. vị nội bộ";
            this.tlcolIsLocalDep.FieldName = "IsLocalDep";
            this.tlcolIsLocalDep.Name = "tlcolIsLocalDep";
            this.tlcolIsLocalDep.Visible = true;
            this.tlcolIsLocalDep.VisibleIndex = 5;
            this.tlcolIsLocalDep.Width = 98;
            // 
            // tlcolSort
            // 
            this.tlcolSort.Caption = "Sort";
            this.tlcolSort.FieldName = "Sort";
            this.tlcolSort.Name = "tlcolSort";
            // 
            // rItemBTAudio
            // 
            this.rItemBTAudio.AutoHeight = false;
            this.rItemBTAudio.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.rItemBTAudio.Name = "rItemBTAudio";
            this.rItemBTAudio.NullText = "Chọn file âm thanh";
            this.rItemBTAudio.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(844, 602);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeList1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(834, 568);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(834, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
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
            this.btAdd,
            this.btEdit,
            this.btDelete,
            this.btSave,
            this.btCancel});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btCancel)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btAdd
            // 
            this.btAdd.Caption = "Thêm";
            this.btAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("btAdd.Glyph")));
            this.btAdd.Id = 0;
            this.btAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btAdd.LargeGlyph")));
            this.btAdd.Name = "btAdd";
            this.btAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btAdd_ItemClick);
            // 
            // btEdit
            // 
            this.btEdit.Caption = "Sửa";
            this.btEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("btEdit.Glyph")));
            this.btEdit.Id = 1;
            this.btEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btEdit.LargeGlyph")));
            this.btEdit.Name = "btEdit";
            this.btEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btEdit_ItemClick);
            // 
            // btDelete
            // 
            this.btDelete.Caption = "Xóa";
            this.btDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btDelete.Glyph")));
            this.btDelete.Id = 2;
            this.btDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btDelete.LargeGlyph")));
            this.btDelete.Name = "btDelete";
            this.btDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btDelete_ItemClick);
            // 
            // btSave
            // 
            this.btSave.Caption = "Lưu";
            this.btSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btSave.Glyph")));
            this.btSave.Id = 3;
            this.btSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btSave.LargeGlyph")));
            this.btSave.Name = "btSave";
            this.btSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSave_ItemClick);
            // 
            // btCancel
            // 
            this.btCancel.Caption = "Nạp lại";
            this.btCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("btCancel.Glyph")));
            this.btCancel.Id = 4;
            this.btCancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btCancel.LargeGlyph")));
            this.btCancel.Name = "btCancel";
            this.btCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btCancel_ItemClick);
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Lime;
            this.barAndDockingController1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.barAndDockingController1.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.barAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(844, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 631);
            this.barDockControlBottom.Size = new System.Drawing.Size(844, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 602);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(844, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 602);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 631);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmDepartment";
            this.Text = "Đơn vị- phòng ban";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbsaw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rItemBTAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit cbService;
        private DevExpress.XtraEditors.CheckEdit cbPack;
        private DevExpress.XtraEditors.CheckEdit cbCut;
        private DevExpress.XtraEditors.CheckEdit cbsaw;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolDepName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolParentID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolPhoneDep;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolIsChain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolIsChainSaw;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolIsChainCut;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolIsChainPackage;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolIsWarehouse;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolIsLocalDep;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolSort;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rItemBTAudio;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolDepID;
        private DevExpress.XtraEditors.LabelControl lbGroup;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcolNoWorked;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btAdd;
        private DevExpress.XtraBars.BarButtonItem btEdit;
        private DevExpress.XtraBars.BarButtonItem btDelete;
        private DevExpress.XtraBars.BarButtonItem btSave;
        private DevExpress.XtraBars.BarButtonItem btCancel;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;

    }
}