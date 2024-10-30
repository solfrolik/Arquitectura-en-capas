using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class TipoTurismoBusiness
   {
      private TipoTurismoData tipoTurismoData = new TipoTurismoData();
      
      public List<TipoTurismo> getAll()
      {
         try
         {
            return tipoTurismoData.getAll();
         }catch (Exception ex)
         {
            throw;
         }
      }

   }
}
