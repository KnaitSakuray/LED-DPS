using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_DPS.Class.Global
{
    internal class GLOBAL_DOWNTIME
    {
        public static DateTime data { get; set; }
        public static DateTime Data_hora { get; set; }
        public static string linha { get; set; }
        public static int turno { get; set; }
        public static string duracao { get; set; }
        public static string id_downtime { get; set; }
        public static string tipo_categ { get; set; }
        public static string descricao { get; set; }
        public static string status { get; set; }
        public static DateTime data_horaF { get; set; }
        public static DateTime duracaoM { get; set; }
        public static string setor { get; set; }
        public static string pause { get; set; }
        public static string pause1 { get; set; }
        public static int id_user { get; set; }

        private static string _statusParada = "";
        public static string statusParada
        {
            get { return _statusParada; }
            set { _statusParada = value; }
        }
    }
}
