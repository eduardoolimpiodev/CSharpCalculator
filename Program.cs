using System;
using System.Linq.Expressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que seja fazer ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potencialização");
            Console.WriteLine("6 - Área do Quadrado");
            Console.WriteLine("7 - Sair da aplicação");
            Console.WriteLine("----------------------");
            Console.WriteLine("Selecione uma opção!");
            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Potencializacao(); break;
                case 6: AreaQuadado(); break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

            Console.ReadKey();
        }

        static void Soma()
        {
            // limpa a tela.
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");

            // O Console ReaLine sempre retorna uma string, por isso usar o Parse, para converter a string em um float.
            float v1 = float.Parse(Console.ReadLine());
            

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());            ;
            

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}.");
            
            
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear ();

            Console.WriteLine("Primeiro valor: ");

            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}.");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}.");
            Console.ReadKey();

        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");

            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}.");

            Console.ReadKey();

        }

        static void Potencializacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");

            var v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            var resultado = Math.Pow(v1, v2);
            Console.WriteLine($"O resultado da Potencialização é {resultado}.");

            Console.ReadKey();

        }

        static void AreaQuadado()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");

            var v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            var resultado = v1 * v2;
            Console.WriteLine($"O resultado da Potencialização é {resultado} m².");

            Console.ReadKey();
        }

    }
}