using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); // Métodos
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("    CALCULADORA 1.0");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("========================");
            Console.WriteLine("Selecione uma opção: ");
            short escolha = short.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 1: Console.Clear(); Soma(); break;
                case 2: Console.Clear(); Subtracao(); break;
                case 3: Console.Clear(); Divisao(); break;
                case 4: Console.Clear(); Multiplicacao(); break;
                case 5: Console.Clear(); Console.WriteLine("Obrigado por usar minha calculadora!"); System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado é {resultado}");

            Console.ReadKey();
            Menu();
        }
    
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.ReadKey();  
            Menu();           
        }

        static void Multiplicacao()
        {   
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            
            Console.ReadKey();
            Menu();
        }
    }       
}
