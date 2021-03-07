using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioSysQuestao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Questao02();
        }

        private static void Questao02()
        {
            List<int> input = new List<int>();
            int compra = 0;
            int venda = 0;

            Console.WriteLine("Digite o tamanho do array: ");
            var tamanhoArray = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os valores do array (digite o valor e aperte enter): ");

            CriaListaInt(tamanhoArray, input);

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == input.Min())
                {
                    int diaCompra = i + 1;
                    compra = input[i];
                    i = diaCompra;
                }
                else if (i + 1 < tamanhoArray)
                {
                    if (input[i] > input[i + 1])
                    {
                        if (compra > 0)
                        {
                            venda = input[i];
                        }
                    }
                }

            }
            if (venda - compra > 0)
                Console.Write($"{venda - compra}");
            else
                Console.Write($"0");
        }

        private static void CriaListaInt(int tamanhoArray, List<int> input)
        {
            for (int i = 0; i < tamanhoArray; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                input.Add(numero);
            }
        }
    }
}
