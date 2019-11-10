using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Procesamiento_de_datos
{
    class Newton_Gregory
    {


        static String protermString(int i, float[] x)
        {
            String pro = "";
            for (int j = 0; j < i; j++)
            {
                if (x[j] > 0)
                {
                    pro = pro + "( x -" + x[j].ToString() + ")";
                } else
                {
                    pro = pro + "( x +" + (-1*x[j]).ToString() + ")";
                }
                
            }
            return pro;
        }

        // Función para buscar el termino de producto  
        static float proterm(int i, float value, float[] x)
        {
            float pro = 1;
            for (int j = 0; j < i; j++)
            {
                pro = pro * (value - x[j]);
            }
            return pro;
        }

        static float regterm(int i, float value, float[] x)
        {
            int tamanio = x.Length - 1;
            float pro = 1;
            for (int j = 0; j < i; j++)
            {
                pro = pro * (value - x[tamanio]);
                tamanio--;
            }
            return pro;
        }

        static String regtermString(int i, float[] x)
        {
            int tamanio = x.Length - 1;
            String pro = "";
            for (int j = 0; j < i; j++)
            {
                float valor = x[tamanio];
                if (x[tamanio] > 0)
                {
                   
                    pro = pro + "( x - " + valor.ToString() + ")";
                }
                else
                {
                    pro = pro + "( x + " + (-1 * valor).ToString() + ")";
                }
                tamanio--;
            }
            return pro;
        }

        

        // Funcion para calcular
        // la tabla de diferencias divididas  
        static void tablaDeDiferenciasDivididas(float[] x, float[,] y, int grado)
        {
            for (int i = 1; i < grado; i++)
            {
                for (int j = 0; j < grado - i; j++)
                {
                    y[j, i] = (y[j, i - 1] - y[j + 1, i - 1]) / (x[j] - x[i + j]);
                }
            }
        }

        public float[,] obtenerTablaDeDiferenciasDivididas(float[] x, float[,] y, int grado)
        {
            for (int i = 1; i < grado; i++)
            {
                for (int j = 0; j < grado - i; j++)
                {
                    y[j, i] = (y[j, i - 1] - y[j + 1, i - 1]) / (x[j] - x[i + j]);
                }
            }
            return y;
        }


        public float obtenerResultadoDeKEnBaseA(float valor, float[] x, float[] y, int tipoAlgortimo)
        {
            float resultado = 0;

            resultado = aplicarFormulaProgresiva(valor, x, y);

            return resultado;
        }

        private float[,] crearTabla(float[] datosDeY)
        {
            float[,] devolver = new float[datosDeY.Length, datosDeY.Length];

            for (int i = 0; i < datosDeY.Length; i++)
            {
                devolver[i, 0] = datosDeY[i];
            }
            return devolver;
        }

        public float aplicarFormulaRegresivo(float valor, float[] x, float[] datosDeY)
        {
            float[,] y = obtenerTablaDeDiferenciasDivididas(x, crearTabla(datosDeY), x.Length);
            
            //tomar el mas grande de estos
            
            int tamanio = x.Length;
            float sum = y[tamanio, 0];
            for (int i = 1; i < x.Length; i++)
            {
                sum = sum + (regterm(i, valor, x) * y[tamanio-1, i]);
                tamanio--;
            }
            return sum;
        }

        public String buscandoFxResueltoProgresivo(float[] x, float[] datosDeY)
        {
            String devolver = "";
            float[,] y = obtenerTablaDeDiferenciasDivididas(x, crearTabla(datosDeY), x.Length);
            int tamanio = datosDeY.Length - 1;
            devolver = y[0, 0].ToString();
            for (int i = 1; i < x.Length; i++)
            {
                if (i > 1)
                {
                    devolver =
                    devolver + "+(" + y[0, i].ToString() + ")" + (protermString(i, x));
                }
                else
                {
                    devolver =
                    devolver + "+(" + y[0, i].ToString() + ")" + (protermString(i, x));
                }
            }
            return devolver;
        }

        public String formulaProgresiva(float[] x, float[] datosDeY)
        {
            String devolver = "";
            float[,] y = obtenerTablaDeDiferenciasDivididas(x, crearTabla(datosDeY), x.Length);
            int tamanio = datosDeY.Length - 1;
            devolver = y[0, 0].ToString();
            for (int i = 1; i < x.Length; i++)
            {
                if (i > 1)
                {
                    devolver =
                    devolver + "+("+ y[0, i].ToString()+")"+(protermString(i, x));
                }  else
                {
                    devolver =
                    devolver + "+(" + y[0, i].ToString() + ")" + (protermString(i, x));
                }
            }
            return devolver;
        }

        public String formulaProgresivaPolinomio(float[] x, float[] datosDeY)
        {
            Procesamiento_de_datos.Polinomio pol = new Polinomio();


            String devolver = "";
            float[,] y = obtenerTablaDeDiferenciasDivididas(x, crearTabla(datosDeY), x.Length);
            int tamanio = datosDeY.Length - 1;
            devolver = y[0, 0].ToString();
            for (int i = 1; i < x.Length; i++)
            {
                if (i > 1)
                {
                    devolver =
                    devolver + "+(" + y[0, i].ToString() + ")" + (protermString(i, x));
                }
            }
            return devolver;
        }

        public String formulaRegresiva(float[] x, float[] datosDeY)
        {
            String devolver = "";
            float[,] y = obtenerTablaDeDiferenciasDivididas(x,
                crearTabla(datosDeY), x.Length);
            int tamanio = datosDeY.Length - 1;
            devolver = y[tamanio, 0].ToString();
            for (int i = 1; i < x.Length; i++)
            {
                tamanio--;
                if (i > 1)
                {
                    devolver = devolver + " + (" + y[tamanio, i].ToString()+")" + (regtermString(i, x));
                } else devolver = devolver + " + (" + y[tamanio, i].ToString() + ")" + (regtermString(i, x));


            }
            return devolver;
        }

        // Funcion apra aplicar Newton Gregory formula de las diferencias dividida
        public float aplicarFormulaProgresiva(float valor, float[] x, float[] datosDeY)
        {
            float[,] y = obtenerTablaDeDiferenciasDivididas(x, crearTabla(datosDeY), x.Length);


            float sum = y[0, 0];

            for (int i = 1; i < x.Length; i++)
            {
                float valors = y[0, i];
                sum = sum + (proterm(i, valor, x) * valors);
            }
            return sum;
        }
//
     //   private float[,] tablaDIFDIVs;

        // Funcion para mostrar la tabla de las diferencias dividida
        public void imprimirTablaDeDifsDivs(float[,] y, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(Math.Round(y[i, j], 4) + "\t ");
                }
                Console.WriteLine("");
            }
        }

       

        /*
        // Driver Function  
        public static void Main()
        {
            // number of inputs given  
            int n = 4;
            float value;
            float[,] y = new float[10, 10];
            float[] x = { 5, 6, 9, 11 };

            // y[][] is used for divided difference  
            // table where y[][0] is used for input  
            y[0, 0] = 12;
            y[1, 0] = 13;
            y[2, 0] = 14;
            y[3, 0] = 16;

            // calculating divided difference table  
            tablaDeDiferenciasDivididas(x, y, n);

            // displaying divided difference table  
            imprimirTablaDeDifsDivs(y, n);

            // value to be interpolated  
            value = 7;

            // printing the value  

            Console.WriteLine("\nValue at " + (value) + " is "
                    + Math.Round(aplicarFormula(value, x, y, n), 2));
        }
        */
    }
}
