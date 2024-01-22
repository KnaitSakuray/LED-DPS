using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_DPS.Class.IF_Exist_Sql
{
    internal class IfExist_SN_CKD
    {
        public static string Exist(string IfExist,string ckd)
        {
            using (SqlConnection conn = new SqlConnection(LED_DPS.Class.Conexao.Conexao.ROTA))
            {
                conn.Open();
                SqlCommand comande1 = new SqlCommand(@"IF EXISTS
                ( 
                SELECT  [sn] FROM [DPS].[dbo].[SN_DPS] WHERE [sn] = @sn and [id_ckd_fk] = @id_ckd_fk
                )
                SELECT 1 ELSE SELECT 0", conn);
                comande1.Parameters.Add("@sn", SqlDbType.VarChar).Value = IfExist;
                comande1.Parameters.Add("@id_ckd_fk", SqlDbType.VarChar).Value = ckd;
                IfExist = comande1.ExecuteScalar().ToString();
                conn.Close();
            }

            return IfExist;
        }
    }
}
