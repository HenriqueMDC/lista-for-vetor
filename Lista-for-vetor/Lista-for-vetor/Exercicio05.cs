using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_for_vetor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.WriteLine("Digite a quantidade de jogos que queres cadastrar: ");
            int quantidadeJogos = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int[] quantidadeEstoque = new int[quantidadeJogos];
            string[] nomeJogo = new string[quantidadeJogos];

            for (int i = 0; i < nomeJogo.Length; i++)
            {
                Console.WriteLine("Nome do Jogo: ");
                nomeJogo[i] = Console.ReadLine();
                Console.WriteLine("QUantidade do jogo: ");
                quantidadeEstoque[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 0; i < nomeJogo.Length; i++)
            {
                Console.WriteLine(nomeJogo[i] +  " tem " + quantidadeEstoque[i] + " guardados");
            }


        }
    }
}
