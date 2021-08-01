using System;
using System.Collections;

namespace C_
{
    class Program
    {
        public static int contarCaracter(string cadena, char caracter){
                int contador = 0;
                foreach (char item in cadena)
                {
                    if(item == caracter){
                        contador++;
                    }
                }
                return contador;
            }
        static void Main(string[] args)
        {      
            Console.WriteLine("Ingrese la palabra: ");
            string palabra = Console.ReadLine();
            Console.WriteLine("Ingrese el caracter: ");
            char caracter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(contarCaracter(palabra,caracter));
        }
    }
}
