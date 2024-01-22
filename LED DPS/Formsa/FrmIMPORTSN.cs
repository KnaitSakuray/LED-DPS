using LED_DPS.Class.Conexao;
using LED_DPS.Class.Global;
using LED_DPS.Class.IF_Exist_Sql;
using LED_DPS.Class.Model;
using LED_DPS.Forms;
using LED_DPS.RJControls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_DPS.Formsa
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmIMPORTSN : LED_DPS.Forms.ChildForm
    {

        private string _sn;
        private string _sn_count;

        public FrmIMPORTSN()
        {
            InitializeComponent();
        }
        //EVENTOS DE CONTROLES----------------------------------------------------------------------


        // Delet de SN no banco de dados pelo Botão
        private void DeleteSNImport(object sender, EventArgs e)
        {
            // cria um novo objeto SqlConnection
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                // abre a conexão
                conn.Open();

                // escreve a consulta SQL para deletar a importação SN
                // cria um novo objeto SqlCommand com a consulta e o objeto SqlConnection
                using (SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[SN_DPS] WHERE [id_ckd_fk]= @id_ckd_fk", conn))
                {
                    // adiciona o parâmetro SN ao comando
                    cmd.Parameters.AddWithValue("@id_ckd_fk", SN_DPS.id_ckd_fk);

                    // executa o comando
                    cmd.ExecuteNonQuery();
                }
            }

        }
        //------------------------------------------------------------------------------------------

        // botão Delet SN do banco de dados
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ROTA))
            {
                // Consulta SQL para verificar se o SN existe na tabela
                string query = "SELECT COUNT(*) FROM [DPS].[dbo].[Embalagem]  WHERE [id_ckd_fk]= @id_ckd_fk";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@id_ckd_fk", SN_DPS.id_ckd_fk);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        // Se o SN for encontrado, executamos o DELETE
                        query = "DELETE FROM [DPS].[dbo].[SN_DPS] WHERE [id_ckd_fk]= @id_ckd_fk";

                        using (SqlCommand deleteCommand = new SqlCommand(query, connection))
                        {

                            deleteCommand.Parameters.AddWithValue("@id_ckd_fk", SN_DPS.id_ckd_fk);

                            deleteCommand.ExecuteNonQuery();

                            LMessageBox.Show("Sn's deletado do sistema!");
                        }
                    }
                    else
                    {
                        LMessageBox.Show("SN ja passou pela EMBALAGEM! Não pode ser deletado.");
                    }
                }
            }


        }
        //------------------------------------------------------------

        //Estruturas do SN
        private void btn_crirSN_Click(object sender, EventArgs e)
        {
            EstruturaSn();
        }
        //----------------------------------------------------------

        //Dispara o loop ao selecionar uma OP
        private void cb_op_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInfos();
            SN_DPS.id_ckd_fk = cb_op.Text;
        }
        //----------------------------------------------------------------------

        //Load OPs
        private void FrmIMPORTSN_Load(object sender, EventArgs e)
        {

            LoadOP();
        }
        //----------------------------------------------------------
     
        //Insert Botão
        private void btn_ExportSN_Click(object sender, EventArgs e)
        {
            InsertBulk();
        }
        //------------------------------------------------------------



        //=================================================================================================================
        /// <summary>
        /// REGIÃO ABAIXO SOMENTE PARA MÉTODOS/OBJETOS E ATRIBUTOS
        /// </summary>
        //=================================================================================================================

        #region Parte de Load( Inf e OP)
        private void LoadInfos()
        {

            using (SqlConnection connection = new SqlConnection(Conexao.ROTA))
            {
                // Abrir a conexão com o banco de dados
                connection.Open();

                // Criar o comando SQL
                string sql = @"SELECT [CKD_PK], [modelo_id_fk], [data], [qtd], [filial], M.modelo 
                             FROM DPS.[dbo].[CKD_DPS] AS C 
                             INNER JOIN DPS.[dbo].[MODELO_DPS] AS M 
                             ON C.[modelo_id_fk]=M.Id_modelo_PK WHERE CKD_PK=@CKD";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CKD", cb_op.Texts);
                // Executar o comando e obter o SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Verificar se o SqlDataReader contém resultados
                    if (reader.HasRows)
                    {
                        // Loop através dos resultados usando o while loop
                        while (reader.Read())
                        {
                            // Obter os valores das colunas
                            lblNumeroOP.Text = reader.GetString(0);
                            SN_DPS.id_modelo = reader.GetInt32(1);
                            DateTime data = reader.GetDateTime(2);
                            txt_total.Text = reader.GetInt32(3).ToString();
                            //txt_filial.Text = reader.GetInt32(4).ToString();
                            txt_modelo.Text = reader.GetString(5);

                            txt_dataD.Text = data.Day.ToString();
                            txt_dataM.Text = data.Month.ToString().PadLeft(2, '0');
                            txt_dataA.Text = data.Year.ToString().Substring(data.Year.ToString().Length - 2);

                            txt_inicial.Text = "00001";
                            txt_final.Text = txt_total.Text.PadLeft(5, '0');
                        }
                    }
                }
            }
        }
        private void LoadOP()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                // Abrir a conexão com o banco de dados
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"SELECT TOP 100 [CKD_PK]  FROM [DPS].[dbo].[CKD_DPS] ORDER BY CKD_PK DESC", conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    // SETUP DO COMBO BOX
                    cb_op.DisplayMember = "CKD_PK";
                    cb_op.DataSource = dt;
                    cb_op.SelectedIndex = -1;

                }
            }
        }
        #endregion

        #region Parte de Estrutura e InsertBulk
        private void EstruturaSn()
        {


            //suspende o layout da grid
            dgv_Import.SuspendLayout();
            //limpa do dgv
            dgv_Import.Rows.Clear();
            dgv_Import.Columns.Clear();
            dgv_Import.Refresh();


            //define as colunas
            dgv_Import.Columns.Add("SN", "SN");
            dgv_Import.Columns.Add("SEQ", "SEQ");

            //define o sn *txt_filial.Text +
            _sn = txt_modelo.Text + txt_dataA.Text + txt_dataM.Text + txt_dataD.Text;

            //Loop para criar os SN
            for (long i = Convert.ToInt64(txt_inicial.Text.Trim()); i <= Convert.ToInt64(txt_final.Text); i++)
            {

                //objeto do dgv
                DataGridViewRow item = new DataGridViewRow();

                //cria as celulas
                item.CreateCells(dgv_Import);

                //define o sn
                _sn_count = _sn + i.ToString().PadLeft(5, '0');

                //define os valores das celulas
                item.Cells[0].Value = _sn_count;
                item.Cells[1].Value = i;

                //adiciona as linhas
                dgv_Import.Rows.Add(item);

                //Verifica se o SN existe  (TERMINAR O IF EXIST DA TABELA SN)
                if (IfExist_SN_CKD.Exist(_sn_count, lblNumeroOP.Text).Equals("1"))
                {
                    LMessageBox.Show("SN já foi exportado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            //reativa o layout da grid
            dgv_Import.ResumeLayout();
        }
        private void InsertBulk()
        {
            DateTime DT = DateTime.Now;

            //cria a tabela em memória local
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("sn", typeof(string));
            dataTable.Columns.Add("data", typeof(DateTime));
            dataTable.Columns.Add("data_hora", typeof(DateTime));
            dataTable.Columns.Add("id_modelo", typeof(int));
            dataTable.Columns.Add("id_ckd_fk", typeof(string));
            dataTable.Columns.Add("filial", typeof(int));

            //preenche a tabela em memória local com os dados do dgv
            for (int i = 0; i < dgv_Import.Rows.Count - 1; i++)
            {
                if (dgv_Import.Rows[i].Cells[0].Value != null)
                {
                    //cria uma nova linha na tabela em memória local
                    DataRow newRow = dataTable.NewRow();
                    newRow["sn"] = dgv_Import.Rows[i].Cells[0].Value.ToString();
                    newRow["data"] = DateTime.Parse(DT.ToString().Substring(0, 10));
                    newRow["data_hora"] = DT;
                    newRow["id_modelo"] = SN_DPS.id_modelo;
                    newRow["id_ckd_fk"] = lblNumeroOP.Text;
                    newRow["filial"] = "06";
                    dataTable.Rows.Add(newRow);
                }
            }

            //prepara a conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                //faz o bulk insert!!!
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                {
                    bulkCopy.DestinationTableName = "[DPS].[dbo].[SN_DPS]";
                    bulkCopy.WriteToServer(dataTable);
                }
                conn.Close();
            }

            dgv_Import.Rows.Clear();
            dgv_Import.Refresh();

            LMessageBox.Show("EXPORTAÇÃO CONCLUIDA");

        }
        #endregion

    }

}
