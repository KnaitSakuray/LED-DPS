using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_DPS.Class.Model
{
    internal class CKD_DPS
    {
        public static int CKD_PK { get; set; }
        public static string modelo_id_fk { get; set; }
        public static string status_op { get; set; }
        public static DateTime data { get; set; }
        public static DateTime date_hora { get; set; }
        public static int qtd { get; set; }
        public static string descricao { get; set; }
        public static int filial { get; set; }
    }
}
