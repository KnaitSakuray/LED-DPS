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
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_DPS.Formsa
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmOPmanual_C : LED_DPS.Forms.ChildForm
    {
        private string QueryInsert = "";
        private string QueryUpdate = "";
        private string Status_op = "PENDENTE";
        int idModelo = 0;

        public FrmOPmanual_C()
        {
            InitializeComponent();
        }
        //EVENTOS DE CONTROLES----------------------------------------------------------------------

        // Botão Atualizar e Cadastro
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (IfExist_CKD_DPS.Exist(Convert.ToString(txt_Nop.Text)).Equals("1"))
            {
                UpdateDBO();
                LMessageBox.Show("OP  Atualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LMessageBox.Show("OP não cadastrado", "Aviso");
            }

        }
        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            if (IfExist_CKD_DPS.Exist(Convert.ToString(txt_Nop.Text)).Equals("1"))
            {
                LMessageBox.Show("OP já cadastrado", "Aviso");
            }
            else
            {
                InsertDBO();
                LMessageBox.Show("OP  cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //-------------------------------------------------------------

        //Load Modelos
        private void cb_modelo_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //--------------------------------------------------------------------------

        //Faz aparecer todas as informaçoes nessaria para o sistema
        private void FrmOPmanual_C_load_1(object sender, EventArgs e)
        {
            consultaAll();
            loadModelo();
        }
        //--------------------------------------------------------------

        // CheckList de Pendente e Finalizado
        private void chb_pendente_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_pendente.Checked.Equals(true)) Status_op = "PENDENTE";
        }
        private void chb_finalizado_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_finalizado.Checked.Equals(true)) Status_op = "FINALIZADO";
        }
        //----------------------------------------------------------------------

        private void pnlClientArea_Paint(object sender, PaintEventArgs e)
        {

        }

        //=================================================================================================================
        /// <summary>
        /// REGIÃO ABAIXO SOMENTE PARA MÉTODOS/OBJETOS E ATRIBUTOS
        /// </summary>
        //=================================================================================================================

        #region Parte de Insert e Update
        private void InsertDBO()
        {
            ConsultaIDmodelo();

            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                // Criar o comando SQL
                conn.Open();
                //Query pega do Insert no SQL
                QueryInsert = @"INSERT INTO [DPS].[dbo].[CKD_DPS]
                ([CKD_PK],[modelo_id_fk],[status_op],[data],[date_hora],[qtd],[descricao],[filial])
                VALUES
                (@CKD_PK, @modelo_id_fk, @status_op, @data, @date_hora, @qtd, @descricao, @filial)";

                using (SqlCommand cmd = new SqlCommand(QueryInsert, conn))
                {
                    //Campos txt/cbox,Comunucação com as class da pasta Model>CKD_DPS.cs
                    cmd.Parameters.AddWithValue("@CKD_PK", txt_Nop.Text);
                    cmd.Parameters.AddWithValue("@modelo_id_fk", idModelo);
                    cmd.Parameters.AddWithValue("@data", dt_data.Value);
                    cmd.Parameters.AddWithValue("@date_hora", dt_data.Value);
                    cmd.Parameters.AddWithValue("@qtd", txt_qtd.Text);
                    cmd.Parameters.AddWithValue("@descricao", txt_descricao.Text);
                    cmd.Parameters.AddWithValue("@filial", SqlDbType.Int).Value = 06;
                    cmd.Parameters.AddWithValue("@status_op", "PENDENTE");

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void UpdateDBO()
        {

            ConsultaIDmodelo();

            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                //Query pega do Insert no SQL
                string QueryUpdate = @"UPDATE [DPS].[dbo].[CKD_DPS]
                                SET [modelo_id_fk] = @modelo_id_fk,
                               [status_op] = @status_op,
                               [data] = @data,
                               [date_hora] = @date_hora,
                               [qtd] = @qtd,
                               [descricao] = @descricao
                               WHERE [CKD_PK] = @CKD_PK";

                using (SqlCommand cmd = new SqlCommand(QueryUpdate, conn))
                {
                    //Campos txt/cbox,Comunucação com as class da pasta Model>CKD_DPS.cs
                    cmd.Parameters.AddWithValue("@CKD_PK", txt_Nop.Text);
                    cmd.Parameters.AddWithValue("@modelo_id_fk", idModelo);
                    cmd.Parameters.AddWithValue("@data", dt_data.Value);
                    cmd.Parameters.AddWithValue("@date_hora", dt_data.Value);
                    cmd.Parameters.AddWithValue("@qtd", txt_qtd.Text);
                    cmd.Parameters.AddWithValue("@descricao", txt_descricao.Text);
                    cmd.Parameters.AddWithValue("@status_op", "PENDENTE");

                    cmd.ExecuteNonQuery();
                    
                }
            }
        }
        #endregion

        #region Parte de Consulta(IDModelo e All) e Load
        private void ConsultaIDmodelo()
        {

            /// consultar o id do modelo dps pela coluna modelo para retornar o id
            /// SELECT[Id_modelo_PK] FROM[DPS].[dbo].[MODELO_DPS] where modelo = ''
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(@"SELECT[Id_modelo_PK] FROM[DPS].[dbo].[MODELO_DPS] where modelo = @modelo", conn))
                {
                    cmd.Parameters.AddWithValue("@modelo", cb_modelo.Texts);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //Atribui o valor do ID do modelo à variável idModelo
                        idModelo = Convert.ToInt32(reader["Id_modelo_PK"]);
                    }
                    reader.Close();
                }
            }
        }

        private void consultaAll()
        {
            using (SqlConnection conecta = new SqlConnection(Conexao.ROTA))
            {
                string query = @"SELECT [CKD_PK],MD.modelo,[status_op],OP.[data]
                        ,[date_hora],[qtd],OP.[descricao],OP.[filial]
                        FROM [DPS].[dbo].[CKD_DPS] as OP
                        INNER JOIN [DPS].[dbo].[MODELO_DPS] as MD on OP.modelo_id_fk = MD.Id_modelo_PK
                        GROUP BY [CKD_PK],MD.modelo,[status_op],OP.[data]
                        ,[date_hora],[qtd],OP.[descricao],OP.[filial]";

                using (SqlCommand comande = new SqlCommand(query, conecta))
                {
                    conecta.Open();
                    SqlDataReader dr = comande.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    dgv_op.DataSource = dt;
                    conecta.Close();
                }


            }


        }
        private void loadModelo()
        {
            SqlConnection cn10 = new SqlConnection(Conexao.ROTA);
            SqlCommand cmd10 = new SqlCommand("SELECT modelo FROM [DPS].[dbo].[MODELO_DPS]", cn10);
            cn10.Open();
            SqlDataReader dr10 = cmd10.ExecuteReader();
            DataTable dt10 = new DataTable();
            dt10.Load(dr10);
            cb_modelo.DisplayMember = "modelo";
            cb_modelo.DataSource = dt10;
            cn10.Close();
            cb_modelo.SelectedIndex = -1;
        }
        #endregion



    }
}
