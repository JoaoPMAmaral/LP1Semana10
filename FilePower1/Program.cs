using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string nomeFicheiro = args[0];
            StreamWriter sw = new StreamWriter(nomeFicheiro);
            Queue<string> palavras = new Queue<string>();

            bool loop = true;

            while(loop == true)
            {
                
                Console.WriteLine("Escreve uma palavra");
                string palavra = Console.ReadLine();

                if(palavra == "")
                {
                    loop = false;
                }
                
                palavras.Enqueue(palavra);
            }

            foreach(string elemento in palavras)
            {
                sw.WriteLine(elemento);
            }

            sw.Close();
        }
    }
}
