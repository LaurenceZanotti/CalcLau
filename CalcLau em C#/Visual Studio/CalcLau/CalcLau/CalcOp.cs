using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLau
{
    class CalcOp
    {
        private static string resultado;
        private static long valor;
        private static long valor1;
        private static long valor2;


        public static void Soma()
        {
            valor = valor2 + valor1;
            resultado = valor.ToString();
        }

        public static void Sub()
        {
            valor = valor2 - valor1;
            resultado = valor.ToString();
        }

        public static void Multi()
        {
            valor = valor2 * valor1;
            resultado = valor.ToString();
        }

        public static void Div()
        {
            valor = valor2 / valor1;
            resultado = valor.ToString();
        }

        public static string getResultado()
        {
            return resultado;
        }

        public static void setValor1(long valor1)
        {
            CalcOp.valor1 = valor1;
        }

        public static void setValor2(long valor2)
        {
            CalcOp.valor2 = valor2;
        }
    }
}
