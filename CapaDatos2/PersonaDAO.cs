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
        private static String cadenaConexion = @"server=PC; database=Estudiantes; integrated security=true";

        public static int crear(Persona persona)
        {
            //Agregar estudiantes en la BDD
            //1. Establecer conexión con el servidor de BDD

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



            //objeto tipo Conexión para conectarse al servidor

            SqlConnection conexion = new SqlConnection(cadenaConexion);



            //2. definir la operación a realizar en el servidor

            //operación: obtener todos los registros

            //sql (lenguaje estructurado de consultas)

            string sql = "select cedula as Cédula, upper(apellidos +' '+ nombres) as Estudiante, case when sexo='M' then 'Masculino' else 'Femenino' end as Sexo, fechaNacimiento as [Fecha Nac.], Correo, Estatura, Peso" +

                " from Personas order by apellidos, nombres";



            //definir un adaptador de datos: es un puente que permite pasar los datos de la BDD hacia el datatable

            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);



            //3. recuperamos los datos

            DataTable dt = new DataTable();

            ad.Fill(dt);//desde el adaptador paso los datos al datatable

            return dt;

        }

        public static Persona GetPersona(String cedula)

        {

            //1. Establecer conexión con el servidor de BDD



            //autenticación sql server

            //string cadenaConexion = @"server=A-SIS-0KP\SQLEXPRESS2016; database=Estudiantes; user id=sa; pwd=isa";



            //autenticación con el usuario de windows



            //objeto tipo Conexión para conectarse al servidor

            SqlConnection conexion = new SqlConnection(cadenaConexion);



            //2. definir la operación a realizar en el servidor

            //operación: obtener todos los registros

            //sql (lenguaje estructurado de consultas)

            string sql = "select cedula, apellidos, nombres, sexo, fechaNacimiento, Correo, Estatura, Peso " +
                "from Personas "+
                "where cedula=@cedula";



            //definir un adaptador de datos: es un puente que permite pasar los datos de la BDD hacia el datatable

            SqlDataAdapter ad = new SqlDataAdapter(sql, conexion);

            //pasar el parámetro
            ad.SelectCommand.Parameters.AddWithValue("@cedula", cedula);


            //3. recuperamos los datos

            DataTable dt = new DataTable();

            ad.Fill(dt);//desde el adaptador paso los datos al datatable

            Persona p = new Persona();
            //recorrer el datatable
            foreach(DataRow fila in dt.Rows)
            {
                p.Cedula = fila["cedula"].ToString();
                p.Apellidos = fila["apellidos"].ToString();
                p.Nombres = fila["nombres"].ToString();
                p.Sexo = fila["sexo"].ToString();
                p.Correo = fila["correo"].ToString();
                p.Estatura = int.Parse(fila["estatura"].ToString());
                p.Peso = decimal.Parse(fila["peso"].ToString());
                p.FechaNacimiento = Convert.ToDateTime(fila["fechaNacimiento"].ToString());
                break; //abandona el for
            }

            return p;

        }

    }

}