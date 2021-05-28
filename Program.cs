using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, largura;
            bool alturadig, larguradig;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-----Quadrado preenchido-----");
            Console.ResetColor();

            Console.Write("Digite um numero para ser a altura do quadrado (0 A 10): ");
            alturadig = Int32.TryParse(Console.ReadLine(), out altura);

            Console.WriteLine();

            Console.Write("Digite um numero para se a largura do quadrado (0 A 10): ");
            larguradig = Int32.TryParse(Console.ReadLine(), out largura);

            Console.WriteLine();

            for (int linha = 1; linha <= altura; linha++)
            {
                Console.WriteLine();
                
                for (int coluna = 1; coluna <= largura; coluna++)
                {
                    Console.Write("* ");
                }
            }
            
        }
    }
}
