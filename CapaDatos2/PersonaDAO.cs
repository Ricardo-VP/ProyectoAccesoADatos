using System;

using System.Collections.Generic;

using System.Text;

using System.Data;

using System.Data.SqlClient;



namespace CapaDatos

{

    public static class PersonaDAO

    {

        //DAO Data Access Object

        public static int crear(Persona persona)
        {
            //Agregar estudiantes en la BDD
            //1. Establecer conexión con el servidor de BDD
            string cadenaConexion = @"server=PC; database=Estudiantes; integrated security=true";

            //objeto tipo Conexión para conectarse al servidor
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //2. Definir operación sobre la bdd (insertar)
            string sql = "insert into Personas(cedula, apellidos, nombres, sexo, fechaNacimiento, correo, estatura, peso)" +
                " values(@cedula, @apellidos, @nombres, @sexo, @fechaNacimiento, @correo, @estatura, @peso)";

            //Definir un objeto de la clase Command para ejecutar la sentencia sql que hemos creado
            SqlCommand comando = new SqlCommand(sql, conexion);

            //Definir parámetros
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@cedula", persona.Cedula);
            comando.Parameters.AddWithValue("@apellidos", persona.Apellidos);
            comando.Parameters.AddWithValue("@nombres", persona.Nombres);
            comando.Parameters.AddWithValue("@sexo", persona.Sexo);
            comando.Parameters.AddWithValue("@fechaNacimiento", persona.FechaNacimiento);
            comando.Parameters.AddWithValue("@correo", persona.Correo);
            comando.Parameters.AddWithValue("@estatura", persona.Estatura);
            comando.Parameters.AddWithValue("@peso", persona.Peso);

            //3. Abrir la conexión y ejecutar el comando
            conexion.Open();
            int x = comando.ExecuteNonQuery();
            //4. Cerrar la conexión
            conexion.Close();

            return x;
        }

        public static DataTable GetAll()

        {

            //1. Establecer conexión con el servidor de BDD



            //autenticación sql server

            //string cadenaConexion = @"server=A-SIS-0KP\SQLEXPRESS2016; database=Estudiantes; user id=sa; pwd=isa";



            //autenticación con el usuario de windows

            string cadenaConexion = @"server=PC; database=Estudiantes; integrated security=true";



            //objeto tipo Conexión para conectarse al servidor

            SqlConnection conexion = new SqlConnection(cadenaConexion);



            //2. definir la operación a realizar en el servidor

            //operación: obtener todos los registros

            //sql (lenguaje estructurado de consultas)

            string sql = "select cedula, apellidos,nombres, sexo, fechaNacimiento, correo, estatura, peso " +

                "from Personas";



            //definir un adaptador de datos: es un puente que permite pasar los datos de la BDD hacia el datatable

            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);



            //3. recuperamos los datos

            DataTable dt = new DataTable();

            ad.Fill(dt);//desde el adaptador paso los datos al datatable

            return dt;

        }

    }

}