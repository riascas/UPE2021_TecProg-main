using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPE_MiPrimerAplicacionDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declaramos las variables*/
            float promedio = 0;
            int cantidadDeNotasACargar = 0;

            Console.WriteLine("Ingrese la cantidad de notas a cargar:");


            cantidadDeNotasACargar = int.Parse(Console.ReadLine());

            promedio = CalcularPromedio(PedirNotas(cantidadDeNotasACargar), cantidadDeNotasACargar);

            Console.Read();
        }
        

        /// <summary>
        /// Método que se encarga de calcular el promedio
        /// </summary>
        /// <param name="sumaDeNotas">Sumatoria de las notas a promediar</param>
        /// <param name="totalDeNotas">Cantidad total de notas</param>
        /// <returns>El promedio</returns>
        public static float CalcularPromedio(int sumaDeNotas, int totalDeNotas)
        {
            /*Calcular promedio*/
            float promedio = (float)(sumaDeNotas) / (float)totalDeNotas;
            Console.WriteLine(string.Format("El promedio de las cuatro notas es: {0}", promedio.ToString()));
            Console.WriteLine("¡Presione una tecla para finalizar!");

            return promedio;
        }


        private static int PedirNotas(int pTotalDeNotas)
        {
            int sumaDeNotas = 0;


            /*Solicitamos las notas*/
            for (int i = 0; i < pTotalDeNotas; i++)
            {
                Console.WriteLine("Ingrese la nota " + (i + 1));
                sumaDeNotas += int.Parse(Console.ReadLine());
            }

            return sumaDeNotas;

        }
    }
}
