using System;
using System.Collections;
using System.IO;
using System.Threading.Tasks;
namespace C_
{
    class Program
    {

        public static int[] calcularTotalAño(int[,] matriz)
        {
            int acumulador;
            int[] totalAño = null;
            if(matriz != null){
                totalAño = new int[matriz.GetLength(1)];
                for(int col = 0; col < matriz.GetLength(1); col++)
                {
                    acumulador = 0;
                    for(int fila = 0;fila < matriz.GetLength(0); fila++)
                    { 
                        acumulador += matriz[fila,col];
                    }
                    totalAño[col] = acumulador;
                }
            }
            return totalAño;
        }

        public static int[] calcularTotalVendedor(int[,] matriz)
        {
            int acumulador;
            int[] totalVendedor = null;
            if(matriz != null){
                totalVendedor = new int[matriz.GetLength(0)];
                for(int fila = 0; fila < matriz.GetLength(0); fila++)
                {
                    acumulador = 0;
                    for(int col = 0;col < matriz.GetLength(1); col++)
                    { 
                        acumulador += matriz[fila,col];
                    }
                    totalVendedor[fila] = acumulador;
                }
            }
            return totalVendedor;
        }
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

        public static void mostrarVector(int[] vector)
        {
            foreach (var item in vector)
            {
                Console.Write(item+" ,");
            }
            Console.WriteLine();
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
            int[] totalAño = calcularTotalAño(matriz);
            mostrarVector(totalAño);
            int[] totalVendedor = calcularTotalVendedor(matriz);
            mostrarVector(totalVendedor);
        }
    }
}
