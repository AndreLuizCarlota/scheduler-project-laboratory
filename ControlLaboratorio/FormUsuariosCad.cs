using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ControlLaboratorio
{
  public partial class FormUsuariosCad : DevExpress.XtraEditors.XtraForm
  {
    public const int positionX = 0xA1;
    public const int positionY = 0x2;
    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr handle, int Msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();

    IDbDataAdapter adapterUsu = null;
    string codigo = string.Empty;

    public FormUsuariosCad()
    {
      InitializeComponent();
    }

    public FormUsuariosCad(string codigo)
    {
      InitializeComponent();
      this.codigo = codigo;
    }

    private void FormUsuariosCad_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        Close();
      }
    }

    private void FormUsuariosCad_Load(object sender, EventArgs e)
    {
      toolTip.IsBalloon = true;

      if (codigo.Length == 0)
      {
        Conexao.CarregaTable("SELECT * FROM USUARIO WHERE 0 = 1", ref adapterUsu, bsUsu, dsUsu);
      }
      else 
      {
        Conexao.CarregaTable("SELECT * FROM USUARIO WHERE CODUSU = " + codigo, ref adapterUsu, bsUsu, dsUsu);
      }

      Conexao.BindingControl(textNome, "TEXT", "NOMEUSU", bsUsu);
      Conexao.BindingControl(textSenha, "TEXT", "SENHAUSU", bsUsu);

      if (codigo.Length == 0)
      {
        bsUsu.AddNew();
        textRepSenha.Visible = true;
        labelRep.Visible = true;
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

      if (textSenha.Text.Trim().Length == 0)
      {
        MessageBox.Show("O Campo Senha e Preenchimento Obrigatorio.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        textSenha.Focus();
        return;
      }

      if (codigo.Length == 0)
      {
        if (textRepSenha.Text.Trim().Length == 0)
        {
          MessageBox.Show("O Confirme Sua Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
          textRepSenha.Focus();
          return;
        }
        else
        {
          if (textRepSenha.Text != textSenha.Text)
          {
            MessageBox.Show("As Senhas não Correspondem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            textRepSenha.Text = null;
            textSenha.Text = null;
            textSenha.Focus();
            return;
          }
        }
      }


      try
      {
        bsUsu.EndEdit();
        adapterUsu.Update(dsUsu);
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
