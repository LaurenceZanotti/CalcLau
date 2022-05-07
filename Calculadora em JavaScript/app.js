/* Código da calculadora em JavaScript

Ao clicar no número, escrever value1 e exibir no visor.

Ao clicar no operador, operationId recebe operação a ser realizada.
O value ID será o segundo campo e exibirá no visor o value1 e o operador.

Clicar no número novamente escreverá sobre value2 e exibirá no visor. Ex: 5 + 5.

Clicar em igual dará o resultado da operação baseado na operação escolhida
que será salvo na variável operationId.

*/

var result,
value1 = "",
value2 = "",
operationId = "",
buttonId = "",
valueId = 1;

function operationResult() { // Sinal de igual
  valueId = 3; // Para resetar a calculadora caso eu faça outro cálculo (ver function numberButton)

  //Converter texto para número
  value1 = Number(value1);
  value2 = Number(value2);

  // Calcular de acordo com a operação selecionada
  switch (operationId) { // Calcular
    case "÷":
      result = value1 / value2;
      break;
    case "x":
      result = value1 * value2;
      break;
    case "+":
      result = value1 + value2;
      break;
    case "-":
      result = value1 - value2;
      break;
  }

  //Exibir resultado
  document.getElementById("resultado_da_calculadora").innerHTML = "<span class='texto_da_conta' id='resultado_da_calculadora'>" + result + "</span>";

  // Zerar os valores para próximo cálculo

}

function numberButton(buttonId) { // Números
  if (valueId == 1)  {
    value1 = String(value1) + buttonId;
    document.getElementById("resultado_da_calculadora").innerHTML = "<span class='texto_da_conta' id='resultado_da_calculadora'>" + value1 + "</span>";
  } else if (valueId == 2) {
    value2 = String(value2) + buttonId;
    document.getElementById("resultado_da_calculadora").innerHTML = "<span class='texto_da_conta' id='resultado_da_calculadora'>" + value1 + " " + operationId + " " + value2 + "</span>";
  } else if (valueId == 3) {
    document.getElementById("historico_da_calculadora").innerHTML = "<span class='texto_da_conta' id='historico_da_calculadora'>" + value1 + " " + operationId + " " + value2 + " = " + result + "</span>";
    value1 = String(value1) + buttonId;
    document.getElementById("resultado_da_calculadora").innerHTML = "<span class='texto_da_conta' id='resultado_da_calculadora'></span>";
    value1 = "";
    value2 = "";
    valueId = 1;
  }
}

function operationButton(buttonId) { // Operadores
  // if (valueId == 3) {
  //   numberButton();
  // }
  operationId = buttonId;
  valueId = 2;
  document.getElementById("resultado_da_calculadora").innerHTML = "<span class='texto_da_conta' id='resultado_da_calculadora'>" + value1 + " " + operationId + "</span>";
}

function clearCalc(){
  value1 = "";
  value2 = "";
  //value2 = "";
  operationId = "";
  buttonId = "";
  valueId = 1;
  document.getElementById("historico_da_calculadora").innerHTML = "<span class='texto_da_conta' id='historico_da_calculadora'></span>";
  document.getElementById("resultado_da_calculadora").innerHTML = "<span class='texto_da_conta' id='resultado_da_calculadora'></span>";

}
// Console Teste

console.log("result: "+result);
console.log("value1: "+value1);
console.log("value2: "+value2);
console.log("valueId: "+valueId);
console.log("buttonId: "+buttonId);
console.log("operationId: "+operationId);
