using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCalculadora.Controller
{
    class Controle
    {
        Calcular calcular = new Calcular();
        public String Mensagem { get; set; }

        public double Somar(double n1, double n2)
        {
            return calcular.Somar(n1, n2);
        }
        public double Dividir(double n1, double n2)
        {
            return calcular.Dividir(n1, n2);
        }
        public double Subtrair(double n1, double n2)
        {
            return calcular.Subtrair(n1, n2);
        }
        public double Multiplicar(double n1, double n2)
        {
            return calcular.Multiplicar(n1, n2);
        }
        public double ConverterSinal(double valor)
        {
            return calcular.ConverterSinal(valor);
        }
    }
}
