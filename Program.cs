using System;

namespace cs_1._6_CalculaExpressao
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, D, F, R;

            // {Leitura das variáveis de entrada}
            Console.Write("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            C = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de D: ");
            D = double.Parse(Console.ReadLine());

            //valida o valor de F (não pode ser zero)
            do
            {
                Console.Write("Digite o valor de F: ");
                F = double.Parse(Console.ReadLine());
                Console.WriteLine(); //salta linha
            } while (F == 0); //fim da validação da variável F

            //{Faz os cálculos}

            R = A - B * (C + Math.Pow(D, 2)) / F;
            Console.WriteLine(); //salta linha
            
            // {Apresenta o resultado}
            Console.WriteLine($"{A} - {B} * {C} + {D}² / {F} = {R}");
        }
    }
}
