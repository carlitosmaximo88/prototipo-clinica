using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCita
    {
        public int CitaID { get; set; }
        public int PacienteID { get; set; }
        public int MedicoID { get; set; }
        public int ConsultorioID { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
    }
}
