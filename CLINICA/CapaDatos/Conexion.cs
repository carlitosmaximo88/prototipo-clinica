using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private static Conexion _instancia = null;

        public static Conexion Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Conexion();

                return _instancia;
            }
        }

        public SqlConnection Conectar()
        {
            return new SqlConnection(
                "Data Source=DESKTOP-DTDPIP3;Initial Catalog=ClinicaDB;Integrated Security=True");
        }
    }
}
