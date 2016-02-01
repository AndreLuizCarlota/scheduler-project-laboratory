using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ControlLaboratorio.Classes;


namespace ControlLaboratorio
{
  public partial class FormEnt : XtraForm
  {
    public static bool passouSenha = false;

    public FormEnt()
    {
      InitializeComponent();
    }

    private void FormEnt_Load(object sender, EventArgs e)
    {
      
    }

    private void textCod_Leave(object sender, EventArgs e)
    {
      if (textCod.Text.Trim().Length > 0)
      {
       string nome =  Conexao.RetornaDados("SELECT NOMEUSU FROM USUARIO WHERE CODUSU = " + textCod.Text);
       if (nome.Length > 0)
       {
         textNome.Text = nome;
       }
       else
       {
         MessageBox.Show("Não Existe Usuario com Este Codigo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         textCod.Text = null;
         textNome.Text = null;
         textCod.Focus();
         return;
       }
      }
      else
      {
        textCod.Text = null;
        textNome.Text = null;
        textCod.Focus();
        return;
      }
    }

    private void FormEnt_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        Close();
      }

      if (e.KeyCode == Keys.Enter)
      {
        SelectNextControl(ActiveControl, !e.Shift, true, true, true);
      }
    }

    private void textSenha_Leave(object sender, EventArgs e)
    {
      if (textCod.Text.Trim().Length > 0)
      {
        if (textSenha.Text.Trim().Length > 0)
        {
          string senha = Conexao.RetornaDados("SELECT SENHAUSU FROM USUARIO WHERE CODUSU = " + textCod.Text);
          if (senha.Equals(textSenha.Text))
          {
            passouSenha = true;
            Registros.codigoUsuLog = textCod.Text;

            Close();
          }
          else
          {
            MessageBox.Show("A Senha Informada Não Corresponde!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textSenha.Text = null;
            textSenha.Focus();
          }
        }
      }
    }
  }
}
