using System.Diagnostics.Eventing.Reader;

namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            CountProducts();
        }


        #region Eventos

        private void btnAdd_Click(object sender, EventArgs e)
        {

            product product = new product();

            product.name = txtName.Text;
            product.model = txtModel.Text;
            product.quantity = Convert.ToInt32(txtQuantity.Text);
            product.value = float.Parse(txtValue.Text);
            product.national = Convert.ToBoolean(cbNacional.Checked);


            bool response = product.Add(product);


            if (!response)
            {
                MessageBox.Show("Erro ao tentar gravar o produto");

            }
            else
            {
                LoadProducts();
                ClearForm();
                CountProducts();
            }

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                product producto = new product();

                int id = Convert.ToInt32(
                    dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells["id"].Value);

                if (e.ColumnIndex == dgvProdutos.Columns["edit"].Index)
                {

                    producto = producto.Get(id);

                    txtId.Text = producto.id.ToString();
                    txtName.Text = producto.name.ToString();
                    txtModel.Text = producto.model.ToString();
                    txtQuantity.Text = producto.quantity.ToString();
                    txtValue.Text = producto.value.ToString();

                }
                else if (e.ColumnIndex == dgvProdutos.Columns["delete"].Index)
                {

                    DialogResult dialog = MessageBox.Show("Confirma exclusão?", "Excluir",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {


                        bool response = producto.Delete(id);

                        if (!response)
                        {
                            MessageBox.Show("Erro ao tentar excluir");
                        }
                        else
                        {
                            LoadProducts();
                            CountProducts();
                        }


                    }

                }

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
                        CountProducts();
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



        #endregion

        #region Métodos Privados

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


        private void CountProducts()
        {
            product producto = new product();
            lblCount.Text = producto.Count().ToString();
        }

        #endregion

        #region Exemplo

        private void ExemploConversa()
        {
            string valorEntrada = "";

            //Valores inteiros
            short leituraShort = Convert.ToInt16(valorEntrada);
            int leituraInt = Convert.ToInt32(valorEntrada);
            long leituraLong = Convert.ToInt64(valorEntrada);

            //valores decimais
            float leituraFloat = float.Parse(valorEntrada);
            double leituraDouble = double.Parse(valorEntrada);

            //Boolean
            bool leituraBool = Convert.ToBoolean(valorEntrada);

            //Data, hora, data e hora
            DateTime leituraDateTime = Convert.ToDateTime(valorEntrada);
        }

        #endregion





    }


}