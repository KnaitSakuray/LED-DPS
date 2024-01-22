using LED_DPS.Class.Conexao;
using LED_DPS.Class.Global;
using LED_DPS.Class.IF_Exist_Sql;
using LED_DPS.Class.Model;
using LED_DPS.Forms;
using LED_DPS.RJControls;
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
using System.Xml.Serialization;

namespace LED_DPS.Formsa
{
    /// <summary>
    ///teste
    /// </summary>
    public partial class FrmCadastro_C : LED_DPS.Forms.ChildForm
    {
        private string QueryInsert = "";
        private string QueryUpdate = "";

        public FrmCadastro_C()
        {
            InitializeComponent();
        }
        //EVENTOS DE CONTROLES----------------------------------------------------------------------

        //limpar Campos Txt
        private void ClearALL()
        {
            // Limpa os campos de entrada de dados do formulário
            txt_modelo.Clear();
            txt_descricao.Clear();
            txt_qtd.Clear();
            txt_liquido.Clear();
            txt_bruto.Clear();
        }
        //------------------------

        //Nada nos Private
        private void txt_modelo_onTextChanged(object sender, EventArgs e)
        {

        }
        private void txt_descricao_onTextChanged(object sender, EventArgs e)
        {

        }
        private void txt_qtd_onTextChanged(object sender, EventArgs e)
        {

        }
        private void FrmCadastro_C_load(object sender, EventArgs e)
        {

        }
        private void cb_modelo_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgv_modelo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //-------------------------------------------------------------------------------------

        // Botão Atualizar e Cadastro de Modelos
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            // Verifica se o modelo já está cadastrado
            if (IfExist_MODELO_ID.Exist(Convert.ToString(txt_modelo.Texts)).Equals("1"))
            {
                // Se o modelo já estiver cadastrado, exibe um aviso
                LMessageBox.Show("Modelo já cadastrado", "Aviso");
            }
            else
            {
                // Se o modelo não estiver cadastrado, realiza o cadastro e exibe um aviso de sucesso
                InsertCadastro();
                LMessageBox.Show("Modelo  cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            // Verifica se o modelo já está cadastrado
            if (IfExist_MODELO_ID.Exist(Convert.ToString(txt_modelo.Texts)).Equals("1"))
            {
                // Se o modelo estiver cadastrado, realiza a atualização do cadastro e exibe um aviso de sucesso
                UpdateCadastro();
                LMessageBox.Show("Modelo  Atualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Se o modelo não estiver cadastrado, exibe uma mensagem de aviso
                LMessageBox.Show("Modelo não cadastrado", "Aviso");
            }
        }
        //------------------------------------------------------------

        private void FrmCadastro_C_Load_1(object sender, EventArgs e)
        {
            // Carrega os modelos existentes no formulário e consulta todos os registros
            LoadModelos();
            consultaAll();
        }

        //=================================================================================================================
        /// <summary>
        /// REGIÃO ABAIXO SOMENTE PARA MÉTODOS/OBJETOS E ATRIBUTOS
        /// </summary>
        //=================================================================================================================
        #region Insert/Update
        private void InsertCadastro()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Query para inserir um novo cadastro na tabela MODELO_DPS
                QueryInsert = @"INSERT INTO [DPS].[dbo].[MODELO_DPS]

                ([modelo],[descricao],[peso_L],[peso_L],[qtd_caixa])

                VALUES

                (@Modelo, @Descricao,@peso_L,@peso_B, @Qtd_caixa)";

                using (SqlCommand cmd = new SqlCommand(QueryInsert, conn))
                {
                    // Define os parâmetros da query com os valores dos campos do formulário
                    cmd.Parameters.AddWithValue("@Modelo", txt_modelo.Text);
                    cmd.Parameters.AddWithValue("@Descricao", txt_descricao.Text);
                    cmd.Parameters.AddWithValue("@peso_L", txt_liquido.Text);
                    cmd.Parameters.AddWithValue("@peso_B", txt_bruto.Text);
                    cmd.Parameters.AddWithValue("@Qtd_caixa", txt_qtd.Text);

                    // Executa a query de inserção
                    cmd.ExecuteNonQuery();
                    // Limpa os campos do formulário após a inserção
                    ClearALL();
                }

            }
            // Atualiza a exibição dos registros no formulário
            consultaAll();
        }
        private void UpdateCadastro()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                // Abre a conexão com o banco de dados
                conn.Open();
                // Query para atualizar um cadastro existente na tabela MODELO_DPS
                QueryUpdate = @"UPDATE [DPS].[dbo].[MODELO_DPS] SET 
                                [modelo] = @Modelo,
                                [descricao] = @Descricao,
                                [peso_L] = @peso_L,
                                [peso_B] = @peso_B,
                                [qtd_caixa] = @Qtd_caixa

                                WHERE [modelo]= @Modelo";

                using (SqlCommand cmd = new SqlCommand(QueryUpdate, conn))
                {
                    //Campos txt/ cbox,Comunucação com as class da pasta Model>MODELO_DPS.cs
                    cmd.Parameters.AddWithValue("@Modelo", txt_modelo.Text);
                    cmd.Parameters.AddWithValue("@Descricao", txt_descricao.Text);
                    cmd.Parameters.AddWithValue("@peso_L", txt_liquido.Text);
                    cmd.Parameters.AddWithValue("@peso_B", txt_bruto.Text);
                    cmd.Parameters.AddWithValue("@Qtd_caixa", txt_qtd.Text);

                    // Executa a query de atualização
                    cmd.ExecuteNonQuery();
                    // Limpa os campos do formulário após a atualização
                    ClearALL();
                }
            }
            // Atualiza a exibição dos registros no formulário
            consultaAll();

        }
        #endregion
        #region Consulta( All e OP)
        private void consultaAll()
        {
            SqlConnection conecta = new SqlConnection(Conexao.ROTA);
            SqlCommand comande = new SqlCommand("SELECT * FROM [DPS].[dbo].[MODELO_DPS]", conecta);
            // Abre a conexão com o banco de dados
            conecta.Open();
            // Executa o comando SQL e obtém os dados resultantes
            SqlDataReader dr = comande.ExecuteReader();
            // Cria um objeto DataTable para armazenar os dados resultantes
            DataTable dt = new DataTable();
            // Carrega os dados do SqlDataReader para o DataTable
            dt.Load(dr);
            // Define o DataTable como a fonte de dados do DataGridView dgv_modelo
            dgv_modelo.DataSource = dt;
            // Fecha a conexão com o banco de dados
            conecta.Close();
        }
        private void consultaOP()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Cria um comando SQL para selecionar os registros da tabela CKD_DPS que correspondem à OP especificada
                using (SqlCommand cmd = new SqlCommand(@"SELECT [CKD_PK]
                    ,[modelo_id_fk]
                    ,[status_op]
                    ,[data]
                    ,[date_hora]
                    ,[qtd]
                    ,[descricao]
                    ,[peso_L]
                    ,[peso_L]
                    ,[filial]
                     FROM [DPS].[dbo].[CKD_DPS]
                     WHERE [CKD_DPS] = @CKD_DPS", conn))
                {
                    // Define o parâmetro da consulta usando o valor de txt_Nop
                    cmd.Parameters.AddWithValue("@CKD_DPS", txt_Nop.Text);

                    // Executa o comando SQL e obtém os dados resultantes usando um SqlDataReader
                    SqlDataReader dr = cmd.ExecuteReader();
                    // Cria um objeto DataTable para armazenar os dados resultantes
                    DataTable dt = new DataTable();
                    // Carrega os dados do SqlDataReader para o DataTable
                    dt.Load(dr);
                    // Define o DataTable como a fonte de dados do DataGridView dgv_modelo
                    dgv_modelo.DataSource = dt;

                }
            }

        }
        #endregion
        #region Load
        private void LoadModelos()
        {

            SqlConnection cn10 = new SqlConnection(Conexao.ROTA);
            SqlCommand cmd10 = new SqlCommand("SELECT modelo FROM [DPS].[dbo].[MODELO_DPS]", cn10);
            cn10.Open();
            // Executa o comando SQL e obtém os dados resultantes usando um SqlDataReader
            SqlDataReader dr10 = cmd10.ExecuteReader();
            // Cria um objeto DataTable para armazenar os dados resultantes
            DataTable dt10 = new DataTable();
            // Carrega os dados do SqlDataReader para o DataTable
            dt10.Load(dr10);
            // Define o campo "modelo" como o valor a ser exibido no ComboBox txt_Nop
            txt_Nop.DisplayMember = "modelo";
            // Define o DataTable como a fonte de dados do ComboBox txt_Nop
            txt_Nop.DataSource = dt10;
            // Fecha a conexão com o banco de dados
            cn10.Close();
            // Define o índice selecionado do ComboBox txt_Nop como -1 (nenhum item selecionado)
            txt_Nop.SelectedIndex = -1;
        }
        #endregion

    }
}
