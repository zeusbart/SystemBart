using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTOs_Maps.DTO;
using DTOs_Maps.DTO;

namespace WcfService.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlumnoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAlumnoService
    {
        [OperationContract]
        DTOAlumnosList GetAllAlumnos();

        [OperationContract]
        Boolean NewAndUpdateAlumno(DTOAlumno alumno);

       
    }
}
