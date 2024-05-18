using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TesteTecnicoTec21
{
    public partial class TelaImportacao : Form
    {
        public TelaImportacao()
        {
            InitializeComponent();
            this.titulosTableAdapter1.Fill(this.tech21dbDataSet1.Titulos);
        }

        //ESSA CONECTIONSTRING PROVAVELMENTE VAI PRECISAR SER ALTERADA CASO O BANCO DE TESTES TROQUE PARA OUTRA MÁQUINA
        public string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Tech21db;Data Source=DESKTOP-QR4BNH8\SQLSERVER01";

        public static string valorIdTitulo = "";

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (!openFileDialog1.FileName.Contains(".xml"))
                {
                    lblAlerta.Text = "Só são aceitos arquivos xml para a Importação";
                    lblAlerta.Visible = true;
                    return;
                }
                //Cria um Stream Reader para ler o Arquivo Selecionado
                var sr = new StreamReader(openFileDialog1.FileName);

                //Cria um serializador para converter os dados do XML para objeto
                XmlSerializer xs = new XmlSerializer(typeof(Titulos));

                //Objeto com os arquivos desserializados
                Titulos titulos = (Titulos)xs.Deserialize(sr);

                //Cria um laço para recuperar todos os títulos que são armazenados no XML e os converte para um objeto novo
                foreach (Titulo titulo in titulos.Titulo)
                {
                    Titulo tituloBanco = new Titulo();

                    tituloBanco.Protocolo = titulo.Protocolo;
                    tituloBanco.NomeDevedor = titulo.NomeDevedor;
                    tituloBanco.DocumentoDevedor = titulo.DocumentoDevedor;
                    tituloBanco.NomeApresentante = titulo.NomeApresentante;
                    tituloBanco.DocumentoApresentante = titulo.NomeApresentante;
                    tituloBanco.NomeCredor = titulo.NomeCredor;
                    tituloBanco.DocumentoCredor = titulo.DocumentoCredor;
                    tituloBanco.NumeroTitulo = titulo.NumeroTitulo;
                    tituloBanco.ValorTitulo = titulo.ValorTitulo;
                    tituloBanco.DataEmissao = titulo.DataEmissao;
                    tituloBanco.EspecieTitulo = titulo.EspecieTitulo;

                    //Faz o trampo
                    SalvarTitulo(tituloBanco);
                }

                //Recarrega a grid de Títulos
                TelaImportacao_Load(sender, e);

                //Aviso de conclusão de importação
                lblAlerta.Text = "O arquivo " + openFileDialog1.FileName + " acabou de ser lido!";
                lblAlerta.Visible = true;
            }
        }


        //Método que salva Títulos no banco de dados
        private bool SalvarTitulo(Titulo titulo)
        {
            string strSql = "INSERT INTO Titulos (Protocolo,NomeDevedor,DocumentoDevedor,NomeApresentante,DocumentoApresentante,NomeCredor,DocumentoCredor,NumeroTitulo,ValorTitulo,DataEmissao,EspecieTitulo,DataApresentacao,ValorCustas) VALUES (" + titulo.Protocolo + ", '" + titulo.NomeDevedor + "','" + titulo.DocumentoDevedor + "', '" + titulo.NomeApresentante + "', '" + titulo.DocumentoApresentante + "', '" + titulo.NomeCredor + "' , '" + titulo.DocumentoCredor + "', " + titulo.NumeroTitulo + ", '" + titulo.ValorTitulo + "', CONVERT(DATE,'" + titulo.DataEmissao + "',103), '" + titulo.EspecieTitulo + "', NULL,NULL )";
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

        private void TelaImportacao_Load(object sender, EventArgs e)
        {
            this.titulosTableAdapter1.Fill(this.tech21dbDataSet1.Titulos);
        }

        //Evento que faz o Clique do botão Selecione
        private void dgvTitulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewButtonCell cell = (DataGridViewButtonCell)
                            dgvTitulos.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value.ToString() == "Selecione")
                {
                    lblAlerta.Visible = false;
                    TelaDadosTitulo telaDados = new TelaDadosTitulo();

                    valorIdTitulo = cell.OwningRow.Cells[1].Value.ToString();
                    telaDados.Show();
                }
            }
            catch (Exception)
            {
                lblAlerta.Text = "Para Abrir o Título, clique no botão 'Selecione'.";
                lblAlerta.Visible = true;
            }
            

        }

        private void Reload_Click(object sender, EventArgs e)
        {
            TelaImportacao_Load(sender, e);
        }
    }
}
