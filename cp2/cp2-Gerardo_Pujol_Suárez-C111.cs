
public class Program
{
    public static void Main(string[] args)
    {
        //Di hola
        Console.WriteLine("hola");

        int Max = int.MaxValue;
        int Min = int.MinValue;
        string A = Convert.ToString(Max);
        string B = Convert.ToString(Min);
        Console.WriteLine($"{A} {B}");

        double a = Math.PI;
        Console.WriteLine(a);



        //Recibiendo entradas

        Console.WriteLine("Escribe, un Limon :)");
        Console.ReadLine();
        Console.WriteLine($"{Console.ReadLine()}, Medio Limón");

        Console.Write("Escribe un numero natural para encontrar su doble");
        Console.ReadLine();
        int Numero = int.Parse(Console.ReadLine()!);
        Console.WriteLine(Numero * 2);

        Console.WriteLine("Escribe 3 numeros naturales para hallar su medio y su promedio");
        Double Z = Double.Parse(Console.ReadLine()!), y = Double.Parse(Console.ReadLine()!), C = Double.Parse(Console.ReadLine()!);
        Double Max1 = Math.Max(Z, y);
        Double Max2 = Math.Max(Max1, C);
        Double Medio = Math.Max(Max2, Max1);
        Double Promedio = (Z + y + C) / 3;
        Console.WriteLine($"El del medio es: {Medio} y el promedio de los valores es: {Promedio}");

        //3
        Console.WriteLine("Escribe 2 numero enteros");
        int x = int.Parse(Console.ReadLine()!), y = int.Parse(Console.ReadLine()!);
        int mayor = (x + y + Math.Abs(x - y)) / 2;
        Console.WriteLine($"El número mayor es {mayor}");

        // 4-
        Console.WriteLine("Escribe 3 numero enteros");
        int x = int.Parse(Console.ReadLine()!), y = int.Parse(Console.ReadLine()!), z = int.Parse(Console.ReadLine()!);
        int Max1 = Math.Max(x, y);
        int Max2 = Math.Max(Max1, z);
        int Medio = Math.Min(Max1, Max2);
        Console.WriteLine($"El número del medio es {Medio} y el promedio es {(x + y + z) / 3}");

        // 5-
        Console.WriteLine("Escribe un nombre y un numero menor que la cantidad de letras de la palabras");
        string palabra = Console.ReadLine()!;
        int num = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine($"La letra que tiene ese numero es {palabra[num]}");

        // Intercambio de variables *******************************************************************************************************************
        //1-*******************************************************************************************************************************************
        Console.WriteLine("Escribe los valores para A y B");
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"El valor de A es {b} y el de B es {a} ");
        //2- 
        Console.WriteLine("Escribe los valores para A y B");
        int x = int.Parse(Console.ReadLine()!);
        int y = int.Parse(Console.ReadLine()!);

        int c = x;
        x = y;
        y = c;

        Console.WriteLine($"El valos de A es {x} y el de B es {y} ");

        // Velocidad de escritura
        Console.WriteLine(" escribe una palabra");
        double reloj = Environment.TickCount;
        string palabra = Console.ReadLine()!;
        double tiempo = Environment.TickCount - reloj;
        Console.WriteLine($"Te demoraste {tiempo} ms que son {tiempo / 100}seg ");

        //Fecha de Nacimiento
        System.Console.WriteLine("Escribe tu carnet");
        ulong num = ulong.Parse(Console.ReadLine()!);
        Console.WriteLine($" Tu fecha de nacimiento es {(num % 10000000) / 100000}/{(num / 10000000) % 10}/{(num / 1000000000)}");


        //Formando fechas
        Console.WriteLine("Dame datos para formar una fecha en el formato dia/mes/año ");
        int d = int.Parse(Console.ReadLine()!), m = int.Parse(Console.ReadLine()!), a = int.Parse(Console.ReadLine()!);
        if (FormarFecha(d, m, a) == true)
        {
            Console.WriteLine($"{d}/{m}/{a}");
        }
        else Console.WriteLine("No se pudo formar una fecha válida.");


    }
}