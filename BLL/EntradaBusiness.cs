using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class EntradaBusiness
   {
      private EntradaData entradaData = new EntradaData();

      public void guardarEntrada(Entrada entrada)
      {
         try
         {
            if (string.IsNullOrEmpty(entrada.DniPasaporte) || entrada.DniPasaporte.Length < 5)
            {
               throw new Exception("El DNI o Pasaporte es incorrecto. Debe tener más de 5 caracteres.");
            }

            if (entrada.FechaValidez < DateTime.Now)
            {
               throw new Exception("La fecha de validez no puede ser menor a la actual.");
            }

            if (entrada.Monto <= 0)
            {
               throw new Exception("El monto debe ser mayor a cero.");
            }

            if (entrada.IdTipoTurismo <= 0)
            {
               throw new Exception("Debe seleccionar un tipo de turismo.");
            }

            entrada.FechaRegistro = DateTime.Now;  
            entradaData.guardarEntrada(entrada);
         }
         catch (Exception ex)
         {
            throw new Exception("Error al guardar la entrada: " + ex.Message);
         }
      }

      public List<Entrada> getAll()
      {
         try
         {
            return entradaData.getAll();
         }
         catch (Exception ex)
         {
            throw;
         }
      }
     
      public void EliminarEntrada(int IdEntrada)
      {
         try
         {
            entradaData.EliminarEntrada(IdEntrada);
         }
         catch (Exception ex)
         {
            throw;
         }

      }

      public void ExtenderVigencia(int IdEntrada, DateTime nuevaFechaValidez)
      {
         try
         {
            entradaData.ExtenderVigencia(IdEntrada,nuevaFechaValidez);
         }
         catch (Exception ex)
         {
            throw;
         }
      }

   }
}


