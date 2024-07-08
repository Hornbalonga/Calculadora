using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i == 0)
            {
                menu();
                int nMenu = int.Parse(Console.ReadLine());
                i = Operacao(nMenu);
                Console.Clear();
            }
            Console.Read();
        }





        static void menu()
        {
            Console.WriteLine("Digite qual opção desejada:");
            Console.WriteLine("1- Adição\n2- Subtração\n3- Multiplicação\n4- Divisão\n0- Sair");
        }
        static int Operacao(int numero)
        {
            int numero1, numero2;
            string simNao, grande;

                switch (numero)
                {

                    case 0:

                       return 1;

                    case 1:
                        Console.WriteLine("Digite um número:");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        numero2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"A soma de {numero1} + {numero2} é {numero1 + numero2}.");
                        break;

                    case 2:
                        Console.WriteLine("Digite um número:");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        numero2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"A subtração de {numero1} - {numero2} é {numero1 - numero2}.");
                        break;

                    case 3:
                        Console.WriteLine("Digite um número:");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        numero2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"A multiplicação de {numero1} * {numero2} é {numero1 * numero2}.");
                        break;

                    case 4:
                        Console.WriteLine("Digite um número:");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite outro número:");
                        numero2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"A divisão de {numero1} / {numero2} é {numero1 / numero2}.");
                        break;

                default:
                        Console.WriteLine("Opção não econtrada");
                        break;
                }

                Console.WriteLine("Deseja fazer novamente? S/N");
                simNao = Console.ReadLine();
                grande = simNao.ToUpper();
                if (grande == "S" || grande == "SIM")
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
        }
    }
}
