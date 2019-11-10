using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Procesamiento_de_datos
{
    class BuscarPolinomio
    {
        public BuscarPolinomio() { }

        // A[] represents coefficients  
        // of first polynomial 
        // B[] represents coefficients  
        // of second polynomial 
        // m and n are sizes of A[]  
        // and B[] respectively 
        public float[] multiplicarPolinomios(float[] A, float[] B)
        {
            int m = A.Length;
            int n = B.Length;
            float[] prod = new float[m + n - 1];
            // Initialize the porduct polynomial 
            for (int i = 0; i < m + n - 1; i++)
            {
                prod[i] = 0;
            }
            // Multiply two polynomials term by term 
            // Take ever term of first polynomial 
            for (int i = 0; i < m; i++)
            {
                // Multiply the current term of first polynomial 
                // with every term of second polynomial. 
                for (int j = 0; j < n; j++)
                {
                    prod[i + j] += A[i] * B[j];
                }
            }
            return prod;
        }

        public float[] sumarPolinomios(float[] A, float[] B)
        {
            float[] retorno;
            if (A.Length < B.Length)
            {
                retorno = new float[A.Length];
                for(int i = 0; i< A.Length; i++)
                {
                    retorno[i] = A[i] + B[i];
                }
            } else if (A.Length == B.Length)
            {
                retorno = new float[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    retorno[i] = A[i] + B[i];
                }
            } else
            {
                retorno = new float[B.Length];
                for (int i = 0; i < B.Length; i++)
                {
                    retorno[i] = A[i] + B[i];
                }
            }
            return retorno;
        }

        public float[] multiplicarPolinomioXY(float[] A, float Y)
        {
            for(int i = 0; i < A.Length; i++)
            {
                A[i] *= Y;
            }
            return A;
        }

        // A utility function to print a polynomial 
        public String obtenerStringPolinomio(float[] poly)
        {
            int n = poly.Length;
            String retorno = "";
            int cant = 0;
            for (int i = 0; i < n; i++)
            {
                if (poly[i] != 0)
                {
                    if (cant == 0)
                    {
                        if (i != 0)
                        {
                            retorno = retorno + poly[i].ToString()+"x^" + i.ToString();
                        } else
                        {
                            retorno = retorno + poly[i].ToString();
                        }
                        cant++;
                    } else
                    {
                        if (i != 0)
                        {
                            retorno = retorno +" + "+ poly[i].ToString() + "x^" + i.ToString();
                        }
                        else
                        {
                            retorno = retorno + " + " + poly[i].ToString();
                        }
                    }
                }  
            }
            return retorno;
        }

        /*
        // Driver code 
        public static void Main(String[] args)
        {

            // The following array represents  
            // polynomial 5 + 10x^2 + 6x^3 
            int[] A = { 5, 0, 10, 6 };

            // The following array represents 
            // polynomial 1 + 2x + 4x^2 
            int[] B = { 1, 2, 4 };
            int m = A.Length;
            int n = B.Length;

            Console.WriteLine("First polynomial is n");
            printPoly(A, m);
            Console.WriteLine("nSecond polynomial is n");
            printPoly(B, n);

            int[] prod = multiply(A, B, m, n);

            Console.WriteLine("nProduct polynomial is n");
            printPoly(prod, m + n - 1);
        }*/

    }
}
