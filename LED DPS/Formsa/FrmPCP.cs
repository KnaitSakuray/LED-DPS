using LED_DPS.Class.Conexao;
using LED_DPS.Class.IF_Exist_Sql;
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
    public partial class FrmPCP : LED_DPS.Forms.ChildForm
    {
        public FrmPCP()
        {
            InitializeComponent();
        }

        //aqui vc digita o numero da op
        private void consultaOP()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                //abre conexão
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"SELECT C.[CKD_PK], 
                C.[qtd] as QUANTIDADE, 
                COUNT(E.[sn]) as QTD_PRODUZIDO,
                C.[qtd] - COUNT(E.[sn]) as QTD_PENDENTE,
                M.[modelo]
                FROM DPS.[dbo].[CKD_DPS] C
                INNER JOIN DPS.[dbo].[EMBALAGEM] E ON C.[CKD_PK] = E.[id_ckd_fk]
                INNER JOIN DPS.[dbo].[MODELO_DPS] M ON E.[id_modelo] = M.[Id_modelo_PK]
                WHERE C.CKD_PK = @ckd
                GROUP BY C.[CKD_PK],C.[qtd],M.[modelo]", conn))
                {
                    // digita o numero da OP
                    cmd.Parameters.AddWithValue("@ckd", txt_ml.Text);

                    // Tabela mostra as informaçoes da query 
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    Dgvpcp.DataSource = dt;

                }
            }

        }

        //seleciona a data pra procurar a op
        private void consultadata()
        {
            using (SqlConnection conn = new SqlConnection(Conexao.ROTA))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(@"SELECT 
                C.[CKD_PK], 
                C.[qtd] as QUANTIDADE, 
                COUNT(E.[sn]) as QTD_PRODUZIDO,
                C.[qtd] - COUNT(E.[sn]) as QTD_PENDENTE,
                M.[modelo]
                FROM DPS.[dbo].[CKD_DPS] C
                INNER JOIN DPS.[dbo].[EMBALAGEM] E ON C.[CKD_PK] = E.[id_ckd_fk]
                INNER JOIN DPS.[dbo].[MODELO_DPS] M ON E.[id_modelo] = M.[Id_modelo_PK]
                WHERE E.[data] BETWEEN @DataInicio AND @DataFim
                GROUP BY
                    C.[CKD_PK],
                    C.[qtd],
                    M.[modelo]
                ORDER BY C.[CKD_PK] DESC;", conn))
                {
                    command.Parameters.AddWithValue("@DataInicio", dt_dataI.Value);
                    command.Parameters.AddWithValue("@DataFim", dt_dataF.Value);

                    // Tabela mostra as informaçoes da query 
                    SqlDataReader dr = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    Dgvpcp.DataSource = dt;
                }
            }
        }
        private void pnlClientArea_Paint(object sender, PaintEventArgs e)
        {

        }

        // o Textbox data final esta nomeado com Btnconsultackd_Clic assim que escolher
        // a data ele ja mostra as ops
        private void Btnconsultackd_Click(object sender, EventArgs e)
        {
            // verifica  o estado q o toggle esta selecionado
            if (rjToggleButton1.Checked) consultadata();
            else consultaOP();
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelData.Visible = false;
            panelOp.Visible = false;

            // verifica  o estado q o toggle esta selecionado
            if (rjToggleButton1.Checked) panelData.Visible = true;
            else panelOp.Visible = true;
        }

        private void FrmPCP_Load(object sender, EventArgs e)
        {

            dt_dataI.Value = DateTime.Now;
            dt_dataF.Value = DateTime.Now.AddDays(-1);

        }
    }
}
