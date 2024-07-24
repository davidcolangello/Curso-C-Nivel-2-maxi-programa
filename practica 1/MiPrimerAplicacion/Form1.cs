using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void VentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
             MessageBox.Show("Chau chau ...");
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.BackColor = Color.Red;

            if (textBox2.Text == "")
                textBox2.BackColor = Color.Red;

            if (textBox3.Text == "")
                textBox3.BackColor = Color.Red;

            if (textBox4.Text == "")
                textBox4.BackColor = Color.Red;

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            { textBox1.BackColor = Color.White;
              textBox2.BackColor = Color.White;
              textBox3.BackColor = Color.White;
              textBox4.BackColor = Color.White;
            

              textBox5.Text = "Apellido y Nombre: " + textBox1.Text + " " + textBox2.Text + "\r\n" + "Edad: " + textBox3.Text + "\r\n" + "Direccion:  " + textBox4.Text;
              
             
            }











        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
