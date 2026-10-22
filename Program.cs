using System.Collections.Generic;


//Criando lista de produtos dinamica (começando vazia, e vai colocando informções conforme o usuário digita)
List<double> precosProdutos = new List<double>();

Console.WriteLine("=== MERCADINHO: REGISTRO DE COMPRAS ===");

double precosDigitado = -1;

//laço de repitição a interação de valores pelo usuário
while (precosDigitado != 0)
{
    Console.WriteLine("PAra finalizar digite \"0\"");
    Console.WriteLine("Digite o Preco do Produto:");
    precosDigitado = double.Parse(Console.ReadLine()!);

    if(precosDigitado > 0)
    {
        //adiciona o valor digitado a lista precosProdutos com .ADD()
        precosProdutos.Add(precosDigitado);
    }
}

double valorTotal = CalcularTotalCompra(precosProdutos);

Console.WriteLine("=============================================");
Console.WriteLine($"Quantidade De Itens Comprados: {precosProdutos}");
Console.WriteLine($"Valor Total a pagar: R${valorTotal:F2}");
Console.WriteLine("=============================================");


//funcao que recebe a lista com os precos por parãmero, soma-os e RETORNA o total.
static double CalcularTotalCompra(List<double> listaPrecos)
{
    double soma = 0;

    //o foreach percorre cada item da lista automaticamente (foreach -forma simplicada do for)
    foreach(double preco in listaPrecos)
    {
        soma += preco;
    }

    return soma;
}
