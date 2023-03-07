double n1, n2;
int continua = 1;

Console.WriteLine("Informe o primeiro número a ser calculado: ");
n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número a ser calculado: ");
n2 = double.Parse(Console.ReadLine());

int Menu()
{
    Console.Clear();
    Console.WriteLine("1- Somar");
    Console.WriteLine("2- Subtrair");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Sair");
    Console.WriteLine("Escolha uma opção: ");
    return int.Parse(Console.ReadLine());
}


double Soma()
{
    Console.WriteLine("A soma dos números é " + (n1 + n2));
    Console.WriteLine("Digite qualquer tecla");
    return double.Parse(Console.ReadLine());
}

double Subtracao()
{
    Console.WriteLine("A soma dos números é  " + (n1 - n2));
    Console.WriteLine("Digite outro numero para realizar a calculadora realizar a operação");
    return double.Parse(Console.ReadLine());
}
double Multiplicacao()
{
    Console.WriteLine("A multiplicação dos números é: " + (n1 * n2));
    Console.WriteLine("Digite outro numero para realizar a calculadora realizar a operação");
    return double.Parse(Console.ReadLine());
}

double Divisao()
{
    Console.WriteLine("A divisão dos números é: " + (n1 / n2));
    Console.WriteLine("Digite outro numero para realizar a calculadora realizar a operação");
    return double.Parse(Console.ReadLine());
}




while (continua == 1)
{

    switch (Menu())
    {

        default:
            Console.WriteLine("Opção Inválida");
            break;

        case 1:
            Soma();
            break;

        case 2:
            Subtracao();
            break;
        case 3:
            Multiplicacao();
            break;
        case 4:
            Divisao();
            break;
        case 5:
            Console.WriteLine("Obrigada por usar a calculadora. Até logo!");
            continua = 0;
            break;

    }

}