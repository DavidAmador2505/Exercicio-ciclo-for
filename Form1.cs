using System.Windows.Forms;

namespace Exercicio_ciclo_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.OrangeRed;
            this.ForeColor = Color.White;
            this.Text = "Página Principal";
            Btn_For.BackColor = Color.Black;
            button1.BackColor = Color.Black;    
        }

        private void Btn_For_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 0; i <= 1000; i++)
            {
                soma += i;

            }

            MessageBox.Show("O resultado da soma de 0 a 1000:" + soma);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox1.Text);
            int soma = 0;

            for (int i = 0; i <= num; i++)
            {
                soma += i;
            }
            MessageBox.Show("Soma de 0 - "+num+": " + soma);
            
        }
    }

}