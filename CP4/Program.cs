using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        #region CP4
        //Mayor, menor y promedio de forma perezosa
        int[] n = { 4, 10, 8, 7, 5, 1, 11, };
        MayoMenorPromedio(n);

        //Segundo
        int[] k = { 1, 0, 3, 6, 4, 5, 8, 9, 10 };
        int m = MenorNumeroDeUnArray(k);
        int aux = int.MaxValue;
        for (int i = 0; i < k.Length; i++)
        {
            if (k[i] != m && k[i] < aux)
                aux = k[i];

        }
        System.Console.WriteLine(aux);

        //Invirtiendo
        int[] array = { 2, 7, -9 };
        Invertir(array);

        //Orden por cercania
        int[] a = { 5, 3, 7, 10 };
        int p = 7;
        int[] b = OrdenPorCercania(a, p);

        for (int i = 0; i < b.Length; i++)
            System.Console.WriteLine($"[{i}] = {b[i]}");


        //Busqueda
        int[] ab = { 0, 1, 2, 4, 5 };
        int nb = 7;
        bool mb = Existe(ab, nb);
        System.Console.WriteLine(mb);

        //Moda
        int[] am = { 1, 2, 1, 4, 7, 7, 7, 3, 1, 7 };
        Moda(am);

        //Mediana
        int[] kme = { 1, 2, 3, 6, 4, 5, 8, 9, 10, 7 };
        Mediana(kme);

        //Sumando Cadenas**********************************************************************************

        //Restando cadenas*********************************************************************************

        //Multiplicando cadenas****************************************************************************

        //Dividiendo cadenas*******************************************************************************

        //Resto de la division... ¿ando? cadenas***********************************************************

        //Filtrando Positivos
        int[] kf = { -1, -2, 3 };
        int[] bf = FiltrandoPositivos(kf);
        for (int i = 0; i < bf.Length; i++)
            System.Console.WriteLine($"[{i}] = {bf[i]}");

        //Eliminar
        int[] ae = { -1, -2, 3, 1, 5, 9, 6, 8, 10, 7, -8 };
        int pos = 5;
        int[] be = Eliminar(ae, pos);
        for (int i = 0; i < be.Length; i++)
            System.Console.WriteLine($"[{i}] = {be[i]}");

        //Conjuntos
        int[] ac = { 6, 8, 10, 8, -1, 3 };
        int[] bc = { -1, -2, 6, };
        //a)*****************************************************************************************************
        int[] inter = Interseccion(ac, bc);
        for (int i = 0; i < inter.Length; i++)
            System.Console.WriteLine($"[{i}] = {inter[i]}");

        //b)
        int[] union = Union(ac, bc);
        for (int i = 0; i < union.Length; i++)
            System.Console.WriteLine($"[{i}] = {union[i]}");
        //c)*****************************************************************************************************

        //Buena accion del dia
        string[] texto = new string[8]; /*InsertarTexto();*/
        string word = "agua";
        Contar(texto, word);

        //Factorial
        int nff = 3;
        Factorial(nff);

        //Suma de Impares
        int ns = 10;
        SumaDeImpares(ns);

        //Recorriendo arrays
        int[] nra = { 4, 10, 8, 7, 5, 11, 1 };
        Recorriendo bra = new Recorriendo();
        int mra = 5;

        bra.Mayor(n);
        int yra = bra.Promedio(n); System.Console.WriteLine(yra);
        bra.Segundomenor2Elemento(nra);
        bra.Existe(nra, mra);
        bra.Contar(nra);

        //Rotando
        int[] nro = { 25, 40, 17, 83, 9 };
        int mro = 0;
        Rotando(nro, mro);

        //Mezcla ordenada
        int[] nmo = { 1, 3, 5, 7, 9 };
        int[] mmo = { 0, 2, 4, 6, 8, 10 };
        MezclaOrdenada(nmo, mmo);

        // Añadiendo al Final
        int[] n_a = { 1, 3, 5, 7, 9 };
        int val_a = 50;
        AddingAtTheEnd(n_a, val_a);

        // Insertando
        int[] n_i = { 0, 0, 0, 0, 0, 0, 0, 0, 0, };
        int val_i = 50;
        int pos_i = 4;
        Adding(n_i, val_i, pos_i);

        //Es primo
        string a_pri = "En casa de manuela hay queso";
        string b_pri = "en";

        Substring(a_pri, b_pri);

        //Es Palindromo
        string a_pal = "reloj";

        EsPalindromo(a_pal);

        // Menor sufijo para ser palındromo********************************************************************************
        #endregion
    }
    //Este metodo es para determinar el mayor elemento de un array devolverlo.
    static int MayorNumeroDeUnArray(int[] n)
    {
        int mayor = n[0];
        for (int j = 0; j < n.Length; j++)
        {
            if (mayor < n[j])
                mayor = n[j];
        }
        return mayor;
    }

    //Este metodo es lo mismo que el de PosDelMenor, la diferencia es que no devuelve la posicion del menor, sino que devuelve el menor en si.
    public static int MenorNumeroDeUnArray(int[] a)
    {
        int menor = int.MaxValue;
        for (int i = 0; i < a.Length; i++)
        {
            if (menor > a[i])
                menor = a[i];
        }
        return menor;
    }

    //Este metodo es para invertir un array de su posicion original.
    static void Invertir(int[] a)
    {
        for (int i = 0; i < a.Length / 2; i++)
        {
            int temp = a[i];
            a[i] = a[a.Length - 1 - i];
            a[a.Length - 1 - i] = temp;

        }
        for (int j = 0; j < a.Length; j++)
            System.Console.WriteLine($"[{j}] = {a[j]}");
    }

    //Este metodo esta diseñado para buscar un elemento "n" en un array "a" que este ordenado.
    static int BusquedaBinaria(int[] a, int n)
    {
        int inicio = 0;
        int fin = a.Length - 1;
        while (inicio <= fin)
        {
            int medio = (inicio + fin) / 2;
            if (n < a[medio])
            {
                fin = medio - 1;
            }
            else if (n > a[medio])
            {
                fin = medio + 1;
            }
            else return medio;
        }
        return -1;
    }

    //Este metodo recibe un array y determina cual es el elemento que mas se repite, luego imprime en pantalla el elemento.
    static void Moda(int[] a)
    {

        int moda = 0;
        int c = 0;
        int maxc = 0;

        for (int i = 0; i < a.Length; i++)
        {
            c = 0;
            for (int j = 0; j < a.Length; j++)
            {
                if (a[i] == a[j])
                    c += 1;
                if (c > maxc)
                    maxc = c;
                moda = a[i];

            }
        }

        System.Console.WriteLine(moda); ;
    }

    //Este metodo es para cambiar los valores del array "a" en las posiciones "i" y "j" correspondientes.

    static void Intercambiar(int[] a, int i, int j)
    {
        int temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }
    //Este metodo es para oredenar de menor a mayor.
    static int[] Ordenar(int[] a)
    {
        for (int k = 0; k < a.Length; k++)
            Intercambiar(a, k, PosDelMenor(a, k));

        return a;
    }

    //Este metodo pide un array "a" y un "pivote" para ordenar todos los elementos segun la distancia de cada uno con el pivote.
    // En el 1er ciclo se restan la diferencia con el pivote de cada posicion de "a[i]".
    // En el 2do ciclo llama a los metodos "Intercambiar" y determina el menor elemento del array "a" segun su modulo para luego posicionarlo en el lugar
    // correspondiente y por ultimo le suma a cada b[i] el pivote para devolver el array organizado.
    static int[] OrdenPorCercania(int[] a, int pivote)
    {
        int p = 0;

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = a[i] - pivote;
        }
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = p + 1; j < a.Length; j++)
            {
                if (Math.Abs(a[j]) < Math.Abs(a[p])) p = j;
            }
            Intercambiar(a, i, p);
            a[i] += pivote;
        }
        return a;
    }

    //Este metodo verifica la posicion del menor elemento del array "a" devuelve la posicion en la que se encuentra el valor.
    //La variable "inicio" es para determinar desde donde se quiera empezar a buscar el menor valor del array "a".
    static int PosDelMenor(int[] a, int inicio)
    {
        int p = inicio;
        for (int i = inicio + 1; i < a.Length; i++)
        {
            if (a[i] < a[p]) p = i;
        }
        return p;
    }

    //Este metodo es para determinar si un valor "x" esta en un array "a", devuelve "true" si existe, "false" en caso contrario.
    static bool Existe(int[] a, int x)
    {
        bool exist = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == x)
                exist = true;

        }
        return exist;
    }

    // Este metodo envia un "CWL" con el elemento del "a[i]" que es la mediana del array.
    static void Mediana(int[] a)
    {
        int m = a.Length - 1;
        int medio = m / 2;
        if (m % 2 == 0)
            System.Console.WriteLine($"La mediana es {a[medio]}");
        else System.Console.WriteLine($"La mediana es {a[medio]} y {a[medio + 1]}");

    }

    //Este metodo devuelve un array con todos los numeros positivos que se encuentren en el array "a" que se le pase.
    static int[] FiltrandoPositivos(int[] a)
    {
        int[] c = new int[a.Length];
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] >= 0)
            {
                c[i] = a[i];
                count += 1;
            }
        }
        if (count == 0) throw new ArgumentException("El Array no puede ser entero negativo");

        return EliminarCeros(c, count);
    }

    //Este metodo se le pasa un array "a" con la cuenta de la cantidad de elementos diferentes de 0 (count) y devuelve un array sin los ceros del array original.
    static int[] EliminarCeros(int[] a, int count)
    {
        int[] sub = new int[count];
        int k = 0;

        for (int j = 0; j < a.Length; j++)
        {
            if (a[j] != 0)
            {
                sub[k] = a[j];
                k++;
            }
        }
        return sub;
    }

    //Este metodo recibe un array "a" y elimina el elemento en la posicion (pos) y devuelve el array sin dicho elemento.
    static int[] Eliminar(int[] a, int pos)
    {
        int[] nuevo = new int[a.Length - 1];

        for (int i = 0; i < pos; i++)
            nuevo[i] = a[i];
        for (int i = pos; i < a.Length; i++)
            nuevo[i] = a[i + 1];

        return nuevo;
    }

    //Este metodo recibe dos arrays "a" y "b" y busca los elementos iguales de cada uno y los almacena en un nuevo array "inter" y luego son eliminados sus ceros.
    static int[] Interseccion(int[] a, int[] b)
    {
        int[] inter = new int[a.Length + b.Length];
        int count = 0;
        if (a.Length < b.Length)
        {
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        inter[count] = a[i];
                        count++;
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        inter[count] = a[i];
                        count++;
                    }
                }
            }
        }
        if (count == 0) throw new ArgumentException("El Array no puede ser entero negativo");

        return EliminarCeros(inter, count);
    }

    // Este metodo se les pasa dos arrays "a" y "b", y los une XD...
    static int[] Union(int[] a, int[] b)
    {
        int[] u = new int[a.Length + b.Length];
        int pos = a.Length;
        for (int i = 0; i < a.Length; i++)
            u[i] = a[i];
        for (int i = 0; i < b.Length; i++)
            u[pos + i] = b[i];

        return u;
    }

    // Este metodo recibe un array de string y un string para buscarlo en dicho array y devuelve la cantidad de veces que se repite en el array.
    static void Contar(string[] parrafo, string word)
    {
        int c = 0;
        for (int i = 0; i < parrafo.Length; i++)
        {
            if (parrafo[i] == word)
                c++;
        }
        System.Console.WriteLine(c);
    }

    /* static string[] InsertarTexto()******************************************************************
     {
         string words;
         string[] text = new string[1];
         while (true)
         {
             words = Console.ReadLine()!;

             if (words == " ") break;



         }
         return text;
     }*/
    public static void Factorial(int n)
    {
        int f = 1;
        while (n > 1)
        {
            f *= n;
            n--;
        }

        System.Console.WriteLine(f);
    }

    public static void SumaDeImpares(int n)
    {
        int suma = 0;
        if (n > 0)
        {
            for (int i = n; i >= 1; i--)
            {
                if (i % 2 != 0) suma += i;
            }
        }
        else if (n < 0)
        {
            for (int i = n; Math.Abs(i) >= 1; i++)
            {
                if (i % 2 != 0) suma += i;
            }
        }
        System.Console.WriteLine(suma);
    }
    
    public static void MayoMenorPromedio(int[] n)
    {
        int mayor = n[0];
        int menor = mayor;
        int promedio = n[0];

        for (int i = 1; i < n.Length; i++)
        {
            if (mayor < n[i]) mayor = n[i];
            else if (menor > n[i]) menor = n[i];
            promedio += n[i];
        }
        promedio /= n.Length;

        System.Console.WriteLine(mayor + " " + menor + " " + promedio);
    }

    public static void Rotando(int[] n, int veces)
    {

        if (veces > 0)
        {
            for (int i = 0; i < veces + 1; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if (j + 1 < n.Length)
                    {
                        int temp = n[j];
                        n[j] = n[j + 1];
                        n[j + 1] = temp;
                    }

                }
            }

        }
        else if (veces < 0)
        {
            for (int i = 0; i <= Math.Abs(veces); i++)
            {
                for (int j = n.Length - 1; j >= 0; j--)
                {
                    if (j - 1 >= 0)
                    {
                        int temp = n[j];
                        n[j] = n[j - 1];
                        n[j - 1] = temp;
                    }

                }
            }
        }
        for (int i = 0; i < n.Length; i++)
            System.Console.WriteLine($"[{i}] = {n[i]}");

    }

    public static void MezclaOrdenada(int[] a, int[] b)
    {
        int[] ordenada = new int[a.Length + b.Length];

        for (int i = 0; i < a.Length; i++)
            ordenada[i] = a[i];
        for (int i = 0; i < b.Length; i++)
            ordenada[a.Length + i] = b[i];

        for (int i = 0; i < ordenada.Length; i++)
        {
            int p = i;
            for (int j = p + 1; j < ordenada.Length; j++)
            {
                if (ordenada[p] > ordenada[j])
                {
                    p = j;
                    int temp = ordenada[i];
                    ordenada[i] = ordenada[p];
                    ordenada[p] = temp;
                }

            }
        }
        for (int i = 0; i < ordenada.Length; i++)
            System.Console.WriteLine($" [{i}] = {ordenada[i]} ");
    }

    public static void AddingAtTheEnd(int[] n, int val)
    {
        int[] n2 = new int[n.Length + 1];
        for (int i = 0; i < n2.Length - 1; i++)
            n2[i] = n[i];
        n2[n.Length] = val;


        for (int i = 0; i < n2.Length; i++)
            System.Console.WriteLine($"[{i}] = {n2[i]}");
    }

    public static void Adding(int[] n, int val, int pos)
    {
        int[] n2 = new int[n.Length + 1];

        for (int i = 0; i < pos; i++)
            n2[i] = n[i];

        n2[pos] = val;

        for (int i = pos; i < n.Length; i++)
            n2[i + 1] = n[i];



        for (int i = 0; i < n2.Length; i++)
            System.Console.WriteLine($"[{i}] = {n2[i]}");
    }

    public static void Substring(string a, string b)
    {
        string[] a2 = new string[a.Length];
        int p = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].ToString() != " ")
                a2[p] += a[i].ToString();

            else if (a[i].ToString() == " ")
            {
                p++;
                a2[p] += a[i].ToString();
                p++;
            }
        }

        for (int i = 0; (i < a.Length) && (a2[i] != null); i++)
        {
            if (b == "")
            {
                System.Console.WriteLine("Es substring");
                break;
            }
            else if (b == a2[i])
            {
                System.Console.WriteLine("Es substring");
                break;
            }
            else System.Console.WriteLine("No es Substring");
            break;

        }
    }

    public static void EsPalindromo(string a)
    {
        char[] b = new char[a.Length];
        for (int i = 0; i < a.Length; i++)
            b[i] = a[i];
        for (int i = 0; i < b.Length / 2; i++)
        {
            char temp = b[i];
            b[i] = b[b.Length - 1 - i];
            b[b.Length - 1 - i] = temp;
        }
        string c = "";
        for (int i = 0; i < b.Length; i++)
            c += b[i];

        if (a == c)
            System.Console.WriteLine("Es Palindromo");
        else System.Console.WriteLine("No es Palindromo");
    }

}

public class Recorriendo
{
    public void Mayor(int[] n)
    {
        int mayor = n[0];
        for (int i = 1; i < n.Length; i++)
            if (mayor < n[i]) mayor = n[i];


        System.Console.WriteLine(mayor);
    }
    public int Promedio(int[] n)
    {
        int promedio = n[0];

        for (int i = 1; i < n.Length; i++)
        {
            promedio += n[i];
        }
        promedio /= n.Length;
        return promedio;
    }

    public void Segundomenor2Elemento(int[] n)
    {

        for (int i = 0; i < n.Length; i++)
        {
            int p = i;
            for (int j = p + 1; j < n.Length; j++)
            {
                if (n[p] > n[j])
                {
                    p = j;
                    int temp = n[i];
                    n[i] = n[p];
                    n[p] = temp;
                }
            }

        }
        int menor2 = n[0];
        for (int i = 0; i < n.Length; i++)
        {
            if (menor2 != n[i])
            {
                menor2 = n[i];
                break;
            }

        }

        System.Console.WriteLine($"{menor2}");

    }

    public void Existe(int[] a, int x)
    {
        bool exist = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == x)
                exist = true;

        }
        System.Console.WriteLine(exist); ;
    }

    public void Contar(int[] n)
    {
        int y = Promedio(n);
        int c = 0;
        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] > y)
                c++;
        }
        System.Console.WriteLine(c);
    }




}
