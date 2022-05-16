// See https://aka.ms/new-console-template for more information
Console.WriteLine("Elija un poligono:");
Console.WriteLine("\n3. TRIANGULO\n4. CUADRILATERO\n5. PENTAGONO\n6. HEXAGONO\n7. HEPTAGONO\n8. OCTÓGONO\n9. ENEAGONO\n10. DECAGONO\n11. ENDECAGONO\n12. DODECAGONO");
int cantidadLados = leerEntero();

Console.Write("Longitud de uno de los lados del poligono: ");
double longitudLados = leerDouble();

Console.Write("Apotema del poligono: ");
double apotema = leerDouble();

System.Console.Write("El perimetro es: " + (cantidadLados * longitudLados));

double area = cantidadLados * ((apotema * longitudLados) / 2);
System.Console.WriteLine("\nEl area es: " + area);

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
