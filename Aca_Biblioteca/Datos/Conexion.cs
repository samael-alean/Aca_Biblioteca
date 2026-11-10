using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Aca_Biblioteca.Datos
{
    public class Conexion
    {
        private static string cadenaConexion = "Server=.;Database=Aca_Biblioteca;Integrated Security=true;TrustServerCertificate=True;Encrypt=False;";
       
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }

}