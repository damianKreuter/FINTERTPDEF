using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DataGridView datosOriginales;

        public Form1()
        {
            datosOriginales = dataGridView1;
            InitializeComponent();
            radioButtonLagrange.Checked = true;
        }

        private void buttonIngresarDatos_Click(object sender, EventArgs e)
        {
            DataGridView data = dataGridView1;
            int i = 1;
            if (checkBoxDominioNegativo.Checked)
            {
                i = -1;
            }
            double dominio = (double) numericUpDown1.Value * i;
            i = 1;
            if (checkBoxImagenNegativo.Checked)
            {
                i = -1;
            }
            double imagen = (double) numericUpDown2.Value * i;

            string dato = string.Empty;
            Boolean sePuede = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    dato = row.Cells[0].Value.ToString();
                    if (dominio.ToString().Equals(dato))
                    {
                        //YA EXISTE EN LA TABLA ASI QUE MANDO ALERT 
                        //Y TERMINO ESTA OPERACION
                        MessageBox.Show("Ya existe el numero de dominio " + dominio.ToString() + " en la tabla a ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        sePuede = false;
                    }
                }
            }
            if (sePuede)
            {
                dataGridView1.Rows.Add(dominio, imagen);
     //           this.dataGridView1.Sort(dataGridView1.Columns["X"], ListSortDirection.Ascending);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalcularInterpolante_Click(object sender, EventArgs e)
        {
            String tipoAlgoritmo;
            if (radioButtonLagrange.Checked)
            {
                tipoAlgoritmo = "Lagrange";
            }
            else if(radioButtonNewtonProgresivo.Checked)
            {
                tipoAlgoritmo = "Newton-Gregory progresivo";
            }
            else tipoAlgoritmo = "Newton-Gregory regresivo";
            Mostrar_datos.MostrarPasos pasos =
                new Mostrar_datos.MostrarPasos(dataGridView1, tipoAlgoritmo);
            pasos.Show();
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tipoAlgoritmo;
            if (radioButtonLagrange.Checked)
            {
                tipoAlgoritmo = "Lagrange";
            }
            else if (radioButtonNewtonProgresivo.Checked)
            {
                tipoAlgoritmo = "Newton-Gregory Progresivo";
            }
            else tipoAlgoritmo = "Newton-Gregory Regresivo";
            Mostrar_Resultado.resultado pasos =
                new Mostrar_Resultado.resultado(dataGridView1, tipoAlgoritmo);
            pasos.Show();
        }

        private void radioButtonLagrange_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
