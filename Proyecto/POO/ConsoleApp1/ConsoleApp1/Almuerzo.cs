using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Almuerzo
    {
        private Bebida[] bebida;
        private Postre postre;



        private string nombre;
        private float precio;
        private bool sopa;

        public Almuerzo()
        {
            nombre = "Plancha";
            precio = 12000;
            sopa = false;
        }

        public static void Comer(float precio)
        {

        }
        public static void Empacar(string nombre)
        {
            

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public bool Sopa { get => sopa; set => sopa = value; }
        public Postre Postre { get => postre; set => postre = value; }
    }
}
