namespace CP5
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region 1. Fracción
            Fraction a = new Fraction(1, 3);
            Fraction b = new Fraction(9, 3);
            //1. Obtener el numerador(simplificado)
            b.Simplify();
            //2. Obtener el denominador (simplificado)

            //3. Representacíon en cadena de caracteres
            a.FractionToString();

            //4. Suma de fracciones
            Fraction suma = a.Fsuma(b);
            b.Simplify();
            b.FractionToString();

            //5.Resta de fracciones
            Fraction resta = a.Resta(b);
            resta.FractionToString();

            //6. Multiplicacíon de fracciones
            Fraction c = b.Multiply(a);
            c.FractionToString();

            //7.División de fracciones
            Fraction d = a.Division(b);
            d.FractionToString();
            //8.Comparación de fracciones
            a.isEqual(b);
            #endregion

            #region 2. Polinomio
            
            #endregion
            
            #region 3. Conjunto
            
            #endregion
            
            #region 4. Entero grande
            
            #endregion
            
            #region 5. Fecha 
            
            #endregion
            
            #region 6. Libro con reseñas 
            
            #endregion
            
        }

    }
}