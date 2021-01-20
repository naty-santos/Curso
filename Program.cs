using System;
using System.Globalization;

namespace curso_
{
    class Program
    {
        static void Main(string[] args)
        {
                Produto p = new Produto();



            Console.WriteLine("Entre os dados do produto:");
             Console.WriteLine("NOME: ");
            p.Nome = Console.ReadLine();
            Console.Write("PREÇO: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("QUANTIDADE NO ESTOQUE: ");
        p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("DADOS DO PRODUTO: " + p);

            Console.WriteLine();
            Console.WriteLine("DIGITE O NÚMERO DE PRODUTOS A SEREM ADICIONADOS NO ESTOQUE: ");
            int qte =  int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("DADOS ATUALIZADOS: " + p);
            Console.WriteLine("Digoite o número de produtos a serem removidos do estoque: ");
            qte= int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("DADOS ATUALIZADOS: " + p);
        }
    }
}
