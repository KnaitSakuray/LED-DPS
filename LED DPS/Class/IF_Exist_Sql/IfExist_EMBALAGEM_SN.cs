using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LED_DPS.Class.Global;

namespace LED_DPS.Class.IF_Exist_Sql
{
    internal class IfExist_EMBALAGEM_SN
    {
        // mande o SN para o metodo e ele retorna 1 se existir e 0 se não existir
        public static string Exist(string IfExist)
        {
            using (SqlConnection conn = new SqlConnection(LED_DPS.Class.Conexao.Conexao.ROTA))
            {
                conn.Open();
                SqlCommand comande1 = new SqlCommand(@"IF EXISTS
                ( 
                SELECT [id_ckd_fk] FROM [DPS].[dbo].[EMBALAGEM] WHERE [sn] = @sn and [id_ckd_fk] = @id_ckd_fk
                )
                SELECT 1 ELSE SELECT 0", conn);
                comande1.Parameters.Add("@sn", SqlDbType.VarChar).Value = IfExist;
                comande1.Parameters.Add("@id_ckd_fk", SqlDbType.VarChar).Value = GLOBAL_EMBALAGEM.id_ckd_fk;
                IfExist = comande1.ExecuteScalar().ToString();
                conn.Close();
            }

            return IfExist;
        }
    }
}
