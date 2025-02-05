namespace Calculadora
{
    class Operacoes
    {
        public static void RealizarAdicao( 
        decimal var1, 
        decimal var2
        )
        {
          Console.WriteLine($"A soma dos valores {var1} e {var2} é {var1+var2}");
        }
        public static void RealizarSubtracao( 
        decimal var1, 
        decimal var2
        )
        {
          Console.WriteLine($"A soma dos valores {var1} e {var2} é {var1-var2}");
        }
         public static void RealizarMultiplicacao( 
        decimal var1, 
        decimal var2
        )
        {
          Console.WriteLine($"A soma dos valores {var1} e {var2} é { var1*var2}");
        }
         public static void RealizarDivisao( 
        decimal var1, 
        decimal var2
        )
        {
          Console.WriteLine($"A soma dos valores {var1} e {var2} é {var1/var2}");
        }
    }

}