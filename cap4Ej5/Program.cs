// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cuantas personas seran?");
int cantPersonas = leerEntero();

List<int> personas = new List<int>();


Console.WriteLine("Edad de la Persona 1: ");
int edad = leerEntero();

int edadMayor = edad;
int edadMenor = edad;

for (int i = 2; i <= cantPersonas; i++)
{
    Console.Write("\nEdad de la Persona " + i + ": ");
    edad = leerEntero();
    if (edad > edadMayor)
    {
        edadMayor = edad;
    }
    if (edad < edadMenor)
    {
        edadMenor = edad;
    }
}

Console.Write("La edad mayor es: " + edadMayor);
Console.Write("\nLa edad menor es: " + edadMenor);

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