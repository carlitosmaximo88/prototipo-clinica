using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logPaciente
    {
        public static readonly logPaciente Instancia = new logPaciente();

        public bool InsertarPaciente(entPaciente p)
        {
            return datPaciente.Instancia.InsertarPaciente(p);
        }

        public List<entPaciente> ListarPacientes()
        {
            return datPaciente.Instancia.ListarPacientes();
        }

    }


}
