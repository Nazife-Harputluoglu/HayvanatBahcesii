using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace HayvanatBahcesi
{
    public static class VeriTabani
    {
            private static string baglantiAdresi = "Host=localhost;Port=5432;Username=postgres;Password=1306;Database=HayvanatBahcesi";

            public static NpgsqlConnection BaglantiGetir()
            {
                return new NpgsqlConnection(baglantiAdresi);
            }
        
    }
}
