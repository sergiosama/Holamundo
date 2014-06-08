namespace DXHolaMundo
{
  partial class frmMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.rbnGrp1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
      this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
      this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbon
      // 
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonGroup1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barCheckItem1,
            this.barHeaderItem1});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.MaxItemId = 5;
      this.ribbon.Name = "ribbon";
      this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbon.Size = new System.Drawing.Size(983, 144);
      this.ribbon.StatusBar = this.ribbonStatusBar;
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnGrp1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ribbonPage1";
      // 
      // rbnGrp1
      // 
      this.rbnGrp1.ItemLinks.Add(this.barButtonGroup1);
      this.rbnGrp1.ItemLinks.Add(this.barButtonItem2);
      this.rbnGrp1.Name = "rbnGrp1";
      this.rbnGrp1.Text = "Grupo A";
      // 
      // ribbonStatusBar
      // 
      this.ribbonStatusBar.Location = new System.Drawing.Point(0, 585);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new System.Drawing.Size(983, 31);
      // 
      // barButtonGroup1
      // 
      this.barButtonGroup1.Caption = "barButtonGroup1";
      this.barButtonGroup1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
      this.barButtonGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonGroup1.Glyph")));
      this.barButtonGroup1.Id = 1;
      this.barButtonGroup1.ItemLinks.Add(this.barButtonItem4);
      this.barButtonGroup1.ItemLinks.Add(this.barButtonItem5);
      this.barButtonGroup1.ItemLinks.Add(this.barCheckItem1);
      this.barButtonGroup1.ItemLinks.Add(this.barHeaderItem1);
      this.barButtonGroup1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonGroup1.LargeGlyph")));
      this.barButtonGroup1.Name = "barButtonGroup1";
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "barButtonItem1";
      this.barButtonItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
      this.barButtonItem1.Id = 2;
      this.barButtonItem1.Name = "barButtonItem1";
      // 
      // barButtonItem2
      // 
      this.barButtonItem2.Caption = "barButtonItem2";
      this.barButtonItem2.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
      this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
      this.barButtonItem2.Id = 3;
      this.barButtonItem2.Name = "barButtonItem2";
      // 
      // barButtonItem3
      // 
      this.barButtonItem3.Caption = "barButtonItem3";
      this.barButtonItem3.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
      this.barButtonItem3.Id = 4;
      this.barButtonItem3.Name = "barButtonItem3";
      // 
      // barButtonItem4
      // 
      this.barButtonItem4.Caption = "barButtonItem4";
      this.barButtonItem4.Id = 1;
      this.barButtonItem4.Name = "barButtonItem4";
      // 
      // barButtonItem5
      // 
      this.barButtonItem5.Caption = "barButtonItem5";
      this.barButtonItem5.Id = 2;
      this.barButtonItem5.Name = "barButtonItem5";
      // 
      // barCheckItem1
      // 
      this.barCheckItem1.Caption = "barCheckItem1";
      this.barCheckItem1.Id = 3;
      this.barCheckItem1.Name = "barCheckItem1";
      // 
      // barHeaderItem1
      // 
      this.barHeaderItem1.Caption = "barHeaderItem1";
      this.barHeaderItem1.Id = 4;
      this.barHeaderItem1.Name = "barHeaderItem1";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(983, 616);
      this.Controls.Add(this.ribbonStatusBar);
      this.Controls.Add(this.ribbon);
      this.Name = "frmMain";
      this.Ribbon = this.ribbon;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "frmMain";
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnGrp1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    private DevExpress.XtraBars.BarCheckItem barCheckItem1;
    private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
  }
}