using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;
using ControlLaboratorio.Classes;


namespace ControlLaboratorio
{
  public partial class FormIni : XtraForm
  {
    public const int positionX = 0xA1;
    public const int positionY = 0x2;
    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr handle, int Msg, int wParam, int lParam);
    [DllImportAttribute("user32.dll")]
    public static extern bool ReleaseCapture();
    public bool minMax = false;
    public int locaX;
    public int locaY;
   

    public FormIni()
    {
      InitializeComponent();
    }

    private void FormIni_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        Close();
      }
    }

    private void buttonUsu_Click(object sender, EventArgs e)
    {
      FormUsuarios abrirUsu = new FormUsuarios();
      abrirUsu.ShowDialog();
    }

    private void buttonMax_Click(object sender, EventArgs e)
    {
      int x = Screen.PrimaryScreen.WorkingArea.Width;
      int y = Screen.PrimaryScreen.WorkingArea.Height;

      if (minMax == false)
      {
        locaX = Form.ActiveForm.Location.X;
        locaY = Form.ActiveForm.Location.Y;

        Form.ActiveForm.DesktopLocation = new Point(0, 0);
        ClientSize = new System.Drawing.Size(x, y);
        minMax = true;
      }
      else
      {
        Form.ActiveForm.DesktopLocation = new Point(locaX, locaY);
        ClientSize = new System.Drawing.Size(800, 500);
        minMax = false;
      }
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void FormIni_Load(object sender, EventArgs e)
    {
      labelNome.Text = Conexao.RetornaDados("SELECT NOMEUSU FROM USUARIO WHERE CODUSU = " + Registros.codigoUsuLog);
      labelTime.Text = DateTime.Now.Hour.ToString();
      labelTime.Text = labelTime.Text + ":" + DateTime.Now.Minute.ToString();
      labelVersao.Text = Application.ProductVersion;
      Application.DoEvents();

    }

    private void FormIni_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(Handle, positionX, positionY, 0);
    }

    private void simpleButtonUsu_Click(object sender, EventArgs e)
    {
      FormUsuarios myForm = new FormUsuarios();
      myForm.ShowDialog();
    }

    private void simpleButtonAgenda_Click(object sender, EventArgs e)
    {
      FormAgendaLab myForm = new FormAgendaLab();
      myForm.ShowDialog();
    }

    private void simpleButtonProf_Click(object sender, EventArgs e)
    {
      FormProfessor myForm = new FormProfessor();
      myForm.ShowDialog();
    }

    private void simpleButtonLab_Click(object sender, EventArgs e)
    {
      FormLaboratorio myForm = new FormLaboratorio();
      myForm.ShowDialog();
    }
  }
}
