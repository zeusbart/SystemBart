using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTOs_Maps.DTO
{
    [DataContract]
   public class DTOEstado
    {
        [DataMember]
        public int Id_Estado { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Codigo { get; set; }
    }
}
