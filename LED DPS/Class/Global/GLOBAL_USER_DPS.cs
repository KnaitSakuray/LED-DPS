using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_DPS.Class.Global
{
    internal class GLOBAL_USER__DPS
    {
        public static int Id_matricula { get; set; } 
        public static string nome { get; set; }
        public static string usuario { get; set; }
        public static string senha { get; set; }
        public static string setor { get; set; }

        public static int a_cadastro { get; set; }
        public static int a_import { get; set; }
        public static int a_embalagem { get; set; }
        public static int a_consulta { get; set; }
        public static int a_op { get; set; }
        public static int a_adm { get; set; }

        public static int status_user { get; set; }
    }
}
