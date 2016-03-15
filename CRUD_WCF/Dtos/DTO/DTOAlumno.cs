using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.DTO
{
   public class DTOAlumno
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string appat { get; set; }
        public string apmat { get; set; }
        public string curp { get; set; }
        public DateTime? fecha_nac { get; set; }
        public int? Id_Estado { get; set; }

    }
}
