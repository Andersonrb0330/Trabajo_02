using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_02
{

    public class Cliente
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
        }

        public Cliente(int dni, DateTime fechaNacimiento)
        {
            this.Dni = dni;
            this.FechaNacimiento = fechaNacimiento;
        }
    }
}
