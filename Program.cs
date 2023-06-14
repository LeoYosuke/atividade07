using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Double deposit;
            Console.WriteLine("Bem-Vindo ao Café-Bar!");
            Console.WriteLine("Escolha uma das opções");
            Console.WriteLine("1 - Café R$ 3,00");
            Console.WriteLine("2 - Capuccino R$ 4,50");
            Console.WriteLine("3 - Mocaccino R$ 6,00");
            Console.WriteLine("4 - Agua quente R$ 1,00");
            Console.WriteLine();
            opcao = Int32.Parse(Console.ReadLine());
            if(opcao == 1) 
            {
                Console.WriteLine("DEPOSITE R$ 3,00");
                deposit = Double.Parse(Console.ReadLine());
                if (deposit >= 3.00) 
                {
                    Console.WriteLine("pedido feito");
                    Console.WriteLine("\n");
                    Main(null);
                    return;
                }
                else 
                {
                    Console.WriteLine("DINHEIRO INSUFICIENTE...");
                    Main(null);
                    return;
                }
            }
            if(opcao == 2) 
            {
                Console.WriteLine("DEPOSITE R$ 4,50");
                deposit = Double.Parse(Console.ReadLine());
                if (deposit >= 4.50) 
                {
                    Console.WriteLine("PEDIDO FEITO");
                    Console.WriteLine("\n");

                    Main(null);
                    return;
                }
                else
                {
                    Console.WriteLine("DINHEIRO INSUFICIENTE...");
                    Main(null);
                    return;
                }

            }
            if(opcao == 3) 
            {
                Console.WriteLine("DEPOSITE R$ 6,00");
                deposit = Double.Parse(Console.ReadLine());
                if (deposit >= 6.00) 
                {
                    Console.WriteLine("PEDIDO FEITO");
                    Console.WriteLine("\n");

                    Main(null);
                    return;
                }
                else
                {
                    Console.WriteLine("DINHEIRO INSUFICIENTE...");
                    Main(null);
                    return;
                }
            }
            if(opcao == 4) 
            {
                Console.WriteLine("DEPOSITE R$ 1,00");
                deposit = Double.Parse(Console.ReadLine());
                if (deposit >= 1.00) 
                {
                    Console.WriteLine("PEDIDO FEITO");
                    Console.WriteLine("\n");

                    Main(null);
                    return;
                }
                else
                {
                    Console.WriteLine("DINHEIRO INSUFICIENTE...");
                    Main(null);
                    return;
                }
            }
            Console.ReadKey();
        }
    }
}
