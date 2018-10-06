namespace Transferencia_de_calor
{
    partial class mForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.fronteraN = new System.Windows.Forms.MaskedTextBox();
            this.fronteraS = new System.Windows.Forms.MaskedTextBox();
            this.fronteraE = new System.Windows.Forms.MaskedTextBox();
            this.fronteraO = new System.Windows.Forms.MaskedTextBox();
            this.inicio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qAgregar = new System.Windows.Forms.Button();
            this.qReset = new System.Windows.Forms.Button();
            this.qValor = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.qcolumna = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.qfila = new System.Windows.Forms.NumericUpDown();
            this.pAceptar = new System.Windows.Forms.Button();
            this.columnas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.filas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qcolumna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qfila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filas)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Location = new System.Drawing.Point(155, 47);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.ShowEditingIcon = false;
            this.grid.Size = new System.Drawing.Size(497, 182);
            this.grid.TabIndex = 0;
            // 
            // fronteraN
            // 
            this.fronteraN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fronteraN.Location = new System.Drawing.Point(336, 15);
            this.fronteraN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fronteraN.Mask = "99999";
            this.fronteraN.Name = "fronteraN";
            this.fronteraN.Size = new System.Drawing.Size(132, 22);
            this.fronteraN.TabIndex = 1;
            this.fronteraN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fronteraN.ValidatingType = typeof(int);
            // 
            // fronteraS
            // 
            this.fronteraS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fronteraS.Location = new System.Drawing.Point(336, 236);
            this.fronteraS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fronteraS.Mask = "99999";
            this.fronteraS.Name = "fronteraS";
            this.fronteraS.Size = new System.Drawing.Size(132, 22);
            this.fronteraS.TabIndex = 2;
            this.fronteraS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fronteraS.ValidatingType = typeof(int);
            // 
            // fronteraE
            // 
            this.fronteraE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fronteraE.Location = new System.Drawing.Point(657, 128);
            this.fronteraE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fronteraE.Mask = "99999";
            this.fronteraE.Name = "fronteraE";
            this.fronteraE.Size = new System.Drawing.Size(132, 22);
            this.fronteraE.TabIndex = 3;
            this.fronteraE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fronteraE.ValidatingType = typeof(int);
            // 
            // fronteraO
            // 
            this.fronteraO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fronteraO.Location = new System.Drawing.Point(13, 128);
            this.fronteraO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fronteraO.Mask = "99999";
            this.fronteraO.Name = "fronteraO";
            this.fronteraO.Size = new System.Drawing.Size(132, 22);
            this.fronteraO.TabIndex = 4;
            this.fronteraO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fronteraO.ValidatingType = typeof(int);
            // 
            // inicio
            // 
            this.inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inicio.Location = new System.Drawing.Point(691, 521);
            this.inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(100, 28);
            this.inicio.TabIndex = 6;
            this.inicio.Text = "Calcular";
            this.inicio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pAceptar);
            this.groupBox1.Controls.Add(this.columnas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.filas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 303);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(501, 246);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qAgregar);
            this.groupBox2.Controls.Add(this.qReset);
            this.groupBox2.Controls.Add(this.qValor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.qcolumna);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.qfila);
            this.groupBox2.Location = new System.Drawing.Point(8, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(329, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generación de calor";
            // 
            // qAgregar
            // 
            this.qAgregar.Location = new System.Drawing.Point(197, 119);
            this.qAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qAgregar.Name = "qAgregar";
            this.qAgregar.Size = new System.Drawing.Size(100, 28);
            this.qAgregar.TabIndex = 12;
            this.qAgregar.Text = "Agregar";
            this.qAgregar.UseVisualStyleBackColor = true;
            // 
            // qReset
            // 
            this.qReset.Location = new System.Drawing.Point(8, 119);
            this.qReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qReset.Name = "qReset";
            this.qReset.Size = new System.Drawing.Size(100, 28);
            this.qReset.TabIndex = 13;
            this.qReset.Text = "Reset all";
            this.qReset.UseVisualStyleBackColor = true;
            // 
            // qValor
            // 
            this.qValor.Location = new System.Drawing.Point(125, 81);
            this.qValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qValor.Mask = "99999";
            this.qValor.Name = "qValor";
            this.qValor.Size = new System.Drawing.Size(132, 22);
            this.qValor.TabIndex = 11;
            this.qValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qValor.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Valor:";
            // 
            // qcolumna
            // 
            this.qcolumna.Location = new System.Drawing.Point(223, 23);
            this.qcolumna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qcolumna.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qcolumna.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qcolumna.Name = "qcolumna";
            this.qcolumna.Size = new System.Drawing.Size(75, 22);
            this.qcolumna.TabIndex = 9;
            this.qcolumna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qcolumna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Columna";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fila";
            // 
            // qfila
            // 
            this.qfila.Location = new System.Drawing.Point(48, 25);
            this.qfila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qfila.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qfila.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qfila.Name = "qfila";
            this.qfila.Size = new System.Drawing.Size(75, 22);
            this.qfila.TabIndex = 7;
            this.qfila.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.qfila.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pAceptar
            // 
            this.pAceptar.Location = new System.Drawing.Point(353, 53);
            this.pAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pAceptar.Name = "pAceptar";
            this.pAceptar.Size = new System.Drawing.Size(100, 28);
            this.pAceptar.TabIndex = 4;
            this.pAceptar.Text = "Generar";
            this.pAceptar.UseVisualStyleBackColor = true;
            // 
            // columnas
            // 
            this.columnas.Location = new System.Drawing.Point(231, 23);
            this.columnas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.columnas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columnas.Name = "columnas";
            this.columnas.Size = new System.Drawing.Size(75, 22);
            this.columnas.TabIndex = 3;
            this.columnas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columnas";
            // 
            // filas
            // 
            this.filas.Location = new System.Drawing.Point(56, 25);
            this.filas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.filas.Name = "filas";
            this.filas.Size = new System.Drawing.Size(75, 22);
            this.filas.TabIndex = 1;
            this.filas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.filas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filas";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Condición de frontera";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Condición de frontera";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Condición de frontera";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Condición de frontera";
            // 
            // mForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 564);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.fronteraO);
            this.Controls.Add(this.fronteraE);
            this.Controls.Add(this.fronteraS);
            this.Controls.Add(this.fronteraN);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mForm";
            this.Text = "Transferencia de calor";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qcolumna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qfila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.MaskedTextBox fronteraN;
        private System.Windows.Forms.MaskedTextBox fronteraS;
        private System.Windows.Forms.MaskedTextBox fronteraE;
        private System.Windows.Forms.MaskedTextBox fronteraO;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pAceptar;
        private System.Windows.Forms.NumericUpDown columnas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown filas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button qAgregar;
        private System.Windows.Forms.Button qReset;
        private System.Windows.Forms.MaskedTextBox qValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown qcolumna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown qfila;
    }
}

