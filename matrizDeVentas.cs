using System;
using System.Collections;

namespace C_
{
    class Program
    {
        public static void mostrarMatriz(int[,] matriz)
        {
            int cantidadFilas = matriz.GetLength(0);
            int cantidadColumnas = matriz.GetLength(1);
            for(int i = 0; i<cantidadFilas; i++)
            {
                for(int j=0;j<cantidadColumnas;j++)
                {
                    Console.Write(matriz[i,j]+" | ");
                    
                }
            Console.WriteLine(" ");
            }
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("escriba el numero de vendedores:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba el numero de años que llevan vendiendo:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[m,n];

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n;j++)
                {
                    Console.WriteLine($"Cuanto vendió el vendedor {i+1} en el {j+1} año");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            mostrarMatriz(matriz);




        }
    }
}
