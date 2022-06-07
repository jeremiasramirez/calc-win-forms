using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica02
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            operacion.SelectedIndex = 0;
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            if (operacion.SelectedIndex == 0 || operacion.SelectedIndex == 1 || operacion.SelectedIndex == 2 || operacion.SelectedIndex == 3)
            {
    
                
           
            
            try
            {
                if (operacion.SelectedIndex == 0) resultado.Text = (double.Parse(txtValor1.Text) + double.Parse(txtValor2.Text)).ToString();

                if (operacion.SelectedIndex == 1) resultado.Text = (double.Parse(txtValor1.Text) - double.Parse(txtValor2.Text)).ToString();

                if (operacion.SelectedIndex == 2) resultado.Text = (double.Parse(txtValor1.Text) * double.Parse(txtValor2.Text)).ToString();

                if (operacion.SelectedIndex == 3) resultado.Text = (double.Parse(txtValor1.Text) / double.Parse(txtValor2.Text)).ToString();
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operacion", "Formato incorrecto");
            }
           }
            else { operacion.SelectedIndex = 0; }
        }

        private void operacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
