using D04_LINQ.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HelloWorld
            HelloWorld hw = new HelloWorld();

            Console.WriteLine("Hello World - Method Syntax \n -----");
            hw.HelloWorldMethodSyntax();

            Console.WriteLine();


            Console.WriteLine("Hello World - Query Syntax \n -----");
            hw.HelloWorldQuerySyntax();

            Console.ReadKey();

            #endregion



            #region NumbersGreaterOrEqualTo10
            NumbersGreaterOrEqualTo10 numbers = new NumbersGreaterOrEqualTo10();

            #endregion

        }
    }
}
