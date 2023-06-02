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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblId = new Label();
            lblName = new Label();
            lblModelo = new Label();
            lblQtd = new Label();
            lblValor = new Label();
            btnAdd = new Button();
            txtQuantity = new TextBox();
            txtValue = new TextBox();
            txtName = new TextBox();
            txtModel = new TextBox();
            txtId = new TextBox();
            dgvProdutos = new DataGridView();
            btnDelete = new Button();
            btnAlterar = new Button();
            btnClear = new Button();
            lblCount = new Label();
            cbNacional = new CheckBox();
            rbNovo = new RadioButton();
            rbSeminovo = new RadioButton();
            rbUsado = new RadioButton();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            model = new DataGridViewTextBoxColumn();
            value = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            national = new DataGridViewCheckBoxColumn();
            status = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
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
            btnAdd.Location = new Point(143, 383);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(143, 218);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 6;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(143, 273);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(150, 31);
            txtValue.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 8;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(143, 157);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(150, 31);
            txtModel.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(143, 57);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 10;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AllowUserToResizeColumns = false;
            dgvProdutos.AllowUserToResizeRows = false;
            dgvProdutos.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { id, name, model, value, quantity, national, status, edit, delete });
            dgvProdutos.Location = new Point(316, 45);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersWidth = 62;
            dgvProdutos.RowTemplate.Height = 33;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(1022, 356);
            dgvProdutos.TabIndex = 11;
            dgvProdutos.CellClick += dgvProdutos_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(143, 425);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(143, 467);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(112, 34);
            btnAlterar.TabIndex = 13;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(16, 383);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 118);
            btnClear.TabIndex = 14;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(1280, 416);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(24, 25);
            lblCount.TabIndex = 15;
            lblCount.Text = "...";
            // 
            // cbNacional
            // 
            cbNacional.AutoSize = true;
            cbNacional.Location = new Point(143, 337);
            cbNacional.Name = "cbNacional";
            cbNacional.Size = new Size(106, 29);
            cbNacional.TabIndex = 16;
            cbNacional.Text = "Nacional";
            cbNacional.UseVisualStyleBackColor = true;
            // 
            // rbNovo
            // 
            rbNovo.AutoSize = true;
            rbNovo.Checked = true;
            rbNovo.Location = new Point(339, 416);
            rbNovo.Name = "rbNovo";
            rbNovo.Size = new Size(81, 29);
            rbNovo.TabIndex = 17;
            rbNovo.TabStop = true;
            rbNovo.Text = "Novo";
            rbNovo.UseVisualStyleBackColor = true;
            // 
            // rbSeminovo
            // 
            rbSeminovo.AutoSize = true;
            rbSeminovo.Location = new Point(339, 456);
            rbSeminovo.Name = "rbSeminovo";
            rbSeminovo.Size = new Size(117, 29);
            rbSeminovo.TabIndex = 18;
            rbSeminovo.Text = "Seminovo";
            rbSeminovo.UseVisualStyleBackColor = true;
            // 
            // rbUsado
            // 
            rbUsado.AutoSize = true;
            rbUsado.Location = new Point(339, 491);
            rbUsado.Name = "rbUsado";
            rbUsado.Size = new Size(88, 29);
            rbUsado.TabIndex = 19;
            rbUsado.Text = "Usado";
            rbUsado.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Identificador";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 150;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Nome";
            name.MinimumWidth = 8;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 150;
            // 
            // model
            // 
            model.DataPropertyName = "model";
            model.HeaderText = "Modelo";
            model.MinimumWidth = 8;
            model.Name = "model";
            model.ReadOnly = true;
            model.Width = 150;
            // 
            // value
            // 
            value.DataPropertyName = "value";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            value.DefaultCellStyle = dataGridViewCellStyle1;
            value.HeaderText = "Valor";
            value.MinimumWidth = 8;
            value.Name = "value";
            value.ReadOnly = true;
            value.Width = 150;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            quantity.DefaultCellStyle = dataGridViewCellStyle2;
            quantity.HeaderText = "Quantidade";
            quantity.MinimumWidth = 8;
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 150;
            // 
            // national
            // 
            national.DataPropertyName = "national";
            national.HeaderText = "Nacional";
            national.MinimumWidth = 8;
            national.Name = "national";
            national.ReadOnly = true;
            national.Width = 150;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Status";
            status.MinimumWidth = 8;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 150;
            // 
            // edit
            // 
            edit.HeaderText = "Edição";
            edit.MinimumWidth = 8;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Editar";
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 150;
            // 
            // delete
            // 
            delete.HeaderText = "Exclusão";
            delete.MinimumWidth = 8;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "Excluir";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 150;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 536);
            Controls.Add(rbUsado);
            Controls.Add(rbSeminovo);
            Controls.Add(rbNovo);
            Controls.Add(cbNacional);
            Controls.Add(lblCount);
            Controls.Add(btnClear);
            Controls.Add(btnAlterar);
            Controls.Add(btnDelete);
            Controls.Add(dgvProdutos);
            Controls.Add(txtId);
            Controls.Add(txtModel);
            Controls.Add(txtName);
            Controls.Add(txtValue);
            Controls.Add(txtQuantity);
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
        private TextBox txtQuantity;
        private TextBox txtValue;
        private TextBox txtName;
        private TextBox txtModel;
        private TextBox txtId;
        private DataGridView dgvProdutos;
        private Button btnDelete;
        private Button btnAlterar;
        private Button btnClear;
        private Label lblCount;
        private CheckBox cbNacional;
        private RadioButton rbNovo;
        private RadioButton rbSeminovo;
        private RadioButton rbUsado;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn model;
        private DataGridViewTextBoxColumn value;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewCheckBoxColumn national;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}