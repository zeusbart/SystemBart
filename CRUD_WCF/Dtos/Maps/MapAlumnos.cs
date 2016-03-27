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
        /// 
       
       public DTOAlumno MapAlumnosENTToDTO(Model.alumnos alumnos)
       {
           DTOAlumno DTOAlumno = new DTOAlumno();
           try
           {
               DTOAlumno.id = alumnos.Id_Alumno;
               DTOAlumno.nombre = alumnos.nombre;
               DTOAlumno.appat=alumnos.appat;
                DTOAlumno.apmat=alumnos.apmat;
                DTOAlumno.curp = alumnos.curp;
               DTOAlumno.fecha_nac =alumnos.fecha_nac ;
                DTOAlumno.Id_Estado= alumnos.Id_Estado;

               return DTOAlumno;
           }
           catch (Exception ex)
           {
               
               throw ex;
           }
         
         
       }

       public Model.alumnos MapAlumnosDTOToENT(DTOAlumno DTOAlumno,Model.alumnos ent)
       {
          
           try
           {

               ent.Id_Alumno = DTOAlumno.id;
               ent.nombre = DTOAlumno.nombre;
               ent.appat = DTOAlumno.appat;
               ent.apmat = DTOAlumno.apmat;
               ent.curp = DTOAlumno.curp;
               ent.Id_Estado = DTOAlumno.Id_Estado;
               ent.fecha_nac = DTOAlumno.fecha_nac;

               return ent;
           }
           catch (Exception ex)
           {
               
               throw ex;
           }
       }
    }
}
