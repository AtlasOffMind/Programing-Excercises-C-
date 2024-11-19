using System.ComponentModel.DataAnnotations;

namespace CP5
{
    public class Fraction
    {
        public int numerador;
        public int denominador = 1;

        public Fraction(int n, int d)
        {
            numerador = n;
            denominador = d;

            if (denominador == 0)
                throw new ArgumentException("el denominador no puede ser 0");
        }
        public float Divide()
        {
            return (float)numerador / denominador;
        }
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

            // if (numerador % denominador == 0)
            //{
            ///  Simplify(n_num, n_den);
            //}
        }
        public void suma(int s)
        {
            Suma(new Fraction(s, 1));
        }
        public void FractionToString()
        {
            if (denominador == 1) Console.WriteLine(numerador);
            else System.Console.WriteLine($"{numerador}/{denominador}");
        }
        public void Simplify()
        {
            int mcdN = numerador;
            int mcdD = denominador;
            int resto = mcdN % mcdD;
            while (resto != 0)
            {
                mcdN = mcdD;
                mcdD = resto;
                resto = mcdN % mcdD;
            }

            numerador /= mcdD;
            denominador /= mcdD;
        }
        public Fraction Resta(Fraction other)
        {
            int n_num;
            int n_den;
            Fraction temp;

            // if (numerador != other.numerador && denominador != other.denominador)
            //{
            n_num = (numerador * other.denominador) - (other.numerador * denominador);
            n_den = denominador * other.denominador;
            temp = new Fraction(n_num, n_den);
            temp.Simplify();

            return temp;
            /* }
             else if (numerador == other.numerador && denominador == other.denominador)
             {
                 n_num = (numerador * other.denominador) - (other.numerador * denominador);
                 n_den = other.denominador;

                 return new Fraction(n_num, denominador);
             }
             //else if (numerador != other.numerador || denominador != other.denominador)
                 return new Fraction();*/
        }
        public Fraction Multiply(Fraction other)
        {
            int nMult = numerador * other.numerador;
            int dMult = denominador * other.denominador;

            Fraction Multiplo = new Fraction(nMult, dMult);
            Multiplo.Simplify();

            return Multiplo;
        }
        public Fraction Division(Fraction other)
        {
            int nDiv = numerador * other.denominador;
            int dDiv = denominador * other.numerador;
            Fraction division = new Fraction(nDiv, dDiv);
            division.Simplify();
            return division;
        }
        public void isEqual(Fraction other)
        {
            float racional1 = (float)numerador / denominador;
            float racional2 = other.Divide();
            other.Simplify();

            if (racional1 != racional2)
            {
                if ( racional1 < racional2) System.Console.WriteLine($"{numerador}/{denominador} < {other.numerador}/{other.denominador}");
                else System.Console.WriteLine($"{numerador}/{denominador} > {other.numerador}/{other.denominador}");
            }
            else System.Console.WriteLine($"{numerador}/{denominador} = {other.numerador}/{other.denominador}");
        }
    }

    public class Poly
    {
        public int[] coeficientes;
        public Poly(params int[] coeficientes)
        {
            this.coeficientes = coeficientes;
        }

        public int Grade() => coeficientes.Length - 1; // =  return coeficientes.Length - 1;} 
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
    }

}
