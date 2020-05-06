/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package backlogic;

/**
 *
 * @author Lau
 */
public class CalcOp {
        private static String resultado;
        private static long valor;
        private static long valor1;
        private static long valor2;
        
        
    public static void Soma(){
        valor = valor2 + valor1;
        resultado = String.valueOf(valor);
    }
    
    public static void Sub(){
        valor = valor2 - valor1;
        resultado = String.valueOf(valor);
    }
    
    public static void Multi(){
        valor = valor2 * valor1;
        resultado = String.valueOf(valor);
    }
    
    public static void Div(){
        valor = valor2 / valor1;
        resultado = String.valueOf(valor);
    }

    public static String getResultado() {
        return resultado;
    }

    public static void setValor1(long valor1) {
        CalcOp.valor1 = valor1;
    }

    public static void setValor2(long valor2) {
        CalcOp.valor2 = valor2;
    }
}