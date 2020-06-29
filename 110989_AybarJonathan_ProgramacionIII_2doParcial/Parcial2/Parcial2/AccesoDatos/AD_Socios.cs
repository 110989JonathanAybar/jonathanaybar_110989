using Parcial2.Models;
using Parcial2.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Parcial2.AccesoDatos
{
    public class AD_Socios
    {
        public static bool AltaSocio(Socio s)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"].ToString();
            
            SqlConnection cn = new SqlConnection(@"Data Source=JGA_NOTEBOOK;Initial Catalog=master;Integrated Security=True");

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Socios VALUES(@Nombre, @Apellido, @IdTipoDocumento, @NroDocumento, @IdDeporte)";
                
                cmd.Parameters.Clear();
                
                cmd.Parameters.AddWithValue("@Nombre", s.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", s.Apellido);
                cmd.Parameters.AddWithValue("@IdTipoDocumento", s.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@NroDocumento", s.NroDocumento);
                cmd.Parameters.AddWithValue("@IdDeporte", s.IdDeporte);
                
                cmd.CommandType = System.Data.CommandType.Text;
                
                cmd.CommandText = consulta;
                
                cn.Open();
                
                cmd.Connection = cn;
                
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static List<Socio> obtenerListadoSocios()
        {
            List<Socio> resultado = new List<Socio>();            
            SqlConnection cn = new SqlConnection(@"Data Source=JGA_NOTEBOOK;Initial Catalog=master;Integrated Security=True");

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Socios";
                
                cmd.Parameters.Clear();
                
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;
                
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Socio aux = new Socio();
                        aux.Id = int.Parse(dr["Id"].ToString());
                        aux.Nombre = dr["Nombre"].ToString();
                        aux.Apellido = dr["Apellido"].ToString();
                        aux.IdTipoDocumento = int.Parse(dr["IdTipoDocumento"].ToString());
                        aux.NroDocumento = dr["NroDocumento"].ToString();
                        aux.IdDeporte = int.Parse(dr["IdDeporte"].ToString());

                        resultado.Add(aux);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static List<Reporte> obtenerReporte()
        {
            List<Reporte> resultado = new List<Reporte>();
            SqlConnection cn = new SqlConnection(@"Data Source=JGA_NOTEBOOK;Initial Catalog=master;Integrated Security=True");

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Deportes.Nombre 'Deporte' ,COUNT(*) AS 'Cantidad' FROM Deportes,Socios WHERE Deportes.Id=Socios.IdDeporte GROUP BY Deportes.Nombre";

                cmd.Parameters.Clear();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Reporte aux = new Reporte();
                        aux.Deporte = dr.GetString(0);
                        aux.CantidadSocios = int.Parse(dr["Cantidad"].ToString());

                        resultado.Add(aux);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }


        public static List<TipoDocumentoItemVM> obtenerListaTipoDocumento()
        {
            List<TipoDocumentoItemVM> resultado = new List<TipoDocumentoItemVM>();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"].ToString();
            
            SqlConnection cn = new SqlConnection(@"Data Source=JGA_NOTEBOOK;Initial Catalog=master;Integrated Security=True");

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM TiposDocumentos";
                
                cmd.Parameters.Clear();
                
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;
                
                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        TipoDocumentoItemVM aux = new TipoDocumentoItemVM();
                        aux.Id = int.Parse(dr["Id"].ToString());
                        aux.Nombre = dr["Nombre"].ToString();

                        resultado.Add(aux);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static List<DeporteItemVM> obtenerListaDeportes()
        {
            List<DeporteItemVM> resultado = new List<DeporteItemVM>();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"].ToString();

            SqlConnection cn = new SqlConnection(@"Data Source=JGA_NOTEBOOK;Initial Catalog=master;Integrated Security=True");

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Deportes";

                cmd.Parameters.Clear();

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        DeporteItemVM aux = new DeporteItemVM();
                        aux.Id = int.Parse(dr["Id"].ToString());
                        aux.Nombre = dr["Nombre"].ToString();

                        resultado.Add(aux);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
    }
}