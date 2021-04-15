using System;

namespace NegativoCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("--- CASO ---");

            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case < 0 :
                Console.WriteLine("NEGATIVO");
                break;

                case > 0 :
                Console.WriteLine("POSITIVO");
                break;

                case  0 :
                Console.WriteLine("ZERO");
                break;

            }
        Console.WriteLine("Obrigado e volte sempre");
        }
    }
}
