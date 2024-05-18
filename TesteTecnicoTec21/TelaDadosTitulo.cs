using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTecnicoTec21
{
    public partial class TelaDadosTitulo : Form
    {
        public TelaDadosTitulo()
        {
            InitializeComponent();
        }

        //ESSA CONECTIONSTRING PROVAVELMENTE VAI PRECISAR SER ALTERADA CASO O BANCO DE TESTES TROQUE PARA OUTRA MÁQUINA
        public string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Tech21db;Data Source=DESKTOP-QR4BNH8\SQLSERVER01";

        //Faz o click no botão de salvar adicionando os dados faltantes
        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            if(txtDataApresentacao.Text == "  /  /")
            {
                lblAlerta.Text = "A Data da Apresentação precisa ser preenchida!";
                lblAlerta.Visible = true;
                return;
            }

            if(txtValorCustas.Text == "     .")
            {
                lblAlerta.Text = "O Valor das Custas precisa ser preenchido!";
                lblAlerta.Visible = true;
                return;
            }


            lblIdTitulo.Text = TelaImportacao.valorIdTitulo.ToString();
            SalvarDados(txtDataApresentacao.Text, txtValorCustas.Text, Convert.ToInt32(lblIdTitulo.Text));
            this.Close();
        }

        //Salva os dados no banco de dados atualizando de acordo com o Id do Título
        private bool SalvarDados(string dataApresentacao, string valorCustas, int idTitulo)
        {
            string strSql = "UPDATE Titulos SET DataApresentacao = CONVERT(DATE,'" + dataApresentacao + "',103), ValorCustas = " + valorCustas + " WHERE IdTitulo = " + idTitulo;
            SqlConnection sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            try
            {
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                sqlCon.Close();
            }
        }

      
    }
}
