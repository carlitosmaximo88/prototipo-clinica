using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datPaciente
    {
        public static readonly datPaciente Instancia = new datPaciente();

        public bool InsertarPaciente(entPaciente p)
        {
            SqlCommand cmd = null;
            bool ok = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("sp_CrearPaciente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DNI", p.DNI);
                cmd.Parameters.AddWithValue("@Nombres", p.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", p.Apellidos);
                cmd.Parameters.AddWithValue("@FechaNacimiento", p.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@Email", p.Email);
                cmd.Parameters.AddWithValue("@Direccion", p.Direccion);

                cn.Open();
                cmd.ExecuteNonQuery();
                ok = true;
            }
            catch
            {
                throw;
            }

            return ok;
        }
        public List<entPaciente> ListarPacientes()
        {
            SqlCommand cmd = null;
            List<entPaciente> lista = new List<entPaciente>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_ListarPacientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entPaciente p = new entPaciente();

                    p.DNI = dr["DNI"].ToString();
                    p.Nombres = dr["Nombres"].ToString();
                    p.Apellidos = dr["Apellidos"].ToString();
                    p.FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                    p.Telefono = dr["Telefono"].ToString();
                    p.Email = dr["Email"].ToString();
                    p.Direccion = dr["Direccion"].ToString();

                    lista.Add(p);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

    }
}
