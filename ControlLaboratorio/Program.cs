using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace ControlLaboratorio
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      BonusSkins.Register();
      SkinManager.EnableFormSkins();
      UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
      if (!Conexao.Conectar())
      {
        MessageBox.Show("Erro ao Conectar ao Banco de Dados");
      }
      Application.Run(new FormEnt());
      if (FormEnt.passouSenha == true)
      {
        FormIni abrir = new FormIni();
        abrir.ShowDialog();
      }
    }
  }
}
