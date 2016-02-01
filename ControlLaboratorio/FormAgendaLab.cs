using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlLaboratorio
{
  public partial class FormAgendaLab : XtraForm
  {

    DataSet dsProfessor, dsHorariosLaboratorio;
    IDbDataAdapter adapterLab, adapter;

    public FormAgendaLab()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      ConfiguraAgenda();
      CarregarProfessor();
      CarregarLaboratorios();
      schedulerAgenda.GoToDate(DateTime.Today);
    }

    void ConfiguraAgenda()
    {
      schedulerAgenda.WorkWeekView.TimeRulers.Clear();
      schedulerAgenda.WorkWeekView.TimeRulers.Add(new TimeRuler() { ShowMinutes = true, AlwaysShowTimeDesignator = true });
      schedulerAgenda.WorkWeekView.TimeScale = TimeSpan.FromMinutes(10);
      schedulerAgenda.ActiveViewType = SchedulerViewType.WorkWeek;
      schedulerAgenda.WorkDays.Add(WeekDays.Monday);
      schedulerAgenda.WorkDays.Add(WeekDays.Thursday);
      schedulerAgenda.WorkDays.Add(WeekDays.Wednesday);
      schedulerAgenda.WorkDays.Add(WeekDays.Tuesday);
      schedulerAgenda.WorkDays.Add(WeekDays.Friday);
      schedulerAgenda.WorkDays.Add(WeekDays.Saturday);

      TimeSpan inicio = TimeSpan.FromHours(7);
      TimeSpan fim = TimeSpan.FromHours(24);
      schedulerAgenda.WorkWeekView.VisibleTime = new TimeOfDayInterval(inicio, fim);
    }

    public string ConverteSemana(string diaSemana)
    {
      if (diaSemana.Equals("Monday")) { diaSemana = "SEGUNDA"; }
      else if (diaSemana.Equals("Tuesday")) { diaSemana = "TERCA"; }
      else if (diaSemana.Equals("Wednesday")) { diaSemana = "QUARTA"; }
      else if (diaSemana.Equals("Thursday")) { diaSemana = "QUINTA"; }
      else if (diaSemana.Equals("Friday")) { diaSemana = "SEXTA"; }
      else if (diaSemana.Equals("Saturday")) { diaSemana = "SABADO"; }
      else if (diaSemana.Equals("Sunday")) { diaSemana = "DOMINGO"; }

      return diaSemana;
    }

    private void schedulerAgenda_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
    {
      if(Convert.ToInt16(e.Appointment.Id) > 0)
      {
        DialogResult exc = MessageBox.Show("Tem certeza que deseja desagendar o horário selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (exc == DialogResult.No)
        {
          e.Handled = true;
          return;
        }

        Conexao.ExecutaComando("DELETE FROM AGENDALAB WHERE CODAGENDALAB = " + e.Appointment.Id);
        CarregarAgendaLaboratorio();
        e.Handled = true;
        return;
      }

      if (lookUpEditLaboratorio.EditValue == null || lookUpEditProfessor.EditValue == null)
      {
        MessageBox.Show("Para agendar um horário é necessário selecionar um professor e um laboratório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        e.Handled = true;
        return;
      }

      if(e.Appointment.Start < DateTime.Now)
      {
        MessageBox.Show("Impossível agendar aula depois que a data ou hora ja se passaram!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        e.Handled = true;
        return;
      }

      foreach (DataRow row in dsHorariosLaboratorio.Tables[0].Rows)
      {
        TimeSpan inicio = (TimeSpan)new TimeSpanConverter().ConvertFromString(row["HORAINIITLAB"].ToString());
        TimeSpan fim = (TimeSpan)new TimeSpanConverter().ConvertFromString(row["HORAFIMITLAB"].ToString());
        string semana = row["SEMANAITLAB"].ToString();
        
        var dataInicio = e.Appointment.Start.Date.AddTicks(inicio.Ticks);
        var dataFim = e.Appointment.End.Date.AddTicks(fim.Ticks);

        string vericaHorario = Conexao.RetornaDados("SELECT CODAGENDALAB FROM AGENDALAB WHERE DTHORAINIAGENDALAB = '" + dataInicio + "' AND DTHORAFIMAGENDALAB = '" + dataFim + "'");
        if (vericaHorario.Length > 0)
        {
          continue;
        }

        if (ConverteSemana(e.Appointment.Start.Date.DayOfWeek.ToString()).Equals(semana) && e.Appointment.Start.AddSeconds(1) == dataInicio)
        {
          GravarAgendamentoHorario(dataInicio, dataFim);
          CarregarAgendaLaboratorio();
        }
      }
      e.Handled = true;
      return;
    }

    void CarregarProfessor()
    {
      try
      {
        dsProfessor = Conexao.RetornaDataSet("SELECT * FROM PROFESSOR WHERE CODPROF > 0 ORDER BY NOMEPROF");

        if (dsProfessor != null)
        {
          lookUpEditProfessor.Properties.DisplayMember = "NOMEPROF";
          lookUpEditProfessor.Properties.ValueMember = "CODPROF";
          lookUpEditProfessor.Properties.BestFitMode = BestFitMode.None;
          lookUpEditProfessor.Properties.DataSource = dsProfessor.Tables[0];

          lookUpEditProfessor.Properties.Columns.Add(new LookUpColumnInfo() { FieldName = "CODPROF", Caption = "Código", Width = 25, Alignment = DevExpress.Utils.HorzAlignment.Center });
          lookUpEditProfessor.Properties.Columns.Add(new LookUpColumnInfo() { FieldName = "NOMEPROF", Caption = "Professor", Width = 150 });
          lookUpEditProfessor.EditValue = null;
        }
      }
      catch { }
    }

    void CarregarLaboratorios()
    {
      try
      {
        Conexao.CarregaTable("SELECT * FROM LABORATORIO ORDER BY NOMELAB", ref adapterLab, bsLaboratorios, dsLaboratorio);

        if (dsLaboratorio != null)
        {
          lookUpEditLaboratorio.Properties.DisplayMember = "NOMELAB";
          lookUpEditLaboratorio.Properties.ValueMember = "CODLAB";
          lookUpEditLaboratorio.Properties.BestFitMode = BestFitMode.None;
          lookUpEditLaboratorio.Properties.DataSource = dsLaboratorio.Tables[0];

          lookUpEditLaboratorio.Properties.Columns.Add(new LookUpColumnInfo() { FieldName = "CODLAB", Caption = "Código", Width = 25, Alignment = DevExpress.Utils.HorzAlignment.Center });
          lookUpEditLaboratorio.Properties.Columns.Add(new LookUpColumnInfo() { FieldName = "NOMELAB", Caption = "Laboratório", Width = 150 });
          lookUpEditLaboratorio.EditValue = null;
        }
      }
      catch { }
    }

    void GravarAgendamentoHorario(DateTime dtHoraIni, DateTime dtHotaFim)
    {
      try
      {
        IDbDataAdapter adapterNewAgendamento = null;
        BindingSource bsNewAgendamento = new BindingSource();
        DataSet dsNewAgendamento = new DataSet();

        Conexao.CarregaTable("SELECT * FROM AGENDALAB WHERE 0 = 1", ref adapterNewAgendamento, bsNewAgendamento, dsNewAgendamento);

        bsNewAgendamento.AddNew();

        ((DataRowView)bsNewAgendamento.Current).Row["DTHORAINIAGENDALAB"] = dtHoraIni;
        ((DataRowView)bsNewAgendamento.Current).Row["DTHORAFIMAGENDALAB"] = dtHotaFim;
        ((DataRowView)bsNewAgendamento.Current).Row["CODLABAGENDALAB"] = lookUpEditLaboratorio.EditValue; ;
        ((DataRowView)bsNewAgendamento.Current).Row["CODPROFAGENDALAB"] = lookUpEditProfessor.EditValue;
        ((DataRowView)bsNewAgendamento.Current).Row["OBSAGENDALAB"] = "Laboratório: " + lookUpEditLaboratorio.Text + "\r\nProfesso: " + lookUpEditProfessor.Text + "\r\n";

        bsNewAgendamento.EndEdit();
        adapterNewAgendamento.Update(dsNewAgendamento);
        CarregarAgendaLaboratorio();
      }
      catch { }
    }

    void CarregarAgendaLaboratorio()
    {
      try
      {

        string sql = "SELECT * FROM AGENDALAB WHERE CODAGENDALAB > 0";

        if (lookUpEditLaboratorio.EditValue != null)
        {
          sql += " AND CODLABAGENDALAB = " + lookUpEditLaboratorio.EditValue;
        }

        if (lookUpEditProfessor.EditValue != null)
        {
          sql += " AND CODPROFAGENDALAB = " + lookUpEditProfessor.EditValue;
        }

        Conexao.CarregaTable(sql, ref adapter, bsAgendaLab, dsAgendaLab);

      }
      catch { }
    }

    private void lookUpEditProfessor_Properties_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Index == 1)
      {
        lookUpEditProfessor.EditValue = null;
      }
    }

    private void lookUpEditLaboratorio_Properties_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Index == 1)
      {
        lookUpEditLaboratorio.EditValue = null;
        dsHorariosLaboratorio = null;
        schedulerAgenda.Refresh();
      }
    }

    private void schedulerAgenda_CustomDrawTimeCell(object sender, CustomDrawObjectEventArgs e)
    {
      if (e.ObjectInfo is TimeCell)
      {
        TimeCell tc = e.ObjectInfo as TimeCell;

        if (dsHorariosLaboratorio != null)
        {
          foreach (DataRow row in dsHorariosLaboratorio.Tables[0].Rows)
          {
            TimeSpan inicio = (TimeSpan)new TimeSpanConverter().ConvertFromString(row["HORAINIITLAB"].ToString());
            TimeSpan fim = inicio.Add(TimeSpan.FromMinutes(9));
            
            var dataInicio = tc.Interval.Start.Date.AddTicks(inicio.Ticks);
            var dataFim = tc.Interval.End.Date.AddTicks(fim.Ticks);
            var interval = new TimeInterval(dataInicio, dataFim);
            var semana = row["SEMANAITLAB"];
            if (ConverteSemana(tc.Interval.Start.DayOfWeek.ToString()).Equals(semana) && new TimeInterval(tc.Interval.Start, tc.Interval.End).IntersectsWith(interval) & !(tc.Interval.Start == interval.End || tc.Interval.End == interval.Start))
            {
              tc.Appearance.BackColor = Color.LightGreen;
              break;
            }
          }
        }
      }
    }
    private void lookUpEditLaboratorio_EditValueChanged(object sender, EventArgs e)
    {
      if (lookUpEditLaboratorio != null)
      {
        CarregarAgendaLaboratorio();
        dsHorariosLaboratorio = Conexao.RetornaDataSet("SELECT * FROM ITLABORATORIO WHERE CODLABITLAB = " + lookUpEditLaboratorio.EditValue);
        schedulerAgenda.Refresh();
      }
    }

    private void lookUpEditLaboratorio_Leave(object sender, EventArgs e)
    {
      //if (lookUpEditLaboratorio != null)
      //{
      //  dsHorariosLaboratorio = Conexao.RetornaDataSet("SELECT * FROM ITLABORATORIO WHERE CODLABITLAB = " + lookUpEditLaboratorio.EditValue);
      //  schedulerAgenda.Refresh();
      //}
    }

    private void schedulerAgenda_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
    {
      e.Menu.Items.Clear();
    }

    private void schedulerAgenda_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
    {
      AppointmentViewInfo viewInfo = e.ViewInfo;
      string corLab = Conexao.RetornaDados("SELECT CORLAB FROM LABORATORIO WHERE CODLAB = " + viewInfo.Appointment.ResourceId);
      if (!string.IsNullOrEmpty(corLab))
      {
        viewInfo.Appearance.BackColor = Color.FromArgb(int.Parse(corLab));
      }
    }

    private void FormAgendaLab_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        Close();
      }
    }
  }
}
