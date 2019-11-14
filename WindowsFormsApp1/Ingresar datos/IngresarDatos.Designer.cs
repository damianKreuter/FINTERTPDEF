namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIngresarDatos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCalcularInterpolante = new System.Windows.Forms.Button();
            this.radioButtonLagrange = new System.Windows.Forms.RadioButton();
            this.radioButtonNewtonProgresivo = new System.Windows.Forms.RadioButton();
            this.radioButtonNetwonRegresivo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numerricEliminar = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerricEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIngresarDatos
            // 
            this.buttonIngresarDatos.Location = new System.Drawing.Point(264, 123);
            this.buttonIngresarDatos.Name = "buttonIngresarDatos";
            this.buttonIngresarDatos.Size = new System.Drawing.Size(196, 46);
            this.buttonIngresarDatos.TabIndex = 0;
            this.buttonIngresarDatos.Text = "Ingresar par de datos o modificar ya X existente";
            this.buttonIngresarDatos.UseVisualStyleBackColor = true;
            this.buttonIngresarDatos.Click += new System.EventHandler(this.buttonIngresarDatos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDominio,
            this.ColumnImagen});
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(243, 350);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnDominio
            // 
            this.ColumnDominio.HeaderText = "X";
            this.ColumnDominio.Name = "ColumnDominio";
            this.ColumnDominio.ReadOnly = true;
            // 
            // ColumnImagen
            // 
            this.ColumnImagen.HeaderText = "F(X)";
            this.ColumnImagen.Name = "ColumnImagen";
            this.ColumnImagen.ReadOnly = true;
            // 
            // buttonCalcularInterpolante
            // 
            this.buttonCalcularInterpolante.Location = new System.Drawing.Point(12, 424);
            this.buttonCalcularInterpolante.Name = "buttonCalcularInterpolante";
            this.buttonCalcularInterpolante.Size = new System.Drawing.Size(154, 43);
            this.buttonCalcularInterpolante.TabIndex = 2;
            this.buttonCalcularInterpolante.Text = "Mostrar pasos del calculo";
            this.buttonCalcularInterpolante.UseVisualStyleBackColor = true;
            this.buttonCalcularInterpolante.Click += new System.EventHandler(this.buttonCalcularInterpolante_Click);
            // 
            // radioButtonLagrange
            // 
            this.radioButtonLagrange.AutoSize = true;
            this.radioButtonLagrange.Checked = true;
            this.radioButtonLagrange.Location = new System.Drawing.Point(273, 331);
            this.radioButtonLagrange.Name = "radioButtonLagrange";
            this.radioButtonLagrange.Size = new System.Drawing.Size(70, 17);
            this.radioButtonLagrange.TabIndex = 3;
            this.radioButtonLagrange.TabStop = true;
            this.radioButtonLagrange.Text = "Lagrange";
            this.radioButtonLagrange.UseVisualStyleBackColor = true;
            this.radioButtonLagrange.CheckedChanged += new System.EventHandler(this.radioButtonLagrange_CheckedChanged);
            // 
            // radioButtonNewtonProgresivo
            // 
            this.radioButtonNewtonProgresivo.AutoSize = true;
            this.radioButtonNewtonProgresivo.Location = new System.Drawing.Point(273, 355);
            this.radioButtonNewtonProgresivo.Name = "radioButtonNewtonProgresivo";
            this.radioButtonNewtonProgresivo.Size = new System.Drawing.Size(154, 17);
            this.radioButtonNewtonProgresivo.TabIndex = 4;
            this.radioButtonNewtonProgresivo.Text = "Newton-Gregory progresivo";
            this.radioButtonNewtonProgresivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonNetwonRegresivo
            // 
            this.radioButtonNetwonRegresivo.AutoSize = true;
            this.radioButtonNetwonRegresivo.Location = new System.Drawing.Point(273, 379);
            this.radioButtonNetwonRegresivo.Name = "radioButtonNetwonRegresivo";
            this.radioButtonNetwonRegresivo.Size = new System.Drawing.Size(148, 17);
            this.radioButtonNetwonRegresivo.TabIndex = 5;
            this.radioButtonNetwonRegresivo.Text = "Newton-Gregory regresivo";
            this.radioButtonNetwonRegresivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Algoritmo de interpolacion";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(264, 97);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(365, 97);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dominio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Imagen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "FINTER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Autor: Damián Nicolás Kreuter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Especializar el polinomio en K";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 43);
            this.button2.TabIndex = 17;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Eliminar X y su imagen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numerricEliminar
            // 
            this.numerricEliminar.DecimalPlaces = 2;
            this.numerricEliminar.Location = new System.Drawing.Point(267, 228);
            this.numerricEliminar.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numerricEliminar.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.numerricEliminar.Name = "numerricEliminar";
            this.numerricEliminar.Size = new System.Drawing.Size(194, 20);
            this.numerricEliminar.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "X a eliminar junto a su F(X)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 479);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numerricEliminar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonNetwonRegresivo);
            this.Controls.Add(this.radioButtonNewtonProgresivo);
            this.Controls.Add(this.radioButtonLagrange);
            this.Controls.Add(this.buttonCalcularInterpolante);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonIngresarDatos);
            this.Name = "Form1";
            this.Text = "Ingresar datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerricEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIngresarDatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImagen;
        private System.Windows.Forms.Button buttonCalcularInterpolante;
        private System.Windows.Forms.RadioButton radioButtonLagrange;
        private System.Windows.Forms.RadioButton radioButtonNewtonProgresivo;
        private System.Windows.Forms.RadioButton radioButtonNetwonRegresivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numerricEliminar;
        private System.Windows.Forms.Label label6;
    }
}

