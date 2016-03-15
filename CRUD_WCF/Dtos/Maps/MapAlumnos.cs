using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dtos.DTO;
using Persistencia.Model.Operativo;
namespace Dtos.Maps
{
   public class MapAlumnos
    {
       /// <summary>
       /// Mapeo Entidad Alumnos
       /// </summary>
       /// <param name="alumnos"></param>
        /// <returns>DTOAlumno</returns>
       public DTOAlumno MapAlumnosENTToDTO(alumnos alumnos)
       {
           DTOAlumno DTOAlumno=new DTOAlumno();
           try
           {
               alumnos.Id_Estado = DTOAlumno.Id_Estado;
               alumnos.nombre = DTOAlumno.nombre;
               alumnos.appat = DTOAlumno.appat;
               alumnos.apmat = DTOAlumno.apmat;
               alumnos.curp = DTOAlumno.curp;
               alumnos.fecha_nac = DTOAlumno.fecha_nac;
               alumnos.Id_Estado = DTOAlumno.Id_Estado;

               return DTOAlumno;
           }
           catch (Exception ex)
           {
               
               throw ex;
           }
         
         
       }
    }
}
