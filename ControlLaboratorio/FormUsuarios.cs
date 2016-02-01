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
  public partial class FormUsuarios : XtraForm
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

    public FormUsuarios()
    {
      InitializeComponent();
    }

    private void FormUsuarios_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        Close();
      }
    }

    private void FormUsuarios_Load(object sender, EventArgs e)
    {
      toolTip.IsBalloon = true;
      carregarUsuario();
    }

    public void carregarUsuario()
    {
      try
      {
        IDbDataAdapter adapterCli = null;
        BindingSource BsCli = new BindingSource();
        DataSet DsCli = new DataSet();

        Conexao.CarregaTable("SELECT CODUSU, NOMEUSU FROM USUARIO", ref adapterCli, BsCli, DsCli);

        gridUsuarios.DataSource = BsCli;

        gridViewUsuario.Columns["CODUSU"].Caption = "Codigo";
        gridViewUsuario.Columns["CODUSU"].Width = 30;
        gridViewUsuario.Columns["CODUSU"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

        gridViewUsuario.Columns["NOMEUSU"].Caption = "Usuario";
        gridViewUsuario.Columns["NOMEUSU"].Width = 300;
      }
      catch (Exception ef) 
      {
        MessageBox.Show("Erro ao Caregar Tabela Usuarios: " + ef.Message); 
      }
    }

    private void buttonInserir_Click(object sender, EventArgs e)
    {
      FormUsuariosCad abrirUsu = new FormUsuariosCad();
      abrirUsu.ShowDialog();
      carregarUsuario();
    }

    private void buttonEd_Click(object sender, EventArgs e)
    {
      if (gridViewUsuario.SelectedRowsCount == 0)
      {
        return;
      }

      string codigo = gridViewUsuario.GetRowCellValue(gridViewUsuario.GetSelectedRows()[0], "CODUSU").ToString();

      FormUsuariosCad abrirEdit = new FormUsuariosCad(codigo);
      abrirEdit.ShowDialog();
      carregarUsuario();
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Close();
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

    private void buttonMin_Click(object sender, EventArgs e)
    {
      WindowState = FormWindowState.Minimized;
    }

    private void buttonEx_Click(object sender, EventArgs e)
    {
      if (gridViewUsuario.SelectedRowsCount == 0)
      {
        return;
      }

      string codigo = gridViewUsuario.GetRowCellValue(gridViewUsuario.GetSelectedRows()[0], "CODUSU").ToString();
      string nome = gridViewUsuario.GetRowCellValue(gridViewUsuario.GetSelectedRows()[0], "NOMEUSU").ToString();

      if (codigo.Equals("1"))
      {
        return;
      }

      DialogResult ex = MessageBox.Show("Você Tem Certeza que Deseja Excluir o Usuario: " + nome + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (ex == DialogResult.No)
      {
        return;
      }

      try
      {
        Conexao.ExecutaComando("DELETE FROM USUARIO WHERE CODUSU = " + codigo);
        MessageBox.Show("Usuario Excluido com Sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch { }

      carregarUsuario();
    }

    private void FormUsuarios_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(Handle, positionX, positionY, 0);
    }

    private void gridUsuarios_DoubleClick(object sender, EventArgs e)
    {
      buttonEd_Click(sender, e);
    }
  }
}
