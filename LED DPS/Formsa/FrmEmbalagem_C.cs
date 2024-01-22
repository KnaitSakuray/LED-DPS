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
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using static System.Resources.ResXFileRef;

namespace LED_DPS.Formsa
{
    /// <summary>
    /// 
    /// </summary>

    public partial class FrmEmbalagem_C : LED_DPS.Forms.ChildForm
    {
        private string CaixaID = "";
        private string SeguenciaJaLogada = "";
        string OP = "";
        string datahora = "";
        string descricao = "";
        string peso_L = "";
        string peso_B = "";

        public FrmEmbalagem_C()
        {
            InitializeComponent();
        }
        //EVENTOS DE CONTROLES----------------------------------------------------------------------

        // CARREGA VALORES DA OP
        private void cb_op_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            DadosOP();
            ConsultaStatus();

            // Tornar o ComboBox cb_linha visível
            cb_linha.Visible = true;

        }
        //----------------------------------------------------------------------

        //Informaçoes da linha para vincular com a OP
        private void cb_linha_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            SetLine();

            // Desabilitar o painel panelTopSide e habilitar o painel panelBotSide
            panelTopSide.Enabled = false;
            panelBotSide.Enabled = true;


            SelectMax();
            LoadItensCaixa();
            CalculoPendente();
            ConsultaIDmodelo();

            // Definir o valor de id_ckd_fk na variável GLOBAL_EMBALAGEM como o valor do texto selecionado em cb_op
            GLOBAL_EMBALAGEM.id_ckd_fk = cb_op.Texts;

        }
        //-------------------------------------------------------------------------

        //Botão para imprimir
        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            // Chamar a função ComandoImpressao() com os valores da quantidade de caixas (lblQtdCaixa.Text) e o número da caixa (txtNcaixa.Text)
            ComandoImpressao(lblQtdCaixa.Text, txtNcaixa.Text);
        }
        //------------------------------------------------------------

        //Ativação  da Embalagem para uso
        private void rjButton1_Click(object sender, EventArgs e)
        {

            SelectMax();
            CalculoPendente();
            LoadItensCaixa();

            // Atualizar o texto e a cor do botão BtnStatus para indicar que a embalagem está ativa
            BtnStatus.Text = "EMBALAGEM ATIVA";
            BtnStatus.BackColor = Color.FromArgb(55, 159, 113);

        }
        //---------------------------------------------------------
        SqlDataReader DR1;

        // Botão Back e Next
        private void btn_frente_Click(object sender, EventArgs e)
        {

            SelectNext();
        }
        private void btn_atras_Click(object sender, EventArgs e)
        {
            // Atualizar o texto e a cor do botão BtnStatus para indicar que a embalagem está desativada
            BtnStatus.Text = "EMBALAGEM DESATIVADA";
            BtnStatus.BackColor = Color.FromArgb(234, 79, 82);


            SelectBack();
        }

        //Sn no Textbox 
        private void txt_sn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar se a tecla pressionada não é Enter (char 13)
            if (e.KeyChar != (char)13)
            {
                return;
            }
            // Verificar se os campos cb_op e cb_linha foram preenchidos
            if (cb_op.Text == "" || cb_linha.Texts == "")
            {
                LMessageBox.Show("Preencha todos os campos!", "AVISO");
                return;
            }
            //condição para esse exist n é 1 e sim 0, pois 0 =  não existe
            // Verificar se o SN não existe na OP
            if (IfExist_SN_CKD.Exist(txt_sn.Text, cb_op.Texts).Equals("0"))
            {
                LMessageBox.Show("Sn  não existe nessa OP", "aviso");
                txt_sn.Clear();
                return;
            }

            int NaCaixa =Convert.ToInt32(lblQtdCaixa.Text);
            int PorCaixa =Convert.ToInt32(lblPorCaixa.Text);

            if(NaCaixa >= PorCaixa)
            {
                LMessageBox.Show("Caixa cheia", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txt_sn.Clear();
                return;
            }

            // Verificar se o SN já foi registrado anteriormente
            if (IfExist_EMBALAGEM_SN.Exist(txt_sn.Text).Equals("1"))
            {
                // Verificar se o SN já foi registrado anteriormente na tabela de EMBALAGEM
                using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
                {
                    conn.Open();
                    // Criar um comando SQL para selecionar informações relacionadas ao SN na tabela EMBALAGEM
                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT  [id_ckd_fk],[data_hora] ,[numero] FROM [DPS].[dbo].[EMBALAGEM] where SN=@sn", conn))
                    {
                        cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = txt_sn.Text;
                        DR1 = cmd.ExecuteReader();
                        // Ler os resultados da consulta e armazenar em variáveis
                        while (DR1.Read())
                        {
                            OP = DR1["id_ckd_fk"].ToString();
                            datahora = DR1["data_hora"].ToString();
                            SeguenciaJaLogada = DR1["numero"].ToString();
                        }
                        // Atualizar o texto do label lblAvisos para mostrar informações sobre o SN já registrado
                        lblAvisos.Text = "Sn já logado:" + txt_sn.Text + "\nNa OP:" + OP + ",Hora:" + datahora + "\nCaixa:" + SeguenciaJaLogada;
                        lblAvisos.ForeColor = Color.Salmon;

                        // Exibir um MessageBox com informações sobre o SN já registrado
                        LMessageBox.Show("Sn já logado:" + txt_sn.Text + " na OP:" + OP + "Hora" + datahora + "\nCaixa:" + SeguenciaJaLogada, "Aviso");
                    }
                }
                // Limpar o campo de texto do SN e encerrar o processamento
                txt_sn.Clear();
                return;
            }


            // Atualizar o texto e a cor do label lblAvisos para indicar que o SN passou
            lblAvisos.Text = "PASS";
            lblAvisos.ForeColor = Color.ForestGreen;


            //insere a caixa
            InsertSN();

            //consulta total presente na caixa
            SelectQtdPresenteNaCaixa();

            // consulta quantidade que tem na OP
            ConsultaStatus();

            //calcula a quantidade pendente
            CalculoPendente();

            //imprime a etiqueta - fecha a caixa -  e solicita uma nova
            ImpressaoAutomatica();

            //trava a embalagem para que não possa bipar mais
            TravaTela();

            // Limpar o campo de texto do SN
            txt_sn.Text = "";
            txt_sn.Focus();

            // Limpar a grid view dgv_caixa e recarregar os itens da caixa
            dgv_caixa.Rows.Clear();
            LoadItensCaixa();

            // Limpar todas as outras variáveis ou estados
            ClearAll();

        }
        //-----------------------------------------------------------------

        private void FrmEmbalagem_C_Load(object sender, EventArgs e)
        {
            LoadOP();
        }

        //Nada nos Private
        private void txt_sn_onTextChanged(object sender, EventArgs e)
        {

        }
        private void cb_op_Load(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------

        //=======================================================================================================================
        /// <summary>
        /// REGIÃO ABAIXO SOMENTE PARA MÉTODOS/OBJETOS E ATRIBUTOS
        /// </summary>
        //=================================================================================================================


        private void TravaTela()
        {
            // Variável para armazenar a quantidade de SNs registrados
            int quantidadeRegistrada = 0;
            int quantidadePermitida = 0;
            // Conectar-se ao banco de dados
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Consultar a quantidade de SNs registrados para a caixa atual e a OP selecionada
                using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(sn) FROM [DPS].[dbo].[EMBALAGEM] WHERE numero=@NUM AND id_ckd_fk=@OP", conn))
                {
                    cmd.Parameters.AddWithValue("@NUM", txtNcaixa.Text);
                    cmd.Parameters.AddWithValue("@OP", cb_op.Texts);
                    quantidadeRegistrada = Convert.ToInt32(cmd.ExecuteScalar());
                }
                // Consultar a quantidade permitida de SNs para a OP selecionada
                using (SqlCommand cmd = new SqlCommand(@"SELECT M.qtd_caixa FROM [DPS].[dbo].[CKD_DPS] AS C INNER JOIN DPS.dbo.MODELO_DPS AS M ON M.Id_modelo_PK=C.modelo_id_fk WHERE C.CKD_PK=@OP", conn))
                {
                    cmd.Parameters.AddWithValue("@OP", cb_op.Texts);
                    quantidadePermitida = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            // Verifica se a quantidade máxima de SNs foi atingida
            if (quantidadeRegistrada >= quantidadePermitida)
            {
                // Se atingiu o limite, desabilita a entrada de novos SNs
                txt_sn.Enabled = false;
                LMessageBox.Show("Limite da Op Atingido!", "Aviso");
            }
            else
            {
                // Se a quantidade ainda não atingiu o limite, permite a entrada de novos SNs

                txt_sn.Enabled = true;
            }
        }

        //caso o sn não exista ele da um aviso caso não ele constinua tranquilamente!
        private void VerificacaoSN()
        {
            // Conectar-se ao banco de dados
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Consultar a quantidade de registros na tabela SN_DPS que possuem o SN igual a txt_sn.Text
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [DPS].[dbo].[SN_DPS] WHERE [sn] = @sn", conn))
                {
                    cmd.Parameters.Add("@sn", SqlDbType.VarChar).Value = txt_sn.Text;
                    int count = (int)cmd.ExecuteScalar();
                    // Verificar se o SN não existe na tabela SN_DPS
                    if (count == 0)
                    {
                        // Se o SN não existir na tabela, exibir um aviso
                        LMessageBox.Show("SN não importado.", "AVISO");

                    }


                }
            }
        }
        //--------------------------

        // esqueleto que entrega os valores presentes na caixa para o datagridview
        private void LoadItensCaixa()
        {
            // Limpar as linhas da DataGridView dgv_caixa
            dgv_caixa.Rows.Clear();

            // Conectar-se ao banco de dados
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Consultar os registros da tabela EMBALAGEM para o número de caixa, OP e linha especificados
                using (SqlCommand cmd = new SqlCommand(@"SELECT [sn], [data_hora]
                                FROM DPS.[dbo].[EMBALAGEM]
                                WHERE numero = @CAIXA AND linha = @L
                                ORDER BY [data_hora] DESC;", conn))
                {

                    cmd.Parameters.AddWithValue("@CAIXA", txtNcaixa.Text);
                    cmd.Parameters.AddWithValue("@L", cb_linha.Texts);

                    SqlDataReader reader = cmd.ExecuteReader();
                    // Ler os resultados da consulta e adicionar cada registro à DataGridView
                    while (reader.Read())
                    {
                        dgv_caixa.Rows.Add(reader["SN"].ToString(), lblmodelo.Text, reader["data_hora"].ToString());
                    }
                    // Fechar o leitor após uso
                    reader.Close();
                }
            }
            // Atualizar a quantidade presente na caixa
            SelectQtdPresenteNaCaixa();
        }
        //---------------------------

        //...
        private void SelectQtdPresenteNaCaixa()
        {
            // Abrir uma conexão com o banco de dados usando a string de conexão da classe Conexao
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                // Abrir a conexão com o banco de dados
                conn.Open();
                // Criar um comando SQL para contar a quantidade de registros na tabela [EMBALAGEM]
                // que correspondem aos critérios fornecidos
                using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(sn) FROM [DPS].[dbo].[EMBALAGEM] WHERE numero=@NUM AND id_ckd_fk=@OP", conn))
                {
                    // Adicionar parâmetros ao comando SQL para substituir os valores das variáveis
                    // @NUM e @OP pelos valores de txtNcaixa.Text e cb_op.Texts, respectivamente
                    cmd.Parameters.AddWithValue("@NUM", txtNcaixa.Text);
                    cmd.Parameters.AddWithValue("@OP", cb_op.Texts);
                    // Executar o comando SQL usando ExecuteScalar() para obter o resultado da contagem
                    // Converter o resultado para um valor inteiro e, em seguida, para uma string
                    lblQtdCaixa.Text = (Convert.ToInt32(cmd.ExecuteScalar())).ToString();
                }
            }
        }
        //-------------------------------------

        //...
        private void CalculoPendente()
        {
            //DEFINE O VALOR DE DPS PENDENTE PARA EMBALAR NA CAIXA 
            lblPendente.Text = (Convert.ToInt32(lblPorCaixa.Text) - Convert.ToInt32(lblQtdCaixa.Text)).ToString();
        }
        //------------------------

        //Limpa Txt
        private void ClearAll()
        {
            txt_sn.Clear();
        }
        //------------------------

        //SET DO ID LINHA Q VOU USAR NA ETIQUETA
        private void SetLine()
        {
            if (cb_linha.Texts == "LINHA1")
            {
                CaixaID = "L1E";// Define o ID da caixa como "L1E"
                Conexao.PRINT_SERVER = Conexao.PRINT_SERVER + "DPS1";
            }
            else if (cb_linha.Texts == "LINHA2")
            {
                CaixaID = "L2E";
                Conexao.PRINT_SERVER = "Microsoft Print to PDF";
            }

            else if (cb_linha.Texts == "LINHA3") CaixaID = "L3E"; // DPS3
        }
        //--------------------

        #region Delete

        // Evento de clique no botão de deleção
        private void btnDeletarSn_Click(object sender, EventArgs e)
        {
            // Certifica se uma linha está selecionada no DataGridView
            if (dgv_caixa.SelectedRows.Count > 0)
            {
                // Obtém o valor do 'sn' da linha selecionada
                string snToDelete = dgv_caixa.SelectedRows[0].Cells["sn"].Value.ToString();
                // Chama a função DeletarSN() para remover o SN do banco de dados
                DeletarSN(snToDelete);
                // Remove a linha selecionada do DataGridView
                dgv_caixa.Rows.RemoveAt(dgv_caixa.SelectedRows[0].Index);
                // Atualiza o status da consulta
                ConsultaStatus();
                // Atualiza a quantidade presente na caixa
                SelectQtdPresenteNaCaixa();


            }
            else
            {
                LMessageBox.Show("Por favor, selecione uma linha para deletar o SN.");
            }
        }

        // Método para deletar o 'sn' na tabela [dbo].[EMBALAGEM]
        private void DeletarSN(string sn)
        {
            try
            {
                // Cria a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(Conexao.ROTA))
                {
                    connection.Open();

                    // Define o comando SQL para deletar o 'sn' na tabela
                    string sqlQuery = "DELETE FROM [DPS].[dbo].[EMBALAGEM] WHERE [sn] = @sn";

                    // Cria o objeto SqlCommand e adiciona os parâmetros
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@sn", sn);

                        // Executa o comando de deletar
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Deleção bem-sucedida
                            LMessageBox.Show("SN deletado com sucesso.");
                        }
                        else
                        {
                            // O 'sn' não foi encontrado na tabela
                            LMessageBox.Show("SN não encontrado na tabela.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate a exceção, se necessário
                LMessageBox.Show("Erro ao deletar o SN: " + ex.Message);
            }
        }



        #endregion

        #region Consulta
        //consulta status Quantidade da OP que resta
        private void ConsultaStatus()
        {
            // Conectar-se ao banco de dados
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Consultar a contagem total de SNs registrados na OP atual
                using (SqlCommand cmd = new SqlCommand(@"SELECT COUNT(sn) AS TOTAL
                                                FROM [DPS].[dbo].[EMBALAGEM] 
                                                WHERE [id_ckd_fk] = @id_ckd_fk", conn))
                {
                    cmd.Parameters.AddWithValue("@id_ckd_fk", cb_op.Texts); // Substitua pelo valor real do id_ckd_fk

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        lblStatusOP.Text = reader["TOTAL"].ToString();// Atualiza o texto da label lblStatusOP com a contagem total de SNs na OP

                        int quantidadeOP = Convert.ToInt32(lblQtdOP.Text);// Converte o texto da label lblQtdOP em um número inteiro
                        int quantidadeRegistrada = Convert.ToInt32(reader["TOTAL"]);// Obtém a quantidade total de SNs registrados na OP

                        // Verifica se a OP foi finalizada
                        if (quantidadeRegistrada >= quantidadeOP)
                        {
                            // Se a OP foi finalizada (quantidade registrada igual ou superior à quantidade total da OP), exibe uma mensagem de aviso
                            LMessageBox.Show("FINALIZADO! Por favor escolher outra OP!", "Aviso");
                        }
                    }

                    reader.Close();
                }
            }

        }


        private void ConsultaIDmodelo()
        {

            /// consultar o id do modelo dps pela coluna modelo para retornar o id
            /// SELECT[Id_modelo_PK] FROM[DPS].[dbo].[MODELO_DPS] where modelo = ''
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Consultar o ID do modelo DPS, descrição e pesos associados ao modelo atual
                using (SqlCommand cmd = new SqlCommand(@"SELECT[Id_modelo_PK], [descricao],[peso_L],[peso_B] FROM[DPS].[dbo].[MODELO_DPS] where modelo = @modelo", conn))
                {
                    // Substituir pelo valor real do modelo
                    cmd.Parameters.AddWithValue("@modelo", lblmodelo.Text);
                    // Obter o ID do modelo e outros dados relacionados
                    GLOBAL_EMBALAGEM.id_modelo = int.Parse(cmd.ExecuteScalar().ToString());

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Armazenar detalhes adicionais sobre o modelo
                        EMBALAGEM.id_modelo = Convert.ToInt32(reader["Id_modelo_PK"]);
                        descricao = reader["descricao"].ToString();
                        peso_L = reader["peso_L"].ToString();
                        peso_B = reader["peso_B"].ToString();

                    }
                    // Fechar o leitor após uso
                    reader.Close();

                }
            }
        }
        #endregion

        #region linha de codigo Botao (Back, Next e Max)

        private void SelectMax()
        {
            int valorAtualMaximo = 0;
            // Conectar-se ao banco de dados
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Consultar o valor máximo da coluna "numero" na tabela EMBALAGEM para a linha especificada
                using (SqlCommand cmd = new SqlCommand(@"SELECT RIGHT(MAX([numero]), 7) FROM [DPS].[dbo].[EMBALAGEM] WHERE linha = @LINHA", conn))
                {
                    cmd.Parameters.AddWithValue("@LINHA", cb_linha.Text);
                    // Obtém o valor atual máximo
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        valorAtualMaximo = Convert.ToInt32(result);
                    }
                }
            }

            // Incrementa o valor máximo em 1
            int novoValor = valorAtualMaximo + 1;

            // Formata o novo valor com pelo menos 7 dígitos, preenchidos com zeros à esquerda
            string novoNumeroFormatado = $"{CaixaID}{novoValor:D7}";

            // Atualiza o texto do txtNcaixa com o novo número formatado
            txtNcaixa.Text = novoNumeroFormatado;
        }
        private void SelectNext()
        {

            string valorNextCaixa = "";
            int ValorAtual = 0;
            // Obter o valor numérico da parte final do texto em txtNcaixa
            ValorAtual = Convert.ToInt32(txtNcaixa.Text.ToString().Substring(txtNcaixa.Text.Length - 7));
            // Calcula o próximo valor da caixa
            valorNextCaixa = CaixaID + (ValorAtual + 1).ToString();
            // Conectar-se ao banco de dados
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Verifica se o próximo valor da caixa já existe na tabela EMBALAGEM
                using (SqlCommand cmd = new SqlCommand(@"SELECT RIGHT( numero ,7) FROM [DPS].[dbo].[EMBALAGEM] WHERE linha=@LINHA and numero=@ND", conn))
                {
                    cmd.Parameters.AddWithValue("@LINHA", cb_linha.Texts);
                    cmd.Parameters.AddWithValue("@ND", valorNextCaixa);
                    // Executa a consulta para verificar a existência
                    cmd.ExecuteScalar();
                }
            }
            // Atualiza o texto do txtNcaixa para o próximo valor da caixa
            txtNcaixa.Text = valorNextCaixa;
            // Carrega os itens da nova caixa
            LoadItensCaixa();

        }
        private void SelectBack()
        {
            string valorBackCaixa = "";
            int ValorAtual = 0;
            // Obter o valor numérico da parte final do texto em txtNcaixa
            ValorAtual = Convert.ToInt32(txtNcaixa.Text.ToString().Substring(txtNcaixa.Text.Length - 7));
            // Subtrai 1 para calcular o valor da caixa anterior
            valorBackCaixa = CaixaID + (ValorAtual - 1).ToString();
            // Conectar-se ao banco de dados
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Verifica se o valor da caixa anterior existe na tabela EMBALAGEM
                using (SqlCommand cmd = new SqlCommand(@"SELECT RIGHT( numero ,7) FROM [DPS].[dbo].[EMBALAGEM] WHERE linha=@LINHA and numero=@ND", conn))
                {
                    cmd.Parameters.AddWithValue("@LINHA", cb_linha.Texts);
                    cmd.Parameters.AddWithValue("@ND", valorBackCaixa);
                    // Executa a consulta para verificar a existência
                    cmd.ExecuteScalar();
                }
            }
            // Atualiza o texto do txtNcaixa para o valor da caixa anterior
            txtNcaixa.Text = valorBackCaixa;
            // Carrega os itens da caixa anterior
            LoadItensCaixa();
        }

        #endregion

        #region Insert
        private void InsertSN()
        {
            ///remover
            ///
            GLOBAL_USER__DPS.Id_matricula = 1;
            ///remover
            VerificacaoSN();
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                //Query pega do insert no SQL
                string QueryInsert = @"
                 INSERT INTO  [DPS].[dbo].[EMBALAGEM]
                ([numero],[sn],[id_modelo]
                ,[id_ckd_fk],[id_user]
                ,[data],[data_hora]
                ,[filial],[d_e_l_e_t_e]
                ,[linha])
                VALUES
                (@numero, @sn, @id_modelo, @id_ckd_fk, @id_user, GETDATE(), GETDATE(), @filial, @d_e_l_e_t_e, @linha)";

                using (SqlCommand cmd = new SqlCommand(QueryInsert, conn))
                {
                    //TERMINAR DE PREENCHER OS PARAMETROS
                    cmd.Parameters.AddWithValue("@numero", txtNcaixa.Text);
                    cmd.Parameters.AddWithValue("@sn", txt_sn.Text);
                    cmd.Parameters.AddWithValue("@id_modelo", GLOBAL_EMBALAGEM.id_modelo);
                    cmd.Parameters.AddWithValue("@id_ckd_fk", cb_op.Texts);
                    cmd.Parameters.AddWithValue("@id_user", SqlDbType.Int).Value = GLOBAL_USER__DPS.Id_matricula;
                    cmd.Parameters.AddWithValue("@filial", SqlDbType.Int).Value = 06;
                    cmd.Parameters.AddWithValue("@d_e_l_e_t_e", SqlDbType.VarChar).Value = 0;
                    cmd.Parameters.AddWithValue("@linha", cb_linha.Texts);

                    cmd.ExecuteNonQuery();
                }
            }

            SelectQtdPresenteNaCaixa();
        }
        #endregion

        #region BOTSIDE(Load Dados Op)

        private void DadosOP()
        {
            // Conectar-se ao banco de dados
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Consultar dados da OP selecionada
                using (SqlCommand cmd = new SqlCommand(@"SELECT  [CKD_PK],M.modelo,M.qtd_caixa,M.Id_modelo_PK,C.qtd as QTD_OP 
                FROM [DPS].[dbo].[CKD_DPS] AS C
                INNER JOIN DPS.dbo.MODELO_DPS AS M ON M.Id_modelo_PK=C.modelo_id_fk
                WHERE CKD_PK=@CKD", conn))
                {
                    // Substituir pelo valor real da OP
                    cmd.Parameters.AddWithValue("@CKD", cb_op.Texts);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // Atualizar as variáveis e labels com os dados da OP selecionada
                        EMBALAGEM.id_ckd_fk = reader["CKD_PK"].ToString();

                        EMBALAGEM.id_modelo = Convert.ToInt32(reader["Id_modelo_PK"]);

                        lblPorCaixa.Text = reader["qtd_caixa"].ToString();

                        lblQtdOP.Text = reader["QTD_OP"].ToString();

                        lblmodelo.Text = reader["modelo"].ToString();
                    }
                    // Fechar o leitor após uso
                    reader.Close();
                }
            }
        }

        #endregion

        #region TOPSIDE(LOAD OP)

        private void LoadOP()
        {
            // Conectar-se ao banco de dados
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                // Consultar os IDs das últimas 100 OPs na tabela CKD_DPS
                using (SqlCommand cmd = new SqlCommand(@"SELECT TOP 100 [CKD_PK]  FROM [DPS].[dbo].[CKD_DPS] ORDER BY CKD_PK DESC", conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    // Configurar o ComboBox cb_op com os dados obtidos da consulta
                    cb_op.DisplayMember = "CKD_PK";// Define a coluna a ser exibida no ComboBox
                    cb_op.DataSource = dt;// Define o DataTable como fonte de dados do ComboBox
                    cb_op.SelectedIndex = -1;// Define o índice de seleção para nenhum item selecionado


                }
            }
        }

        #endregion

        #region IMPRESSAO
        private void ComandoImpressao(string QtdCaixa, string txtNcaixa)
        {
            //investigar se é possivel adicionar vaios doc_Print no Doc.PrintPage, e imprimir com paginação e Cria um documento para impressão
            PrintDocument doc = new PrintDocument();
            // Associar o evento PrintPage ao método Doc_PrintPageX4 para realizar a impressão
            doc.PrintPage += (sender, e) => Doc_PrintPageX4(sender, e, QtdCaixa, txtNcaixa);
            // CAMINHO PARA A IMPRESSORA e Definir o nome da impressora
            doc.PrinterSettings.PrinterName = Conexao.PRINT_SERVER;//*/"Microsoft Print to PDF";//Conexao.PRINT_SERVER
            // Verificar se a impressora é válida
            if (doc.PrinterSettings.IsValid)
            {
                // Define o controlador de impressão padrão
                doc.PrintController = new StandardPrintController();
                // Inicia o processo de impressão
                doc.Print();
            }
            else
            {
                // Mostra uma mensagem de erro caso a impressora seja inválida
                MessageBox.Show("IMPRESSORA INVALIDA");
            }
        }
        Thread threadImp;
        private void ImpressaoAutomatica()
        {
            int ValorPorCaixa = 0;
            int ValorEmbalado = 0;
            // Obter os valores de quantidade por caixa e quantidade embalada
            ValorPorCaixa = Convert.ToInt32(lblPorCaixa.Text);
            ValorEmbalado = Convert.ToInt32(lblQtdCaixa.Text);
            // Verificar se a quantidade embalada atingiu a quantidade por caixa
            if (ValorEmbalado >= ValorPorCaixa)
            {
                // Fazer uma cópia do valor atual de txtNcaixa
                string valorTxtNcaixa = txtNcaixa.Text;
                // Verificar e reiniciar a thread de impressão se necessário
                if (threadImp != null && threadImp.ThreadState != System.Threading.ThreadState.Stopped) threadImp = null;

                //lambda para capturar o argumento e Cria uma nova thread para realizar a impressão
                threadImp = new Thread(() => ComandoImpressao(ValorEmbalado.ToString(), valorTxtNcaixa));
                CheckForIllegalCrossThreadCalls = false;
                // Iniciar a thread para a impressão
                threadImp.Start();

                // Atualizar os valores após a impressão
                SelectMax();
                LoadItensCaixa();
                CalculoPendente();
                // Atualizar o status da embalagem
                BtnStatus.Text = "EMBALAGEM ATIVA";
                BtnStatus.BackColor = Color.FromArgb(55, 159, 113);

            }
        }

        private void Doc_PrintPageX4(object sender, PrintPageEventArgs e, string QtdCaixaDoc, string txtNcaixaDoc)
        {
            // Configurações do texto para a etiqueta

            // Texto 1: Descrição do modelo
            string nome1 = "Descrição:" + descricao;
            Font letran1 = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush corn1 = new SolidBrush(Color.Black);
            Point ponton1 = new Point(20, 5); // (X,Y)


            // Texto 2: Código do modelo
            string nome2 = "Codigo:" + lblmodelo.Text;
            Font letran2 = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush corn2 = new SolidBrush(Color.Black);
            Point ponton2 = new Point(20, 20); // (X,Y)

            // Texto 3: numero da OP
            string nome8 = "OP:" + cb_op.Text;
            Font letran8 = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush corn8 = new SolidBrush(Color.Black);
            Point ponton8 = new Point(20, 40); // (X,Y)

            // Texto 4: quantidade na caixa
            string nome3 = "Qtd:" + QtdCaixaDoc;
            Font letran3 = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush corn3 = new SolidBrush(Color.Black);
            Point ponton3 = new Point(20, 60);// (X,Y)

            // Texto 5: numero da caixa
            string nome4 = "Caixa:" + txtNcaixaDoc;
            Font letran4 = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush corn4 = new SolidBrush(Color.Black);
            Point ponton4 = new Point(20, 80);// (X,Y)

            // Texto 6: numero do peso liquido
            string nome5 = "Peso L:" + peso_L;
            Font letran5 = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush corn5 = new SolidBrush(Color.Black);
            Point ponton5 = new Point(20, 100); // (X,Y)

            // Texto 7: numero do peso bruto 
            string nome6 = "Peso B:" + peso_B;
            Font letran6 = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush corn6 = new SolidBrush(Color.Black);
            Point ponton6 = new Point(20, 120); // (X,Y)

            // Texto 8: Data do dia que foi produzido
            string nome7 = "Data:" + DateTime.Now.ToShortDateString();
            Font letran7 = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush corn7 = new SolidBrush(Color.Black);
            Point ponton7 = new Point(20, 140);// (X,Y)

            // Desenhar a imagem de fundo (se necessário)
            Bitmap bm = new Bitmap(505, 165);
            e.Graphics.DrawImage(bm, 0, 0);

            // Tamanho da etiqueta em pixels
            int width = 100;
            int height = 100;

            //imagens se necessario

            //-----------------------------------------------------------------------------------
            //conf QR CODE
            ZXing.BarcodeWriter barcodeWhriter = new ZXing.BarcodeWriter();
            // lista de opcionais 
            EncodingOptions encodingOptions = new EncodingOptions() { Width = width, Height = height, Margin = 0, PureBarcode = true };
            // lista de opcionais 
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.L);
            //set
            barcodeWhriter.Renderer = new BitmapRenderer();
            //set
            barcodeWhriter.Options = encodingOptions;
            //set
            barcodeWhriter.Format = BarcodeFormat.QR_CODE;

            Bitmap bitmap = barcodeWhriter.Write(txtNcaixa.Text);

            //ponto de impressão do QR code
            Point pontoQR = new Point(260, 30);
            //posiciona os campos 
            e.Graphics.DrawImage(bitmap, pontoQR);

            e.Graphics.DrawString(nome1, letran1, corn1, ponton1);

            e.Graphics.DrawString(nome2, letran2, corn2, ponton2);

            e.Graphics.DrawString(nome3, letran3, corn3, ponton3);

            e.Graphics.DrawString(nome4, letran4, corn4, ponton4);

            e.Graphics.DrawString(nome5, letran5, corn5, ponton5);

            e.Graphics.DrawString(nome6, letran6, corn6, ponton6);

            e.Graphics.DrawString(nome7, letran7, corn7, ponton7);

            e.Graphics.DrawString(nome8, letran8, corn8, ponton8);

            //---------------------------------------------------------------------------------------
            bm.Dispose();
        }
        #endregion


    }
}
