float n1, n2;

Console.WriteLine("Digite o primeiro número para a calculadora realizar as operações");
n1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o primeiro número para a calculadora realizar as operações");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("A soma dos números digitados é: " + (n1 + n2));
Console.WriteLine("A subtração dos números digitados é: " + (n1 - n2));
Console.WriteLine("A multiplicação dos números digitados é: " + (n1 * n2));

if (n2 == 0)
{
    Console.WriteLine("Impossível dividir por zero!");

}
else
{
    Console.WriteLine("A divisão dos números é: " + (n1 / n2));
}

Console.ReadKey();