using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2
{
    public partial class frmSeleccion : Form
    {
        public List<string> monedaRequerida { get; set; } = new List<string>();
        public string MonedaInicial { get; set; }
        public frmSeleccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            string[] opciones = new string[] {
            "USD - Dolar Estadounidense",
            "MXN - Peso Mexicano",
            "CAD - Dolar Canadiense",
            "EUR - Euro",
            "JPY - Yen Japonés"
            };
            foreach (string moneda in opciones)
            {
                if (!string.IsNullOrEmpty(MonedaInicial) && moneda.StartsWith(MonedaInicial))
                { //aqui use "StartsWith" es una función que encontré en internet que sirve
                  //para comparar las primeras letras de 2 cadenas
                  //(aprovechando que cada opcion empieza con la abreviación)
                    continue;
                }
                chkMonedaSelec.Items.Add(moneda);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(chkMonedaSelec.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una moneda");
                return;
            }
            foreach (var item in chkMonedaSelec.CheckedItems)
            {
                monedaRequerida.Add(item.ToString());
            }
            this.Close();
        }
    }
}
