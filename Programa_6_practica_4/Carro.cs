using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_6_practica_4
{
   public  class Carro
    {
         private int cantidad_combustible;
        

        public void encender()
        {

            Console.WriteLine("Digite la cantidad de Combustible:");
            cantidad_combustible = int.Parse(Console.ReadLine());

            for (int i = 0; i > cantidad_combustible; i++)
            {
                
                                       }
            if (cantidad_combustible >= 1)
            {
                Console.WriteLine("El auto esta encendido");

                Console.WriteLine("El Carro pudo avanzar");

            }
            else if (cantidad_combustible < 1)
            {
                Console.WriteLine("Conbustible insuficiente" + cantidad_combustible);
            }
            Console.ReadKey();
            return;
           


        }
    }
   
}
