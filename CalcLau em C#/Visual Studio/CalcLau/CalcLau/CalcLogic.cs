using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLau
{
    class CalcLogic
    {
        //ATRIBUTOS
        private static long valorDigitado;
        private static string valorExibido;
        private static string valorExibido2;

        //MÉTODOS

        private static bool isZerado()
        {
            if (valorExibido == "0")
            {
                return true;
            } else
            {
                return false;
            }
        }

        private static bool isFull()
        {
            return valorDigitado > 99999999999999999;
        }

        public static void digitar(long numeroBotao)
        {
            if (!isFull())
            {
                if (!isZerado())
                {
                    string valor = valorExibido + numeroBotao;
                    valorExibido = valor;
                    valorDigitado = long.Parse(valor);
                    //Console.WriteLine("valorExibido: "+valorExibido);
                    //Console.WriteLine("valorDigitado: " + valorDigitado);
                }
                else
                {
                    string valor = numeroBotao.ToString();
                    valorExibido = valor;
                    valorDigitado = long.Parse(valor);
                    //Console.WriteLine("valorExibido: " + valorExibido);
                    //Console.WriteLine("valorDigitado: " + valorDigitado);
                }
            }
            else
            {
                Console.WriteLine("Valor máximo atingido");
            }
        }

        public static void operar(string op)
        {
            CalcOp.setValor1(long.Parse(CalcLogic.getValorExibido()));
            CalcOp.setValor2(long.Parse(CalcLogic.getValorExibido2()));

            switch (op)
            {
                case "soma":
                    CalcOp.Soma();
                    break;

                case "sub":
                    CalcOp.Sub();
                    break;

                case "multi":
                    CalcOp.Multi();
                    break;

                case "div":
                    CalcOp.Div();
                    break;
            }
        }

        public static void atualizar()
        {
            valorExibido2 = valorExibido;
            valorExibido = "0";
            valorDigitado = 0;
            //Console.WriteLine("Método atualizar() | valorExibido2: " + valorExibido2);
        }

        public static void resetar()
        {
            valorDigitado = 0;
            valorExibido = "0";
            valorExibido2 = "0";
        }

        // GETTERS e SETTERS (Feitos manualmente baseado na estrutura da versão Java).

        public static long getValorDigitado()
        {
            return valorDigitado;
        }

        public static void setValorDigitado(long valor)
        {
            CalcLogic.valorDigitado = valor;
        }

        public static string getValorExibido()
        {
            return valorExibido;
        }

        public static void setValorExibido(string valor)
        {
            CalcLogic.valorExibido = valor;
        }

        public static string getValorExibido2()
        {
            return valorExibido2;
        }

        public static void setValorExibido2(string valor)
        {
            CalcLogic.valorExibido2 = valor;
        }

    }
}