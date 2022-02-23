namespace NtbSoft.ERP.Win.Modules.DicForm
{
    partial class frmDicInitialize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDicInitialize));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemChungLoai = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemNhom = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemKho = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemDepartment = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(924, 643);
            this.splitContainerControl1.SplitterPosition = 220;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemDepartment,
            this.navBarItemChungLoai,
            this.navBarItemNhom,
            this.navBarItemKho});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.navBarControl1.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.navBarControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 220;
            this.navBarControl1.Size = new System.Drawing.Size(220, 643);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Caption = "Đặc điểm sản phẩm";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.LargeImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemChungLoai),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemNhom),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemKho)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItemChungLoai
            // 
            this.navBarItemChungLoai.Caption = "Chủng loại";
            this.navBarItemChungLoai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemChungLoai.ImageOptions.LargeImage")));
            this.navBarItemChungLoai.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemChungLoai.ImageOptions.SmallImage")));
            this.navBarItemChungLoai.Name = "navBarItemChungLoai";
         
            // 
            // navBarItemNhom
            // 
            this.navBarItemNhom.Caption = "Nhóm";
            this.navBarItemNhom.ImageOptions.SmallImage = global::NtbSoft.ERP.Win.Properties.Resources.chartsshowlegend_16x16;
            this.navBarItemNhom.Name = "navBarItemNhom";
           
            // 
            // navBarItemKho
            // 
            this.navBarItemKho.Caption = "Kho";
            this.navBarItemKho.ImageOptions.SmallImage = global::NtbSoft.ERP.Win.Properties.Resources.chartsshowlegend_16x16;
            this.navBarItemKho.Name = "navBarItemKho";

            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup2.Appearance.Options.UseFont = true;
            this.navBarGroup2.Caption = "Cơ cấu tổ chức";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.ImageOptions.LargeImage")));
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDepartment)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItemDepartment
            // 
            this.navBarItemDepartment.Caption = "Phòng ban";
            this.navBarItemDepartment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDepartment.ImageOptions.LargeImage")));
            this.navBarItemDepartment.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemDepartment.ImageOptions.SmallImage")));
            this.navBarItemDepartment.Name = "navBarItemDepartment";
   
            // 
            // frmDicInitialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 643);
            this.Controls.Add(this.splitContainerControl1);
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmDicInitialize";
            this.Text = "Thiết lập";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDepartment;
        private DevExpress.XtraNavBar.NavBarItem navBarItemChungLoai;
        private DevExpress.XtraNavBar.NavBarItem navBarItemNhom;
        private DevExpress.XtraNavBar.NavBarItem navBarItemKho;
    }
}