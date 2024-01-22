using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_DPS.Class.IF_Exist_Sql
{
    internal class IfExist_MODELO_ID
    {
        public static string Exist(string IfExist)
        {
            using (SqlConnection conn = new SqlConnection(LED_DPS.Class.Conexao.Conexao.ROTA))
            {
                conn.Open();
                SqlCommand comande1 = new SqlCommand(@"IF EXISTS
                ( 
                SELECT [Id_modelo_PK] FROM [DPS].[dbo].[MODELO_DPS] WHERE [modelo] = @modelo
                )
                SELECT 1 ELSE SELECT 0", conn);
                comande1.Parameters.Add("@modelo", SqlDbType.VarChar).Value = IfExist;
                IfExist = comande1.ExecuteScalar().ToString();
                conn.Close();
            }

            return IfExist;
        }
    }
}
