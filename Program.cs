using Calculadora;

class Program
{
    static void Main()
    {
        decimal valor1, valor2;
        int resposta;

        
        while (true)
        {
            Console.Write("\nInsira o primeiro valor: ");
            if (decimal.TryParse(Console.ReadLine(), out valor1))
            {
                break; 
            }
            else
            {
                Console.WriteLine("Insira um valor válido.");
            }
        }

       
        while (true)
        {
            Console.Write("\nInsira o segundo valor: ");
            if (decimal.TryParse(Console.ReadLine(), out valor2))
            {
                break; 
            }
            else
            {
                Console.WriteLine("Insira um valor válido.");
            }
        }

       
        Console.WriteLine("\n1- Adição");
        Console.WriteLine("2- Subtração");
        Console.WriteLine("3- Multiplicação");
        Console.WriteLine("4- Divisão");
        Console.WriteLine("Qual operação você deseja?  ");
        
       
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out resposta) && resposta >= 1 && resposta <= 4)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Insira uma resposta válida entre 1 e 4.");
            }
        }

    
        switch (resposta)
        {
            case 1:
                Operacoes.RealizarAdicao(valor1, valor2);
                break;

            case 2:
                Operacoes.RealizarSubtracao(valor1, valor2);
                break;

            case 3:
                Operacoes.RealizarMultiplicacao(valor1, valor2);
                break;

            case 4:
                Operacoes.RealizarDivisao(valor1, valor2);
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
