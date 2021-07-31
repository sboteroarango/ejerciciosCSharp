using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese una palabra palindroma o capicúa");
            string palabra = Console.ReadLine();
            string palabraAlReves = "";
            for(int i = palabra.Length-1;i>=0;i--){
                palabraAlReves += palabra[i];
            }
            if(palabra == palabraAlReves){
                try{
                    Convert.ToInt32(palabra);
                    Console.WriteLine("es una capicúa");
                }catch{
                    Console.WriteLine("es un palindromo");
                }
            }else{
                Console.WriteLine("No es un palindromo ni capicúa");
            }

            



        }
    }
}
