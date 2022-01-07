using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculadora_Abstract
{
    abstract class Calculadora
    {
        #region Properties
        public abstract double Valor01 { get; set; }
        public abstract double Valor02 { get; set; }
        public abstract double Valor03 { get; set; }
        public abstract double Valor04 { get; set; }
        public abstract double Resultado { get; set; }
        #endregion


        #region Methods
        public abstract double Somar(double v1, double v2);
        public abstract double Subtrair(double v1, double v2);
        public abstract double Multiplicar(double v1, double v2, double v3, double v4);
        public abstract double Dividir(double v1, double v2);
        
        #endregion

    }
}
