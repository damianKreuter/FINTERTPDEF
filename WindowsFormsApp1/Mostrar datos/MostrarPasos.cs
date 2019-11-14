using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;



namespace WindowsFormsApp1.Mostrar_datos
{
    public partial class MostrarPasos : Form
    {
        private String tipoAlgoritmo;
        private DataGridView datos;
        private ArrayList array;
        private float[] datosDeX;
        private float[] datosDeY;

        private float[] polAnterior;
        Form1 ingresarDatos;
        public MostrarPasos(DataGridView datos, String tipoAlgoritmo, float[] polinomioAnterior,
            Form1 ingresarDatos)
        {
            this.ingresarDatos = ingresarDatos;
            InitializeComponent();
            polAnterior = polinomioAnterior;

            int cantidadIteraciones = datos.RowCount - 1;
            datosDeX = new float[cantidadIteraciones];
            datosDeY = new float[cantidadIteraciones];
            int i = 0;
            
            for (i=0; i< cantidadIteraciones; i++)
            {
                datosDeX[i] =
                    float.Parse(datos.Rows[i].Cells[0].Value.ToString());
                datosDeY[i] =
                   float.Parse(datos.Rows[i].Cells[1].Value.ToString());
            }
            this.datos = datos;
            labelAlgoritmoUsado.Text = tipoAlgoritmo;
            this.tipoAlgoritmo = tipoAlgoritmo;
            llenarGrilla();
            esXEspaciado();

            llenarXs();
            
        }

        private void chequearSiElPolinomioObtenidoDifiereDelAnterior(float[] polObtenido)
        {

            Boolean esDiferente = false;
            if(polAnterior != null)
            {
                if (polAnterior.Length != polObtenido.Length)
                {
                    esDiferente = true;
                }
                if (esDiferente)
                {
                    MessageBox.Show("Los cambios en la grilla dieron un Polinomio distinto",
                         "P(x) diferente");
                }
                else
                {
                    for (int i = 0; i < polAnterior.Length; i++)
                    {
                        if (polAnterior[i] != polObtenido[i])
                        {
                            esDiferente = true;
                        }
                    }
                }
            }
            
            if (esDiferente)
            {
                MessageBox.Show("Los cambios en la grilla dieron un Polinomio distinto",
                     "P(x) diferente");
            }

            polAnterior = polObtenido;
        }

        private void llenarXs()
        {
            dataGridView3.ColumnCount = 2;
            dataGridView3.Columns[0].Name = "X";
            dataGridView3.Columns[1].Name = "Y";
            for (int i =0; i < datosDeX.Length; i++)
            {
                dataGridView3.Rows.Add(datosDeX[i].ToString(), datosDeY[i].ToString());

            }
        }

        private void esXEspaciado()
        {
            Boolean Esxespaciado = true;
            float diferenciaInicia = datosDeX[0] - datosDeX[1];

            for(int i=0; i<datosDeX.Length-1; i++)
            {
                float difs = datosDeX[i] - datosDeX[i+1];
                if(difs != diferenciaInicia)
                {
                    Esxespaciado = false;
                    
                }
            }
            if (Esxespaciado)
            {
                xespaciado.Text = "Si";
            } else xespaciado.Text = "No";
        }


        private void llenarGrilla()
        {
            if (tipoAlgoritmo.Equals("Lagrange"))
            {
                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Li";
                dataGridView1.Columns[1].Name = "Resultado";

                Procesamiento_de_datos.Lagrange lagrange = new Procesamiento_de_datos.Lagrange();
                int tamanio = datosDeX.Length;
                ArrayList resultados = lagrange.mostrarPasos(datosDeX, datosDeY);
                int cantidaResultado = resultados.Count;
                //               dataGridView1.Columns.Add("inicial", "L i");
                //              dataGridView1.Columns.Add("secundario", "Operaciones que debe realizar");
                for (int i = 0; i < cantidaResultado; i++)
                {
                    dataGridView1.Rows.Add("L" + i, resultados[i].ToString());
                    labelGrado.Text = (cantidaResultado - 1).ToString();
                }
                dataGridView2.ColumnCount = 1;
                dataGridView2.Columns[0].Name = "P(x)";
                dataGridView2.Rows.Add(lagrange.buscandoFx(datosDeX, datosDeY));

                dataGridViewFx.ColumnCount = 1;
                dataGridViewFx.Columns[0].Name = "P(x)";
                float[] datos = lagrange.buscandoFxResuelto(datosDeX, datosDeY);
                ponerGrado(datos);
                dataGridViewFx.Rows.Add(polinomioAString(datos));

                chequearSiElPolinomioObtenidoDifiereDelAnterior(datos);
            }
            else
            {
                Procesamiento_de_datos.Newton_Gregory nuevo = new Procesamiento_de_datos.Newton_Gregory();
                int grado = datosDeX.Length;
                float[,] tabla = nuevo.obtenerTablaDeDiferenciasDivididas(datosDeX, crearTabla(), grado);

                DataGridView tablaDeNG = new DataGridView();
                dataGridView1.ColumnCount = grado;
                int gradoMaximo = 0;
                for (int i = 0; i < grado; i++)
                {
                    if (i == 0)
                    {
                        dataGridView1.Columns[i].Name = "Y";
                    }
                    else
                    {
                        dataGridView1.Columns[i].Name = "Orden " + i.ToString();
                    }

                }

                int tamanio = datosDeX.Length - 1;

                for (int i = 0; i < grado; i++)
                {
                    ArrayList row = new ArrayList();
                    for (int j = 0; j < grado - i; j++)
                    {
                        row.Add(tabla[i, j]);
                        if (tipoAlgoritmo.Equals("Newton-Gregory progresivo"))
                        {
                            if (i == 0)
                            {
                                if (tabla[0, j] != 0)
                                {
                                    gradoMaximo = j + 1;
                                }
                            }

                        }
                        else
                        {
                            if (j == grado - i - 1)
                            {
                                if (tabla[tamanio, grado - i - 1] != 0)
                                {
                                    gradoMaximo++;
                                }
                                tamanio--;
                            }

                        }

                    }
                    dataGridView1.Rows.Add(row.ToArray());
                }
                if (tipoAlgoritmo.Equals("Newton-Gregory progresivo"))
                {
                    dataGridView2.ColumnCount = 1;
                    dataGridView2.Columns[0].Name = "P(x)";
                    dataGridView2.Rows.Add(nuevo.formulaProgresiva(datosDeX, datosDeY));

                    dataGridViewFx.ColumnCount = 1;
                    dataGridViewFx.Columns[0].Name = "P(x)";
                    float[] datos = nuevo.buscandoFxResueltoProgresivo(datosDeX, datosDeY);

                    ponerGrado(datos);
                    dataGridViewFx.Rows.Add(polinomioAString(datos));
                    chequearSiElPolinomioObtenidoDifiereDelAnterior(datos);
                }
                else
                {
                    dataGridView2.ColumnCount = 1;
                    dataGridView2.Columns[0].Name = "P(x)";
                    dataGridView2.Rows.Add(nuevo.formulaRegresiva(datosDeX, datosDeY));

                    dataGridViewFx.ColumnCount = 1;
                    dataGridViewFx.Columns[0].Name = "P(x)";
                    float[] datos = nuevo.buscandoFxResueltoRegresivo(datosDeX, datosDeY);

                    ponerGrado(datos);
                    dataGridViewFx.Rows.Add(polinomioAString(datos));
                    chequearSiElPolinomioObtenidoDifiereDelAnterior(datos);
                }
            }
        }

        //        dataGridView1[i, j].Value = tabla[i, j];

    /*
                    dataGridView1.Rows.Add(row.ToArray());
                }
                labelGrado.Text = gradoMaximo.ToString();
          //      datosDeAlgoritmo = Procesamiento_de_datos.NewtonGregory.mostrarPasos(datos, tipoAlgoritmo);
            }
        }*/

        private String polinomioAString(float[] datos)
        {
            Procesamiento_de_datos.BuscarPolinomio buscar = new Procesamiento_de_datos.BuscarPolinomio();
            String retorno = buscar.obtenerStringPolinomio(datos);
            return retorno;
        }

        private void ponerGrado(float[] pol)
        {
            int grado = 0;
            for(int i = 1; i<pol.Length; i++)
            {
                if (pol[i] != 0)
                {
                    grado = i;
                }
            }
            labelGrado.Text = grado.ToString();
        }

        private float[,] crearTabla()
        {
            float[,] devolver = new float[datosDeY.Length, datosDeY.Length];

            for(int i=0; i< datosDeY.Length; i++)
            {
                devolver[i, 0] = datosDeY[i];
            }
            return devolver;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void MostrarPasos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MostrarPasos_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click_1(object sender, EventArgs e)
        {
            ingresarDatos.actualizarPolinomio(polAnterior);
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Ingresar_datos.alterarValoresIniciales valores =
                new Ingresar_datos.alterarValoresIniciales(this, datosDeX, datosDeY);

            valores.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }









}
