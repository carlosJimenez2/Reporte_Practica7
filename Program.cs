using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosMultidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int[,] matriz1 = new int [ 5, 5 ];
            int[,] matriz3 = { { 3, 4 }, { 5, 6 } };
            int [,] matriz4 = { { 7, 8 }, { 9, 10 } };
            string[,] matriz5 = { { "Enero", "Lunes" }, { "Soleado", "Lluvioso" } };
            string[,] matriz6 = { { "mes", "dia" }, { "Clima en la añana", "Clima en la tarde" } };

            for (i = 0; i < 2; i++)
            {
                for (j = 0; i < 2; j++)
                {
                    matriz1[i,j] = matriz3[i,j] + matriz4[i,j];
                    Console.WriteLine(matriz1[i,j]);
                }
            } 

          /*  for (i = 0; i < 2; i++)
            {
                for (j = 0; i < 2; j++)
                {
                   
                    Console.WriteLine("El {0}, Sera {1}", matriz6[i, j], matriz5[i,j]);
                }
            }*/

           
            Console.ReadKey();

        }
    }
}
