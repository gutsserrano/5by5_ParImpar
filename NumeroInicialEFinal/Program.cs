// Faça um programa que leia um numero inicial e um numero final, mostrando entre eles, quais sao os valores pares e impares

int inicial = 0, final = 0;
int aux;

Console.WriteLine("Digite o número inicial: ");
inicial = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número final: ");
final = int.Parse(Console.ReadLine());

Console.WriteLine("\nPares: ");
aux = inicial;
aux++;
while (aux < final){
    
    if (aux % 2 == 0)
    {
        Console.WriteLine(aux);
    }
    aux++;
}

Console.WriteLine("\nImpares: ");
aux = inicial;
aux++;
while (aux < final)
{

    if (aux % 2 != 0)
    {
        Console.WriteLine(aux);
    }
    aux++;
}

Console.WriteLine("\nDigite qualquer tecla para sair...");
Console.ReadKey();