double n1, n2;
int opcao = 0;

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


void Soma()
{
    Console.WriteLine("A soma dos números é " + (n1 + n2));
    Console.ReadLine();
}

void Subtracao()
{
    Console.WriteLine("A soma dos números é  " + (n1 - n2));
    Console.ReadLine();
}
void Multiplicacao()
{
    Console.WriteLine("A multiplicação dos números é: " + (n1 * n2));
    Console.ReadLine();
}

void Divisao()
{
    Console.WriteLine("A divisão dos números é: " + (n1 / n2));
    Console.ReadLine();
}



while (opcao != 5)
{
    opcao = Menu();

    switch (opcao)
    {

        default:
            Console.WriteLine("Opção Inválida");
            Console.ReadLine();
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
            Console.ReadLine();
            break;

    }

}