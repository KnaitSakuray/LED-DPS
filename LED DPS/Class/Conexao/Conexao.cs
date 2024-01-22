using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_DPS.Class.Conexao
{
    internal class Conexao
    {

        private static string _ROTA = "";
        public static string ROTA
        {
            get { return _ROTA; }
            set { _ROTA = value; }
        }


        private static string _PRINT_SERVER = "";
        public static string PRINT_SERVER
        {
            get { return _PRINT_SERVER; }
            set { _PRINT_SERVER = value; }
        }

    }
}
