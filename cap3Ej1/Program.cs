// See https://aka.ms/new-console-template for more information
Console.Write("Digite el numero: ");

Console.WriteLine((leerEntero() % 2 == 0) ? "Es par" : "Es impar");

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