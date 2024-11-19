using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

/*class Program
{
    public static void Main(string[] args)
    {
        Fraction a = new Fraction(2, 3);
        Fraction b = new Fraction(5, 9);
        float d = a.Divide();

        Fraction D = Fsuma(a, b);
        Fraction dd = a.Fsuma(b);  //para llamar al metodo Fsuma si esta estuviera dentro de la clase Fraccion

        // forma de darles valores a v
        Poly v = new Poly(2, 2, 1, 5, 7, 8, 5);
        v.Grade();

    }

    public static Fraction Fsuma(Fraction a, Fraction b)
    {
        //estos son campos
        int num = (a.numerador * b.denominador) + (b.numerador * a.denominador);
        int den = a.denominador * b.denominador;

        return new Fraction(num, den);
    }
}
public class Fraction
{
    public int numerador;
    public int denominador = 1;

    //constructor de la clase 
    public Fraction(int n, int d)
    {
        numerador = n;
        denominador = d;
    }
    // adentro de una clase no se le pone estatico porque va a estar arraigado a la clase
    public float Divide()
    {
        return (float)numerador / denominador;
    }

    //other es para referirse a otro elemento del mismo tipo
    public Fraction Fsuma(Fraction other)
    {
        int n_num = (numerador * other.denominador) + (other.numerador * denominador);
        int n_den = denominador * other.denominador;
        return new Fraction(n_num, n_den);
    }

    public Fraction Fsuma(int s)
    {
        return Fsuma(new Fraction(s, 1));
    }

    public void Suma(Fraction other)
    {
        int n_num = (numerador * other.denominador) + (other.numerador * denominador);
        int n_den = denominador * other.denominador;
    }
    public void suma(int s)
    {
        Suma(new Fraction(s, 1));
    }
}

public class Poly
{
    public int[] coeficientes;
    public Poly(params int[] coeficientes)
    {
        this.coeficientes = coeficientes;
    }

    public int Grade() => coeficientes.Length-1; // =  return coeficientes.Length - 1;} 
    public int GetCoef(int k) => coeficientes[k];
    public string ToString()
    {
        string s = TermToString(coeficientes[coeficientes[^-1]], coeficientes.Length);

        for (int i = coeficientes.Length - 2; i >= 0; i--)
        {
            if (coeficientes[i] == 0) continue;//** duda
            {
                if (coeficientes[i] > 0) s += "+";

                s += TermToString(coeficientes[i], i);
            }

        }

        return s;
    }

    public string TermToString(int coef, int grade)
    {
        string s = "";

        if (coef == -1)
            s += "-";
        else if (coef != 1)
            s += coef.ToString();
        if (grade != 0)
        {
            s += "x";
            if (grade != 1)
            {
                s += "'" + grade;
            }
            //falta revisar el caso en q el termino independiente fuera uno y hay q escribir +1

        }
        return s;
    }

}*/