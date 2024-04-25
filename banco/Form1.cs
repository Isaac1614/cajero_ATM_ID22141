using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void agregarnumeros(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (textBox_cuenta.Text == "0") 
            
                textBox_cuenta.Text = "";
                textBox_cuenta.Text += boton.Text;
            
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            textBox_cuenta.Clear();
            textBox_NIP.Clear();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (textBox_cuenta.Text == "12345" && textBox_NIP.Text == "6789")
            {
                MessageBox.Show("Usuario y contraseña correctos");
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos");
            }
        }
    }
}
