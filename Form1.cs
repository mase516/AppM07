namespace PrimeraApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(this.Left, this.Top);

            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
