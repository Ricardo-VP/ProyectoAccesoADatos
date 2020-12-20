using System;

using System.Collections.Generic;

using System.Text;



namespace CapaDatos

{

    public class Persona

    {

        //getter y setter (getter: devolver el valor --hacer un return

        //setter (cambiar el valor del atributos)

        public String Cedula { get; set; }

        public String Apellidos { get; set; }

        public String Nombres { get; set; }

        public String Sexo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public String Correo { get; set; }

        public int Estatura { get; set; }

        public Decimal Peso { get; set; }

    }

}

