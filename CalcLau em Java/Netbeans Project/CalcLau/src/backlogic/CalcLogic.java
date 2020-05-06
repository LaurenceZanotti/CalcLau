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
public class CalcLogic {
    private static long valorDigitado;
    //private int valorDigitado2 = valorDigitado;
    private static String valorExibido;
    private static String valorExibido2;

    private static boolean isZerado(){
        return "0".equals(valorExibido);
    }
    
    private static boolean isFull(){
        return valorDigitado > Long.parseLong("99999999999999999"); //99.999.999.999.999.999 quatrilhão ou 99999999999999999
    }                                                                                             //Saída: 999999999999999999 ou 999.999.999.999.999.999
    
    public static void digitar(int numeroBotao){
        if (!isFull()){
            if (!isZerado()){
                String valor = valorExibido + String.valueOf(numeroBotao);
                valorExibido = valor;
                valorDigitado = Long.parseLong(valor);
                //lblValorDigitado1.setText(valor);
                
                //System.out.println("valorDigitado: "+valorDigitado);
                //System.out.println("valorExibido: "+valorExibido);
            } else {
                String valor = String.valueOf(numeroBotao);
                valorExibido = valor;
                valorDigitado = Long.parseLong(valor);
                //lblValorDigitado1.setText(valor);
                
                //System.out.println("valorDigitado: "+valorDigitado);
                //System.out.println("valorExibido: "+valorExibido);
            }
        } else {
            System.out.println("Valor máximo excedido");
        }
    }
    
    public static void operar(String op){
        CalcOp.setValor1(Long.parseLong(valorExibido));
        CalcOp.setValor2(Long.parseLong(valorExibido2));
        
        switch(op){
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
    
    public static void atualizar(){
        valorExibido2 = valorExibido;
        valorExibido = "0";
        valorDigitado = 0;
    }
    
    public static void resetar(){
        valorDigitado = 0;
        valorExibido = "0";
        valorExibido2 = "0";
    }
    
    public static long getValorDigitado() {
        return valorDigitado;
    }

    public static void setValorDigitado(int valorDigitado) {
        CalcLogic.valorDigitado = Long.valueOf(valorDigitado);
    }

    public static String getValorExibido() {
        return valorExibido;
    }

    public static void setValorExibido(String valorExibido) {
        CalcLogic.valorExibido = valorExibido;
    }

    public static String getValorExibido2() {
        return valorExibido2;
    }

    public static void setValorExibido2(String valorExibido2) {
        CalcLogic.valorExibido2 = valorExibido2;
    }
}