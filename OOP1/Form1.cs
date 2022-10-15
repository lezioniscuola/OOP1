namespace OOP1
{
    public partial class Form1 : Form
    {
        private Classe c;
        public Form1()
        {
            InitializeComponent();
            c=new Classe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.numero = int.Parse(textBox1.Text);
            //c.setNumero(int.Parse(textBox1.Text));
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = c.numero.ToString();//c.getNumero().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}