using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Procesamiento_de_datos
{
    class Lagrange
    {
        public Lagrange() { }

        public ArrayList mostrarPasos(float[] xs, float[] ys)
        {
            ArrayList stringPasos = new ArrayList();
            DataGridView data = new DataGridView();
            int size = xs.Length;

           //INDICE va pasando por cada 1 de los datos de XS
            for (int indice =0; indice < size; indice++)
            {
                String aDevolver = pasoPolinomio(xs, ys[indice], indice);
                stringPasos.Add(aDevolver);
            }
            return stringPasos;
        }

       

    public String pasoPolinomio(float[] xArray, float y, int i)
        {
            String devolver = "";
            String numerador = "";
            String denominador = "";
            float diferencias = 1;
            int size = xArray.Length;
            
            for (int j = 0; j < size; j++)
            {
                if (j != i)
                {
           //         numerador = numerador + "( x -" + xArray[j].ToString() + " )";
                    denominador = denominador + entreParentesis(xArray[i], xArray[j]);
                    diferencias *= xArray[i] - xArray[j];
                }
            }
            //       devolver = "{[" + numerador + "] / [" + denominador + "]}*" + y.ToString();
            devolver = "[" + denominador + "] = " + diferencias.ToString();
            return devolver;
        }

        private String entreParentesis(float x1, float x2)
        {
            if (x2 > 0)
            {
                return "( " + x1.ToString() + " - " + x2.ToString() + " )";
            }
            return "( " + x1.ToString() + " + " + (-1*x2).ToString() + " )";
        }

        private String divisionToString(float buscado, float x, float y)
        {
            return entreParentesis(buscado, x) + "/" + entreParentesis(x, y);
        }



        //SEGUN LA CANTIDAD DE GRADOS SE SUMAN LA CANTIDAD DE COSAS QUE HAY QUE AHCER

        public float[] diferenciasPols(float[] xArray, float y, int i)
        {
            float[] retorno = new float[xArray.Length - 1];
            int size = xArray.Length;
            for (int j = 0; j < size; j++)
            {
                if (j != i)
                {
                    retorno[i] = (xArray[i] - xArray[j]);
                }
            }
            return retorno;
        }

        public ArrayList obtenerLosLxi(float x, float[] xArray, int i)
        {
            ArrayList lxis = new ArrayList();
            int size = xArray.Length;
            for (int j = 0; j < size; j++)
            {
                if (j != i)
                {
                    lxis.Add((x - xArray[j]) / (xArray[i] - xArray[j]));
                }
            }
            return lxis;
        }

        /*
         * X        -> El punto al que quiero buscar su imagen
         * XARRAY   -> Conjunto de puntos que existen como dominio
         * YARRAY   -> Conjunto de puntos que existen en la imagen
         * */

        public float obtenerKEspecializado(float kBuscada, DataGridView datos)
        {
            int cantidadIteraciones = datos.RowCount - 1;
            float[] datosDeX = new float[cantidadIteraciones];
            float[] datosDeY = new float[cantidadIteraciones];
            int i = 0;

            for (i = 0; i < cantidadIteraciones; i++)
            {
                datosDeX[i] =
                    float.Parse(datos.Rows[i].Cells[0].Value.ToString());
                datosDeY[i] =
                   float.Parse(datos.Rows[i].Cells[1].Value.ToString());
            }
            float res = LagrangeInterpolacionPolimonial(kBuscada, datosDeX, datosDeY);
            return res;
        }

        public float LagrangeInterpolacionPolimonial(float kEspecializada, float[] xArray, float[] yArray)
        {
            int size = xArray.Length;

            float lagrangePolynomial = 0;

            for (int i = 0; i < size; i++)
            {
                lagrangePolynomial += calcularPolinomioEnLi(kEspecializada, xArray, i) * yArray[i];
            }

            return lagrangePolynomial;
        }

        public String traduciendoFx(float[] xArray, float[] yArray)
        {
            int size = xArray.Length;
            String lagrangePolynomial = "";
            for (int i = 0; i < size; i++) {
                float y = yArray[i];
                if (i == 0) {
                    lagrangePolynomial = lagrangePolynomial + paraBuscarFx(xArray, i, y).ToString() +
                    obtenerLasXs(xArray, i);
                }
                else {
                    lagrangePolynomial = lagrangePolynomial + " + " + paraBuscarFx(xArray, i, y).ToString() +
                    obtenerLasXs(xArray, i);
                }
            }
            return lagrangePolynomial;
        }

        public String obtenerPolinomio(float[] xArray, int i, float y)
        {
            String devolver = "";
            int size = xArray.Length;
            float[] pol = new float[size];
            Procesamiento_de_datos.Polinomio polinomio = new Polinomio();
            for(int otro = 0; otro < size; i++)
            {
                pol[otro] = 0;
            }
            for (int j = 0; j < size; j++)
            {
                float[] nuevo = new float[2];
                if (j != i)
                {
                    nuevo[0] = xArray[j];
                    nuevo[1] = 1;
                    pol = polinomio.multiply(pol, nuevo, pol.Length, nuevo.Length, j);
                }
            }
            for (int j = 0; j < size; j++)
            {
                pol[i] *= y;
            }
            return devolver;
        }

        public float[] buscandoFxResuelto(float[] xArray, float[] yArray)
        {
            int size = xArray.Length;

            Procesamiento_de_datos.BuscarPolinomio buscar = new BuscarPolinomio();

            String lagrangePolynomial = "";
            float[] polAcumulado = new float[1];
                polAcumulado[0] = 0;

            float valorYSobreLX = 0;
            for (int i = 0; i < size; i++)
            {
                float y = yArray[i];
                float[] res = new float[1];
                res[0] = 0;
                valorYSobreLX = paraBuscarFx(xArray, i, y);
                for (int j = 0; j<1; j++)
                {
                    res = obtenerPolinomioDeLx(xArray, i, res);
                }
                res = buscar.multiplicarPolinomioXY(res, valorYSobreLX);
                polAcumulado = buscar.sumarPolinomios(res, polAcumulado);
   /*                 lagrangePolynomial =
                    lagrangePolynomial + paraBuscarFx(xArray, i, y).ToString() +
                    obtenerLasXs(xArray, i);
                    */
            }
            return polAcumulado;
        }

        public String buscandoFx(float[] xArray, float[] yArray)
        {
            int size = xArray.Length;

            String lagrangePolynomial = "";
            for (int i = 0; i < size; i++)
            {
                float y = yArray[i];
                if (i == 0)
                {
                    lagrangePolynomial =
                    lagrangePolynomial  + paraBuscarFx(xArray, i, y).ToString() +
                    obtenerLasXs(xArray, i);
                } else
                {
                    lagrangePolynomial =
                    lagrangePolynomial + " + " + paraBuscarFx(xArray, i, y).ToString() +
                    obtenerLasXs(xArray, i);
                }
            }
            return lagrangePolynomial;
        }

        public float[] obtenerPolinomioDeLx(float[] xArray, int i, float[] polAnterior)
        {
            Procesamiento_de_datos.BuscarPolinomio b = new BuscarPolinomio();
            int size = xArray.Length;
            int primero = 0;
            for (int j = 0; j < size; j++)
            {
                if (j != i)
                {
                    float[] cosaX = new float[2];
                    cosaX[0] = xArray[j]*(-1);
                    cosaX[1] = 1;
                    if (primero != 0)
                    {
                        polAnterior = b.multiplicarPolinomios(cosaX, polAnterior);
                    } else
                    {
                        polAnterior = new float[2];
                        polAnterior = cosaX;
                        primero++;
                    }
                    
                }
            }
            return polAnterior;
        }

        public String obtenerLasXs(float[] xArray, int i)
        {
            String devolver = "";
            int size = xArray.Length;

            for (int j = 0; j < size; j++)
            {
                if (j != i)
                {
                    devolver = devolver + "( x -" + xArray[j].ToString() + " )";
                }
            }
            return devolver;
        }

            public float paraBuscarFx(float[] xArray, int i, float y)
        {
            float devolver;
            float denominador = 1;
            int size = xArray.Length;
            for (int j = 0; j < size; j++)
            {
                if (j != i)
                {
        /*            if (xArray[j] > 0)
                    {*/
                        
                        denominador *= xArray[i] - xArray[j];
              /*      }
                    else
                    {
                     //   denominador *= xArray[i] + xArray[j];
                    }*/
                }
            }
            double ret = (double)y / denominador;
            float devolverA = (float)ret;
            return devolverA;
        }

        public float calcularPolinomioEnLi(float kBuscada, float[] xArray, int i)
        {
            float devolver;
            float numerador = 1;
            float denominador = 1;
            int size = xArray.Length;
            for (int j = 0; j < size; j++)
            {
                if (j != i)
                {
                    if (xArray[j] > 0)
                    {
                        numerador *= kBuscada - xArray[j];
                        denominador *= xArray[i] - xArray[j];
                    } else {
                        numerador *= kBuscada + xArray[j];
                        denominador *= xArray[i] + xArray[j];
                    }
                }
            }
            devolver = (numerador / denominador);
            return devolver;
        }
    }
}
