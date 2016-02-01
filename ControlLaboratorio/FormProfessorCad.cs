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


namespace ControlLaboratorio
{
  public partial class FormProfessorCad : XtraForm
  {
    public const int positionX = 0xA1;
    public const int positionY = 0x2;
    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr handle, int Msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();

    IDbDataAdapter adapterProf = null;
    string codigo = string.Empty;

    public FormProfessorCad()
    {
      InitializeComponent();
    }

    public FormProfessorCad(string codigo)
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

    private void FormProfessorCad_Load(object sender, EventArgs e)
    {
      toolTip.IsBalloon = true;

      if (codigo.Length == 0)
      {
        Conexao.CarregaTable("SELECT * FROM PROFESSOR WHERE 0 = 1", ref adapterProf, bsProf, dsProf);
      }
      else 
      {
        Conexao.CarregaTable("SELECT * FROM PROFESSOR WHERE CODPROF = " + codigo, ref adapterProf, bsProf, dsProf);
      }

      Conexao.BindingControl(textNome, "TEXT", "NOMEPROF", bsProf);

      if (codigo.Length == 0)
      {
        bsProf.AddNew();
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
        bsProf.EndEdit();
        adapterProf.Update(dsProf);
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
  }
}
