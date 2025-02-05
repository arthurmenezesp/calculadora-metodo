using Calculadora;
using Jesus;

Console.WriteLine ("Insira o primeiro valor");
if(!int.TryParse(Console.ReadLine(), out decimal valor1)){
    Console.WriteLine("Insira um valor válido")

}
if(!int.TryParse(Console.ReadLine(), out decimal valor2)){
    Console.WriteLine("Insira um valor válido")

} 

Operacoes.RealizarAdiçao(2,5);
Operacoes.RealizarAdiçao(4,2);
Operacoes.RealizarAdiçao(7,1);
Operacoes.RealizarAdiçao(0,5);

