using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_for_vetor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            int tamanhoPP = 0;
            int tamanhoP = 0;
            int tamanhoM = 0;
            int tamanhoG = 0;
            int tamanhoGG = 0;
            int tamanhoXG = 0;
            int tamanhoXGG = 0;
        
            Console.WriteLine("Digite a quantidade de camisas que queres cadastrar: ");
            int quantidadeCamisas = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            string[] tamanhos = new string[quantidadeCamisas];

            for (int i = 0; i < tamanhos.Length; i++)
            {
                Console.WriteLine("Tamanho da camisa: ");
                tamanhos[i] = Console.ReadLine();
            }

            for (int i = 0; i < tamanhos.Length; i++)
            {
                if (tamanhos[i] == "pp")
                {
                    tamanhoPP = tamanhoPP + 1;
                }
                else if (tamanhos[i] == "p")
                {
                    tamanhoP = tamanhoP + 1;
                }
                else if (tamanhos[i] == "m")
                {
                    tamanhoM = tamanhoM + 1;
                }
                else if (tamanhos[i] == "g")
                {
                    tamanhoG = tamanhoG + 1;
                }
                else if (tamanhos[i] == "gg")
                {
                    tamanhoGG = tamanhoGG + 1;
                }
                else if (tamanhos[i] == "xg")
                {
                    tamanhoXG = tamanhoXG + 1;
                }
                else if (tamanhos[i] == "xgg")
                {
                    tamanhoXGG = tamanhoXGG + 1;
                }

            }
            Console.WriteLine("Quantidade PP: " + tamanhoPP);
            Console.WriteLine("Quantidade P: " + tamanhoP);
            Console.WriteLine("Quantidade M: " + tamanhoM);
            Console.WriteLine("Quantidade G: " + tamanhoG);
            Console.WriteLine("Quantidade GG: " + tamanhoGG);
            Console.WriteLine("Quantidade XG: " + tamanhoXG);
            Console.WriteLine("Quantidade XGG: " + tamanhoXGG);

        }
    }
}
