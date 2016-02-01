namespace ControlLaboratorio
{
  partial class FormLaboratorio
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaboratorio));
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
      this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
      this.buttonEd = new DevExpress.XtraEditors.SimpleButton();
      this.buttonInserir = new DevExpress.XtraEditors.SimpleButton();
      this.buttonEx = new DevExpress.XtraEditors.SimpleButton();
      this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
      this.buttonMin = new DevExpress.XtraEditors.SimpleButton();
      this.buttonMax = new DevExpress.XtraEditors.SimpleButton();
      this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
      this.gridLaboratorios = new DevExpress.XtraGrid.GridControl();
      this.gridViewLaboratorio = new DevExpress.XtraGrid.Views.Grid.GridView();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
      this.panelControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridLaboratorios)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewLaboratorio)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray;
      this.labelControl1.Location = new System.Drawing.Point(3, 3);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(71, 15);
      this.labelControl1.TabIndex = 13;
      this.labelControl1.Text = "Laboratórios";
      // 
      // toolTip
      // 
      this.toolTip.AutoPopDelay = 5000;
      this.toolTip.InitialDelay = 0;
      this.toolTip.IsBalloon = true;
      this.toolTip.ReshowDelay = 100;
      // 
      // panelControl2
      // 
      this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelControl2.Appearance.BackColor = System.Drawing.Color.DimGray;
      this.panelControl2.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.panelControl2.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.panelControl2.Appearance.Options.UseBackColor = true;
      this.panelControl2.Appearance.Options.UseBorderColor = true;
      this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelControl2.Controls.Add(this.pictureEdit1);
      this.panelControl2.Controls.Add(this.buttonEd);
      this.panelControl2.Controls.Add(this.buttonInserir);
      this.panelControl2.Controls.Add(this.buttonEx);
      this.panelControl2.Location = new System.Drawing.Point(0, 43);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new System.Drawing.Size(800, 55);
      this.panelControl2.TabIndex = 14;
      // 
      // pictureEdit1
      // 
      this.pictureEdit1.EditValue = global::ControlLaboratorio.Properties.Resources.logoEnt;
      this.pictureEdit1.Location = new System.Drawing.Point(70, -41);
      this.pictureEdit1.Name = "pictureEdit1";
      this.pictureEdit1.Properties.AllowFocused = false;
      this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.pictureEdit1.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.pictureEdit1.Properties.ShowMenu = false;
      this.pictureEdit1.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
      this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
      this.pictureEdit1.Size = new System.Drawing.Size(72, 78);
      this.pictureEdit1.TabIndex = 15;
      // 
      // buttonEd
      // 
      this.buttonEd.AllowFocus = false;
      this.buttonEd.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.buttonEd.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.buttonEd.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.buttonEd.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.buttonEd.Appearance.ForeColor = System.Drawing.Color.White;
      this.buttonEd.Appearance.Options.UseBackColor = true;
      this.buttonEd.Appearance.Options.UseBorderColor = true;
      this.buttonEd.Appearance.Options.UseFont = true;
      this.buttonEd.Appearance.Options.UseForeColor = true;
      this.buttonEd.Appearance.Options.UseTextOptions = true;
      this.buttonEd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.buttonEd.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.buttonEd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEd.BackgroundImage")));
      this.buttonEd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.buttonEd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
      this.buttonEd.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonEd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.buttonEd.Location = new System.Drawing.Point(257, 12);
      this.buttonEd.Name = "buttonEd";
      this.buttonEd.Size = new System.Drawing.Size(85, 30);
      this.buttonEd.TabIndex = 2;
      this.buttonEd.Text = "Editar";
      this.buttonEd.Click += new System.EventHandler(this.buttonEd_Click);
      // 
      // buttonInserir
      // 
      this.buttonInserir.AllowFocus = false;
      this.buttonInserir.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.buttonInserir.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.buttonInserir.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.buttonInserir.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.buttonInserir.Appearance.ForeColor = System.Drawing.Color.White;
      this.buttonInserir.Appearance.Options.UseBackColor = true;
      this.buttonInserir.Appearance.Options.UseBorderColor = true;
      this.buttonInserir.Appearance.Options.UseFont = true;
      this.buttonInserir.Appearance.Options.UseForeColor = true;
      this.buttonInserir.Appearance.Options.UseTextOptions = true;
      this.buttonInserir.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.buttonInserir.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.buttonInserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInserir.BackgroundImage")));
      this.buttonInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.buttonInserir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
      this.buttonInserir.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonInserir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.buttonInserir.Location = new System.Drawing.Point(146, 12);
      this.buttonInserir.Name = "buttonInserir";
      this.buttonInserir.Size = new System.Drawing.Size(85, 30);
      this.buttonInserir.TabIndex = 1;
      this.buttonInserir.Text = "Inserir";
      this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
      // 
      // buttonEx
      // 
      this.buttonEx.AllowFocus = false;
      this.buttonEx.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.buttonEx.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.buttonEx.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.buttonEx.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.buttonEx.Appearance.ForeColor = System.Drawing.Color.White;
      this.buttonEx.Appearance.Options.UseBackColor = true;
      this.buttonEx.Appearance.Options.UseBorderColor = true;
      this.buttonEx.Appearance.Options.UseFont = true;
      this.buttonEx.Appearance.Options.UseForeColor = true;
      this.buttonEx.Appearance.Options.UseTextOptions = true;
      this.buttonEx.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.buttonEx.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.buttonEx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEx.BackgroundImage")));
      this.buttonEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.buttonEx.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
      this.buttonEx.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonEx.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.buttonEx.Location = new System.Drawing.Point(368, 12);
      this.buttonEx.Name = "buttonEx";
      this.buttonEx.Size = new System.Drawing.Size(85, 30);
      this.buttonEx.TabIndex = 3;
      this.buttonEx.Text = "Excluir";
      this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
      // 
      // pictureEdit
      // 
      this.pictureEdit.EditValue = global::ControlLaboratorio.Properties.Resources.logoEnt;
      this.pictureEdit.Location = new System.Drawing.Point(70, 2);
      this.pictureEdit.Name = "pictureEdit";
      this.pictureEdit.Properties.AllowFocused = false;
      this.pictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.pictureEdit.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.pictureEdit.Properties.Appearance.Options.UseBackColor = true;
      this.pictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.pictureEdit.Properties.ShowMenu = false;
      this.pictureEdit.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
      this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
      this.pictureEdit.Size = new System.Drawing.Size(72, 78);
      this.pictureEdit.TabIndex = 15;
      // 
      // buttonMin
      // 
      this.buttonMin.AllowFocus = false;
      this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonMin.Appearance.BackColor = System.Drawing.Color.Gray;
      this.buttonMin.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.buttonMin.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.buttonMin.Appearance.Options.UseBackColor = true;
      this.buttonMin.Appearance.Options.UseBorderColor = true;
      this.buttonMin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
      this.buttonMin.Image = global::ControlLaboratorio.Properties.Resources.minimizar;
      this.buttonMin.ImageIndex = 0;
      this.buttonMin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.buttonMin.Location = new System.Drawing.Point(723, 0);
      this.buttonMin.Name = "buttonMin";
      this.buttonMin.Size = new System.Drawing.Size(26, 18);
      this.buttonMin.TabIndex = 18;
      this.buttonMin.TabStop = false;
      this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
      // 
      // buttonMax
      // 
      this.buttonMax.AllowFocus = false;
      this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonMax.Appearance.BackColor = System.Drawing.Color.Gray;
      this.buttonMax.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.buttonMax.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.buttonMax.Appearance.Options.UseBackColor = true;
      this.buttonMax.Appearance.Options.UseBorderColor = true;
      this.buttonMax.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
      this.buttonMax.Image = global::ControlLaboratorio.Properties.Resources.maximizar;
      this.buttonMax.ImageIndex = 0;
      this.buttonMax.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.buttonMax.Location = new System.Drawing.Point(748, 0);
      this.buttonMax.Name = "buttonMax";
      this.buttonMax.Size = new System.Drawing.Size(26, 18);
      this.buttonMax.TabIndex = 17;
      this.buttonMax.TabStop = false;
      this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
      // 
      // buttonClose
      // 
      this.buttonClose.AllowFocus = false;
      this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonClose.Appearance.BackColor = System.Drawing.Color.Gray;
      this.buttonClose.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.buttonClose.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.buttonClose.Appearance.Options.UseBackColor = true;
      this.buttonClose.Appearance.Options.UseBorderColor = true;
      this.buttonClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
      this.buttonClose.Image = global::ControlLaboratorio.Properties.Resources.fechar;
      this.buttonClose.ImageIndex = 0;
      this.buttonClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.buttonClose.Location = new System.Drawing.Point(773, 0);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(26, 18);
      this.buttonClose.TabIndex = 16;
      this.buttonClose.TabStop = false;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // gridLaboratorios
      // 
      this.gridLaboratorios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridLaboratorios.Cursor = System.Windows.Forms.Cursors.Default;
      this.gridLaboratorios.Location = new System.Drawing.Point(0, 124);
      this.gridLaboratorios.MainView = this.gridViewLaboratorio;
      this.gridLaboratorios.Name = "gridLaboratorios";
      this.gridLaboratorios.Size = new System.Drawing.Size(800, 376);
      this.gridLaboratorios.TabIndex = 19;
      this.gridLaboratorios.TabStop = false;
      this.gridLaboratorios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLaboratorio});
      this.gridLaboratorios.DoubleClick += new System.EventHandler(this.gridLaboratorios_DoubleClick);
      // 
      // gridViewLaboratorio
      // 
      this.gridViewLaboratorio.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightBlue;
      this.gridViewLaboratorio.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.LightBlue;
      this.gridViewLaboratorio.Appearance.FocusedCell.Options.UseBackColor = true;
      this.gridViewLaboratorio.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightBlue;
      this.gridViewLaboratorio.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightBlue;
      this.gridViewLaboratorio.Appearance.FocusedRow.Options.UseBackColor = true;
      this.gridViewLaboratorio.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
      this.gridViewLaboratorio.GridControl = this.gridLaboratorios;
      this.gridViewLaboratorio.Name = "gridViewLaboratorio";
      this.gridViewLaboratorio.OptionsBehavior.Editable = false;
      this.gridViewLaboratorio.OptionsView.ShowGroupPanel = false;
      this.gridViewLaboratorio.OptionsView.ShowIndicator = false;
      // 
      // FormLaboratorio
      // 
      this.ActiveGlowColor = System.Drawing.Color.Transparent;
      this.Appearance.BackColor = System.Drawing.Color.White;
      this.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.Appearance.FontStyleDelta = System.Drawing.FontStyle.Italic;
      this.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
      this.Appearance.Options.UseBackColor = true;
      this.Appearance.Options.UseBorderColor = true;
      this.Appearance.Options.UseFont = true;
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(800, 500);
      this.Controls.Add(this.gridLaboratorios);
      this.Controls.Add(this.buttonMin);
      this.Controls.Add(this.buttonMax);
      this.Controls.Add(this.buttonClose);
      this.Controls.Add(this.panelControl2);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.pictureEdit);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "FormLaboratorio";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Usuarios";
      this.Load += new System.EventHandler(this.FormLaboratorio_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLaboratorio_KeyDown);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLaboratorio_MouseDown);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
      this.panelControl2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridLaboratorios)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewLaboratorio)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.LabelControl labelControl1;
    private System.Windows.Forms.ToolTip toolTip;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    private DevExpress.XtraEditors.SimpleButton buttonEd;
    private DevExpress.XtraEditors.SimpleButton buttonInserir;
    private DevExpress.XtraEditors.SimpleButton buttonEx;
    private DevExpress.XtraEditors.PictureEdit pictureEdit;
    private DevExpress.XtraEditors.SimpleButton buttonMin;
    private DevExpress.XtraEditors.SimpleButton buttonMax;
    private DevExpress.XtraEditors.SimpleButton buttonClose;
    private DevExpress.XtraGrid.GridControl gridLaboratorios;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewLaboratorio;

  }
}

