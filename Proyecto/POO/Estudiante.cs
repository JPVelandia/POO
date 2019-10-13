using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Estudiante
    {
        public int[] notas = new int[] { 3, 2, 3 };
        public string nombre;
        public int semestre;
        static int i;
        static int Snotas = 0;
        public static int p;

        public  int Promedio(int[] notas)
        {

            for (i = 0 ; i < notas.Length ; i++)
            {
;                int p = Snotas + notas[i];
            }
            return p;
            
        }
        /*Console.WriteLine(p);
        private Promedio();
        */
    }
}
