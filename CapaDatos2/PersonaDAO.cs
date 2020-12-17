using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class PersonaDAO
    {
        public static DataTable getAll()
        {
            //1. Definir y configurar la conexión con el motor de BDD

            //Autenticación sql server
            //String cadenaConexion = @" ; database=Estudiantes; user id=sa; pwd=isa";

            //Autenticación con el usuario de windows
            String cadenaConexion = @"PC\PC ; database=Estudiantes; integrated-security=true";

            //Objeto tipo conexión para conectarse con el servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);


            //2. Definir la operación a realizar en el servidor
            //Operación: obtener todos los registros
            // sql(lenguaje estructurado de consultas
            string sql = "select cedula, apellidos, nombres, sexo, fechaNacimiento, correo, estatura, peso " +
                         "from personas";

            //definir un adaptador de datos: es un puente que permite pasar datos de la base de datos hacía el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            //3. Recuperamos los datos
            DataTable dt = new DataTable();
            ad.Fill(dt); //desde el adaptador paso los datos al datatable

            return dt;

        }
    }
}
