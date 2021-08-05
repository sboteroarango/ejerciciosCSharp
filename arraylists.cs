using System;
using System.Collections;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList lista = new ArrayList();
            lista.Add("hola");
            lista.Add("alo");
            lista.Add("para quitar");
            lista.Add("para quitar");
            Console.WriteLine(lista.Contains(lista[1]));
            lista.Remove("para quitar");
            lista.Sort();
            lista.Reverse();
            lista[0] = "para poner";
            foreach(var iteme in lista){
                Console.WriteLine(iteme);
            }


        }
    }
}
