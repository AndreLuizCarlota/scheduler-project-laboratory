namespace ControlLaboratorio
{
  partial class FormAgendaLab
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
      DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
      DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
      this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
      this.schedulerAgenda = new DevExpress.XtraScheduler.SchedulerControl();
      this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
      this.bsAgendaLab = new System.Windows.Forms.BindingSource(this.components);
      this.bsLaboratorios = new System.Windows.Forms.BindingSource(this.components);
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.dsAgendaLab = new System.Data.DataSet();
      this.lookUpEditLaboratorio = new DevExpress.XtraEditors.LookUpEdit();
      this.labelLab = new DevExpress.XtraEditors.LabelControl();
      this.labelProf = new DevExpress.XtraEditors.LabelControl();
      this.lookUpEditProfessor = new DevExpress.XtraEditors.LookUpEdit();
      this.dsLaboratorio = new System.Data.DataSet();
      ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.schedulerAgenda)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsAgendaLab)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsLaboratorios)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dsAgendaLab)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLaboratorio.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProfessor.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio)).BeginInit();
      this.SuspendLayout();
      // 
      // dateNavigator1
      // 
      this.dateNavigator1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dateNavigator1.Font = new System.Drawing.Font("Calibri", 10F);
      this.dateNavigator1.HotDate = null;
      this.dateNavigator1.Location = new System.Drawing.Point(0, 0);
      this.dateNavigator1.Name = "dateNavigator1";
      this.dateNavigator1.SchedulerControl = this.schedulerAgenda;
      this.dateNavigator1.Size = new System.Drawing.Size(212, 433);
      this.dateNavigator1.TabIndex = 0;
      // 
      // schedulerAgenda
      // 
      this.schedulerAgenda.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.schedulerAgenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
      this.schedulerAgenda.Location = new System.Drawing.Point(214, 127);
      this.schedulerAgenda.Name = "schedulerAgenda";
      this.schedulerAgenda.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Forbidden;
      this.schedulerAgenda.Size = new System.Drawing.Size(875, 432);
      this.schedulerAgenda.Start = new System.DateTime(2015, 5, 11, 0, 0, 0, 0);
      this.schedulerAgenda.Storage = this.schedulerStorage;
      this.schedulerAgenda.TabIndex = 7;
      this.schedulerAgenda.Text = "schedulerControl1";
      this.schedulerAgenda.Views.DayView.TimeRulers.Add(timeRuler1);
      this.schedulerAgenda.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
      this.schedulerAgenda.AppointmentViewInfoCustomizing += new DevExpress.XtraScheduler.AppointmentViewInfoCustomizingEventHandler(this.schedulerAgenda_AppointmentViewInfoCustomizing);
      this.schedulerAgenda.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(this.schedulerAgenda_PopupMenuShowing);
      this.schedulerAgenda.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerAgenda_EditAppointmentFormShowing);
      this.schedulerAgenda.CustomDrawTimeCell += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(this.schedulerAgenda_CustomDrawTimeCell);
      // 
      // schedulerStorage
      // 
      this.schedulerStorage.Appointments.DataSource = this.bsAgendaLab;
      this.schedulerStorage.Appointments.Mappings.AppointmentId = "CODAGENDALAB";
      this.schedulerStorage.Appointments.Mappings.Description = "OBSAGENDALAB";
      this.schedulerStorage.Appointments.Mappings.End = "DTHORAFIMAGENDALAB";
      this.schedulerStorage.Appointments.Mappings.ResourceId = "CODPROFAGENDALAB";
      this.schedulerStorage.Appointments.Mappings.Start = "DTHORAINIAGENDALAB";
      this.schedulerStorage.Resources.DataSource = this.bsLaboratorios;
      this.schedulerStorage.Resources.Mappings.Caption = "NOMELAB";
      this.schedulerStorage.Resources.Mappings.Color = "CORLAB";
      this.schedulerStorage.Resources.Mappings.Id = "CODLAB";
      // 
      // panelControl1
      // 
      this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
      this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.White;
      this.panelControl1.Appearance.BorderColor = System.Drawing.Color.White;
      this.panelControl1.Appearance.Options.UseBackColor = true;
      this.panelControl1.Appearance.Options.UseBorderColor = true;
      this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
      this.panelControl1.Controls.Add(this.dateNavigator1);
      this.panelControl1.Location = new System.Drawing.Point(0, 128);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(212, 433);
      this.panelControl1.TabIndex = 2;
      // 
      // dsAgendaLab
      // 
      this.dsAgendaLab.DataSetName = "NewDataSet";
      // 
      // lookUpEditLaboratorio
      // 
      this.lookUpEditLaboratorio.EditValue = "";
      this.lookUpEditLaboratorio.Location = new System.Drawing.Point(214, 56);
      this.lookUpEditLaboratorio.Name = "lookUpEditLaboratorio";
      this.lookUpEditLaboratorio.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.lookUpEditLaboratorio.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.lookUpEditLaboratorio.Properties.Appearance.Options.UseFont = true;
      this.lookUpEditLaboratorio.Properties.Appearance.Options.UseForeColor = true;
      this.lookUpEditLaboratorio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)});
      this.lookUpEditLaboratorio.Properties.NullText = "Selecione o Laboratório...";
      this.lookUpEditLaboratorio.Properties.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lookUpEditLaboratorio_Properties_ButtonPressed);
      this.lookUpEditLaboratorio.Size = new System.Drawing.Size(327, 22);
      this.lookUpEditLaboratorio.TabIndex = 3;
      this.lookUpEditLaboratorio.EditValueChanged += new System.EventHandler(this.lookUpEditLaboratorio_EditValueChanged);
      this.lookUpEditLaboratorio.Leave += new System.EventHandler(this.lookUpEditLaboratorio_Leave);
      // 
      // labelLab
      // 
      this.labelLab.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelLab.Appearance.ForeColor = System.Drawing.Color.Black;
      this.labelLab.Location = new System.Drawing.Point(141, 60);
      this.labelLab.Name = "labelLab";
      this.labelLab.Size = new System.Drawing.Size(65, 15);
      this.labelLab.TabIndex = 4;
      this.labelLab.Text = "Laboratório";
      // 
      // labelProf
      // 
      this.labelProf.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.labelProf.Appearance.ForeColor = System.Drawing.Color.Black;
      this.labelProf.Location = new System.Drawing.Point(155, 32);
      this.labelProf.Name = "labelProf";
      this.labelProf.Size = new System.Drawing.Size(53, 15);
      this.labelProf.TabIndex = 6;
      this.labelProf.Text = "Professor";
      // 
      // lookUpEditProfessor
      // 
      this.lookUpEditProfessor.EditValue = "";
      this.lookUpEditProfessor.Location = new System.Drawing.Point(214, 28);
      this.lookUpEditProfessor.Name = "lookUpEditProfessor";
      this.lookUpEditProfessor.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10F);
      this.lookUpEditProfessor.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
      this.lookUpEditProfessor.Properties.Appearance.Options.UseFont = true;
      this.lookUpEditProfessor.Properties.Appearance.Options.UseForeColor = true;
      this.lookUpEditProfessor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)});
      this.lookUpEditProfessor.Properties.NullText = "Selecione o Professor...";
      this.lookUpEditProfessor.Properties.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lookUpEditProfessor_Properties_ButtonPressed);
      this.lookUpEditProfessor.Size = new System.Drawing.Size(327, 22);
      this.lookUpEditProfessor.TabIndex = 5;
      // 
      // dsLaboratorio
      // 
      this.dsLaboratorio.DataSetName = "NewDataSet";
      // 
      // FormAgendaLab
      // 
      this.Appearance.BackColor = System.Drawing.Color.White;
      this.Appearance.ForeColor = System.Drawing.Color.Black;
      this.Appearance.Options.UseBackColor = true;
      this.Appearance.Options.UseFont = true;
      this.Appearance.Options.UseForeColor = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1091, 561);
      this.Controls.Add(this.labelProf);
      this.Controls.Add(this.lookUpEditProfessor);
      this.Controls.Add(this.labelLab);
      this.Controls.Add(this.lookUpEditLaboratorio);
      this.Controls.Add(this.panelControl1);
      this.Controls.Add(this.schedulerAgenda);
      this.Font = new System.Drawing.Font("Calibri", 10F);
      this.KeyPreview = true;
      this.Name = "FormAgendaLab";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Agenda";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAgendaLab_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.schedulerAgenda)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsAgendaLab)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsLaboratorios)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dsAgendaLab)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLaboratorio.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProfessor.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsLaboratorio)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
    private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private System.Windows.Forms.BindingSource bsAgendaLab;
    private System.Windows.Forms.BindingSource bsLaboratorios;
    private System.Data.DataSet dsAgendaLab;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditLaboratorio;
    private DevExpress.XtraEditors.LabelControl labelLab;
    private DevExpress.XtraEditors.LabelControl labelProf;
    private DevExpress.XtraEditors.LookUpEdit lookUpEditProfessor;
    private DevExpress.XtraScheduler.SchedulerControl schedulerAgenda;
    private System.Data.DataSet dsLaboratorio;

  }
}

