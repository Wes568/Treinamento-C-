﻿using System;

namespace Classe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto... ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            produto.MostraProduto();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(quantidade);

            produto.MostraProduto();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(quantidade);

            produto.MostraProduto();


        }
    }
}