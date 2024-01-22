using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_DPS.Class.IF_Exist_Sql
{
    internal class IfExist_EMBALAGEM_CAIXA
    {
        public static string Exist(string IfExist)
        {
            using (SqlConnection conn = new SqlConnection(LED_DPS.Class.Conexao.Conexao.ROTA))
            {
                conn.Open();
                SqlCommand comande1 = new SqlCommand(@"IF EXISTS
                ( 
                SELECT [numero] FROM [DPS].[dbo].[EMBALAGEM] WHERE [numero] = @numero
                )
                SELECT 1 ELSE SELECT 0", conn);
                comande1.Parameters.Add("@numero", SqlDbType.VarChar).Value = IfExist;
                IfExist = comande1.ExecuteScalar().ToString();
                conn.Close();
            }
            return IfExist;
        }
    }
}
