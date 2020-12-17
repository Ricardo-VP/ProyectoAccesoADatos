using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos
{
    class Persona
    {
        public String Cedula { get; set; }
        public String Apellidos { get; set; }
        public String Nombre { get; set; }
        public String Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Correo { get; set; }
        public int Estatura { get; set; }
        public Decimal Peso { get; set; }
    }
}
