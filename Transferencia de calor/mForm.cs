using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transferencia_de_calor
{
    public partial class mForm : Form
    {
        public mForm()
        {
            InitializeComponent();
            cargarEventos();
        }

        #region campos

        private double[,] matrix;
        private double[,] cMatrix;

        private double fN = 0;
        private double fS = 0;
        private double fE = 0;
        private double fO = 0;
        private double min;
        private double max;
        private Color c1 = Color.Green;
        private Color c2 = Color.LimeGreen;
        private Color c3 = Color.YellowGreen;
        private Color c4 = Color.Yellow;
        private Color c5 = Color.Orange;
        private Color c6 = Color.DarkOrange;
        private Color c7 = Color.OrangeRed;
        private Color c8 = Color.Red;
        private Color c9 = Color.DarkRed;

        #endregion

        #region métodos

        private bool verificarFrontera()
        {
            try
            {
                fN = (string.IsNullOrEmpty(fronteraN.Text)) ? 0 : 
                    double.Parse(fronteraN.Text);
                fS = (string.IsNullOrEmpty(fronteraS.Text)) ? 0 :
                    double.Parse(fronteraS.Text);
                fE = (string.IsNullOrEmpty(fronteraE.Text)) ? 0 :
                    double.Parse(fronteraE.Text);
                fO = (string.IsNullOrEmpty(fronteraO.Text)) ? 0 :
                    double.Parse(fronteraO.Text);
                fronteraN.Text = (string.IsNullOrEmpty(fronteraN.Text)) ? "0" :
                    fronteraN.Text;
                fronteraS.Text = (string.IsNullOrEmpty(fronteraS.Text)) ? "0" :
                    fronteraS.Text;
                fronteraE.Text = (string.IsNullOrEmpty(fronteraE.Text)) ? "0" :
                    fronteraE.Text;
                fronteraO.Text = (string.IsNullOrEmpty(fronteraO.Text)) ? "0" :
                    fronteraO.Text;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void definirMatriz()
        {
            matrix = new double[decimal.ToInt32(filas.Value), 
                decimal.ToInt32(columnas.Value)];
            cMatrix = new double[decimal.ToInt32(filas.Value),
                decimal.ToInt32(columnas.Value)];
            qfila.Maximum = decimal.ToInt32(filas.Value);
            qcolumna.Maximum = decimal.ToInt32(columnas.Value);
            qValor.Text = cMatrix[decimal.ToInt32(qfila.Value) -1, 
                decimal.ToInt32(qcolumna.Value)].ToString();
            mostrarGrid();
        }

        private void calcularValores()
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int a = 0; a < 100; a++)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i, j] = ((((i == 0) ? fN : matrix[i - 1, j]) +
                            ((j == 0) ? fO : matrix[i, j - 1]) +
                            ((i == rows - 1) ? fS : matrix[i + 1, j]) +
                            ((j == columns - 1) ? fE : matrix[i, j + 1])) / 4)
                            + cMatrix[i, j];
                    }
                }
            }
            mostrarGrid();
            min = matrix.Cast<double>().Min();
            max = matrix.Cast<double>().Max();
            double valor = max / 9;
            foreach (DataGridViewRow r in grid.Rows)
            {
                for (int i = 0; i < r.Cells.Count; i++)
                {
                    double val = Convert.ToDouble(r.Cells[i].Value);
                    r.Cells[i].Style.BackColor =
                        (val > valor) ? ((val > valor * 2) ? ((val > valor * 3)
                        ? ((val > valor * 4) ? ((val > valor * 5) ? 
                        ((val > valor * 6) ? ((val > valor * 7) ? 
                        ((val > valor * 8) ? c9 : c8) : c7) : c6) : c5) : c4)
                        : c3) : c2) : c1;
                    r.Cells[i].Style.ForeColor = 
                        (r.Cells[i].Style.BackColor == c4) ? Color.Black : 
                        Color.White;
                }
            }
            grid.Invalidate();
        }

        private void mostrarGrid()
        {
            grid.Rows.Clear();
            grid.ColumnCount = matrix.GetLength(1);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = new DataGridViewRow();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = matrix[i, j]
                    });
                }
                grid.Rows.Add(row);
            }
        }

        #endregion

        #region eventos

        private void cargarEventos()
        {
            fronteraN.KeyPress += new KeyPressEventHandler(textCH);
            fronteraS.KeyPress += new KeyPressEventHandler(textCH);
            fronteraE.KeyPress += new KeyPressEventHandler(textCH);
            fronteraO.KeyPress += new KeyPressEventHandler(textCH);
            qValor.KeyPress += new KeyPressEventHandler(textCH);
            inicio.Click += new EventHandler(iniciarClic);
            pAceptar.Click += new EventHandler(pAceptarClic);
            qfila.ValueChanged += new EventHandler(vChanged);
            qcolumna.ValueChanged += new EventHandler(vChanged);
            qValor.KeyPress += new KeyPressEventHandler(textCH);
            qAgregar.Click += new EventHandler(qAgregarClic);
            qReset.Click += new EventHandler(qResetClic);
        }

        private void textCH(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '.' ||
                e.KeyChar == Convert.ToChar(Keys.Enter) ||
                e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void iniciarClic(object sender, EventArgs e)
        {
            if (verificarFrontera())
            {
                calcularValores();
            }
            else
            {
                MessageBox.Show("Error de conversión");
            }
        }

        private void pAceptarClic(object sender, EventArgs e)
        {
            definirMatriz();
        }

        private void vChanged(object sender, EventArgs e)
        {
            qValor.Text = cMatrix[decimal.ToInt32(qfila.Value) - 1,
              decimal.ToInt32(qcolumna.Value) - 1].ToString();
        }

        private void qAgregarClic(object sender, EventArgs e)
        {
            try
            {
                cMatrix[decimal.ToInt32(qfila.Value) - 1,
              decimal.ToInt32(qcolumna.Value) - 1] = double.Parse(qValor.Text);
                inicio.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conversión");
            }
        }

        private void qResetClic(object sender, EventArgs e)
        {
            cMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
            inicio.PerformClick();
            qValor.Text = "0";
        }

        #endregion
    }
}
