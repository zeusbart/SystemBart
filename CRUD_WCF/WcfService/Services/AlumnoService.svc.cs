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
    

public bool SaveAlumno(DTOAlumno dtalumno)
{
    mp=new MapAlumnos();
    try
    {
        using (OperativoEntities EntityAlumno=new OperativoEntities())
        {
            alumnos al = new alumnos();
           al = mp.MapAlumnosDTOToENT(dtalumno);
           EntityAlumno.alumnos.Add(al);
            EntityAlumno.SaveChanges();
            
        }
        return true;
    }
    catch (Exception)
    {

        return false;
    }


    return true;
}


}
}
