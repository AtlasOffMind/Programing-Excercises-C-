
using system;

public class CP3
{
    public static void Main(string[] args)
    {

        #region CP3 
        /**/
        //Divisibles
        System.Console.WriteLine("Escribe dos numeros enteros");
        int a = int.Parse(Console.ReadLine()!), b = int.Parse(Console.ReadLine()!);
        if (a % b == 0)
        System.Console.WriteLine("los numeros son divisibles");
        else
        System.Console.WriteLine("los numeros no son divisibles");

        //Carnet, de nuevo
        System.Console.WriteLine("Escribe tu CI");
        double ID = double.Parse(Console.ReadLine()!);
        double Sexo = (ID % 10);
        if(Sexo % 2 != 0)
        System.Console.WriteLine("Eres Hombre");
        else
        System.Console.WriteLine("Eres Mujer");

        //Triangulos
        System.Console.WriteLine("Escribe los valores para formar un triangulo");
        int a = int.Parse(Console.ReadLine()!), b = int.Parse(Console.ReadLine()!), c = int.Parse(Console.ReadLine()!);

        if ((a < (b + c)) && (b < (a + c)) && (c < (a + b))) 
        {
            if ( a==b && b==c ) Console.WriteLine("3 => Es un triangulo equilatero");
            else if ( a==b || b==c || c==a ) Console.WriteLine("2 => Es un triangulo isóceles");
            else Console.WriteLine("1 => Es un triangulo escaleno");   
        }
        else Console.WriteLine("0 => No pueden formar un trianglo");

        // Sumando horas
        Console.WriteLine("Escribe los 2 primeros numeros q formen una hora valida");
        int horas1 = int.Parse(Console.ReadLine()!),  Min1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Escribe los 2 ultimos numeros q formen una hora valida");
        int horas2 = int.Parse(Console.ReadLine()!), Min2 = int.Parse(Console.ReadLine()!);
        if ((horas1 >= 0 && horas1 <= 60 && Min1>= 0 && Min1 <= 60) || (horas2 >= 0 && horas2 <= 60 && Min2>= 0 && Min1 <= 60) )
        {
            int totalhoras = horas1 + horas2; 
            int totalmin = Min1 + Min2;
            int totalhorasF = totalhoras + 1;


            if (totalmin >= 60)
            {
               int diferencia = -1*(60 - totalmin);
               totalmin = 0;
               if(totalhorasF >= 24) 
               {
                int diferenciahoras = -1* (24 - totalhorasF);
                totalhorasF = 0;

                 Console.WriteLine($"Tu hora total es {totalhorasF + diferenciahoras}:{totalmin + diferencia} "); 
               }
               else Console.WriteLine($"Tu hora total es {totalhorasF}:{totalmin + diferencia} "); 
            }
            else if (totalmin >= 0 && totalmin < 60 ) 
            {
                if(totalhorasF >= 24) 
               {
                int diferenciahoras = -1* (24 - totalhoras);
                totalhorasF = 0;
                Console.WriteLine($"Tu hora total es {diferenciahoras}:{totalmin} "); 
               }
                else Console.WriteLine($"Tu hora total es {totalhoras}:{totalmin}");

            }
        }
        else Console.WriteLine($"Tu entradas no pueden sumar una hora valida");

        //Avion

        Console.WriteLine("Escriba la hora de salida del vuelo en el formato hh/mm");
        double hs = double.Parse(Console.ReadLine()!), ms = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Escriba la hora de llegada del vuelo en el formato hh/mm");
        double hll = double.Parse(Console.ReadLine()!), mll = double.Parse(Console.ReadLine()!);

        if (hs >= 0 && ms >= 0 && ms <= 60 && mll >= 0 && mll <= 60)
        {                
            double hv = Math.Sqrt(Math.Pow((hs - hll), 2));
            double mv = Math.Sqrt(Math.Pow((ms - mll), 2));

            if (hv > 24) Console.WriteLine($"Su vuelo ha durado mas de 24h y {mv}min ");
            else Console.WriteLine($"Su vuelo ha durado {hv}h y {mv}min ");

        }
        else if (ms > 60)
        {
            double nhs = hs +1;
            double dif = -1*(60 - ms);
            ms = 0;
            double nms = ms + dif;

            double hv = Math.Sqrt(Math.Pow((nhs - hll), 2));
            double mv = Math.Sqrt(Math.Pow((nms - mll), 2));

            if (hv > 24) Console.WriteLine($"Su vuelo ha durado mas de 24h y {mv}min ");
            else Console.WriteLine($"Su vuelo ha durado {hv}h y {mv}min ");
        }
        else if (mll > 60)
        {
            double nhll = hll +1;
            double dif = -1*(60 - mll);
            mll = 0;
            double nmll = mll + dif;

            double hv = Math.Sqrt(Math.Pow((hs - nhll), 2));
            double mv = Math.Sqrt(Math.Pow((ms - nmll), 2));

            if (hv > 24) Console.WriteLine($"Su vuelo ha durado mas de 24h y {mv}min ");
            else Console.WriteLine($"Su vuelo ha durado {hv}h y {mv}min ");
        }
        else if (ms > 60 && mll > 60)
        {
            double nhs = hs +1;
            double dif1 = -1*(60 - ms);
            ms = 0;
            double nms = ms + dif1;

            double nhll = hll +1;
            double dif2 = -1*(60 - mll);
            mll = 0; 
            double nmll = mll + dif2;

            double hv = Math.Sqrt(Math.Pow((nhs - nhll), 2));
            double mv = Math.Sqrt(Math.Pow((ms - nmll), 2));

            if (hv > 24) Console.WriteLine($"Su vuelo ha durado mas de 24h y {mv}min ");
            else Console.WriteLine($"Su vuelo ha durado {hv}h y {mv}min ");           
        }
        else Console.WriteLine($"Diste mal los datos");  

        // Dos Fechas 
        Console.WriteLine("Ingresa fecha 1");
        int a1 = int.Parse(Console.ReadLine()!), m1 = int.Parse(Console.ReadLine()!), d1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Ingresa fecha 2");
        int a2 = int.Parse(Console.ReadLine()!), m2 = int.Parse(Console.ReadLine()!), d2 = int.Parse(Console.ReadLine()!);

        DateTime x = new DateTime(a1, m1, d1);
        DateTime y = new DateTime(a2, m2, d2);
        TimeSpan diferencia = x.Subtract(y);

        Console.WriteLine($"Hay entre fechas {Math.Sqrt(Math.Pow(diferencia.Days, 2))} dias");

        //El dia despues 
        Console.WriteLine("Ingresa una fecha");
        int a1 = int.Parse(Console.ReadLine()!), m1 = int.Parse(Console.ReadLine()!), d1 = int.Parse(Console.ReadLine()!);
        DateTime x = new DateTime(a1, m1, d1 + 1);
        Console.WriteLine($"El dia siguiente sera {x.Year}/{x.Month}/{x.Day}");

        //Dia de la semana
        Console.WriteLine("Ingresa una fecha");
        int a1 = int.Parse(Console.ReadLine()!), m1 = int.Parse(Console.ReadLine()!), d1 = int.Parse(Console.ReadLine()!);
        DateTime x = new DateTime(a1, m1, d1);
        Console.WriteLine($"El dia es {x.ToString("dddd")}");

        //Punto interior*************************************
        Console.WriteLine("Escribe los valores ");
        int a = int.Parse(Console.ReadLine()!), b = int.Parse(Console.ReadLine()!), c = int.Parse(Console.ReadLine()!);

        if ((a < (b + c)) && (b < (a + c)) && (c < (a + b)))
        {

        }
        else Console.WriteLine("0 => No pueden formar un trianglo");

        //Primo *************************************
        System.Console.WriteLine("escribe tunumero");
        int p = 11;//(int)Console.ReadLine();
        int p2 = 2;
        int raiz = (int)Math.Sqrt(p);
        while (p2 <= raiz)
        {
            if (p % p2 == 0) return;
            else p2++;

        }
        System.Console.WriteLine(" es primo");

        #endregion

    }

}

