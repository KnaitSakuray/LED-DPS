using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LED_DPS.Class.Model;

namespace LED_DPS.Class.IF_Exist_Sql
{
    internal class IfExist_USER_ID
    {

        public static int Exist(int IfExist)
        {

            using (SqlConnection conn = new SqlConnection(LED_DPS.Class.Conexao.Conexao.ROTA))
            {
                conn.Open();
                SqlCommand comande1 = new SqlCommand(@"IF EXISTS( 
                SELECT [Id_matricula] FROM [DPS].[dbo].[USER_DPS] where [Id_matricula] = @Matricula
                )SELECT 1 ELSE SELECT 0", conn);
                comande1.Parameters.Add("@Matricula", SqlDbType.VarChar).Value = IfExist;
                IfExist = Convert.ToInt32(comande1.ExecuteScalar().ToString());
                conn.Close();
            }

            return IfExist;
        }

    }
}
