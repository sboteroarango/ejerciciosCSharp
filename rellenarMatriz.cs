using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5,5];
            int longitud = matriz.GetLength(0);
            for(int i=0; i<longitud;i++){
                matriz[i,i] = 1;
                matriz[i,(longitud-1)-i] = 2;

            }
            mostrarMatriz(matriz);
            

            
        }
        public static void mostrarMatriz(int[,] matriz){
            int longitud = matriz.GetLength(0);
            for(int i = 0; i<longitud; i++){
                for(int j=0;j<longitud;j++){
                    Console.Write(matriz[i,j]+" | ");
                    
                }
            Console.WriteLine(" ");
            }

        }
    }
}

