﻿

namespace Actividad2.Models
{
    public class Policia
    {
        public int NumeroPlaca { get; private set; }
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        
        public Policia(int dni, string nombre, int numeroPlaca)
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.NumeroPlaca = numeroPlaca;
        }

        public string VerDatos() 
        {
            return $"{this.Nombre}(DNI:{this.DNI} - placa:{NumeroPlaca})";
        }
    }
}
