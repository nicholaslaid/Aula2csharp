namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            product product = new product();
            
            product.name= textBox3.Text;
            product.model= textBox4.Text;
            product.quantity = Convert.ToInt32(textBox1.Text);
            product.value = float.Parse(textBox2.Text);


            bool response = product.Add(product);


            if (!response)
                MessageBox.Show("Erro ao tentar gravar o produto");
            
        }
    }
}