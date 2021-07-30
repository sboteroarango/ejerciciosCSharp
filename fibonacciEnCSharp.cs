using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 0;
            int segundoNumero = 1;
            int numeroSiguiente = 0;
            Console.Write("Ingrese que dato quiere de la secuencia donde el 0 es el dato 1: ");
            int indiceDeLaSecuencia = Convert.ToInt32(Console.ReadLine());
            if (indiceDeLaSecuencia == 1){
                Console.WriteLine(primerNumero);
            }else if(indiceDeLaSecuencia == 2){
                Console.WriteLine(segundoNumero);
            }else{
                for (int i = 0; i<=indiceDeLaSecuencia-3;i++){
                    numeroSiguiente = primerNumero+segundoNumero;
                    primerNumero = segundoNumero;
                    segundoNumero = numeroSiguiente;
                }
            }
            Console.WriteLine(numeroSiguiente);
            



        }
    }
}
