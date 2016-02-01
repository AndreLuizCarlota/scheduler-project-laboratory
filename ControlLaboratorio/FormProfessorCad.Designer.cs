namespace ControlLaboratorio
{
  partial class FormProfessorCad
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfessorCad));
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.textNome = new DevExpress.XtraEditors.TextEdit();
      this.dsProf = new System.Data.DataSet();
      this.bsProf = new System.Windows.Forms.BindingSource(this.components);
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.buttonMin = new DevExpress.XtraEditors.SimpleButton();
      this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.buttonGravar = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.textNome.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsProf)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsProf)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
      this.panelControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
      this.labelControl1.Location = new System.Drawing.Point(83, 106);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(31, 15);
      this.labelControl1.TabIndex = 2;
      this.labelControl1.Text = "Nome";
      // 
      // textNome
      // 
      this.textNome.Location = new System.Drawing.Point(120, 103);
      this.textNome.Name = "textNome";
      this.textNome.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.textNome.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.textNome.Properties.Appearance.Options.UseFont = true;
      this.textNome.Properties.Appearance.Options.UseForeColor = true;
      this.textNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.textNome.Size = new System.Drawing.Size(598, 22);
      this.textNome.TabIndex = 0;
      // 
      // dsProf
      // 
      this.dsProf.DataSetName = "NewDataSet";
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
      this.panelControl2.Appearance.BackColor = System.Drawing.Color.DimGray;
      this.panelControl2.Appearance.BackColor2 = System.Drawing.Color.DimGray;
      this.panelControl2.Appearance.Options.UseBackColor = true;
      this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelControl2.Controls.Add(this.labelControl4);
      this.panelControl2.Controls.Add(this.buttonMin);
      this.panelControl2.Controls.Add(this.buttonClose);
      this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelControl2.Location = new System.Drawing.Point(0, 0);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new System.Drawing.Size(800, 19);
      this.panelControl2.TabIndex = 18;
      this.panelControl2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl2_MouseDown);
      // 
      // labelControl4
      // 
      this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
      this.labelControl4.Location = new System.Drawing.Point(5, 1);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(111, 15);
      this.labelControl4.TabIndex = 16;
      this.labelControl4.Text = "Cadastrar Professor";
      // 
      // buttonMin
      // 
      this.buttonMin.AllowFocus = false;
      this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonMin.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.buttonMin.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.buttonMin.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.buttonMin.Appearance.Options.UseBackColor = true;
      this.buttonMin.Appearance.Options.UseBorderColor = true;
      this.buttonMin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
      this.buttonMin.Image = global::ControlLaboratorio.Properties.Resources.minimizar;
      this.buttonMin.ImageIndex = 0;
      this.buttonMin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.buttonMin.Location = new System.Drawing.Point(749, 0);
      this.buttonMin.Name = "buttonMin";
      this.buttonMin.Size = new System.Drawing.Size(26, 18);
      this.buttonMin.TabIndex = 16;
      this.buttonMin.TabStop = false;
      this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
      // 
      // buttonClose
      // 
      this.buttonClose.AllowFocus = false;
      this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonClose.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.buttonClose.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.buttonClose.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.buttonClose.Appearance.Options.UseBackColor = true;
      this.buttonClose.Appearance.Options.UseBorderColor = true;
      this.buttonClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
      this.buttonClose.Image = global::ControlLaboratorio.Properties.Resources.fechar;
      this.buttonClose.ImageIndex = 0;
      this.buttonClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.buttonClose.Location = new System.Drawing.Point(774, 0);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(26, 18);
      this.buttonClose.TabIndex = 14;
      this.buttonClose.TabStop = false;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // panelControl1
      // 
      this.panelControl1.Appearance.BackColor = System.Drawing.Color.DimGray;
      this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.panelControl1.Appearance.Options.UseBackColor = true;
      this.panelControl1.Appearance.Options.UseBorderColor = true;
      this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControl1.Location = new System.Drawing.Point(0, 165);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(800, 6);
      this.panelControl1.TabIndex = 19;
      this.panelControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl2_MouseDown);
      // 
      // buttonGravar
      // 
      this.buttonGravar.AllowFocus = false;
      this.buttonGravar.Appearance.BackColor = System.Drawing.Color.DimGray;
      this.buttonGravar.Appearance.BackColor2 = System.Drawing.Color.Gray;
      this.buttonGravar.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.buttonGravar.Appearance.ForeColor = System.Drawing.Color.White;
      this.buttonGravar.Appearance.Options.UseBackColor = true;
      this.buttonGravar.Appearance.Options.UseBorderColor = true;
      this.buttonGravar.Appearance.Options.UseForeColor = true;
      this.buttonGravar.Appearance.Options.UseTextOptions = true;
      this.buttonGravar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.buttonGravar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
      this.buttonGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.buttonGravar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
      this.buttonGravar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonGravar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGravar.Image")));
      this.buttonGravar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.buttonGravar.Location = new System.Drawing.Point(11, 32);
      this.buttonGravar.Name = "buttonGravar";
      this.buttonGravar.Size = new System.Drawing.Size(50, 50);
      this.buttonGravar.TabIndex = 20;
      this.buttonGravar.Text = "Gravar";
      this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
      // 
      // FormProfessorCad
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
      this.ClientSize = new System.Drawing.Size(800, 171);
      this.Controls.Add(this.buttonGravar);
      this.Controls.Add(this.panelControl1);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.textNome);
      this.Controls.Add(this.panelControl2);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "FormProfessorCad";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Usuarios";
      this.Load += new System.EventHandler(this.FormProfessorCad_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProfessorCad_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.textNome.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsProf)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsProf)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource bsProf;
    private System.Data.DataSet dsProf;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.TextEdit textNome;
    private System.Windows.Forms.ToolTip toolTip;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.SimpleButton buttonMin;
    private DevExpress.XtraEditors.SimpleButton buttonClose;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.SimpleButton buttonGravar;

  }
}

