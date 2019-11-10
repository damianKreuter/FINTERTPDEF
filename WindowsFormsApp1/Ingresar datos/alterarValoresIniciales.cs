using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Ingresar_datos
{
    public partial class alterarValoresIniciales : Form
    {
        float[] xss;
        float[] yss;
        Mostrar_datos.MostrarPasos devolver;

        public alterarValoresIniciales(Mostrar_datos.MostrarPasos pasos, float[] xs, float[] ys)
        {
            devolver = pasos;
            xss = xs;
            yss = ys;
            for(int i =0; i< xss.Length; i++)
            {
                dataGridView1.Rows.Add(xss[i], yss[i]);
            }
            InitializeComponent();
        }

        private void alterarValoresIniciales_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
//          pasos.pasarDatosNuevos(xss, yss);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float xAModificar = (float) numericUpDown1.Value;
            for(int i = 0; i< xss.Length; i++)
            {
                if(xAModificar == xss[i])
                {
                    //HAY QUE MODIFICAR ESTA LINEA SOLO
                    dataGridView1.Rows[i].Cells[1].Value = (float)numericUpDown2.Value;
                    return;
                }
            }
            //SALIMOS POR LO TANTO HAY QUE AGREGAR

            float[] xmodificados = new float[xss.Length+1];
            float[] ymodificados = new float[xss.Length+1];
            int dondequedo = 0;
            for(int i = 0; i < xss.Length + 1; i++)
            {
                if(xAModificar < xss[i])
                {
                    xmodificados[i] = xAModificar;
                    ymodificados[i] = (float)numericUpDown2.Value;
                    dondequedo = i;
                    i = xss.Length + 1;
                } else
                {
                    xmodificados[i] = xss[i];
                    ymodificados[i] = yss[i];
                }
            }
            if (dondequedo == 0)
            {
                xmodificados[xss.Length] = xAModificar;
                ymodificados[xss.Length] = (float)numericUpDown2.Value;
            }
        }
    }
}
