using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using DTOs_Maps.DTO;

namespace WcfService.Interfaces
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlumnoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract(Namespace = "IAlumnoService")]
    public interface IAlumnoService
    {
        [OperationContract(Name = "GetAllAlumnos")]
        [WebInvoke(
            Method = "GET",
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
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        DTOAlumnosList GetOneAlumno(int id);
    }
}
