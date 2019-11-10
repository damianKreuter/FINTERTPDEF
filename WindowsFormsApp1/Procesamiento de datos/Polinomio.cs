using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Procesamiento_de_datos
{
    class Polinomio
    {

        public Polinomio(){}

        /*LO DEJO ASI POR AHORA
        public String calcularPolinomio(float comun, String polinomioCrudo)
        {
            float[] res = new float[2];

            res = multiplicarElComunATodos(comun, res);

        }*/

        public float[] sumarPolinomios(float[] pol1, float[] pol2)
        {
            int tamanio1 = pol1.Length;
            int tamanio2 = pol2.Length;
            float[] polNuevo;
            if (tamanio1 == tamanio2)
            {
                polNuevo = new float[tamanio1];
                for(int i = 0; i< tamanio1; i++)
                {
                    polNuevo[i] = pol1[i] + pol2[i];
                }
            } else
            {
                if (tamanio1 < tamanio2)
                {
                    polNuevo = new float[tamanio2];
                    int indice = 0;
                    for (int i = 0; i < tamanio1; i++)
                    {
                        polNuevo[i] = pol1[i] + pol2[i];
                        indice++;
                    }
                    for(int i = indice; i < tamanio2; i++)
                    {
                        polNuevo[i] = pol2[i];
                    }
                } else
                {
                    polNuevo = new float[tamanio1];
                    int indice = 0;
                    for (int i = 0; i < tamanio2; i++)
                    {
                        polNuevo[i] = pol1[i] + pol2[i];
                        indice++;
                    }
                    for (int i = indice; i < tamanio1; i++)
                    {
                        polNuevo[i] = pol1[i];
                    }
                }
            }
            return polNuevo;
        }

        public String polinomioAString(float[] poly)
        {
            int n = poly.Length;
            String pol = "";
            Boolean comenzo = false;
            int grado = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(poly[i]);
                if (i != 0)
                {
                    if (poly[i] != 0)
                    {
                        grado = i;
                        if (comenzo)
                        {
                            pol = pol + " + " + poly[i].ToString() + "X^" + i.ToString();
                        }
                        else
                        {
                            pol = pol + poly[i].ToString() + "X^" + i.ToString();
                            comenzo = true;
                        }   
                    }
                } else
                {
                    if(poly[i] != 0)
                    {
                        grado = i;
                        pol = pol + poly[i].ToString();
                        comenzo = true;
                    }                    
                }
            }
            pol = pol + " [Grado: " + grado.ToString() + "]";
            return pol;
        }

        public float[] multiplicarElComunATodos(float comun, float[] polinomio)
        {
            for(int i = 0; i< polinomio.Length; i++)
            {
                polinomio[i] *= comun;
            }

            return polinomio;
        }

        public float[] multiply(float[] A, float[] B,
                             int m, int n, int indice)
        {
            if (indice == 0)
            {
                A[0] = B[0];
                A[1] = B[1];
                return A;
            }
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

    }
}
