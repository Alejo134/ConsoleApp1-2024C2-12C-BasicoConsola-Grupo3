using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_2024C2_12C_BasicoConsola
{
    internal class Persona
    {
        public String dni { get; set; }
        public String apellido { get; set; }
        public int edad { get; set; }

        public Persona(string dni, string apellido, int edad)
        {
            this.dni = dni;
            this.apellido = apellido;
            this.edad = edad;
        }


        public string mostrarDatos()
        {
            return "El dni de la persona es " + this.dni + ", El apellido es " + this.apellido + ", y la edad es de " + this.edad;
        }
    }
}
