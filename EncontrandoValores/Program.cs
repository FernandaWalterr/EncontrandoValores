namespace EncontrandoValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1 };

            // Encontra o Maior Valor da sequência
            int maior = EncontraMaiorValor(numeros);
            Console.WriteLine("Maior valor: " + maior);

            // Encontra o Menor Valor da sequência
            int menor = EncontraMenorValor(numeros);
            Console.WriteLine("Menor valor: " + menor);

            // Encontra o Valor Médio da sequência
            double media = EncontraValorMedio(numeros);
            Console.WriteLine("Valor médio: " + media);

            // Encontra os 3 maiores valores da sequência
            int[] tresMaiores = EncontraTresMaioresValores(numeros);
            Console.WriteLine("Os 3 maiores valores: " + string.Join(", ", tresMaiores));

            // Encontra os valores negativos da sequência
            int[] negativos = EncontraValoresNegativos(numeros);
            Console.WriteLine("Valores negativos: " + string.Join(", ", negativos));

            // Mostra na Tela os valores da sequência
            Console.WriteLine("Valores da sequência: " + string.Join(", ", numeros));

            // Remove um item da sequência
            int itemRemovido = RemoveItem(numeros, 5);
            Console.WriteLine("Item removido: " + itemRemovido);
            Console.WriteLine("Valores da sequência após remoção: " + string.Join(", ", numeros));
        }

        static int EncontraMaiorValor(int[] numeros)
        {
            int maior = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                }
            }
            return maior;
        }

        static int EncontraMenorValor(int[] numeros)
        {
            int menor = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            return menor;
        }

        static double EncontraValorMedio(int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            double media = (double)soma / numeros.Length;
            return media;
        }

        static int[] EncontraTresMaioresValores(int[] numeros)
        {
            int[] tresMaiores = new int[3];
            Array.Sort(numeros);
            for (int i = numeros.Length - 1, j = 0; i >= 0 && j < 3; i--, j++)
            {
                tresMaiores[j] = numeros[i];
            }
            return tresMaiores;
        }

        static int[] EncontraValoresNegativos(int[] numeros)
        {
            int[] negativos = Array.FindAll(numeros, num => num < 0);
            return negativos;
        }

        static int RemoveItem(int[] numeros, int indice)
        {
            int itemRemovido = numeros[indice];
            for (int i = indice; i < numeros.Length)
            {

            }
        }
    }
}