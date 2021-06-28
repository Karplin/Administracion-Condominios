using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINAL
{
    public partial class general : Form
    {
        public general()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formucondomines mantenimiento = new formucondomines();
            mantenimiento.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultar consultas = new consultar();
            consultas.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cuota pago = new cuota();
            pago.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reclamaciones reclama = new reclamaciones();
            reclama.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }
    }
}
