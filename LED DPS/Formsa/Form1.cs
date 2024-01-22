using LED_DPS.Class.Conexao;
using LED_DPS.Class.Global;
using LED_DPS.Class.IF_Exist_Sql;
using LED_DPS.Formsa;
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
using static System.Net.Mime.MediaTypeNames;

namespace LED_DPS.Forms
{
    // Botão PCP e consulta ok
    public partial class Form1 : LED_DPS.Forms.MainForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurações iniciais quando o formulário é carregado

            // Define a cor do ícone no rjMenuIcon1 como laranja
            rjMenuIcon1.IconColor = Color.Orange;
            // Limpa o conteúdo do campo de texto txtuser
            txtuser.Clear();
            // Define o foco no campo de texto txtuser para que o cursor esteja lá
            txtuser.Select();
            txtuser.Focus();


        }
        //----------------------------------------------------

        //Nada nos Private
        private void rjMenuIcon2_Click(object sender, EventArgs e)
        {

        }
        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
        private void rjMenuButton5_Click(object sender, EventArgs e)
        {

        }
        private void txtuser_onTextChanged(object sender, EventArgs e)
        {

        }
        private void txtsenha_onTextChanged(object sender, EventArgs e)
        {

        }
        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void iconMenuItem2_Click(object sender, EventArgs e)
        {


        }
        //-------------------------------------------------------------

        #region Login(Acesso ao sistema)
        private void loginAutentication()
        {
            // Autenticação do login

            // Verifica se o usuário informado existe na base de dados
            if (IfExist_USER_ID.Exist(Convert.ToInt32(txtuser.Text)).Equals(1))
            {
                // Se o usuário existe
                using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
                {

                    conn.Open();
                    // Consulta os detalhes do usuário na base de dados
                    using (SqlCommand cmd = new SqlCommand(@"  SELECT [Id_matricula]
                     ,[nome]
                     ,[usuario]
                     ,[senha]
                     ,[setor]
                     ,[a-cadastro] as C
                     ,[a-import]
                     ,[a-embalagem]
                     ,[a-consulta]
                     ,[a-op]
                     ,[a-adm]
                     ,[status_user]
                     FROM [dbo].[USER_DPS]
                     WHERE [Id_matricula]=@USER
                     ", conn))
                    {

                        cmd.Parameters.AddWithValue("@USER", txtuser.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            // Define as informações do usuário globalmente
                            GLOBAL_USER__DPS.Id_matricula = Convert.ToInt32(reader["Id_matricula"]);
                            GLOBAL_USER__DPS.nome = Convert.ToString(reader["nome"]);
                            GLOBAL_USER__DPS.usuario = Convert.ToString(reader["usuario"]);
                            GLOBAL_USER__DPS.senha = reader["senha"].ToString();
                            GLOBAL_USER__DPS.setor = Convert.ToString(reader["setor"]);
                            GLOBAL_USER__DPS.a_cadastro = Convert.ToInt32(reader["C"]);
                            GLOBAL_USER__DPS.a_import = Convert.ToInt32(reader["a-import"]);
                            GLOBAL_USER__DPS.a_embalagem = Convert.ToInt32(reader["a-embalagem"]);
                            GLOBAL_USER__DPS.a_consulta = Convert.ToInt32(reader["a-consulta"]);
                            GLOBAL_USER__DPS.a_op = Convert.ToInt32(reader["a-op"]);
                            GLOBAL_USER__DPS.a_adm = Convert.ToInt32(reader["a-adm"]);
                            GLOBAL_USER__DPS.status_user = Convert.ToInt32(reader["status_user"]);
                        }

                        reader.Close();

                    }
                }
                // Verifica se a senha informada corresponde à senha do usuário
                if (GLOBAL_USER__DPS.senha.Equals(txtsenha.Text.Trim()) && txtuser.Text != "")
                {
                    // Se a senha está correta e o campo de usuário não está vazio

                    // Realiza a liberação de ações para o usuário autenticado
                    Liberacoes();


                }
                else
                {
                    // Senha incorreta
                    LMessageBox.Show("Senha incorreto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                // Usuário incorreto
                LMessageBox.Show("Usuario incorreto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        // campo de liberação para acessar os botão/abas
        private void Liberacoes()
        {
            // Liberação de funcionalidades para o usuário autenticado

            // Verifica e define se os botões estão habilitados com base nas permissões do usuário
            btnEmbalagem.Enabled = VerificarLiberacao(GLOBAL_USER__DPS.a_embalagem);
            btnCadastro.Enabled = VerificarLiberacao(GLOBAL_USER__DPS.a_cadastro);
            btnOp.Enabled = VerificarLiberacao(GLOBAL_USER__DPS.a_op);
            btnConsulta.Enabled = VerificarLiberacao(GLOBAL_USER__DPS.a_consulta);
            btnUser.Enabled = VerificarLiberacao(GLOBAL_USER__DPS.a_adm);
            btnImportSn.Enabled = VerificarLiberacao(GLOBAL_USER__DPS.a_import);

            // Atualiza o visual do botão de login para indicar que o usuário está autenticado
            btnlogin.BackColor = Color.FromArgb(55, 159, 113);
            btnlogin.IconChar = FontAwesome.Sharp.IconChar.LockOpen;

        }

        private bool VerificarLiberacao(int valor)
        {
            // Verifica se o valor de permissão é 0 (não permitido) ou diferente de 0 (permitido)

            // Verifica se o valor de permissão é igual a 0 (não permitido)
            if (valor == 0)
            {
                // Retorna falso (não permitido)
                return false;
            }
            else
            {
                // Retorna verdadeiro (permitido)
                return true;
            }
        }

        #endregion
        #region Botao(botão para Acessar aba Embalagem, Cadastro, OP's, Consulta e user)
        // Evento de clique para abrir um formulário secundário (child form) relacionado aos usuários
        private void rjMenuButton4_Click(object sender, EventArgs e)
        {
            // Chama o método OpenChildForm para abrir o formulário FrmUsuario_C como um child form
            this.OpenChildForm(() => new FrmUsuario_C(), sender);

        }

        private void rjMenuButton1_Click(object sender, EventArgs e)
        {

            this.OpenChildForm(() => new FrmEmbalagem_C(), sender);
        }

        private void rjMenuButton2_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FrmCadastro_C(), sender);
        }

        private void rjMenuButton3_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FrmOPmanual_C(), sender);
        }
        private void rjMenuButton1_Click_2(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FrmIMPORTSN(), sender);
        }


        #endregion


        //Botão para liberar usuario a acessar

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Evento de clique para o botão de login

            // Verifica se o campo de usuário está vazio ou nulo
            if (txtuser.Text == "" || txtuser.Text == null)
            {
                // Mostra uma mensagem de aviso se o campo de usuário não estiver preenchido
                LMessageBox.Show("Campo não preenchido!", "Aviso");
            }
            else
            {
                // Verifica se o campo de senha está vazio ou nulo
                if (txtsenha.Text == "" || txtsenha.Text == null)
                {
                    // Mostra uma mensagem de aviso se o campo de senha não estiver preenchido
                    LMessageBox.Show("Campo não Preenchido!", "Aviso");
                }
                else
                {
                    // Chama o método de autenticação de login
                    loginAutentication();
                }
            }

        }
        //--------------------------------------------------------

        //TextBox Usuario
        private void txtuser_Leave(object sender, EventArgs e)
        {
            // Evento de perda de foco do campo de usuário (txtuser)

            // Remove espaços em branco extras do texto do campo de usuário
            txtuser.Text.Trim();

            // Move o foco para o campo de senha (txtsenha)
            txtsenha.Focus();
        }


        //------------------------------------------------------------


        // tem q referenciar qual é o botão de origem, quando for usar o dropdown, nesse caso é o sender, btnConsulta);
        private void iconMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FrmGraficos(), sender, btnConsulta);
        }

        private void iconMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FrmPCP(), sender, btnConsulta);
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            //this.OpenChildForm(() => new FrmDonwTime(), sender, btnConsulta)
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(() => new FrmConsultaML(), sender, btnConsulta);
        }
        private void rjLabel1_Click(object sender, EventArgs e)
        {

        }
        private void rjLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
