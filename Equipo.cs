using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraApp
{
    public partial class Equipo : Form
    {
        public Equipo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.StartPosition = FormStartPosition.Manual;
            inicio.Location = new Point(this.Left, this.Top);

            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }
    }
}
