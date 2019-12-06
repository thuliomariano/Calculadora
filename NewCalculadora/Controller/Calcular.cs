using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculadora.Controller
{
    public class Calcular
    {
        public double Number { get; set; }
        public double Number2 { get; set; }

        public Calcular()
        {
        }

        public Calcular(double number, double number2)
        {
            Number = number;
            Number2 = number2;
        }

        public static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtrair(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Dividir(double n1, double n2)
        {
            double resultado;
            try
            {
                resultado = n1 / n2;
            }
            catch (DivideByZeroException e)
            {
                return 0;
            }
            return resultado;
        }
        public static double ConverterSinal(double valor)
        {
            try
            {
            return valor = valor - (valor * 2);

            }
            catch (StackOverflowException)
            {
                return valor;
            }
        }
    }
}
