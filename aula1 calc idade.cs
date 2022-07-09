using System;

namespace myproject{

    class Program{

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Seja bem vindo(a), " + nome);
            Console.WriteLine("Você nasceu em..." + (2022 - idade));
            if(idade < 18){
                Console.WriteLine("Você é menor de idade");

            } else {
                Console.WriteLine("Você é maior de idade");
            }
        }
    }
}
