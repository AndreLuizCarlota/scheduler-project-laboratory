using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace ControlLaboratorio
{
  public static class Conexao
  {
    public static IDbConnection conexao;
    public static string connectionString;
    public static IDbCommand comand;
    public static DataSet dsConexao;

    public static DataSet CarregaDataSet(string sql)
    {
      try
      {
        SqlDataAdapter adapter = new SqlDataAdapter(sql, (SqlConnection)conexao);
        SqlCommandBuilder builder = new SqlCommandBuilder((SqlDataAdapter)adapter);

        DataSet ds = new DataSet();
        adapter.Fill(ds);
        return ds;
      }
      catch
      {
        throw;
      }
    }

    /// <summary>
    /// Este médodo é utilizado para conectar ao Banco de Dados lendo as 
    /// configurações do arquivo INI
    /// </summary>
    public static bool Conectar()
    {
      try
      {
        if (File.Exists("Conn.xml"))
        {
          dsConexao = new DataSet();
          dsConexao.ReadXml(Application.StartupPath + @"\Conn.xml");

          string conn = string.Empty;

          conexao = new SqlConnection();
          conn =
            "Data Source=" + dsConexao.Tables[0].Rows[0]["servidor"].ToString() + ";" +
            "Initial Catalog=" + dsConexao.Tables[0].Rows[0]["banco"].ToString() + ";" +
            "User Id=" + dsConexao.Tables[0].Rows[0]["usuario"].ToString() + ";" +
            "Password=" + dsConexao.Tables[0].Rows[0]["senha"].ToString() + ";";

          connectionString = conn;
          conexao.ConnectionString = conn;

          conexao.Open();

          return true;
        }

        return false;
      }
      catch
      {
        throw;
      }
    }

    /// <summary>
    /// Este método é utilizado para fazer o Binding do Controle na tela com
    /// o campo da tabela.
    /// </summary>
    /// <param name="control">Controle que está na tela</param>
    /// <param name="property">A propriedade do controle que estará ligada ao BindingSource</param>
    /// <param name="field">O campo da tabela que este campo irá referenciar</param>
    /// <param name="bds">O BindingSource que está sendo utilizado na tela</param>

    public static void BindingControl(Control control, string property, string field, BindingSource bds)
    {
      if (control is ComboBoxEdit || control is PictureBox || control is CheckBox || control is MaskedTextBox)
      {
        control.DataBindings.Add(property, bds, field, true);
      }
      else
      {
        control.DataBindings.Add(property, bds, field);
      }
    }

    public static void SetMask(TextEdit txtcontrol, string format)
    {
      if (txtcontrol.DataBindings.Count == 0)
      {
        return;
      }

      txtcontrol.DataBindings[0].FormattingEnabled = true;
      txtcontrol.DataBindings[0].FormatString = format;
    }

    public static void CarregaTable(string sql, ref IDbDataAdapter adapter, BindingSource bds, DataSet ds, IDbConnection conexaoAExecutar)
    {
      try
      {
        if (conexao is SqlConnection)
        {
          adapter = new SqlDataAdapter(sql, (SqlConnection)conexaoAExecutar);
          SqlCommandBuilder builder = new SqlCommandBuilder((SqlDataAdapter)adapter);
          builder.ConflictOption = ConflictOption.OverwriteChanges;
        }
        
        ds.Tables.Clear();
        bds.DataSource = null;
        adapter.Fill(ds);
        bds.DataMember = ds.Tables[0].TableName;
        bds.DataSource = ds;
      }
      catch
      {
        throw;
      }
    }

    /// <summary>
    /// Este método é utilizado para carregar o IdbDataAdpter do form de acordo com a
    /// tabela
    /// </summary>
    /// <param name="sql">Consulta sql necessária para carregar o Adapter</param>
    /// <param name="adapter">O IDBdataAdapter da tela</param>
    /// <param name="bds">BindingSource da Tela</param>
    /// <param name="ds">DataSet da Tela</param>
    public static void CarregaTable(string sql, ref IDbDataAdapter adapter, BindingSource bds, DataSet ds)
    {
      CarregaTable(sql, ref adapter, bds, ds, conexao);
    }

    public static string RetornaDados(string consulta, IDbConnection conexaoAExecutar)
    {
      string result = string.Empty;

      if (conexao is SqlConnection)
      {
        comand = new SqlCommand(consulta, (SqlConnection)conexaoAExecutar);
      }
      
      try
      {
        comand.CommandTimeout = 600;
        object aux = comand.ExecuteScalar();
        comand.Dispose();

        if (aux != null)
        {
          result = aux.ToString();
        }
      }
      catch
      {
        throw;
      }
      return result;
    }

    /// <summary>
    /// Este método irá executar no Banco de Dados um comando sql,sendo que este
    /// sempre retornará apenas a primeira ou a única coluna
    /// </summary>
    /// <param name="consulta">Comando sql</param>
    /// <returns>Retorna o valor da consulta </returns>

    public static string RetornaDados(string consulta)
    {
      return RetornaDados(consulta, conexao);
    }

    public static object RetornaDadosObject(string consulta, IDbConnection conexaoAExecutar)
    {
      object result = null;

      if (conexao is SqlConnection)
      {
        comand = new SqlCommand(consulta, (SqlConnection)conexaoAExecutar);
      }

      try
      {
        comand.CommandTimeout = 600;
        result = comand.ExecuteScalar();
        comand.Dispose();
      }
      catch
      {
      }
      return result;
    }

    public static object RetornaDadosObject(string consulta)
    {
      return RetornaDadosObject(consulta, conexao);
    }

    public static void ExecutaComando(string comandoexec)
    {
      ExecutaComando(comandoexec, conexao);
    }

    public static void ExecutaComando(string comandoexec, IDbConnection conexaoAExecutar)
    {
      if (conexao is SqlConnection)
      {
        comand = new SqlCommand(comandoexec, (SqlConnection)conexaoAExecutar);
      }

      try
      {
        comand.CommandTimeout = 600;
        comand.ExecuteNonQuery();
        comand.Dispose();
      }
      catch
      {
        throw;
      }
    }

    public static void CarregaObjDados(string sql, ref IDbDataAdapter adapter, BindingSource bds, DataSet ds)
    {
      CarregaObjDados(sql, ref adapter, bds, ds, conexao);
    }

    public static void CarregaObjDados(string sql, ref IDbDataAdapter adapter, BindingSource bds, DataSet ds, IDbConnection conexaoExecutar)
    {
      try
      {
        if (conexao is SqlConnection)
        {
          adapter = new SqlDataAdapter(sql, (SqlConnection)conexaoExecutar);
        }

        ds.Tables.Clear();
        bds.DataSource = null;
        adapter.Fill(ds);
        bds.DataMember = ds.Tables[0].TableName;
        bds.DataSource = ds;
      }
      catch
      {
        throw;
      }
    }


    public static DataSet RetornaDataSet(string comandoSQL)
    {
      SqlDataAdapter adapter = new SqlDataAdapter(comandoSQL, conexao as SqlConnection);
      var ds = new DataSet();
      try
      {
        adapter.Fill(ds);
      }
      catch
      {
        return null;
      }

      adapter.Dispose();

      return ds;
    }
  }
}