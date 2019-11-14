namespace WindowsFormsApp1.Mostrar_Resultado
{
    partial class resultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelResultado = new System.Windows.Forms.Label();
            this.rbLagrange = new System.Windows.Forms.RadioButton();
            this.radioButtonProgesivo = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Especializar K";
            // 
            // buttonBuscarK
            // 
            this.buttonBuscarK.Location = new System.Drawing.Point(15, 66);
            this.buttonBuscarK.Name = "buttonBuscarK";
            this.buttonBuscarK.Size = new System.Drawing.Size(125, 23);
            this.buttonBuscarK.TabIndex = 5;
            this.buttonBuscarK.Text = "Buscar imagen de K";
            this.buttonBuscarK.UseVisualStyleBackColor = true;
            this.buttonBuscarK.Click += new System.EventHandler(this.buttonBuscarK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(12, 266);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(135, 23);
            this.buttonVolver.TabIndex = 8;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 4;
            this.numericUpDown1.Location = new System.Drawing.Point(16, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(124, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(16, 234);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(24, 13);
            this.labelResultado.TabIndex = 10;
            this.labelResultado.Text = "text";
            // 
            // rbLagrange
            // 
            this.rbLagrange.AutoSize = true;
            this.rbLagrange.Checked = true;
            this.rbLagrange.Location = new System.Drawing.Point(152, 39);
            this.rbLagrange.Name = "rbLagrange";
            this.rbLagrange.Size = new System.Drawing.Size(70, 17);
            this.rbLagrange.TabIndex = 11;
            this.rbLagrange.TabStop = true;
            this.rbLagrange.Text = "Lagrange";
            this.rbLagrange.UseVisualStyleBackColor = true;
            this.rbLagrange.CheckedChanged += new System.EventHandler(this.rbLagrange_CheckedChanged);
            // 
            // radioButtonProgesivo
            // 
            this.radioButtonProgesivo.AutoSize = true;
            this.radioButtonProgesivo.Location = new System.Drawing.Point(152, 62);
            this.radioButtonProgesivo.Name = "radioButtonProgesivo";
            this.radioButtonProgesivo.Size = new System.Drawing.Size(154, 17);
            this.radioButtonProgesivo.TabIndex = 12;
            this.radioButtonProgesivo.Text = "Newton Gregory progresivo";
            this.radioButtonProgesivo.UseVisualStyleBackColor = true;
            this.radioButtonProgesivo.CheckedChanged += new System.EventHandler(this.radioButtonProgesivo_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(152, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(148, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "Newton Gregory regresivo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Algoritmos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 70);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 298);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButtonProgesivo);
            this.Controls.Add(this.rbLagrange);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBuscarK);
            this.Controls.Add(this.label1);
            this.Name = "resultado";
            this.Text = "resultado";
            this.Load += new System.EventHandler(this.resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.RadioButton rbLagrange;
        private System.Windows.Forms.RadioButton radioButtonProgesivo;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}