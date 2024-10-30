using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class TipoTurismo
   {
      private int idTipoTurismo;
      private string descripcion = string.Empty;

      public int IdTipoTurismo { get => idTipoTurismo; set => idTipoTurismo = value; }
      public string Descripcion { get => descripcion; set => descripcion = value; }
   }
}
