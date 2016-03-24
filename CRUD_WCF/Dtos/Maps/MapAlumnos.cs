using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs_Maps.DTO;
using Model=Persistencia.Model.Operativo;


namespace DTOs_Maps.Maps
{
   public class MapAlumnos
    {
       /// <summary>
       /// Mapeo Entidad Alumnos
       /// </summary>
       /// <param name="alumnos"></param>
        /// <returns>DTOAlumno</returns>
       public DTOAlumno MapAlumnosENTToDTO(Model.alumnos alumnos)
       {
           DTOAlumno DTOAlumno=new DTOAlumno();
           try
           {
               
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

       public Model.alumnos MapAlumnosDTOToENT(DTOAlumno dto,Model.alumnos ent)
       {
           
           try
           {

               ent.Id_Alumno = dto.id;
               ent.nombre = dto.nombre;
               ent.appat = dto.appat;
               ent.apmat = dto.apmat;
               ent.curp = dto.curp;
               ent.Id_Estado = dto.Id_Estado;
               ent.fecha_nac = dto.fecha_nac;

               return ent;
           }
           catch (Exception ex)
           {
               
               throw ex;
           }
       }
    }
}
