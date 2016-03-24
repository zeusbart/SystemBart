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

       public Model.alumnos MapAlumnosDTOToENT(DTOAlumno DTOAlumno)
       {
           Model.alumnos alu=new Model.alumnos();
           try
           {

               alu.Id_Estado = DTOAlumno.Id_Estado;
               alu.nombre = DTOAlumno.nombre;
               alu.appat = DTOAlumno.appat;
               alu.apmat = DTOAlumno.apmat;
               alu.curp = DTOAlumno.curp;
               alu.fecha_nac = DTOAlumno.fecha_nac;
               alu.Id_Estado = DTOAlumno.Id_Estado;
               return alu;
           }
           catch (Exception ex)
           {
               
               throw ex;
           }
       }
    }
}
