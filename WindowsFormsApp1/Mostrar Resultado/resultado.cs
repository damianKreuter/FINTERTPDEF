using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Mostrar_Resultado
{
    public partial class resultado : Form
    {
        DataGridView datos;


        private float minimo;
        private float maximo;
        private float[] datosDeX;
        private float[] datosDeY;

        public resultado(DataGridView datos, String algoritmo)
        {
            InitializeComponent();
            if (algoritmo.Equals("Lagrange"))
            {
                this.rbLagrange.Checked = true;
            }
            else if (algoritmo.Equals("Progresivo"))
            {
                this.radioButtonProgesivo.Checked = true;
            }
            else
            {
                this.radioButton2.Checked = true;
            }
            this.datos = datos;
            int cantidadIteraciones = datos.RowCount - 1;
            datosDeX = new float[cantidadIteraciones];
            datosDeY = new float[cantidadIteraciones];
            int i = 0;

            for (i = 0; i < cantidadIteraciones; i++)
            {
                datosDeX[i] =
                    float.Parse(datos.Rows[i].Cells[0].Value.ToString());
                datosDeY[i] =
                    float.Parse(datos.Rows[i].Cells[1].Value.ToString());
            }

            minimo = datosDeX[0];
            maximo = datosDeX[datosDeX.Length-1];

            labelMaximoYMinimo.Text = "[" + minimo.ToString() + "-" + maximo.ToString() + "]";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBuscarK_Click(object sender, EventArgs e)
        {
            float kBuscada = (float)numericUpDown1.Value;
          
                float resultadoBuscado = 0;
                if (rbLagrange.Checked)
                {
                    Procesamiento_de_datos.Lagrange lagrange = new Procesamiento_de_datos.Lagrange();
                    resultadoBuscado = lagrange.obtenerKEspecializado(kBuscada, datos);
                }
                else if (radioButtonProgesivo.Checked)
                {
                    Procesamiento_de_datos.Newton_Gregory newton = new Procesamiento_de_datos.Newton_Gregory();
                    resultadoBuscado = newton.aplicarFormulaProgresiva(kBuscada, datosDeX, datosDeY);
                }
                else
                {
                    Procesamiento_de_datos.Newton_Gregory newton = new Procesamiento_de_datos.Newton_Gregory();
                    //        resultadoBuscado = newton.
                    resultadoBuscado = newton.aplicarFormulaRegresivo(kBuscada, datosDeX, datosDeY);
                }

                labelResultado.Text = resultadoBuscado.ToString();
            
            
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

        private void resultado_Load(object sender, EventArgs e)
        {

        }
    }
}
