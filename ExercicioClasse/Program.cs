using System;

namespace ExercicioClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa name, idad, name2,idad2;
            name = new Pessoa();
            idad = new Pessoa();
            name2 = new Pessoa();
            idad2 = new Pessoa();

   
            Console.WriteLine("Digite dados do primeiro nome");
            name.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            idad.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite dados da 2 pessoa");
            name2.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            idad2.idade = int.Parse(Console.ReadLine());

            if(idad.idade > idad2.idade)
            {
                Console.WriteLine("A pessoa mais velha é" + name.nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é" + name2.nome);
            }

           
            
        }
    }
}
