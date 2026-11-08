using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMoneda.Items.Add("USD - Dolar Estadounidense");
            cmbMoneda.Items.Add("MXN - Peso Mexicano");
            cmbMoneda.Items.Add("CAD - Dolar Canadiense");
            cmbMoneda.Items.Add("EUR - Euro");
            cmbMoneda.Items.Add("JPY - Yen Japonés");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbMoneda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una moneda");
                return;
            }
            if (!double.TryParse(txtMonto.Text, out double monto))
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            frmSeleccion seleccion = new frmSeleccion();
            seleccion.MonedaInicial = cmbMoneda.SelectedItem.ToString();

            if (seleccion.ShowDialog() == DialogResult.OK)
            {
                for (int i = this.Controls.Count - 1; i >= 0; i--)
                {
                    if (this.Controls[i].Name == "lblRes" || this.Controls[i].Name == "txtRes")
                    {
                        this.Controls.RemoveAt(i);
                    }
                }

                double resultado = 0;
                int posY = 180;

                foreach (string monedaFinal in seleccion.monedaRequerida)
                {
                    Label lbl = new Label();
                    lbl.Name = "lblRes";
                    lbl.AutoSize = true;
                    lbl.Location = new Point(20, posY + 4);

                    TextBox txt = new TextBox();
                    txt.Name = "txtRes";
                    txt.ReadOnly = true;
                    txt.Width = 100;
                    txt.Location = new Point(140, posY);

                    switch (cmbMoneda.SelectedItem.ToString())
                    {

                        //El startsWith es una función que encontré en internet que sirve para comparar las primeras letras de 2 cadenas
                        case "USD - Dolar Estadounidense":
                            if (monedaFinal.StartsWith("MXN"))
                            {
                                resultado = monto * 17.38;
                                lbl.Text = "MXN - Peso";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("CAD"))
                            {
                                resultado = monto * 1.36;
                                lbl.Text = "CAD - Dólar";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("EUR"))
                            {
                                resultado = monto * 0.86;
                                lbl.Text = "EUR - Euro";
                                txt.Text = "€ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("JPY"))
                            {
                                resultado = monto * 157.92;
                                lbl.Text = "JPY - Yen";
                                txt.Text = "¥ " + resultado.ToString("0.00");
                            }
                            break;

                        case "MXN - Peso Mexicano":
                            if (monedaFinal.StartsWith("USD"))
                            {
                                resultado = monto * 0.06;
                                lbl.Text = "USD - Dólar";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("CAD"))
                            {
                                resultado = monto * 0.08;
                                lbl.Text = "CAD - Dólar";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("EUR"))
                            {
                                resultado = monto * 0.05;
                                lbl.Text = "EUR - Euro";
                                txt.Text = "€ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("JPY"))
                            {
                                resultado = monto * 9.09;
                                lbl.Text = "JPY - Yen";
                                txt.Text = "¥ " + resultado.ToString("0.00");
                            }
                            break;

                        case "CAD - Dolar Canadiense":
                            if (monedaFinal.StartsWith("USD"))
                            {
                                resultado = monto * 0.73;
                                lbl.Text = "USD - Dólar";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("MXN"))
                            {
                                resultado = monto * 12.76;
                                lbl.Text = "MXN - Peso";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("EUR"))
                            {
                                resultado = monto * 0.63;
                                lbl.Text = "EUR - Euro";
                                txt.Text = "€ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("JPY"))
                            {
                                resultado = monto * 115.88;
                                lbl.Text = "JPY - Yen";
                                txt.Text = "¥ " + resultado.ToString("0.00");
                            }
                            break;

                        case "EUR - Euro":
                            if (monedaFinal.StartsWith("USD"))
                            {
                                resultado = monto * 1.17;
                                lbl.Text = "USD - Dólar";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("MXN"))
                            {
                                resultado = monto * 20.32;
                                lbl.Text = "MXN - Peso";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("CAD"))
                            {
                                resultado = monto * 1.59;
                                lbl.Text = "CAD - Dólar";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("JPY"))
                            {
                                resultado = monto * 184.66;
                                lbl.Text = "JPY - Yen";
                                txt.Text = "¥ " + resultado.ToString("0.00");
                            }
                            break;

                        case "JPY - Yen Japonés":
                            if (monedaFinal.StartsWith("USD"))
                            {
                                resultado = monto * 0.0063;
                                lbl.Text = "USD - Dólar";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("MXN"))
                            {
                                resultado = monto * 0.1101;
                                lbl.Text = "MXN - Peso";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("CAD"))
                            {
                                resultado = monto * 0.0086;
                                lbl.Text = "CAD - Dólar";
                                txt.Text = "$ " + resultado.ToString("0.00");
                            }
                            else if (monedaFinal.StartsWith("EUR"))
                            {
                                resultado = monto * 0.0054;
                                lbl.Text = "EUR - Euro";
                                txt.Text = "€ " + resultado.ToString("0.00");
                            }
                            break;
                    }

                    this.Controls.Add(lbl);
                    this.Controls.Add(txt);
                    posY += 35;
                }
            }
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}