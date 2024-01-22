using LED_DPS.Class.Conexao;
using LED_DPS.Class.Global;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace LED_DPS.Formsa
{
    public partial class FrmDowntimeOpen : LED_DPS.Forms.ChildForm
    {
        private int sec = 0, Vs = 0;
        private int min = 0, Vm = 0;
        private int hor = 0, Vh = 0;
        private int turno = 0;
        private DateTime data;
        private int ID = 0;
        private string CodCat = "";
        public FrmDowntimeOpen()
        {
            // Inicializa os componentes da interface.
            InitializeComponent();
            // Associa o evento de clique do botão "Iniciar" ao método correspondente.
            btn_Iniciar.Click += ButtonIniciar_Click;
            // Associa o evento de clique do botão "Finalizar" ao método correspondente.
            btn_finalizar.Click += Btn_finalizar_Click;
        }
        //=======================================================================================================================
        private void Btn_finalizar_Click(object? sender, EventArgs e)
        {
            // Este método é chamado quando o botão "Finalizar" é clicado, mas ainda não foi implementado.
            throw new NotImplementedException();
        }

        private void ButtonIniciar_Click(Object sender, EventArgs e)
        {
            // Inicia o timer, começando a contagem.
            //timer.Start();
        }
        private void ButtonParar_Click(object sender, EventArgs e)
        {
            // Para o timer, interrompendo a contagem.
            //timer.Stop();
            // insertDONW();
            // UpdateDONW();
        }
        //======================================================================================================================
        private void HaveDownTimeActive()
        {
            int exist = 0;
            using (SqlConnection con = new SqlConnection(Conexao.ROTA))
            {
                using (SqlCommand cmd = new SqlCommand(@"IF EXISTS (SELECT 1 FROM [DPS].[dbo].[DOWNTIME_DPS] 
                    WHERE status = 'PENDENTE' AND linha =@Linha)
                        SELECT 1
                    ELSE
                        SELECT 0;"))
                {
                    cmd.Parameters.AddWithValue("@Linha", SqlDbType.VarChar).Value = GLOBAL_EMBALAGEM.linha;
                    con.Open();

                    exist = (int)cmd.ExecuteScalar();
                    con.Close();
                    if (exist == 1) Existe();
                    else
                    {
                        btn_Iniciar.Visible = true;
                        btn_finalizar.Visible = true;
                        if (!(LMessageBox.Show("Confirmar parada do posto embalagem.", "Aviso [Downtime]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            this.Close();
                        }
                        else
                        {
                            timer1.Start();
                            btn_Iniciar.Visible = false;
                            //Insert();
                        }
                    }

                }
            }
        }
        private void Existe()
        {
            //LoadDatataHora():
            TimeSpan total;
            DateTime dataConsulta, dataNow;

            dataNow = data;
            dataConsulta = data;

            using (SqlConnection con = new SqlConnection(Conexao.ROTA))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT top 1 [data_hora],[id]
                FROM [DPS].[dbo].[DOWNTIME_DPS]
                where status='PENDENTE' and linha=@Linha", con))
                {
                    cmd.Parameters.AddWithValue("@Linha", SqlDbType.VarChar).Value = GLOBAL_EMBALAGEM.linha;

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();

                    while (dr.Read())
                    {
                        ID = Convert.ToInt32(dr["ID"]);
                        dataConsulta = Convert.ToDateTime(dr["data_hora]"]);

                        break;
                    }
                    con.Close();

                    lbldowntime.Text = ID.ToString();

                    total = data.Subtract(dataConsulta);
                    hor = total.Hours;
                    min = total.Minutes;
                    sec = total.Seconds;

                    lblH.Text = hor.ToString().PadLeft(2, '0');
                    lblM.Text = min.ToString().PadLeft(2, '0');
                    lblS.Text = sec.ToString().PadLeft(2, '0');

                    timer1.Start();

                    labelAvisos.Text = "Parada já solicitada";
                    labelAvisos.ForeColor = Color.Red;

                    btn_finalizar.Visible = true;
                }
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Cont();
            lblH.Text = hor.ToString().PadLeft(2, '0');
            lblM.Text = min.ToString().PadLeft(2, '0');
            lblS.Text = sec.ToString().PadLeft(2, '0');
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (GLOBAL_DOWNTIME.statusParada == "LIVRE")
            {
                this.Close();
            }
        }

        private void Cont()
        {
            if (sec == 59)
            {
                sec = 0;
                min++;
            }
            else
            {
                sec++;
            }
            if (min == 59)
            {
                min = 0;
                hor++;
            }
        }
        private void Conversor()
        {
            Vh = (Convert.ToInt32(lblH.Text.Trim()) * 60) * 60;
            Vm = (Convert.ToInt32(lblM.Text.Trim()) * 60);
            Vs = (Convert.ToInt32(lblS.Text.Trim()));
        }
        private void ConsultaCodCat()
        {
            using (SqlConnection con = new SqlConnection(Conexao.ROTA))
            {
                using (SqlCommand cmd = new SqlCommand(@"SELECT [Id]
                FROM [DPS].[dbo].[CAUSA_DOWNTIME_DPS]
                where descricao = @Desc and setor = @setor", con))
                {
                    cmd.Parameters.AddWithValue("@Desc", SqlDbType.VarChar).Value = cb_categoria.Text;
                    cmd.Parameters.AddWithValue("@setor", SqlDbType.VarChar).Value = cb_setor.Text;

                    con.Open();
                    CodCat = cmd.ExecuteScalar().ToString();
                    con.Close();
                }
            }
        }

        //======================================================================================================================
        private void loadcb_Motivo()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(@"SELECT ,[descricao]
                FROM [DPS].[dbo].[CAUSA_DOWNTIME_DPS] where descricao=@descricao", conn))
                {
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = cb_categoria.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Limpe os itens existentes na ComboBox, se necessário.
                        cb_categoria.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione os valores da coluna "setor" ao ComboBox.
                            string descricao = reader["descricao"].ToString();
                            cb_categoria.Items.Add(descricao);
                        }
                    }

                }
            }
        }
        private void loadcb_setor()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(@"SELECT ,[setor]
                FROM [DPS].[dbo].[CAUSA_DOWNTIME_DPS] where setor=@setor", conn))
                {
                    cmd.Parameters.Add("@setor", SqlDbType.VarChar).Value = cb_setor.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Limpe os itens existentes na ComboBox, se necessário.
                        cb_setor.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione os valores da coluna "setor" ao ComboBox.
                            string Setor = reader["setor"].ToString();
                            cb_setor.Items.Add(Setor);
                        }
                    }

                }
            }
        }


    }
}
