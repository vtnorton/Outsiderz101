using System;

namespace Outsiderz02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            Console.WriteLine("Infome o valor de x");
            x = int.Parse(Console.ReadLine());
            
            int y;
            Console.WriteLine("Infome o valor de y");
            y = int.Parse(Console.ReadLine());

            int soma = x + y;
            Console.WriteLine("O resultado da soma é " + soma);*/

            string nome;
            string pergunta = "Qual o seu nome? ";
            Console.Write(pergunta);
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é " + nome);

            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            
            /*if(idade > 18){
                Console.WriteLine("Tem mais de 18 anos");
            }else if(idade == 18){
                Console.WriteLine("Tem 18 anos");
            }else{
                Console.WriteLine("Tem menos de 18 anos");
            }*/

            if((idade > 18) || (nome == "Nome")){
                Console.WriteLine("Outsiderz");
            }
        }
    }
}
