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
  public partial class FormProfessor : XtraForm
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

    IDbDataAdapter adapterProf = null;
    BindingSource BsProf = new BindingSource();
    DataSet DsProf = new DataSet();

    public FormProfessor()
    {
      InitializeComponent();
    }

    private void FormProfessor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        Close();
      }
    }

    private void FormProfessor_Load(object sender, EventArgs e)
    {
      toolTip.IsBalloon = true;
      CarregarProfessor();
    }

    public void CarregarProfessor()
    {
      try
      {
        
        Conexao.CarregaTable("SELECT CODPROF, NOMEPROF FROM PROFESSOR", ref adapterProf, BsProf, DsProf);

        gridProfessor.DataSource = BsProf;

        gridViewProfessor.Columns["CODPROF"].Caption = "Codigo";
        gridViewProfessor.Columns["CODPROF"].Width = 30;
        gridViewProfessor.Columns["CODPROF"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

        gridViewProfessor.Columns["NOMEPROF"].Caption = "Professor";
        gridViewProfessor.Columns["NOMEPROF"].Width = 300;
      }
      catch (Exception ef) 
      {
        MessageBox.Show("Erro ao Caregar Tabela Professor: " + ef.Message); 
      }
    }

    private void buttonInserir_Click(object sender, EventArgs e)
    {
      FormProfessorCad myForm = new FormProfessorCad();
      myForm.ShowDialog();
      CarregarProfessor();
    }

    private void buttonEd_Click(object sender, EventArgs e)
    {
      if (gridViewProfessor.SelectedRowsCount == 0)
      {
        return;
      }

      string codigo = gridViewProfessor.GetRowCellValue(gridViewProfessor.GetSelectedRows()[0], "CODPROF").ToString();

      FormProfessorCad myForm = new FormProfessorCad(codigo);
      myForm.ShowDialog();
      CarregarProfessor();
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
      if (gridViewProfessor.SelectedRowsCount == 0)
      {
        return;
      }

      string codigo = gridViewProfessor.GetRowCellValue(gridViewProfessor.GetSelectedRows()[0], "CODPROF").ToString();
      string nome = gridViewProfessor.GetRowCellValue(gridViewProfessor.GetSelectedRows()[0], "NOMEPROF").ToString();

      if (codigo.Equals("1"))
      {
        return;
      }

      DialogResult ex = MessageBox.Show("Você Tem Certeza que Deseja Excluir o Professor: " + nome + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (ex == DialogResult.No)
      {
        return;
      }

      try
      {
        Conexao.ExecutaComando("DELETE FROM PROFESSOR WHERE CODPROF = " + codigo);
        MessageBox.Show("Professor Excluido com Sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch { }

      CarregarProfessor();
    }

    private void FormProfessor_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(Handle, positionX, positionY, 0);
    }

    private void gridProfessor_DoubleClick(object sender, EventArgs e)
    {
      buttonEd_Click(sender, e);
    }
  }
}
