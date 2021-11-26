using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_formatacaomoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("imforme um valor americano para ser formatado : ");
            double valor = double.Parse(Console.ReadLine());

            //moeda brasileira
            Console.Write("\n\nvalor formatado " + valor.ToString("c"));

            //moeda japonesa
            Console.Write("\n\nvalor formatado " + valor.ToString("c", System.Globalization.CultureInfo.GetCultureInfo("ja-JP")));

            //moeda americana
            Console.Write("\n\nvalor formatado " + valor.ToString("c",System.Globalization.CultureInfo.GetCultureInfo("en-US")));

            //moeda argentina
            Console.Write("\n\nvalor formatado " + valor.ToString("c",System.Globalization.CultureInfo.GetCultureInfo("es-AG")));

            Console.ReadKey();
        }
    }
}
