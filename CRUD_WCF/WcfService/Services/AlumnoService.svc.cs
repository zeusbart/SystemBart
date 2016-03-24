using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTOs_Maps.Maps;
using  DTOs_Maps.DTO;
using Persistencia.Model.Operativo;


//using Model = Persistencia.Model.Operativo;


namespace WcfService.Service
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AlumnoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AlumnoService.svc o AlumnoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AlumnoService : IAlumnoService
    {
        private MapAlumnos mp;

        public DTOAlumnosList GetAllAlumnos()
        {
           mp=new MapAlumnos();
            try
            {
                DTOAlumnosList ListaDTOALumnos=new DTOAlumnosList();
                using (OperativoEntities EntityAlumnos = new OperativoEntities())
                {
                    var allEntityAlumnos = EntityAlumnos.alumnos;
                    foreach (var item in allEntityAlumnos)
                    {
                        DTOAlumno DTOAlumno = mp.MapAlumnosENTToDTO(item);
                        ListaDTOALumnos.Add(DTOAlumno);
                    }
                }
                return ListaDTOALumnos;
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
    

public bool NewAlumno(DTOAlumno dtolumno)
{
    mp=new MapAlumnos();
    try
    {
        using (OperativoEntities EntityAlumno=new OperativoEntities())
        {
            alumnos EntityBusquedaAlumno = EntityAlumno.alumnos.FirstOrDefault(p => p.Id_Alumno == dtolumno.id);
            if (EntityBusquedaAlumno==null)
            {
                EntityBusquedaAlumno = new alumnos();
                EntityBusquedaAlumno = mp.MapAlumnosDTOToENT(dtolumno, EntityBusquedaAlumno);
                EntityAlumno.alumnos.Add(EntityBusquedaAlumno);
            }
            
            EntityAlumno.SaveChanges();
          
        }
        return true;
    }
    catch (Exception)
    {

        return false;
    }
}

public bool UpdateAlumno(DTOAlumno dtoalumno)
{
    mp = new MapAlumnos();
    try
    {
        using (OperativoEntities entityAlumno=new OperativoEntities())
        {

            var BusquedaAlumno = entityAlumno.alumnos.FirstOrDefault(p => p.Id_Alumno == dtoalumno.id);
            if (BusquedaAlumno!=null)
            {
                BusquedaAlumno = mp.MapAlumnosDTOToENT(dtoalumno, BusquedaAlumno);
            }
            entityAlumno.SaveChanges();
            return true;
        }
    }
    catch (Exception)
    {
        
        return false;
    }
    
}



    }
}
