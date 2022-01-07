using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Calculadora_Interface
{
    interface ICalculadora
    {
        #region Properties
        double Valor01 { get; }
        double Valor02 { get; }
        double Valor03 { get; }
        double Valor04 { get; }
        double Resultado { get; }
        #endregion


        #region Methods
        double Somar(double v1, double v2);
        double Subtrair(double v1, double v2);
        double Multiplicar(double v1, double v2, double v3, double v4);
        double Dividir(double v1, double v2);

        #endregion
    }
}
