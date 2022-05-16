// See https://aka.ms/new-console-template for more information
Console.Write("Cantidad de grados centigrados: ");
double cantidadGrados = leerDouble();

System.Console.Write("grados Fahrenheit: " + (((cantidadGrados * 9)/5) + 32));


double leerDouble() {
    double num;
    while (true)
    {
        try
        {
            num = Double.Parse(Console.ReadLine());
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