using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;


namespace ReadIB
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Variável para medir tempo de execução.
            var watch = new Stopwatch();
            string[] lstPalavras;
            //Iníco cálculo tempo de execução.
            watch.Start();

            string data = File.ReadAllText(@"C:\\SEG\\dados\\DADOS3.IB").ToString();

            watch.Stop();

            Console.WriteLine($"Tempo Execução em segundos: {watch.Elapsed.TotalSeconds.ToString()} ");

            // Variável que irá validar os caracteres permitidos.
            Regex rgx = new Regex(@"^[a-zA-Z]");           

            // Irá ler a palavra ou frase digitada e separar por espaços.
            lstPalavras = data.Split();
            Console.Clear();

            foreach (var palavra in lstPalavras)
            {
                if (rgx.IsMatch(palavra))
                {
                    Console.WriteLine(palavra);
                    Console.ReadKey();
                }

            }

            Console.ReadKey();
        }

    }
}