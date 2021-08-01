using System;
using System.Collections;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De que longitud quiere el vector: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            int[] arreglo = new int[longitud];
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"que número quiere en el indice {i}?");
                int numero = Convert.ToInt32(Console.ReadLine());
                arreglo[i] = numero;
            }
            Console.WriteLine("su vector es:");
            foreach (int item in arreglo)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("ordenado de menor a mayor es:");
            int[] arregloAscendente = arreglo;
            int numeroGuardado = 0;
            for (int i = 0; i<longitud; i++){
               for(int j = 0; j<longitud-1; j++)
               {
                   if(arregloAscendente[j]>arregloAscendente[j+1])
                   {
                       numeroGuardado = arregloAscendente[j];
                       arregloAscendente[j] = arregloAscendente[j+1];
                       arregloAscendente[j+1] = numeroGuardado;
                   }
               } 
            }
            foreach (int item in arregloAscendente)
            {
                Console.Write(item+" ");
            }
             Console.WriteLine("");
             Console.WriteLine("ordenado de mayor a menor es:");
             int[] arregloDescendente = arreglo;
             for(int i = 0; i<longitud; i++)
             {
               for(int j = 0; j<longitud-1; j++)
               {
                   if(arregloDescendente[j]<arregloDescendente[j+1])
                   {
                       numeroGuardado = arregloDescendente[j];
                       arregloDescendente[j] = arregloDescendente[j+1];
                       arregloDescendente[j+1] = numeroGuardado;
                   }
               } 
            }
            foreach(int item in arregloDescendente)
            {
                Console.Write(item+" ");
            }
        }
    }
}
