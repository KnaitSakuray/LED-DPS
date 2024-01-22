using LED_DPS.Class.Conexao;
using LED_DPS.Class.IF_Exist_Sql;
using LED_DPS.Class.Model;
using LED_DPS.Forms;
using LED_DPS.RJControls;
using System;
using System.Collections;
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
    public partial class FrmUsuario_C : LED_DPS.Forms.ChildForm
    {

        private string QueryInsert = "";
        private string QueryUpdate = "";

        public FrmUsuario_C()
        {
            InitializeComponent();
        }
        //EVENTOS DE CONTROLES----------------------------------------------------------------------

        //Habilita o Form a se interagir com o banco
        private void FrmUsuario_C_Load(object sender, EventArgs e)
        {
            GetUsersAll();

            rjMenuIcon1.IconColor = Color.Orange;

            USER_DPS.status_user = 1;
        }
        //-----------------------------------------------------------

        //VERIFICA O ESTADO DO CHECKBOX SE ESTA 1(HABILITADO) OU 0(DESABILITADO)
        private void chb_cadastro_CheckedChanged(object sender, EventArgs e)
        {
            //VERIFICA O ESTADO DO CHECKBOX
            if (chb_cadastro.Checked)
            {
                USER_DPS.a_cadastro = 1;
            }
            else
            {
                USER_DPS.a_cadastro = 0;
            }
        }
        private void chb_Embalagem_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Embalagem.Checked)
            {
                USER_DPS.a_embalagem = 1;
            }
            else
            {
                USER_DPS.a_embalagem = 0;
            }
        }
        private void chb_Consulta_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Consulta.Checked)
            {
                USER_DPS.a_consulta = 1;
            }
            else
            {
                USER_DPS.a_consulta = 0;
            }
        }
        private void chb_OP_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_OP.Checked)
            {
                USER_DPS.a_op = 1;
            }
            else
            {
                USER_DPS.a_op = 0;
            }
        }
        private void chb_Adm_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Adm.Checked)
            {
                USER_DPS.a_adm = 1;
            }
            else
            {
                USER_DPS.a_adm = 0;
            }
        }
        private void chb_Import_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Import.Checked)
            {
                USER_DPS.a_import = 1;
            }
            else
            {
                USER_DPS.a_import = 0;
            }
        }
        //-------------------------------------------------------------------

        //Tabela de onde mostra todas as informaçoes do usuario
        private void DgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DgvUsuario.Rows[e.RowIndex];
                //TERMIANR DE ADD VARIAVEIS
                USER_DPS.Id_matricula = Convert.ToInt32(row.Cells["Id_matricula"].Value.ToString());
                USER_DPS.nome = row.Cells["nome"].Value.ToString();

                //TERMINAR ADD VAR PROS CAMPOS
                txt_Id_matricula.Texts = USER_DPS.Id_matricula.ToString();

            }

            CheckBoxValues();
        }
        //-------------------------------------------------------------------------------------

        private void rjMenuIcon1_Click(object sender, EventArgs e)
        {
            GetUsers();
        }

        //Nada Dentro do Private
        private void DgvUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void txt_Id_matricula_onTextChanged(object sender, EventArgs e)
        {

        }
        private void pnlClientArea_Paint(object sender, PaintEventArgs e)
        {

        }
        private void chb_Consulta_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
        //------------------------------------------------------------------

        //=================================================================================================================
        /// <summary>
        /// REGIÃO ABAIXO SOMENTE PARA MÉTODOS/OBJETOS E ATRIBUTOS
        /// </summary>
        //=================================================================================================================

        #region BOTAO(Cadastro e Atualizar)
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            // verifica se o usuario existe
            if (IfExist_USER_ID.Exist(Convert.ToInt32(txt_Id_matricula.Texts)).Equals(1))
            {
                LMessageBox.Show("Usuário já cadastrado", "Aviso");
            }
            else
            {
                // insere os dados
                InsertDBU();
            }

            GetUsersAll();

        }
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            // verifica se o usuario existe
            if (IfExist_USER_ID.Exist(Convert.ToInt32(txt_Id_matricula.Texts)).Equals(1))
            {
                UpdateDBU();
            }
            else
            {
                // insere os dados
                LMessageBox.Show("Usuário não cadastrado", "Aviso");
            }


            GetUsersAll();

        }
        #endregion

        #region INSERT/UPDATE
        private void InsertDBU()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                //Query pega do Insert no SQL
                QueryInsert = @"INSERT INTO [DPS].[dbo].[USER_DPS]
                ([Id_matricula],[nome],[usuario],[senha],[setor],[a-cadastro],[a-import],[a-embalagem],
                [a-consulta],[a-op],[a-adm],[status_user])
                VALUES
                (@Id_matricula, @Nome, @Usuario, @Senha, @Setor, @Cadastro, @Import, @Embalagem, @Consulta, @Op, @Adm, @Status)";

                using (SqlCommand cmd = new SqlCommand(QueryInsert, conn))
                {
                    //Campos txt/cbox,Comunucação com as class da pasta Model>USER_DPS.cs
                    cmd.Parameters.AddWithValue("@Id_matricula", txt_Id_matricula.Texts);
                    cmd.Parameters.AddWithValue("@Nome", txt_nome.Texts);
                    cmd.Parameters.AddWithValue("@Usuario", txt_Usuario.Texts);
                    cmd.Parameters.AddWithValue("@Senha", txt_senha.Texts);
                    cmd.Parameters.AddWithValue("@Setor", cb_setor.Texts);

                    //checkbox, Comunucação com as class da pasta Model>USER_DPS.cs
                    cmd.Parameters.AddWithValue(@"Cadastro", USER_DPS.a_cadastro.ToString());
                    cmd.Parameters.AddWithValue(@"Import", USER_DPS.a_import.ToString());
                    cmd.Parameters.AddWithValue(@"Embalagem", USER_DPS.a_embalagem.ToString());
                    cmd.Parameters.AddWithValue(@"Consulta", USER_DPS.a_consulta.ToString());
                    cmd.Parameters.AddWithValue(@"Op", USER_DPS.a_op.ToString());
                    cmd.Parameters.AddWithValue(@"Adm", USER_DPS.a_adm.ToString());
                    cmd.Parameters.AddWithValue(@"Status", USER_DPS.status_user.ToString());

                    //Fecha o comando.
                    cmd.ExecuteNonQuery();
                }
            }
            LMessageBox.Show("Usiario Criado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateDBU()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                //Query pega do Update no SQL
                QueryUpdate = @"
                            UPDATE [DPS].[dbo].[USER_DPS] SET 
                            [nome] = @Nome,
                            [usuario] = @Usuario,
                            [senha] = @Senha,
                            [setor] = @Setor,
                            [a-cadastro] = @Cadastro,
                            [a-import] = @Import,
                            [a-embalagem] = @Embalagem,
                            [a-consulta] = @Consulta,
                            [a-op] = @Op,
                            [a-adm] = @Adm,
                            [status_user] = @Status
                            WHERE [Id_matricula] = @Id_matricula";

                using (SqlCommand cmd = new SqlCommand(QueryUpdate, conn))
                {
                    //Campos txt/ cbox,Comunucação com as class da pasta Model>USER_DPS.cs
                    cmd.Parameters.AddWithValue("@Id_matricula", txt_Id_matricula.Texts);
                    cmd.Parameters.AddWithValue("@Nome", txt_nome.Texts);
                    cmd.Parameters.AddWithValue("@Usuario", txt_Usuario.Texts);
                    cmd.Parameters.AddWithValue("@Senha", txt_senha.Texts);
                    cmd.Parameters.AddWithValue("@Setor", cb_setor.Texts);

                    //checkbox, Comunucação com as class da pasta Model>USER_DPS.cs
                    cmd.Parameters.AddWithValue(@"Cadastro", USER_DPS.a_cadastro.ToString());
                    cmd.Parameters.AddWithValue(@"Import", USER_DPS.a_import.ToString());
                    cmd.Parameters.AddWithValue(@"Embalagem", USER_DPS.a_embalagem.ToString());
                    cmd.Parameters.AddWithValue(@"Consulta", USER_DPS.a_consulta.ToString());
                    cmd.Parameters.AddWithValue(@"Op", USER_DPS.a_op.ToString());
                    cmd.Parameters.AddWithValue(@"Adm", USER_DPS.a_adm.ToString());
                    cmd.Parameters.AddWithValue(@"Status", USER_DPS.status_user.ToString());

                    cmd.ExecuteNonQuery();
                }

            }

            LMessageBox.Show("Usuario Atualizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Get
        private void GetUsers()
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ROTA))
            {
                connection.Open();
                // Cria um comando SQL que chama uma stored procedure chamada "GetUsuario"
                SqlCommand command = new SqlCommand("DPS.dbo.GetUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Define os parâmetros da stored procedure, possivelmente usando informações do campo txt_Id_matricula
                command.Parameters.AddWithValue("@parametro1", txt_Id_matricula.Texts);
                // Cria um adaptador SQL para executar o comando e preencher um DataTable com os resultados
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                // Atualiza a fonte de dados da DataGridView DgvUsuario com os dados obtidos
                DgvUsuario.DataSource = dataTable;
            }
        }

        // all
        private void GetUsersAll()
        {
            using (SqlConnection connection = new SqlConnection(Conexao.ROTA))
            {
                connection.Open();
                // Cria um comando SQL que chama uma stored procedure chamada "GetUsuarioAll"
                SqlCommand command = new SqlCommand("DPS.dbo.GetUsuarioAll", connection);
                command.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                // Atualiza a fonte de dados da DataGridView DgvUsuario com os dados obtidos da consulta
                DgvUsuario.DataSource = dataTable;
                DgvUsuario.Refresh();
            }
        }
        #endregion

        //CONSULTA DIRECIONADA AO CHECKBOX
        private void CheckBoxValues()
        {

            // HABILITA CHECK BOX QUANDO ESTIVER SELECIONADO
            if (USER_DPS.a_cadastro == 1)
            {
                chb_cadastro.Checked = true;
            }
            // SE NÃO TIVER 
            else
            {
                chb_cadastro.Checked = false;
            }
            //-----
            if (USER_DPS.a_embalagem == 1)
            {
                chb_Embalagem.Checked = true;
            }
            else
            {
                chb_Embalagem.Checked = false;
            }
            //-----
            if (USER_DPS.a_consulta == 1)
            {
                chb_Consulta.Checked = true;
            }
            else
            {
                chb_Consulta.Checked = false;
            }
            //-----
            if (USER_DPS.a_op == 1)
            {
                chb_OP.Checked = true;
            }
            else
            {
                chb_OP.Checked = false;
            }
            //-----
            if (USER_DPS.a_adm == 1)
            {
                chb_Adm.Checked = true;
            }
            else
            {
                chb_Adm.Checked = false;
            }
            //-----
            if (USER_DPS.a_import == 1)
            {
                chb_Import.Checked = true;
            }
            else
            {
                chb_Import.Checked = false;
            }
        }
        //------------------------------
    }
}
