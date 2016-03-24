using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs_Maps.DTO;
using Model=Persistencia.Model.Catalogo;

namespace DTOs_Maps.Maps
{
   public class MapsEstados
    {
       /// <summary>
       /// Mapeo de Estados 
       /// </summary>
       /// <param name="Estados">Modelo</param>
       /// <returns>DTO</returns>
       public DTOEstado MapEstadosENTToDTO( Model.Cat_Estados Estados)
       {
           DTOEstado DTO=new DTOEstado();

           Estados.Id_Estado = DTO.Id_Estado;
           Estados.Nombre = DTO.Nombre;


           return DTO;
       }
    }
}
