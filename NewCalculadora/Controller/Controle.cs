using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewCalculadora.Controller;


namespace NewCalculadora.Controller
{
    public class Controle
    {       
       
        public  String Mensagem { get; set; }
        Calcular calcular = new Calcular();

        public double Soma(double n1, double n2)
        {
            return Calcular.Somar(n1,n2);
        }
        public double Div(double n1, double n2)
        {
            return Calcular.Dividir(n1, n2);
        }
        public double Sub(double n1, double n2)
        {
            return Calcular.Subtrair(n1, n2);
        }
        public double Mult(double n1, double n2)
        {
            return Calcular.Multiplicar(n1, n2);
        }
        public double ConverterSinal(double valor)
        {
            return ConverterSinal(valor);
        }
    } 
}
