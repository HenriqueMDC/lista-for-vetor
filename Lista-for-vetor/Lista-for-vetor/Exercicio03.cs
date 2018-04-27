using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_for_vetor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.WriteLine("Digite a quantida de produtos que queres cadastrar: ");
            int quantidadeRegistro = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            double[] valores = new double[quantidadeRegistro];

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Valor dos produtos: ");
                valores[i] = Convert.ToDouble(Console.ReadLine());

                Console.Clear();
            }

            double somaValores = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                somaValores = valores[i] + somaValores;
            }

            Console.WriteLine("Valor total : " + somaValores);
        }
    }
}
