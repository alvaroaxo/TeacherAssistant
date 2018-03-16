using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newConecction
{
    class Conectar
    {
        public static MySqlConnection ObtenerConexcion()
        {
            MySqlConnection conectar = new MySqlConnection("server=192.168.0.16; database=liquidacion_sie; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
        }
    }
}

