using LED_DPS.Class.Conexao;
using LED_DPS.Class.IF_Exist_Sql;
using LED_DPS.Class.Model;
using LED_DPS.Forms;
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

namespace LED_DPS.Formsa
{
    public partial class FrmConsultaML : LED_DPS.Forms.ChildForm
    {
        public FrmConsultaML()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  no consulta ML ainda não consegui pegar a query certa, mas seguindo os codigo!
        /// </summary>
        /// 

        private void txt_consulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Executa quando uma tecla é pressionada no campo de texto txt_consulta

            consultaML();
            consultaAll();
        }
        private void Btn_consultaML_Click(object sender, EventArgs e)
        {
            // Executa quando o botão Btn_consultaML é clicado
            consultaML();
            consultaAll();
        }


        //=======================================================================================================================
        /// <summary>
        /// REGIÃO ABAIXO SOMENTE PARA MÉTODOS/OBJETOS E ATRIBUTOS
        /// </summary>
        //=================================================================================================================

        private void consultaML()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                //abre conexão
                conn.Open();

                // não consegui pegar a forma correta de query pra consulta
                using (SqlCommand cmd = new SqlCommand(@"  
                SELECT COUNT(E.sn) AS TOTAL,
                E.numero,
                M.modelo,
                E.id_ckd_fk,
                MAX(E.data_hora) AS DATA,
                E.linha
                FROM [DPS].[dbo].[EMBALAGEM] AS E
                INNER JOIN [DPS].[dbo].[MODELO_DPS] AS M 
                ON E.id_modelo = M.Id_modelo_PK
                WHERE E.numero = @numero
                GROUP BY E.numero, M.modelo, E.id_ckd_fk, E.linha", conn))
                {
                    // aqui a pessoa vai digitar o numero da caixa no Txt_ml
                    cmd.Parameters.AddWithValue("@numero", txt_consulta.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    // while  para trazer uma linha em especifico que é a op, linha, modelo, qtd,datah
                    while (reader.Read())
                    {
                        // OP
                        txt_op.Text = reader["id_ckd_fk"].ToString();
                        //linha em que foi logado
                        txt_linha.Text = reader["linha"].ToString();
                        //modelo que foi vinculado a OP
                        txt_modelo.Text = reader["modelo"].ToString();
                        // quantidade que foi produzido em uma caixa
                        txt_qtd.Text = reader["TOTAL"].ToString();
                        //data hora da produção
                        txt_dataH.Text = reader["DATA"].ToString();
                    }
                    reader.Close();
                }
            }
        }

        // faz a consulta do SN pelo numero da caixa
        private void consultaAll()
        {
            using (SqlConnection conecta = new SqlConnection(Conexao.ROTA))
            {
                string query = @"
                            SELECT [sn]
                            FROM [dbo].[EMBALAGEM]
                            WHERE [numero] = @numero
                            ORDER BY [sn] ASC"; // Ordena os números de série em ordem crescente

                using (SqlCommand comande = new SqlCommand(query, conecta))
                {
                    comande.Parameters.AddWithValue("@numero", txt_consulta.Text);
                    DataTable dt = new DataTable();

                    conecta.Open();
                    SqlDataReader dr = comande.ExecuteReader();
                    dt.Load(dr);
                    conecta.Close();

                    // Ordena os dados antes de exibi-los no DataGridView
                    DataView dv = dt.DefaultView;
                    dv.Sort = "sn ASC";
                    dgv_sn.DataSource = dv;
                }
            }
        }


    }
}
