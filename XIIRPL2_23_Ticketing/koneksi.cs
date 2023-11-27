using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace XIIRPL2_23_Ticketing
{
    internal class koneksi
    {
        public static NpgsqlConnection conn = new NpgsqlConnection("server=127.0.0.1;Port=5432;Database=db_tiket_XII_RPL_2_23;" + "User Id=postgres;Password=admin;");
    }
}
