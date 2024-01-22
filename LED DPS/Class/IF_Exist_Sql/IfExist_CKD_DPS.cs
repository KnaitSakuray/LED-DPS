using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_DPS.Class.IF_Exist_Sql
{
    internal class IfExist_CKD_DPS
    {
        public static string Exist(string IfExist)
        {
            using (SqlConnection conn = new SqlConnection(LED_DPS.Class.Conexao.Conexao.ROTA))
            {
                conn.Open();
                SqlCommand comande1 = new SqlCommand(@"IF EXISTS
                ( 
                SELECT [CKD_PK] FROM [DPS].[dbo].[CKD_DPS] WHERE [CKD_PK] = @CKD
                )
                SELECT 1 ELSE SELECT 0", conn);
                comande1.Parameters.Add("@CKD", SqlDbType.VarChar).Value = IfExist;
                IfExist = comande1.ExecuteScalar().ToString();
                conn.Close();
            }

            return IfExist;
        }
    }
}
