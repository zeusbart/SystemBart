using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DTOs_Maps.DTO;
using DTOs_Maps.DTO;

namespace WcfService.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlumnoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract(Namespace = "IAlumnoService")]
    public interface IAlumnoService
    {
        [OperationContract(Name = "GetAllAlumnos")]
        [WebInvoke(
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "GetAllAlumnos")]
        DTOAlumnosList GetAllAlumnos();

        [OperationContract]
        [WebInvoke(
             Method = "POST",
             ResponseFormat = WebMessageFormat.Json,
             RequestFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Wrapped)]
        Boolean NewAndUpdateAlumno(DTOAlumno alumno);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        DTOAlumnosList GetOneAlumno(int id);
    }
}
