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

        private float[] datosDePolinomio;

        public resultado(DataGridView datosDeGrilla, String algoritmo)
        {
            InitializeComponent();

            this.datos = datosDeGrilla;
            int cantidadIteraciones = datosDeGrilla.RowCount - 1;
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
            if (algoritmo.Equals("Lagrange"))
            {
                Procesamiento_de_datos.Lagrange lagrange = new Procesamiento_de_datos.Lagrange();
                datosDePolinomio = lagrange.buscandoFxResuelto(datosDeX, datosDeY);
                this.rbLagrange.Checked = true;
            }
            else if (algoritmo.Equals("Progresivo"))
            {
                Procesamiento_de_datos.Newton_Gregory nuevo = new Procesamiento_de_datos.Newton_Gregory();
                datosDePolinomio = nuevo.buscandoFxResueltoProgresivo(datosDeX, datosDeY);
                this.radioButtonProgesivo.Checked = true;
            }
            else
            {
                Procesamiento_de_datos.Newton_Gregory nuevo = new Procesamiento_de_datos.Newton_Gregory();
                datosDePolinomio = nuevo.buscandoFxResueltoRegresivo(datosDeX, datosDeY);
                this.radioButton2.Checked = true;
            }

           

           /* minimo = datosDeX[0];
            maximo = datosDeX[datosDeX.Length-1];

            labelMaximoYMinimo.Text = "[" + minimo.ToString() + "-" + maximo.ToString() + "]";
            */
            

            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = "P(x)";
            dataGridView1.Rows.Add(polinomioAString(datosDePolinomio));

            
        }

        

        private float especializarPolinomioEnK(float k)
        {
            float resultado = 0;
            for(int i =0; i < datosDePolinomio.Length; i++)
            {
                if (datosDePolinomio[i] != 0)
                {
                    if (i == 0)
                    {
                        resultado += datosDePolinomio[i];
                    }
                    else
                    {
                        float potenciaDeK = k;
                        for(int j = 1; j < i; j++)
                        {
                            potenciaDeK *= k;
                        }
                        resultado += datosDePolinomio[i] * potenciaDeK;
                    }
                }

            }
            return resultado;
        }

        private String polinomioAString(float[] datos)
        {
            Procesamiento_de_datos.BuscarPolinomio buscar = new Procesamiento_de_datos.BuscarPolinomio();
            String retorno = buscar.obtenerStringPolinomio(datos);
            return retorno;
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

            float kEncontrada = especializarPolinomioEnK(kBuscada);
            /*     float resultadoBuscado = 0;
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
                */
                labelResultado.Text = kEncontrada.ToString();
            
            
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbLagrange_CheckedChanged(object sender, EventArgs e)
        {
            Procesamiento_de_datos.Lagrange lagrange = new Procesamiento_de_datos.Lagrange();
            datosDePolinomio = lagrange.buscandoFxResuelto(datosDeX, datosDeY);
            DataGridView nuevoData = new DataGridView();
            nuevoData.RowCount = 1;
            nuevoData.Rows.Add(polinomioAString(datosDePolinomio));
            dataGridView1 = nuevoData;
        }

        private void radioButtonProgesivo_CheckedChanged(object sender, EventArgs e)
        {
            Procesamiento_de_datos.Newton_Gregory nuevo = new Procesamiento_de_datos.Newton_Gregory();
            
            datosDePolinomio = nuevo.buscandoFxResueltoProgresivo(datosDeX, datosDeY);

            DataGridView nuevoData = new DataGridView();
            nuevoData.RowCount = 1;
            nuevoData.Rows.Add(polinomioAString(datosDePolinomio));
            dataGridView1 = nuevoData;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Procesamiento_de_datos.Newton_Gregory nuevo = new Procesamiento_de_datos.Newton_Gregory();
            datosDePolinomio = nuevo.buscandoFxResueltoRegresivo(datosDeX, datosDeY);
            DataGridView nuevoData = new DataGridView();
            nuevoData.RowCount = 1;
            nuevoData.Rows.Add(polinomioAString(datosDePolinomio));
            dataGridView1 = nuevoData;
        }
    }
}
