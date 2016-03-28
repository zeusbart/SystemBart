using System;
using System.Linq;
using DTOs_Maps.DTO;
using DTOs_Maps.Maps;
using Persistencia.Model.Operativo;
using WcfService.Interfaces;

namespace WcfService.Operaciones
{
    public class AlumnoService : IAlumnoService
    {
        private MapAlumnos mp;

        public DTOAlumnosList GetAllAlumnos()
        {
            mp = new MapAlumnos();
            try
            {
                DTOAlumnosList ListaDTOALumnos = new DTOAlumnosList();
                using (OperativoEntities EntityAlumnos = new OperativoEntities())
                {
                    var allEntityAlumnos = EntityAlumnos.alumnos.ToList();
                    foreach (var item in allEntityAlumnos)
                    {
                        DTOAlumno DTOalumno = mp.MapAlumnosENTToDTO(item);
                        ListaDTOALumnos.Add(DTOalumno);
                    }
                }
                return ListaDTOALumnos;
            }
            catch (Exception e)
            {

                throw e;
            }
        }




        public bool NewAndUpdateAlumno(DTOAlumno dtolumno)
        {
            mp = new MapAlumnos();
            try
            {
                using (OperativoEntities EntityAlumno = new OperativoEntities())
                {
                    alumnos EntityBusquedaAlumno = EntityAlumno.alumnos.FirstOrDefault(p => p.Id_Alumno == dtolumno.id);
                    if (EntityBusquedaAlumno == null)
                    {
                        EntityBusquedaAlumno = new alumnos();
                        EntityBusquedaAlumno = mp.MapAlumnosDTOToENT(dtolumno, EntityBusquedaAlumno);
                        EntityAlumno.alumnos.Add(EntityBusquedaAlumno);
                    }
                    else
                    {
                        //actualizar
                        EntityBusquedaAlumno = mp.MapAlumnosDTOToENT(dtolumno, EntityBusquedaAlumno);
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

        public DTOAlumnosList GetOneAlumno(int id)
        {
            mp = new MapAlumnos();
            DTOAlumnosList list = new DTOAlumnosList();
            try
            {
                using (OperativoEntities ConexionEntityOP = new OperativoEntities())
                {
                    var consulta = ConexionEntityOP.alumnos.Where(p => p.Id_Alumno == id);

                    foreach (var dato in consulta)
                    {

                        DTOAlumno dt = mp.MapAlumnosENTToDTO(dato);

                        list.Add(dt);
                    }


                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
