using System;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la ruta del archivo de texto plano:");
            string path = Console.ReadLine();
            string[] lines = File.ReadAllLines(@path);  
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }  
            lines[0] = "cambia";
            lines[1] = "cambia 2 veces";
            lines[2] = "cambia 3 veces";
            File.WriteAllLines(path, lines);



        }
    }
}
