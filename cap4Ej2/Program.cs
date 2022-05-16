// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite un numero");
int num = leerEntero();

Console.WriteLine("Digite el exponente");
int num2 = leerEntero();

int result = 1;
for (int i = 0; i < num2; i++)
{
    result *= num;
}

Console.Write("El resusltado es: " + result);

int leerEntero() {
    int num;
    while (true)
    {
        try
        {
            num = Int32.Parse(Console.ReadLine());
            break;
        }
        catch (System.Exception)
        {
            System.Console.Write("Dato incorrecto, digite de nuevo: ");
            continue;
        }
    }
    return num;
}