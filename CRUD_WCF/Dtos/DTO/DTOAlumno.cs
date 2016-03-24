using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTOs_Maps.DTO
{
    [CollectionDataContract]
    public class DTOAlumnosList : Collection<DTOAlumno> { }



    [DataContract]
   public class DTOAlumno
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string appat { get; set; }
        [DataMember]
        public string apmat { get; set; }
        [DataMember]
        public string curp { get; set; }
        [DataMember]
        public DateTime? fecha_nac { get; set; }
        [DataMember]
        public int? Id_Estado { get; set; }

    }
}
