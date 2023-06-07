using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Leitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nome2;

            Console.WriteLine("Digite o seu PRIMEIRO nome: ");
            // comando que permite escrever quando esta executando o codigo
            nome = Console.ReadLine();
            Console.WriteLine("Agora digite seu SEGUNDO nome");
            nome2 = Console.ReadLine();
            Console.WriteLine($"Seja bem-vindo {nome}{nome2}");
            Console.Read();
        }

        void Atividade()
        {
            float lanche = 8.00f;
            float salsicha = 1.50f;
            float hamburger = 2.00f;
            float requeijao = 1.50f;
            float bacon = 2.00f;
            float valorlanche1 = 13.5f;
            float valorlanche2 = 12.5f;
            float valorlanche3 = 15.0f;

            Console.WriteLine("Bem-vindo ao catálogo digital do Conradito Lanches");
            Console.WriteLine("Confira os valores;");
            Console.WriteLine($"X-Tudo; hamburger, bacon e salsicha - R$ {lanche + bacon + salsicha}");
            Console.WriteLine($"Cachorro-quente cremoso:2 salsichas e requeijao - R$ {lanche + 2 * salsicha + requeijao}");
            Console.WriteLine($"A moda da casa: salsicha, hamburger,requeijao e bacon - R$ {salsicha + hamburger + requeijao + bacon}");
            Console.WriteLine("\n \n");
            Console.WriteLine($"Combo:X-Tudo + Cachorro-quente cremoso + A moda da casa - R$ {valorlanche1 + valorlanche2 + valorlanche3}");
            Console.ReadKey();
        }



    }
}
