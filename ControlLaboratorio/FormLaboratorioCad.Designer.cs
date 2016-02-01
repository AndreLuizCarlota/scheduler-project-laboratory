namespace ControlLaboratorio
{
  partial class FormLaboratorioCad
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaboratorioCad));
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.textNome = new DevExpress.XtraEditors.TextEdit();
      this.dsLab = new System.Data.DataSet();
      this.bsLab = new System.Windows.Forms.BindingSource(this.components);
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.buttonGravar = new DevExpress.XtraEditors.SimpleButton();
      this.gridLaboratoriosCad = new DevExpress.XtraGrid.GridControl();
      this.gridViewLaboratorioCad = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
      this.buttonMin = new DevExpress.XtraEditors.SimpleButton();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
      this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
      this.buttonEx = new DevExpress.XtraEditors.SimpleButton();
      this.checkEditDomingo = new DevExpress.XtraEditors.CheckEdit();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.timeEditIntervalo = new DevExpress.XtraEditors.TimeEdit();
      this.timeEditTempoAula = new DevExpress.XtraEditors.TimeEdit();
      this.timeEditAte = new DevExpress.XtraEditors.TimeEdit();
      this.timeEditDe = new DevExpress.XtraEditors.TimeEdit();
      this.checkEditSabado = new DevExpress.XtraEditors.CheckEdit();
      this.checkEditSexta = new DevExpress.XtraEditors.CheckEdit();
      this.checkEditQuinta = new DevExpress.XtraEditors.CheckEdit();
      this.checkEditQuarta = new DevExpress.XtraEditors.CheckEdit();
      this.checkEditTerca = new DevExpress.XtraEditors.CheckEdit();
      this.checkEditSegunda = new DevExpress.XtraEditors.CheckEdit();
      this.buttonProcessar = new DevExpress.XtraEditors.SimpleButton();
      this.bsItLab = new System.Windows.Forms.BindingSource(this.components);
      this.dsItLab = new System.Data.DataSet();
      this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
      this.colorEditLab = new DevExpress.XtraEditors.ColorPickEdit();
      ((System.ComponentModel.ISupportInitialize)(this.textNome.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsLab)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsLab)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridLaboratoriosCad)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewLaboratorioCad)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
      this.panelControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
      this.panelControl3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditDomingo.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.timeEditIntervalo.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.timeEditTempoAula.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.timeEditAte.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.timeEditDe.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditSabado.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditSexta.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditQuinta.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditQuarta.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditTerca.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditSegunda.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsItLab)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsItLab)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.colorEditLab.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
      this.labelControl1.Location = new System.Drawing.Point(54, 107);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(31, 15);
      this.labelControl1.TabIndex = 2;
      this.labelControl1.Text = "Nome";
      // 
      // textNome
      // 
      this.textNome.Location = new System.Drawing.Point(93, 103);
      this.textNome.Name = "textNome";
      this.textNome.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.textNome.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.textNome.Properties.Appearance.Options.UseFont = true;
      this.textNome.Properties.Appearance.Options.UseForeColor = true;
      this.textNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.textNome.Size = new System.Drawing.Size(414, 22);
      this.textNome.TabIndex = 0;
      // 
      // dsLab
      // 
      this.dsLab.DataSetName = "NewDataSet";
      // 
      // toolTip
      // 
      this.toolTip.AutoPopDelay = 5000;
      this.toolTip.InitialDelay = 0;
      this.toolTip.IsBalloon = true;
      this.toolTip.ReshowDelay = 100;
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
      this.panelControl1.Location = new System.Drawing.Point(0, 373);
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
      this.buttonGravar.TabIndex = 200;
      this.buttonGravar.Text = "Gravar";
      this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
      // 
      // gridLaboratoriosCad
      // 
      this.gridLaboratoriosCad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridLaboratoriosCad.Cursor = System.Windows.Forms.Cursors.Default;
      this.gridLaboratoriosCad.Location = new System.Drawing.Point(0, 238);
      this.gridLaboratoriosCad.MainView = this.gridViewLaboratorioCad;
      this.gridLaboratoriosCad.Name = "gridLaboratoriosCad";
      this.gridLaboratoriosCad.Size = new System.Drawing.Size(800, 136);
      this.gridLaboratoriosCad.TabIndex = 21;
      this.gridLaboratoriosCad.TabStop = false;
      this.gridLaboratoriosCad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLaboratorioCad});
      // 
      // gridViewLaboratorioCad
      // 
      this.gridViewLaboratorioCad.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightBlue;
      this.gridViewLaboratorioCad.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.LightBlue;
      this.gridViewLaboratorioCad.Appearance.FocusedCell.Options.UseBackColor = true;
      this.gridViewLaboratorioCad.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightBlue;
      this.gridViewLaboratorioCad.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.LightBlue;
      this.gridViewLaboratorioCad.Appearance.FocusedRow.Options.UseBackColor = true;
      this.gridViewLaboratorioCad.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
      this.gridViewLaboratorioCad.GridControl = this.gridLaboratoriosCad;
      this.gridViewLaboratorioCad.Name = "gridViewLaboratorioCad";
      this.gridViewLaboratorioCad.OptionsBehavior.Editable = false;
      this.gridViewLaboratorioCad.OptionsView.ShowGroupPanel = false;
      this.gridViewLaboratorioCad.OptionsView.ShowIndicator = false;
      this.gridViewLaboratorioCad.PaintStyleName = "Skin";
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
      // labelControl4
      // 
      this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
      this.labelControl4.Location = new System.Drawing.Point(5, 1);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(123, 15);
      this.labelControl4.TabIndex = 16;
      this.labelControl4.Text = "Cadastrar Laboratório";
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
      // panelControl3
      // 
      this.panelControl3.Appearance.BackColor = System.Drawing.Color.DimGray;
      this.panelControl3.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.panelControl3.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.panelControl3.Appearance.Options.UseBackColor = true;
      this.panelControl3.Appearance.Options.UseBorderColor = true;
      this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelControl3.Controls.Add(this.buttonEx);
      this.panelControl3.Controls.Add(this.checkEditDomingo);
      this.panelControl3.Controls.Add(this.labelControl6);
      this.panelControl3.Controls.Add(this.labelControl5);
      this.panelControl3.Controls.Add(this.labelControl3);
      this.panelControl3.Controls.Add(this.labelControl2);
      this.panelControl3.Controls.Add(this.timeEditIntervalo);
      this.panelControl3.Controls.Add(this.timeEditTempoAula);
      this.panelControl3.Controls.Add(this.timeEditAte);
      this.panelControl3.Controls.Add(this.timeEditDe);
      this.panelControl3.Controls.Add(this.checkEditSabado);
      this.panelControl3.Controls.Add(this.checkEditSexta);
      this.panelControl3.Controls.Add(this.checkEditQuinta);
      this.panelControl3.Controls.Add(this.checkEditQuarta);
      this.panelControl3.Controls.Add(this.checkEditTerca);
      this.panelControl3.Controls.Add(this.checkEditSegunda);
      this.panelControl3.Controls.Add(this.buttonProcessar);
      this.panelControl3.Location = new System.Drawing.Point(0, 152);
      this.panelControl3.Name = "panelControl3";
      this.panelControl3.Size = new System.Drawing.Size(800, 87);
      this.panelControl3.TabIndex = 20;
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
      this.buttonEx.Location = new System.Drawing.Point(663, 45);
      this.buttonEx.Name = "buttonEx";
      this.buttonEx.Size = new System.Drawing.Size(125, 30);
      this.buttonEx.TabIndex = 27;
      this.buttonEx.TabStop = false;
      this.buttonEx.Text = "Excluir";
      this.buttonEx.ToolTip = "Excluir Horario";
      // 
      // checkEditDomingo
      // 
      this.checkEditDomingo.Location = new System.Drawing.Point(507, 53);
      this.checkEditDomingo.Name = "checkEditDomingo";
      this.checkEditDomingo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.checkEditDomingo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
      this.checkEditDomingo.Properties.Appearance.Options.UseFont = true;
      this.checkEditDomingo.Properties.Appearance.Options.UseForeColor = true;
      this.checkEditDomingo.Properties.Caption = "Domingo";
      this.checkEditDomingo.Size = new System.Drawing.Size(75, 19);
      this.checkEditDomingo.TabIndex = 100;
      // 
      // labelControl6
      // 
      this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
      this.labelControl6.Location = new System.Drawing.Point(494, 22);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(50, 15);
      this.labelControl6.TabIndex = 25;
      this.labelControl6.Text = "Intervalo";
      // 
      // labelControl5
      // 
      this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
      this.labelControl5.Location = new System.Drawing.Point(318, 22);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(80, 15);
      this.labelControl5.TabIndex = 24;
      this.labelControl5.Text = "Tempo de Aula";
      // 
      // labelControl3
      // 
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
      this.labelControl3.Location = new System.Drawing.Point(183, 22);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(17, 15);
      this.labelControl3.TabIndex = 23;
      this.labelControl3.Text = "Até";
      // 
      // labelControl2
      // 
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
      this.labelControl2.Location = new System.Drawing.Point(21, 22);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(75, 15);
      this.labelControl2.TabIndex = 22;
      this.labelControl2.Text = "Expediente de";
      // 
      // timeEditIntervalo
      // 
      this.timeEditIntervalo.EditValue = new System.DateTime(2015, 8, 12, 0, 0, 0, 0);
      this.timeEditIntervalo.Location = new System.Drawing.Point(550, 18);
      this.timeEditIntervalo.Name = "timeEditIntervalo";
      this.timeEditIntervalo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.timeEditIntervalo.Properties.Appearance.Options.UseFont = true;
      this.timeEditIntervalo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.timeEditIntervalo.Properties.Mask.EditMask = "t";
      this.timeEditIntervalo.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
      this.timeEditIntervalo.Size = new System.Drawing.Size(75, 22);
      this.timeEditIntervalo.TabIndex = 30;
      // 
      // timeEditTempoAula
      // 
      this.timeEditTempoAula.EditValue = new System.DateTime(2015, 8, 12, 0, 0, 0, 0);
      this.timeEditTempoAula.Location = new System.Drawing.Point(404, 18);
      this.timeEditTempoAula.Name = "timeEditTempoAula";
      this.timeEditTempoAula.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.timeEditTempoAula.Properties.Appearance.Options.UseFont = true;
      this.timeEditTempoAula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.timeEditTempoAula.Properties.Mask.EditMask = "t";
      this.timeEditTempoAula.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
      this.timeEditTempoAula.Size = new System.Drawing.Size(75, 22);
      this.timeEditTempoAula.TabIndex = 20;
      // 
      // timeEditAte
      // 
      this.timeEditAte.EditValue = new System.DateTime(2015, 8, 12, 0, 0, 0, 0);
      this.timeEditAte.Location = new System.Drawing.Point(206, 18);
      this.timeEditAte.Name = "timeEditAte";
      this.timeEditAte.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.timeEditAte.Properties.Appearance.Options.UseFont = true;
      this.timeEditAte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.timeEditAte.Properties.Mask.EditMask = "t";
      this.timeEditAte.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
      this.timeEditAte.Size = new System.Drawing.Size(75, 22);
      this.timeEditAte.TabIndex = 10;
      // 
      // timeEditDe
      // 
      this.timeEditDe.EditValue = new System.DateTime(2015, 8, 12, 0, 0, 0, 0);
      this.timeEditDe.Location = new System.Drawing.Point(102, 18);
      this.timeEditDe.Name = "timeEditDe";
      this.timeEditDe.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.timeEditDe.Properties.Appearance.Options.UseFont = true;
      this.timeEditDe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.timeEditDe.Properties.Mask.EditMask = "t";
      this.timeEditDe.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
      this.timeEditDe.Size = new System.Drawing.Size(75, 22);
      this.timeEditDe.TabIndex = 5;
      // 
      // checkEditSabado
      // 
      this.checkEditSabado.Location = new System.Drawing.Point(426, 53);
      this.checkEditSabado.Name = "checkEditSabado";
      this.checkEditSabado.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.checkEditSabado.Properties.Appearance.ForeColor = System.Drawing.Color.White;
      this.checkEditSabado.Properties.Appearance.Options.UseFont = true;
      this.checkEditSabado.Properties.Appearance.Options.UseForeColor = true;
      this.checkEditSabado.Properties.Caption = "Sábado";
      this.checkEditSabado.Size = new System.Drawing.Size(75, 19);
      this.checkEditSabado.TabIndex = 90;
      // 
      // checkEditSexta
      // 
      this.checkEditSexta.EditValue = true;
      this.checkEditSexta.Location = new System.Drawing.Point(345, 53);
      this.checkEditSexta.Name = "checkEditSexta";
      this.checkEditSexta.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.checkEditSexta.Properties.Appearance.ForeColor = System.Drawing.Color.White;
      this.checkEditSexta.Properties.Appearance.Options.UseFont = true;
      this.checkEditSexta.Properties.Appearance.Options.UseForeColor = true;
      this.checkEditSexta.Properties.Caption = "Sexta";
      this.checkEditSexta.Size = new System.Drawing.Size(75, 19);
      this.checkEditSexta.TabIndex = 80;
      // 
      // checkEditQuinta
      // 
      this.checkEditQuinta.EditValue = true;
      this.checkEditQuinta.Location = new System.Drawing.Point(264, 53);
      this.checkEditQuinta.Name = "checkEditQuinta";
      this.checkEditQuinta.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.checkEditQuinta.Properties.Appearance.ForeColor = System.Drawing.Color.White;
      this.checkEditQuinta.Properties.Appearance.Options.UseFont = true;
      this.checkEditQuinta.Properties.Appearance.Options.UseForeColor = true;
      this.checkEditQuinta.Properties.Caption = "Quinta";
      this.checkEditQuinta.Size = new System.Drawing.Size(75, 19);
      this.checkEditQuinta.TabIndex = 70;
      // 
      // checkEditQuarta
      // 
      this.checkEditQuarta.EditValue = true;
      this.checkEditQuarta.Location = new System.Drawing.Point(183, 53);
      this.checkEditQuarta.Name = "checkEditQuarta";
      this.checkEditQuarta.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.checkEditQuarta.Properties.Appearance.ForeColor = System.Drawing.Color.White;
      this.checkEditQuarta.Properties.Appearance.Options.UseFont = true;
      this.checkEditQuarta.Properties.Appearance.Options.UseForeColor = true;
      this.checkEditQuarta.Properties.Caption = "Quarta";
      this.checkEditQuarta.Size = new System.Drawing.Size(75, 19);
      this.checkEditQuarta.TabIndex = 60;
      // 
      // checkEditTerca
      // 
      this.checkEditTerca.EditValue = true;
      this.checkEditTerca.Location = new System.Drawing.Point(102, 53);
      this.checkEditTerca.Name = "checkEditTerca";
      this.checkEditTerca.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.checkEditTerca.Properties.Appearance.ForeColor = System.Drawing.Color.White;
      this.checkEditTerca.Properties.Appearance.Options.UseFont = true;
      this.checkEditTerca.Properties.Appearance.Options.UseForeColor = true;
      this.checkEditTerca.Properties.Caption = "Terça";
      this.checkEditTerca.Size = new System.Drawing.Size(75, 19);
      this.checkEditTerca.TabIndex = 50;
      // 
      // checkEditSegunda
      // 
      this.checkEditSegunda.EditValue = true;
      this.checkEditSegunda.Location = new System.Drawing.Point(21, 53);
      this.checkEditSegunda.Name = "checkEditSegunda";
      this.checkEditSegunda.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.checkEditSegunda.Properties.Appearance.ForeColor = System.Drawing.Color.White;
      this.checkEditSegunda.Properties.Appearance.Options.UseFont = true;
      this.checkEditSegunda.Properties.Appearance.Options.UseForeColor = true;
      this.checkEditSegunda.Properties.Caption = "Segunda";
      this.checkEditSegunda.Size = new System.Drawing.Size(75, 19);
      this.checkEditSegunda.TabIndex = 40;
      // 
      // buttonProcessar
      // 
      this.buttonProcessar.AllowFocus = false;
      this.buttonProcessar.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.buttonProcessar.Appearance.BackColor2 = System.Drawing.Color.Transparent;
      this.buttonProcessar.Appearance.BorderColor = System.Drawing.Color.Transparent;
      this.buttonProcessar.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.buttonProcessar.Appearance.ForeColor = System.Drawing.Color.White;
      this.buttonProcessar.Appearance.Options.UseBackColor = true;
      this.buttonProcessar.Appearance.Options.UseBorderColor = true;
      this.buttonProcessar.Appearance.Options.UseFont = true;
      this.buttonProcessar.Appearance.Options.UseForeColor = true;
      this.buttonProcessar.Appearance.Options.UseTextOptions = true;
      this.buttonProcessar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.buttonProcessar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.buttonProcessar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProcessar.BackgroundImage")));
      this.buttonProcessar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.buttonProcessar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
      this.buttonProcessar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonProcessar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.buttonProcessar.Location = new System.Drawing.Point(663, 11);
      this.buttonProcessar.Name = "buttonProcessar";
      this.buttonProcessar.Size = new System.Drawing.Size(125, 30);
      this.buttonProcessar.TabIndex = 110;
      this.buttonProcessar.Text = "Processar";
      this.buttonProcessar.ToolTip = "Processar Horario";
      this.buttonProcessar.Click += new System.EventHandler(this.buttonProcessar_Click);
      // 
      // dsItLab
      // 
      this.dsItLab.DataSetName = "NewDataSet";
      // 
      // labelControl7
      // 
      this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
      this.labelControl7.Location = new System.Drawing.Point(515, 107);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new System.Drawing.Size(19, 15);
      this.labelControl7.TabIndex = 201;
      this.labelControl7.Text = "Cor";
      // 
      // colorEditLab
      // 
      this.colorEditLab.EditValue = System.Drawing.Color.Empty;
      this.colorEditLab.Location = new System.Drawing.Point(542, 104);
      this.colorEditLab.Name = "colorEditLab";
      this.colorEditLab.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.colorEditLab.Properties.Appearance.Options.UseForeColor = true;
      this.colorEditLab.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.colorEditLab.Size = new System.Drawing.Size(204, 20);
      this.colorEditLab.TabIndex = 202;
      // 
      // FormLaboratorioCad
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
      this.ClientSize = new System.Drawing.Size(800, 379);
      this.Controls.Add(this.colorEditLab);
      this.Controls.Add(this.labelControl7);
      this.Controls.Add(this.panelControl3);
      this.Controls.Add(this.gridLaboratoriosCad);
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
      this.Name = "FormLaboratorioCad";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Usuarios";
      this.Load += new System.EventHandler(this.FormLaboratorioCad_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProfessorCad_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.textNome.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsLab)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsLab)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridLaboratoriosCad)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewLaboratorioCad)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
      this.panelControl3.ResumeLayout(false);
      this.panelControl3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditDomingo.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.timeEditIntervalo.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.timeEditTempoAula.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.timeEditAte.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.timeEditDe.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditSabado.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditSexta.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditQuinta.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditQuarta.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditTerca.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEditSegunda.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsItLab)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsItLab)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.colorEditLab.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource bsLab;
    private System.Data.DataSet dsLab;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.TextEdit textNome;
    private System.Windows.Forms.ToolTip toolTip;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.SimpleButton buttonGravar;
    private DevExpress.XtraGrid.GridControl gridLaboratoriosCad;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewLaboratorioCad;
    private DevExpress.XtraEditors.SimpleButton buttonClose;
    private DevExpress.XtraEditors.SimpleButton buttonMin;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.PanelControl panelControl2;
    private DevExpress.XtraEditors.PanelControl panelControl3;
    private DevExpress.XtraEditors.SimpleButton buttonProcessar;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private DevExpress.XtraEditors.TimeEdit timeEditIntervalo;
    private DevExpress.XtraEditors.TimeEdit timeEditTempoAula;
    private DevExpress.XtraEditors.TimeEdit timeEditAte;
    private DevExpress.XtraEditors.TimeEdit timeEditDe;
    private DevExpress.XtraEditors.CheckEdit checkEditSabado;
    private DevExpress.XtraEditors.CheckEdit checkEditSexta;
    private DevExpress.XtraEditors.CheckEdit checkEditQuinta;
    private DevExpress.XtraEditors.CheckEdit checkEditQuarta;
    private DevExpress.XtraEditors.CheckEdit checkEditTerca;
    private DevExpress.XtraEditors.CheckEdit checkEditSegunda;
    private DevExpress.XtraEditors.CheckEdit checkEditDomingo;
    private DevExpress.XtraEditors.SimpleButton buttonEx;
    private System.Windows.Forms.BindingSource bsItLab;
    private System.Data.DataSet dsItLab;
    private DevExpress.XtraEditors.LabelControl labelControl7;
    private DevExpress.XtraEditors.ColorPickEdit colorEditLab;

  }
}

