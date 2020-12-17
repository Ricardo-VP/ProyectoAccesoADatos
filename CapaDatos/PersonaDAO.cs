using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class PersonaDAO
    {
        public static DataTable getAll()
        {
            //1. Definir y configurar la conexión con el motor de BDD
            //Cadena de conexión que utiliza la conexión que proporciona sql server
            //String cadenaConexion = @" ; database=Estudiantes; user id=sa; pwd=isa";

            //Cadena de conexion utilizando el usuario de windows
            String cadenaConexion = " ; database=Estudiantes; integrated-security=true";

            //Definir un objeto tipo conexión para conectarnos con el servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);
        }
    }
}
