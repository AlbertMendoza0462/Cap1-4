// See https://aka.ms/new-console-template for more information
Console.Write("Cantidad de lados del poligono: ");
int cantidadLados = leerEntero();

Console.Write("Longitud de uno de los lados del poligono: ");
double longitudLados = leerDouble();

System.Console.Write("El perimetro es: " + (cantidadLados * longitudLados));

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
