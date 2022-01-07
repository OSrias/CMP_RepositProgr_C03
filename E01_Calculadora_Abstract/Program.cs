using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculadora_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraSimples cs = new CalculadoraSimples();
            CalculadoraCientifica cc = new CalculadoraCientifica();

            Console.WriteLine(cs.Somar(1, 2));
            Console.WriteLine(cs.Somar(1, 2, 3));
            Console.WriteLine(cs.Subtrair(1, 2));
            Console.WriteLine(cs.Multiplicar(1, 2, 3, 4));
            Console.WriteLine(cs.Dividir(1, 2));

            Console.WriteLine("\n\n");

            Console.WriteLine(cc.Somar(1, 2));
            Console.WriteLine(cc.Subtrair(1, 2));
            Console.WriteLine(cc.Multiplicar(1, 2, 3, 4));
            Console.WriteLine(cc.Dividir(1, 2));
            Console.WriteLine(cc.RaizQuadrada(9));
            Console.WriteLine(cc.ValorAbsoluto(1));



            Console.ReadKey();
        }
    }
}
