using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Entrada
   {
      private int idEntrada;
      private int idTipoTurismo;
      private string dniPasaporte = string.Empty;  // Inicializado
      private double monto;
      private DateTime fechaRegistro;
      private DateTime fechaValidez;

      public int IdEntrada { get => idEntrada; set => idEntrada = value; }
      public int IdTipoTurismo { get => idTipoTurismo; set => idTipoTurismo = value; }
      public string DniPasaporte { get => dniPasaporte; set => dniPasaporte = value; }
      public double Monto { get => monto; set => monto = value; }
      public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
      public DateTime FechaValidez { get => fechaValidez; set => fechaValidez = value; }
   }
}
