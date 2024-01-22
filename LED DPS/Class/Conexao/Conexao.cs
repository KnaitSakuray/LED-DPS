using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_DPS.Class.Conexao
{
    internal class Conexao
    {

        private static string _ROTA = "Data Source = 192.168.108.16\\SQLEXPRESS; Initial Catalog = DPS; Persist Security Info=True;User ID =crud_dps; Password=@UniLed!@#2023";
        public static string ROTA
        {
            get { return _ROTA; }
            set { _ROTA = value; }
        }


        private static string _PRINT_SERVER = @"\\EXT-AV-01\";
        public static string PRINT_SERVER
        {
            get { return _PRINT_SERVER; }
            set { _PRINT_SERVER = value; }
        }

    }
}
