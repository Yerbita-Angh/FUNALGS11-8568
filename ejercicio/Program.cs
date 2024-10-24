Random n = new Random();
Console.WriteLine("Ingrese la cantidad que desea: ");
int num = int.Parse(Console.ReadLine());
int[] numeros = new int[num];
Random ran = new Random();

int cantP = 0, cantI = 0;

for (int x = 0; x < num; x++)
{
    numeros[x] = n.Next(50, 90);
    if (numeros[x] % 2 == 0)
    {
        cantP++;
    }

    else if (numeros[x] % 2 != 0)
    {
        cantI++;
    }

}
Console.WriteLine("¿Te gustan pares o impares?");
string tipo = Console.ReadLine();

string all = string.Join(" ,", numeros);
Console.WriteLine($"Los numeros son {all} ");


if (tipo == "impares")
{
    Console.WriteLine("La cantidad de impares son: " + cantI);
}
else if (tipo == "pares")
{
    Console.WriteLine("La cantidad de pares son: " + cantP);
}
Console.WriteLine("hello");
Console.WriteLine("hola");