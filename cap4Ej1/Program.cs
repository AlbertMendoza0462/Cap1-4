// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite el numero");
int num = leerEntero();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(num + " * " + i + ": " + (num * i));
}

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