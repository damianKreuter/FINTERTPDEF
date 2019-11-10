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
            this.checkBoxDominioNegativo = new System.Windows.Forms.CheckBox();
            this.checkBoxImagenNegativo = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIngresarDatos
            // 
            this.buttonIngresarDatos.Location = new System.Drawing.Point(264, 160);
            this.buttonIngresarDatos.Name = "buttonIngresarDatos";
            this.buttonIngresarDatos.Size = new System.Drawing.Size(196, 24);
            this.buttonIngresarDatos.TabIndex = 0;
            this.buttonIngresarDatos.Text = "Ingresar nuevo par de datos";
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
            this.dataGridView1.Size = new System.Drawing.Size(243, 266);
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
            this.buttonCalcularInterpolante.Location = new System.Drawing.Point(12, 352);
            this.buttonCalcularInterpolante.Name = "buttonCalcularInterpolante";
            this.buttonCalcularInterpolante.Size = new System.Drawing.Size(146, 43);
            this.buttonCalcularInterpolante.TabIndex = 2;
            this.buttonCalcularInterpolante.Text = "Mostrar pasos del calculo";
            this.buttonCalcularInterpolante.UseVisualStyleBackColor = true;
            this.buttonCalcularInterpolante.Click += new System.EventHandler(this.buttonCalcularInterpolante_Click);
            // 
            // radioButtonLagrange
            // 
            this.radioButtonLagrange.AutoSize = true;
            this.radioButtonLagrange.Checked = true;
            this.radioButtonLagrange.Location = new System.Drawing.Point(262, 231);
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
            this.radioButtonNewtonProgresivo.Location = new System.Drawing.Point(262, 255);
            this.radioButtonNewtonProgresivo.Name = "radioButtonNewtonProgresivo";
            this.radioButtonNewtonProgresivo.Size = new System.Drawing.Size(154, 17);
            this.radioButtonNewtonProgresivo.TabIndex = 4;
            this.radioButtonNewtonProgresivo.Text = "Newton-Gregory progresivo";
            this.radioButtonNewtonProgresivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonNetwonRegresivo
            // 
            this.radioButtonNetwonRegresivo.AutoSize = true;
            this.radioButtonNetwonRegresivo.Location = new System.Drawing.Point(262, 279);
            this.radioButtonNetwonRegresivo.Name = "radioButtonNetwonRegresivo";
            this.radioButtonNetwonRegresivo.Size = new System.Drawing.Size(148, 17);
            this.radioButtonNetwonRegresivo.TabIndex = 5;
            this.radioButtonNetwonRegresivo.Text = "Newton-Gregory regresivo";
            this.radioButtonNetwonRegresivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Algoritmo de interpolacion";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(264, 97);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Location = new System.Drawing.Point(365, 97);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
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
            this.button1.Location = new System.Drawing.Point(261, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Especializar el polinomio en K";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxDominioNegativo
            // 
            this.checkBoxDominioNegativo.AutoSize = true;
            this.checkBoxDominioNegativo.Location = new System.Drawing.Point(261, 123);
            this.checkBoxDominioNegativo.Name = "checkBoxDominioNegativo";
            this.checkBoxDominioNegativo.Size = new System.Drawing.Size(69, 17);
            this.checkBoxDominioNegativo.TabIndex = 15;
            this.checkBoxDominioNegativo.Text = "Negativo";
            this.checkBoxDominioNegativo.UseVisualStyleBackColor = true;
            // 
            // checkBoxImagenNegativo
            // 
            this.checkBoxImagenNegativo.AutoSize = true;
            this.checkBoxImagenNegativo.Location = new System.Drawing.Point(365, 123);
            this.checkBoxImagenNegativo.Name = "checkBoxImagenNegativo";
            this.checkBoxImagenNegativo.Size = new System.Drawing.Size(69, 17);
            this.checkBoxImagenNegativo.TabIndex = 16;
            this.checkBoxImagenNegativo.Text = "Negativo";
            this.checkBoxImagenNegativo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 43);
            this.button2.TabIndex = 17;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 479);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxImagenNegativo);
            this.Controls.Add(this.checkBoxDominioNegativo);
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
        private System.Windows.Forms.CheckBox checkBoxDominioNegativo;
        private System.Windows.Forms.CheckBox checkBoxImagenNegativo;
        private System.Windows.Forms.Button button2;
    }
}

