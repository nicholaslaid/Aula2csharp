using System.Diagnostics.Eventing.Reader;

namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            product product = new product();

            product.name = txtName.Text;
            product.model = txtModel.Text;
            product.quantity = Convert.ToInt32(txtQuantity.Text);
            product.value = float.Parse(txtValue.Text);


            bool response = product.Add(product);


            if (!response)
            {
                MessageBox.Show("Erro ao tentar gravar o produto");

            }
            else
            {
                LoadProducts();
                ClearForm();
            }

        }

        private void LoadProducts()
        {
            product product = new product();
            dgvProdutos.DataSource = product.GetALL();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtModel.Clear();
            txtQuantity.Clear();
            txtValue.Clear();
            txtId.Clear();

            txtName.Focus();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                product producto = new product();

                int id = Convert.ToInt32(
                    dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value);

                producto = producto.Get(id);

                txtId.Text = producto.id.ToString();
                txtName.Text = producto.name.ToString();
                txtModel.Text = producto.model.ToString();
                txtQuantity.Text = producto.quantity.ToString();
                txtValue.Text = producto.value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar carregar os dados do produto");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Confirma exclusão?", "Excluir",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    product product = new product();
                    int id = Convert.ToInt32(txtId.Text);
                    bool response = product.Delete(id);

                    if (!response)
                    {
                        MessageBox.Show("Erro ao tentar excluir");
                    }
                    else
                    {
                        LoadProducts();
                    }
                }
            }
            catch (Exception)
            {


            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Confirma alteração?", "Alterar",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    product product = new product();


                    product.id = Convert.ToInt32(txtId.Text);
                    product.name = txtName.Text;
                    product.model = txtModel.Text;
                    product.quantity = Convert.ToInt32(txtQuantity.Text);
                    product.value = float.Parse(txtValue.Text);


                    bool response = product.Update(product);

                    if (!response)
                    {
                        MessageBox.Show("Erro ao tentar alterar");
                    }
                    else
                    {
                        LoadProducts();
                    }
                }
            }
            catch (Exception)
            {


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }


}