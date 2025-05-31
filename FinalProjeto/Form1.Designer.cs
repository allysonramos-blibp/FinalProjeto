namespace FinalProjeto
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
            ID = new Label();
            ID_Produto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Preco_Unitario = new TextBox();
            Categoria = new TextBox();
            Descricao = new TextBox();
            Nome = new TextBox();
            Nivel_Estoque = new TextBox();
            bntSalvar = new Button();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            bntExcluir = new Button();
            bntAlterar = new Button();
            btnTestarConexao = new Button();
            dataGridView1 = new DataGridView();
            bntBuscar = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.Location = new Point(0, 0);
            ID.Name = "ID";
            ID.Size = new Size(100, 23);
            ID.TabIndex = 29;
            // 
            // ID_Produto
            // 
            ID_Produto.Font = new Font("Microsoft Sans Serif", 9.2F, FontStyle.Bold);
            ID_Produto.ForeColor = SystemColors.AppWorkspace;
            ID_Produto.Location = new Point(52, 113);
            ID_Produto.Name = "ID_Produto";
            ID_Produto.Size = new Size(330, 25);
            ID_Produto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            label2.Location = new Point(52, 185);
            label2.Name = "label2";
            label2.Size = new Size(181, 24);
            label2.TabIndex = 4;
            label2.Text = "Nome do Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            label3.Location = new Point(880, 341);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 5;
            label3.Text = "Descrição:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            label4.Location = new Point(880, 145);
            label4.Name = "label4";
            label4.Size = new Size(153, 24);
            label4.TabIndex = 6;
            label4.Text = "Preco_Unitario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            label5.Location = new Point(52, 420);
            label5.Name = "label5";
            label5.Size = new Size(151, 24);
            label5.TabIndex = 7;
            label5.Text = "Nivel_Estoque:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            label6.Location = new Point(52, 341);
            label6.Name = "label6";
            label6.Size = new Size(105, 24);
            label6.TabIndex = 8;
            label6.Text = "Categoria:";
            // 
            // Preco_Unitario
            // 
            Preco_Unitario.Font = new Font("Microsoft Sans Serif", 9.2F, FontStyle.Bold);
            Preco_Unitario.ForeColor = Color.DarkGray;
            Preco_Unitario.Location = new Point(880, 184);
            Preco_Unitario.Name = "Preco_Unitario";
            Preco_Unitario.Size = new Size(339, 25);
            Preco_Unitario.TabIndex = 9;
            // 
            // Categoria
            // 
            Categoria.Font = new Font("Microsoft Sans Serif", 9.2F, FontStyle.Bold);
            Categoria.ForeColor = SystemColors.AppWorkspace;
            Categoria.Location = new Point(52, 368);
            Categoria.Name = "Categoria";
            Categoria.Size = new Size(279, 25);
            Categoria.TabIndex = 10;
            // 
            // Descricao
            // 
            Descricao.Font = new Font("Microsoft Sans Serif", 9.2F, FontStyle.Bold);
            Descricao.ForeColor = Color.DarkGray;
            Descricao.Location = new Point(880, 399);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(360, 25);
            Descricao.TabIndex = 11;
            // 
            // Nome
            // 
            Nome.Font = new Font("Microsoft Sans Serif", 9.2F, FontStyle.Bold);
            Nome.ForeColor = Color.DarkGray;
            Nome.Location = new Point(52, 212);
            Nome.Name = "Nome";
            Nome.Size = new Size(326, 25);
            Nome.TabIndex = 12;
            // 
            // Nivel_Estoque
            // 
            Nivel_Estoque.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            Nivel_Estoque.Location = new Point(52, 462);
            Nivel_Estoque.Name = "Nivel_Estoque";
            Nivel_Estoque.Size = new Size(279, 29);
            Nivel_Estoque.TabIndex = 13;
            // 
            // bntSalvar
            // 
            bntSalvar.BackColor = SystemColors.GradientActiveCaption;
            bntSalvar.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            bntSalvar.Location = new Point(836, 532);
            bntSalvar.Name = "bntSalvar";
            bntSalvar.Size = new Size(99, 44);
            bntSalvar.TabIndex = 14;
            bntSalvar.Text = "Salvar";
            bntSalvar.UseVisualStyleBackColor = false;
            bntSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 28;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(52, 284);
            label8.Name = "label8";
            label8.Size = new Size(272, 24);
            label8.TabIndex = 21;
            label8.Text = "🏷️ Categorização e Estoque";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(970, 68);
            label9.Name = "label9";
            label9.Size = new Size(152, 24);
            label9.TabIndex = 22;
            label9.Text = "💰 Precificação";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(871, 284);
            label10.Name = "label10";
            label10.Size = new Size(222, 24);
            label10.TabIndex = 23;
            label10.Text = "📝 Detalhes Adicionais";
            // 
            // bntExcluir
            // 
            bntExcluir.BackColor = SystemColors.GradientActiveCaption;
            bntExcluir.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            bntExcluir.Location = new Point(523, 532);
            bntExcluir.Name = "bntExcluir";
            bntExcluir.Size = new Size(107, 44);
            bntExcluir.TabIndex = 25;
            bntExcluir.Text = "Excluir";
            bntExcluir.UseVisualStyleBackColor = false;
            bntExcluir.Click += btnExcluir_Click;
            // 
            // bntAlterar
            // 
            bntAlterar.BackColor = SystemColors.GradientActiveCaption;
            bntAlterar.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            bntAlterar.Location = new Point(676, 532);
            bntAlterar.Name = "bntAlterar";
            bntAlterar.Size = new Size(105, 44);
            bntAlterar.TabIndex = 26;
            bntAlterar.Text = "Alterar";
            bntAlterar.UseVisualStyleBackColor = false;
            bntAlterar.Click += btnAlterar_Click;
            // 
            // btnTestarConexao
            // 
            btnTestarConexao.BackColor = SystemColors.GradientActiveCaption;
            btnTestarConexao.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            btnTestarConexao.Location = new Point(1023, 532);
            btnTestarConexao.Name = "btnTestarConexao";
            btnTestarConexao.Size = new Size(99, 44);
            btnTestarConexao.TabIndex = 30;
            btnTestarConexao.Text = "Teste";
            btnTestarConexao.UseVisualStyleBackColor = false;
            btnTestarConexao.Click += btnTestarConexao_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(429, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(410, 423);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bntBuscar
            // 
            bntBuscar.BackColor = SystemColors.GradientActiveCaption;
            bntBuscar.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            bntBuscar.Location = new Point(353, 532);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(110, 44);
            bntBuscar.TabIndex = 24;
            bntBuscar.Text = "btnBuscar";
            bntBuscar.UseVisualStyleBackColor = false;
            bntBuscar.Click += btnBuscar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11.2F, FontStyle.Bold);
            label11.Location = new Point(52, 68);
            label11.Name = "label11";
            label11.Size = new Size(144, 24);
            label11.TabIndex = 32;
            label11.Text = "ID do Produto:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 588);
            Controls.Add(label11);
            Controls.Add(dataGridView1);
            Controls.Add(btnTestarConexao);
            Controls.Add(bntAlterar);
            Controls.Add(bntExcluir);
            Controls.Add(bntBuscar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(Preco_Unitario);
            Controls.Add(label5);
            Controls.Add(bntSalvar);
            Controls.Add(label2);
            Controls.Add(ID_Produto);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(Descricao);
            Controls.Add(Nome);
            Controls.Add(Nivel_Estoque);
            Controls.Add(ID);
            Controls.Add(Categoria);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Cadastro de Produtos";
            Click += btnBuscar_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ID;
        private TextBox ID_Produto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Preco_Unitario;
        private TextBox Categoria;
        private TextBox Descricao;
        private TextBox Nome;
        private TextBox Nivel_Estoque;
        private Button bntSalvar;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button bntExcluir;
        private Button bntAlterar;
        private Button btnTestarConexao;
        private DataGridView dataGridView1;
        private Button bntBuscar;
        private Label label11;
    }
}

    
