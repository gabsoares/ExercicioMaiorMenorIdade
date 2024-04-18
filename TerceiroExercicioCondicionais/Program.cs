Console.Write("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade > 0)
{
    if (idade >= 18)
    {
        Console.WriteLine("Maior de idade");
    }
    else
    {
        Console.WriteLine("Menor de idade");
    }
}
else
{
    Console.WriteLine("Idade invalida");
}
