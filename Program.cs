using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício06
{
    class Program
    {
        static void Main(string[] args)
        {
            int opção;
            string nome1;
            string senha1;
            string nome2 = "Stella";
            string senha2= "stella123";
            


            Console.WriteLine("Bem-vindo ao Conradito's Bank");
            Console.WriteLine("Opções:");
            Console.WriteLine("1-Cadastrar");
            Console.WriteLine("2- Login");
            Console.WriteLine("\n");

            Console.WriteLine("Digite uma opção");
            opção = Int32.Parse(Console.ReadLine());

            if (opção == 1)
            {
                Console.WriteLine("Digite o nome do novo usúario:");
                nome1 = Console.ReadLine();
                Console.WriteLine("Digite a senha do novo usuário");
                senha1 = Console.ReadLine();
                Console.WriteLine("Usuário cadastrado com sucesso!");

            }
 
                Console.WriteLine("---- Login de usuário");
                Console.WriteLine("Para continuar, digite o usuário");
                nome2 = Console.ReadLine();

            if (nome2 != "Stella")
            {
                Console.WriteLine("Este usuário não existe");
                Main(null);
            }

                Console.WriteLine("Digite a senha:");
                senha2 = Console.ReadLine();

           
            if (senha2 != "stella123")
            {
                Console.WriteLine("Senha incorreta");

            }



            









            Console.ReadKey();
            Main(null);








        }
    }
}
