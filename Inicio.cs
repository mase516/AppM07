using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void rankingToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Ranking ranking = new Ranking();
            ranking.StartPosition = FormStartPosition.Manual;
            ranking.Location = new Point(this.Left, this.Top);

            this.Hide();
            ranking.ShowDialog();
            this.Close();
        }

        private void ligasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Ligas ligas = new Ligas();
            ligas.StartPosition = FormStartPosition.Manual;
            ligas.Location = new Point(this.Left, this.Top);

            this.Hide();
            ligas.ShowDialog();
            this.Close();
        }

        private void españolToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");
            this.Hide();
            Inicio f1 = new Inicio();
            f1.StartPosition = FormStartPosition.Manual;
            f1.ShowDialog();
        }
        private void Menu_Opening(object sender, CancelEventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void catalanToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ca");
            this.Hide();
            Inicio f1 = new Inicio();
            f1.StartPosition = FormStartPosition.Manual;
            f1.ShowDialog();
        }

        private void inglesToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            this.Hide();
            Inicio f1 = new Inicio();
            f1.StartPosition = FormStartPosition.Manual;
            f1.ShowDialog();
        }

        private void italianoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("it");
            this.Hide();
            Inicio f1 = new Inicio();
            f1.StartPosition = FormStartPosition.Manual;
            f1.ShowDialog();
        }

        private void alemanToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");
            this.Hide();
            Inicio f1 = new Inicio();
            f1.StartPosition = FormStartPosition.Manual;
            f1.ShowDialog();
        }

        private void mercadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mercado mercado = new Mercado();
            mercado.StartPosition = FormStartPosition.Manual;
            mercado.Location = new Point(this.Left, this.Top);

            this.Hide();
            mercado.ShowDialog();
            this.Close();
        }

        private void miEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.StartPosition = FormStartPosition.Manual;
            equipo.Location = new Point(this.Left, this.Top);

            this.Hide();
            equipo.ShowDialog();
            this.Close();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultados resultados = new Resultados();
            resultados.StartPosition = FormStartPosition.Manual;
            resultados.Location = new Point(this.Left, this.Top);

            this.Hide();
            resultados.ShowDialog();
            this.Close();
        }
    }
}
