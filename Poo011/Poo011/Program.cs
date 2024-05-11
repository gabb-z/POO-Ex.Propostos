using System;
using System.Globalization;
using System.Collections.Generic;
using Poo011.Entities;
using Poo011.Entities.Enums;

//Entrada de Dados - Dados do Cliente
Console.WriteLine("Digite os dados do cliente: ");
Console.Write("Nome: ");
string nomeCliente = Console.ReadLine();
Console.Write("Email: ");
string emailCliente = Console.ReadLine();
Console.Write("Data de nascimento: ");
DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

//Entrada de Dados - Dados do Pedido
Console.WriteLine("\nDigite os dados do pedido: ");
DateTime dataPedido = DateTime.Now;
Console.Write("Status: ");
StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

//Instância de Obj. - Cliente & Pedido
Cliente cliente = new Cliente(nomeCliente, emailCliente, dataNascimento);
Pedido pedido = new Pedido(dataPedido, status, cliente);

Console.Write("\nQuantos itens deseja adicionar nesse pedido: ");
int nItens = int.Parse(Console.ReadLine());
for (int i = 1; i <= nItens; i++)
{
    Console.WriteLine($"\nDigite os dados do #{i} produto: ");
    Console.Write("Nome do produto: ");
    string prodNome = Console.ReadLine();
    Console.Write("Preço do produto: R$ ");
    double prodPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    //Instância de Obj. - Produto
    Produto produto = new Produto(prodNome, prodPreco);

    Console.Write("Quantidade: ");
    int prodQtde = int.Parse(Console.ReadLine());

    //Instância de Obj. - Itens do Pedido
    ItemDoPedido itensPedido = new ItemDoPedido(prodQtde, prodPreco, produto);
    pedido.AddItem(itensPedido);
}

//Saída de Dados - Dados do Cliente & Pedido
Console.WriteLine("\nDados Gerais do Pedido: ");
Console.WriteLine(pedido);