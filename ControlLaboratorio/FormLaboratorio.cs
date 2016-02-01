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
  public partial class FormLaboratorio : XtraForm
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

    IDbDataAdapter adapterLab = null;
    BindingSource BsLab = new BindingSource();
    DataSet DsLab = new DataSet();

    public FormLaboratorio()
    {
      InitializeComponent();
    }

    private void FormLaboratorio_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        Close();
      }
    }

    private void FormLaboratorio_Load(object sender, EventArgs e)
    {
      toolTip.IsBalloon = true;
      carregarLaboratorio();
    }

    public void carregarLaboratorio()
    {
      try
      {
        
        Conexao.CarregaTable("SELECT CODLAB, NOMELAB FROM LABORATORIO", ref adapterLab, BsLab, DsLab);

        gridLaboratorios.DataSource = BsLab;

        gridViewLaboratorio.Columns["CODLAB"].Caption = "Codigo";
        gridViewLaboratorio.Columns["CODLAB"].Width = 30;
        gridViewLaboratorio.Columns["CODLAB"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

        gridViewLaboratorio.Columns["NOMELAB"].Caption = "Laboratório";
        gridViewLaboratorio.Columns["NOMELAB"].Width = 300;
      }
      catch (Exception ef) 
      {
        MessageBox.Show("Erro ao Caregar Tabela Laboratório: " + ef.Message); 
      }
    }

    private void buttonInserir_Click(object sender, EventArgs e)
    {
      string countCodLab = Conexao.RetornaDados("SELECT COUNT(CODLAB) FROM LABORATORIO");

      countCodLab = (int.Parse(countCodLab) + 1).ToString();

      Conexao.ExecutaComando("INSERT INTO LABORATORIO (CODLAB) VALUES(" + (countCodLab) + ")");

      FormLaboratorioCad myForm = new FormLaboratorioCad(countCodLab);
      myForm.ShowDialog();

      carregarLaboratorio();
    }

    private void buttonEd_Click(object sender, EventArgs e)
    {
      if (gridViewLaboratorio.SelectedRowsCount == 0)
      {
        return;
      }

      string codigo = gridViewLaboratorio.GetRowCellValue(gridViewLaboratorio.GetSelectedRows()[0], "CODLAB").ToString();

      FormLaboratorioCad myForm = new FormLaboratorioCad(codigo);
      myForm.ShowDialog();
      carregarLaboratorio();
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
      if (gridViewLaboratorio.SelectedRowsCount == 0)
      {
        return;
      }

      string codigo = gridViewLaboratorio.GetRowCellValue(gridViewLaboratorio.GetSelectedRows()[0], "CODLAB").ToString();
      string nome = gridViewLaboratorio.GetRowCellValue(gridViewLaboratorio.GetSelectedRows()[0], "NOMELAB").ToString();

      if (codigo.Equals("1"))
      {
        return;
      }

      DialogResult ex = MessageBox.Show("Você Tem Certeza que Deseja Excluir o Laboratório: " + nome + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (ex == DialogResult.No)
      {
        return;
      }

      try
      {
        Conexao.ExecutaComando("DELETE FROM LABORATORIO WHERE CODLAB = " + codigo);
        MessageBox.Show("Laboratório Excluido com Sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch { }

      carregarLaboratorio();
    }

    private void FormLaboratorio_MouseDown(object sender, MouseEventArgs e)
    {
      ReleaseCapture();
      SendMessage(Handle, positionX, positionY, 0);
    }

    private void gridLaboratorios_DoubleClick(object sender, EventArgs e)
    {
      buttonEd_Click(sender, e);
    }
  }
}
