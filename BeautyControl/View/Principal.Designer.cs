namespace BeautyControl.View
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BeautyControl.View.WaitForm1), true, true);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.tileNavCategory3 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.tileNavItem1 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavSubItem2 = new DevExpress.XtraBars.Navigation.TileNavSubItem();
            this.tileNavItem2 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem3 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.panelDeViews = new System.Windows.Forms.Panel();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tileNavPane1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDeViews, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 498);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.tileNavPane1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tileNavPane1.Appearance.Options.UseBackColor = true;
            this.tileNavPane1.Appearance.Options.UseFont = true;
            this.tileNavPane1.AppearanceHovered.BackColor = System.Drawing.Color.Brown;
            this.tileNavPane1.AppearanceHovered.Options.UseBackColor = true;
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.tileNavCategory3);
            this.tileNavPane1.Buttons.Add(this.navButton2);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileNavPane1.Location = new System.Drawing.Point(3, 3);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(702, 48);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // tileNavCategory3
            // 
            this.tileNavCategory3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavCategory3.Caption = "tileNavCategory3";
            this.tileNavCategory3.Glyph = ((System.Drawing.Image)(resources.GetObject("tileNavCategory3.Glyph")));
            this.tileNavCategory3.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.tileNavItem1,
            this.tileNavItem2,
            this.tileNavItem3});
            this.tileNavCategory3.Name = "tileNavCategory3";
            this.tileNavCategory3.OptionsDropDown.AppearanceItem.Normal.BackColor = System.Drawing.Color.Crimson;
            this.tileNavCategory3.OptionsDropDown.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileNavCategory3.OptionsDropDown.BackColor = System.Drawing.Color.Firebrick;
            this.tileNavCategory3.OwnerCollection = null;
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "dfdggdfdgdgdgdgdgdfgdgf";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "srerte";
            toolTipTitleItem2.LeftIndent = 6;
            toolTipTitleItem2.Text = "tetete";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipSeparatorItem1);
            superToolTip1.Items.Add(toolTipTitleItem2);
            this.tileNavCategory3.SuperTip = superToolTip1;
            // 
            // 
            // 
            this.tileNavCategory3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavCategory3.Tile.EnableItemDoubleClickEvent = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavCategory3.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileNavCategory3.Tile.ShowDropDownButton = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavCategory3.Visible = false;
            // 
            // tileNavItem1
            // 
            this.tileNavItem1.Caption = "tileNavItem1";
            this.tileNavItem1.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.tileNavItem1.Name = "tileNavItem1";
            this.tileNavItem1.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem1.OwnerCollection = this.tileNavCategory3.Items;
            this.tileNavItem1.SubItems.AddRange(new DevExpress.XtraBars.Navigation.TileNavSubItem[] {
            this.tileNavSubItem2});
            // 
            // 
            // 
            this.tileNavItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = global::BeautyControl.Properties.Resources.apply_32x32;
            tileItemElement2.Text = "tileNavItem1";
            this.tileNavItem1.Tile.Elements.Add(tileItemElement2);
            this.tileNavItem1.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem1.Tile.Name = "tileBarItem1";
            // 
            // tileNavSubItem2
            // 
            this.tileNavSubItem2.Caption = "Teste";
            this.tileNavSubItem2.Name = "tileNavSubItem2";
            this.tileNavSubItem2.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            // 
            // 
            // 
            this.tileNavSubItem2.Tile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavSubItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "Teste";
            this.tileNavSubItem2.Tile.Elements.Add(tileItemElement1);
            this.tileNavSubItem2.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileNavSubItem2.Tile.Name = "tileBarItem1";
            // 
            // tileNavItem2
            // 
            this.tileNavItem2.Caption = "tileNavItem2";
            this.tileNavItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("tileNavItem2.Glyph")));
            this.tileNavItem2.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.tileNavItem2.Name = "tileNavItem2";
            this.tileNavItem2.OptionsDropDown.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavItem2.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem2.OptionsDropDown.CloseOnOuterClick = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavItem2.OptionsDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavItem2.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // 
            // 
            this.tileNavItem2.Tile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavItem2.Tile.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tileNavItem2.Tile.AppearanceItem.Normal.Options.UseFont = true;
            this.tileNavItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.Text = "tileNavItem2";
            this.tileNavItem2.Tile.Elements.Add(tileItemElement3);
            this.tileNavItem2.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem2.Tile.Name = "tileBarItem1";
            // 
            // tileNavItem3
            // 
            this.tileNavItem3.Caption = "tileNavItem3";
            this.tileNavItem3.Name = "tileNavItem3";
            this.tileNavItem3.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem3.OptionsDropDown.CloseOnOuterClick = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavItem3.OwnerCollection = this.tileNavCategory3.Items;
            // 
            // 
            // 
            this.tileNavItem3.Tile.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.tileNavItem3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "tileNavItem3";
            this.tileNavItem3.Tile.Elements.Add(tileItemElement4);
            this.tileNavItem3.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem3.Tile.Name = "tileBarItem2";
            // 
            // navButton2
            // 
            this.navButton2.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navButton2.Appearance.BackColor = System.Drawing.Color.White;
            this.navButton2.Appearance.BackColor2 = System.Drawing.Color.White;
            this.navButton2.Appearance.BorderColor = System.Drawing.Color.White;
            this.navButton2.Appearance.Options.UseBackColor = true;
            this.navButton2.Appearance.Options.UseBorderColor = true;
            this.navButton2.Caption = "";
            this.navButton2.Enabled = false;
            this.navButton2.Glyph = ((System.Drawing.Image)(resources.GetObject("navButton2.Glyph")));
            this.navButton2.Name = "navButton2";
            // 
            // panelDeViews
            // 
            this.panelDeViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeViews.Location = new System.Drawing.Point(3, 57);
            this.panelDeViews.Name = "panelDeViews";
            this.panelDeViews.Size = new System.Drawing.Size(702, 438);
            this.panelDeViews.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
       // private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        public DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory3;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem1;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem2;
        private DevExpress.XtraBars.Navigation.TileNavSubItem tileNavSubItem2;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        public System.Windows.Forms.Panel panelDeViews;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem3;
        public DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}