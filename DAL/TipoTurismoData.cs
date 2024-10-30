using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TipoTurismoData
    {
      public List<TipoTurismo> getAll()
      {
         try
         {
            List<TipoTurismo> tipoTurismos = new List<TipoTurismo>();
            string connectionString = ConfigurationManager.ConnectionStrings["UI.Properties.Settings.ModeloParcialConnection"].ConnectionString;
            using (SqlConnection conection = new SqlConnection(connectionString))
            {
               conection.Open();
               string query = "Select ID_TIPO_TURISMO, DESCRIPCION FROM TIPO_TURISMO";
               using (SqlCommand sqlCommand = new SqlCommand(query, conection))
               {
                  using (SqlDataReader reader = sqlCommand.ExecuteReader())
                  {
                     while (reader.Read())
                     {
                        TipoTurismo turismo = new TipoTurismo();
                        turismo.IdTipoTurismo = reader.GetInt32(0);
                        turismo.Descripcion = reader.GetString(1);
                        tipoTurismos.Add(turismo);
                     }
                  }
               }
            }
            return tipoTurismos;
         }
          catch (Exception ex)
            {
             throw;
            }
      }
       

    }
}
