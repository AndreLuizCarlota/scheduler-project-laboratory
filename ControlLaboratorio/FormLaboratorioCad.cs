using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;


namespace ControlLaboratorio
{
  public partial class FormLaboratorioCad : XtraForm
  {
    public const int positionX = 0xA1;
    public const int positionY = 0x2;
    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr handle, int Msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();

    IDbDataAdapter adapter = null;
    IDbDataAdapter adapterItLab = null;
    string codigo = string.Empty;

    public FormLaboratorioCad()
    {
      InitializeComponent();
    }

    public FormLaboratorioCad(string codigo)
    {
      InitializeComponent();
      this.codigo = codigo;
    }

    private void FormProfessorCad_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        Close();
      }
    }

    private void FormLaboratorioCad_Load(object sender, EventArgs e)
    {
      toolTip.IsBalloon = true;

      Conexao.CarregaTable("SELECT * FROM LABORATORIO WHERE CODLAB = " + codigo, ref adapter, bsLab, dsLab);

      Conexao.BindingControl(textNome, "TEXT", "NOMELAB", bsLab);

      if (((DataRowView)bsLab.Current).Row["CORLAB"] != DBNull.Value)
        colorEditLab.Color = Color.FromArgb(Convert.ToInt32(((DataRowView)bsLab.Current).Row["CORLAB"])); 

      CarregarItLaboratorio();

    }

    void CarregarItLaboratorio()
    {
      try
      {
        Conexao.CarregaTable("SELECT CODITLAB, HORAINIITLAB, HORAFIMITLAB, SEMANAITLAB FROM ITLABORATORIO WHERE CODLABITLAB = " + codigo, ref adapterItLab, bsItLab, dsItLab);


        gridLaboratoriosCad.DataSource = bsItLab;

        gridViewLaboratorioCad.Columns["CODITLAB"].Caption = "Codigo";
        gridViewLaboratorioCad.Columns["CODITLAB"].Width = 30;
        gridViewLaboratorioCad.Columns["CODITLAB"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

        gridViewLaboratorioCad.Columns["HORAINIITLAB"].Caption = "Hora Inicio";
        gridViewLaboratorioCad.Columns["HORAINIITLAB"].Width = 100;
        gridViewLaboratorioCad.Columns["HORAINIITLAB"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
        gridViewLaboratorioCad.Columns["HORAINIITLAB"].DisplayFormat.FormatString = "HH:mm:ss";

        gridViewLaboratorioCad.Columns["HORAFIMITLAB"].Caption = "Hora Fim";
        gridViewLaboratorioCad.Columns["HORAFIMITLAB"].Width = 100;
        gridViewLaboratorioCad.Columns["HORAFIMITLAB"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
        gridViewLaboratorioCad.Columns["HORAFIMITLAB"].DisplayFormat.FormatString = "T";
        
        gridViewLaboratorioCad.Columns["SEMANAITLAB"].Caption = "Semana";
        gridViewLaboratorioCad.Columns["SEMANAITLAB"].Width = 300;

      }
      catch (Exception ef)
      {
        MessageBox.Show(ef.Message);
      }
    }

    private void buttonGravar_Click(object sender, EventArgs e)
    {
      if (textNome.Text.Trim().Length == 0)
      {
        MessageBox.Show("O Campo Nome e Preenchimento Obrigatorio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        textNome.Focus();
        return;
      }

      try
      {
        bsLab.EndEdit();

        ((DataRowView)bsLab.Current).Row["CORLAB"] = colorEditLab.Color.ToArgb();

        adapter.Update(dsLab);
      }
      catch (Exception ef)
      {
        MessageBox.Show("Erro: " + ef.Message);
        return;
      }

      Close();
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void buttonMin_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    private void panelControl2_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(Handle, positionX, positionY, 0);
    }

    private void buttonProcessar_Click(object sender, EventArgs e)
    {
      SplashScreenManager.ShowForm(typeof(FormAguarde));

      if (checkEditSegunda.Checked)
      {
        processaHorarios("SEGUNDA");
      }
      if (checkEditTerca.Checked)
      {
        processaHorarios("TERCA");
      }
      if (checkEditQuarta.Checked)
      {
        processaHorarios("QUARTA");
      }
      if (checkEditQuinta.Checked)
      {
        processaHorarios("QUINTA");
      }
      if (checkEditSexta.Checked)
      {
        processaHorarios("SEXTA");
      }
      if (checkEditSabado.Checked)
      {
        processaHorarios("SABADO");
      }
      if (checkEditDomingo.Checked)
      {
        processaHorarios("DOMINGO");
      }

      SplashScreenManager.CloseForm();
    }

    void processaHorarios(string diaSemana)
    {
      try
      {
        DateTime horaIni = timeEditDe.Time;
        DateTime horaFim = timeEditAte.Time;

        while (horaFim <= timeEditAte.Time)
        {

          horaFim = horaIni.AddHours(timeEditTempoAula.Time.Hour).AddMinutes(timeEditTempoAula.Time.Minute);

          if (horaFim > timeEditAte.Time)
          {
            break;
          }

          string jaExisteEsteHorario = Conexao.RetornaDados("SELECT CODITLAB FROM ITLABORATORIO WHERE CODLABITLAB = " + codigo + " AND SEMANAITLAB = '" + diaSemana + "' AND '" + horaIni.AddSeconds(1).ToLongTimeString() + "' BETWEEN HORAINIITLAB AND HORAFIMITLAB");
          if (jaExisteEsteHorario.Length == 0)
          {
            gravaHorarioSala(diaSemana, horaIni, horaFim);
          }

          if (!timeEditIntervalo.Time.Hour.Equals(0) || !timeEditIntervalo.Time.Minute.Equals(0))
          {
            horaFim = horaFim.AddHours(timeEditIntervalo.Time.Hour).AddMinutes(timeEditIntervalo.Time.Minute);
          }

          horaIni = horaFim;

        }
      }
      catch (Exception ef)
      {
        MessageBox.Show(ef.Message);
        SplashScreenManager.CloseForm();
        return;
      }
    }

    public void gravaHorarioSala(string diaSemana, DateTime horaIni, DateTime horaFim)
    {
      try
      {
        IDbDataAdapter adapterNew = null;
        BindingSource bsNew = new BindingSource();
        DataSet dsNew = new DataSet();

        Conexao.CarregaTable("SELECT * FROM ITLABORATORIO WHERE 0 = 1", ref adapterNew, bsNew, dsNew);

        bsNew.AddNew();

        ((DataRowView)bsNew.Current).Row["HORAINIITLAB"] = horaIni.AddSeconds(1).ToLongTimeString();
        ((DataRowView)bsNew.Current).Row["HORAFIMITLAB"] = horaFim.ToShortTimeString();
        ((DataRowView)bsNew.Current).Row["CODLABITLAB"] = codigo;
        ((DataRowView)bsNew.Current).Row["SEMANAITLAB"] = diaSemana;

        bsNew.EndEdit();
        adapterNew.Update(dsNew);

      }
      catch (Exception ef)
      {
        MessageBox.Show(ef.Message);
        SplashScreenManager.CloseForm();
        return;
      }
    }
  }
}
