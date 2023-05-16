namespace Aula2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblName = new Label();
            lblModelo = new Label();
            lblQtd = new Label();
            lblValor = new Label();
            btnAdd = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(54, 60);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 25);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(54, 105);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(54, 157);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(74, 25);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo";
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(23, 218);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(105, 25);
            lblQtd.TabIndex = 3;
            lblQtd.Text = "Quantidade";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(54, 273);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(52, 25);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(158, 362);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 273);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 157);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 57);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 10;
            // 
            // dgvProdutos
            // 
            dgvProdutos.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(374, 40);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 62;
            dgvProdutos.RowTemplate.Height = 33;
            dgvProdutos.Size = new Size(652, 356);
            dgvProdutos.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnAdd);
            Controls.Add(lblValor);
            Controls.Add(lblQtd);
            Controls.Add(lblModelo);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblModelo;
        private Label lblQtd;
        private Label lblValor;
        private Button btnAdd;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridView dgvProdutos;
    }
}