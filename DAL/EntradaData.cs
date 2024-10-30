using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class EntradaData
   {
      public void EliminarEntrada(int idEntrada)
      {
         string connectionString = ConfigurationManager.ConnectionStrings["UI.Properties.Settings.ModeloParcialConnection"].ConnectionString;
         try
         {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();
               string query = "DELETE FROM ENTRADA WHERE ID_ENTRADA = @NumeroEntrada";
               using (SqlCommand command = new SqlCommand(query, connection))
               {
                  command.Parameters.AddWithValue("@NumeroEntrada", idEntrada);
                  command.ExecuteNonQuery();
               }
            }
         }
         catch (Exception ex)
         {
            throw;
         }
      }

      public void ExtenderVigencia(int idEntrada, DateTime nuevaFechaValidez)
      {
         string connectionString = ConfigurationManager.ConnectionStrings["UI.Properties.Settings.ModeloParcialConnection"].ConnectionString;
         try
         {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();
               string query = "UPDATE ENTRADA SET FECHA_VALIDEZ = @FechaValidez WHERE ID_ENTRADA = @NumeroEntrada";
               using (SqlCommand command = new SqlCommand(query, connection))
               {
                  command.Parameters.AddWithValue("@NumeroEntrada", idEntrada);
                  command.Parameters.AddWithValue("@FechaValidez", nuevaFechaValidez);
                  command.ExecuteNonQuery();
               }
            }
         }
         catch (Exception ex)
         {
            throw;
         }
      }

      public List<Entrada> getAll()
      {
         try
         {
            List<Entrada> ListaEntradas = new List<Entrada>();
            string connectionString = ConfigurationManager.ConnectionStrings["UI.Properties.Settings.ModeloParcialConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();
               string query = "SELECT ID_ENTRADA, ID_TIPO_TURISMO, DNI_PASAPORTE, MONTO, FECHA_REGISTRO, FECHA_VALIDEZ FROM ENTRADA";
               using (SqlCommand command = new SqlCommand(query, connection))
               {
                  using (SqlDataReader reader = command.ExecuteReader())
                  {
                     while (reader.Read())
                     {
                        Entrada nuevaEntrada = new Entrada
                        {
                           IdEntrada = Convert.ToInt32(reader["ID_ENTRADA"].ToString()),
                           IdTipoTurismo = Convert.ToInt32(reader["ID_TIPO_TURISMO"].ToString()),
                           DniPasaporte = reader["DNI_PASAPORTE"].ToString(),
                           Monto = Convert.ToDouble(reader["Monto"].ToString()),
                           FechaRegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"].ToString()),
                           FechaValidez = Convert.ToDateTime(reader["FECHA_VALIDEZ"].ToString()),
                           
                        };
                        ListaEntradas.Add(nuevaEntrada);
                     }
                  }

               }
            }
            return ListaEntradas;
         }catch (Exception ex)
         {
            throw;
         }
      }
      public void guardarEntrada(Entrada entrada)
      {
         string connectionString = ConfigurationManager.ConnectionStrings["UI.Properties.Settings.ModeloParcialConnection"].ConnectionString;
         try
         {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();
               string insertQuery = "INSERT INTO ENTRADA (ID_TIPO_TURISMO, DNI_PASAPORTE, MONTO, FECHA_REGISTRO, FECHA_VALIDEZ) VALUES(@IdTipoTurismo, @DniPasaporte, @Monto, @FechaRegistro, @FechaValidez)";
               using(SqlCommand command = new SqlCommand(insertQuery, connection))
               {
                  command.Parameters.AddWithValue("@IdTipoTurismo", entrada.IdTipoTurismo);
                  command.Parameters.AddWithValue("@DniPasaporte", entrada.DniPasaporte);
                  command.Parameters.AddWithValue("@Monto", entrada.Monto);
                  command.Parameters.AddWithValue("@FechaRegistro", entrada.FechaRegistro);
                  command.Parameters.AddWithValue("@FechaValidez", entrada.FechaValidez);

                  command.ExecuteNonQuery();
               }
            }
         }
         catch (Exception ex)
         {
            throw new Exception("Error al guardar en la base de datos: " + ex.Message);
         }

      }

  
   }
}
