// See https://aka.ms/new-console-template for more information
Console.Write("Digite el numero del dia de la semana: ");

switch (leerEntero())
{
    case 1: Console.WriteLine("Lunes"); break;
    case 2: Console.WriteLine("Martes"); break;
    case 3: Console.WriteLine("Miercoles"); break;
    case 4: Console.WriteLine("Jueves"); break;
    case 5: Console.WriteLine("Viernes"); break;
    case 6: Console.WriteLine("Sabado"); break;
    case 7: Console.WriteLine("Domingo"); break;
}


int leerEntero() {
    int num;
    while (true)
    {
        try
        {
            num = Int32.Parse(Console.ReadLine());
            if (num < 1 || num > 7)
            {
                throw new Exception();
            }
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