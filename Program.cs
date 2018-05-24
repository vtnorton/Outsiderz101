using System;

namespace _01___Programação_C____Parte_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o sabor da sua pizza?");
            Console.WriteLine(" 1 - Bacon");
            Console.WriteLine(" 2 - Portuguesa");
            Console.WriteLine(" 3 - Palmito");
            Console.WriteLine(" 4 - 4 Queijos");

            int sabor;
            sabor = int.Parse(Console.ReadLine());

            switch(sabor){
                case 1:
                    Console.WriteLine("Você escolheu o sabor Bacon");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu o sabor Portuguesa");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu o sabor Palmito");
                    break;
                case 4:
                    Console.WriteLine("Você escolheu o sabor 4 Queijos");
                    break;
                default:
                    Console.WriteLine("Você não escolheu nenhuma opção.");
                    break;
            }


            for(int i = 0; i < 10; i++){
                Console.WriteLine("Loop de número " + i);
            }
        }
    }
}
