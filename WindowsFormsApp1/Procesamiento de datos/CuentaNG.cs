using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Procesamiento_de_datos
{
    class CuentaNG
    {
        public double xmin;
        public double xmax;
        public double yMaximo;
        public double yMinimo;

        public int grado;
        public double fgrado;

        public CuentaNG(double xmaximo, double xminimo, double ymenor, double ymayor, int grado) {
            xmin = xminimo;
            xmax = xminimo;
            yMaximo = ymayor;
            yMinimo = ymenor;
            this.grado = grado;
            fgrado = (ymayor - ymenor) / (xmax - xmin);
        }

        public  double obtenerValor()
        {
            return fgrado;
        }

        public String obtenerFormula()
        {
            return "( " + yMaximo.ToString() + "-("+yMinimo.ToString()+" ) /" +
                " ( "+xmax.ToString()+" - "+xmin.ToString()+" ) ="+fgrado.ToString() ;
        }
    }
}
