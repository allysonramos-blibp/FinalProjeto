using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace FinalProjeto
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "Data Source=ALLYSON\\SQLSERVER;Initial Catalog=ProjetoFinal;Integrated Security=True";
        private string strSql = string.Empty;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(strCon);
                builder.TrustServerCertificate = true;
                string updatedConnectionString = builder.ConnectionString;

                using (SqlConnection conn = new SqlConnection(updatedConnectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Produtos"; 

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Erro SQL: {sqlEx.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }






        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ID_Produto.Text))
            {
                MessageBox.Show("Selecione algum registro para alterar.");
                return;
            }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(strCon);
            builder.TrustServerCertificate = true;
            string updatedConnectionString = builder.ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(updatedConnectionString))
            {
                strSql = @"UPDATE Produtos 
                   SET Nome = @Nome, 
                       Descricao = @Descricao, 
                       Categoria = @Categoria, 
                       Preco_Unitario = @Preco_Unitario, 
                       Nivel_Estoque = @Nivel_Estoque
                   WHERE ID_Produto = @ID_Produto";

                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@ID_Produto", SqlDbType.Int).Value = int.Parse(ID_Produto.Text);
                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome.Text;
                comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = Descricao.Text;
                comando.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = Categoria.Text;
                comando.Parameters.Add("@Preco_Unitario", SqlDbType.Decimal).Value = decimal.Parse(Preco_Unitario.Text);
                comando.Parameters.Add("@Nivel_Estoque", SqlDbType.Int).Value = int.Parse(Nivel_Estoque.Text);

                try
                {
                    sqlCon.Open();
                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("!Parabens, Registro alterado com sucesso!");
                        btnBuscar_Click(null, null); // Atualiza  DataGridView1
                    }
                    else
                    {
                        MessageBox.Show("Registro sem alteração.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao alterar: {ex.Message}");
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Supondo que a coluna do ID se chama "ID_Produto"
                int idProduto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Produto"].Value);

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(strCon);
                builder.TrustServerCertificate = true;
                string updatedConnectionString = builder.ConnectionString;

                using (SqlConnection conn = new SqlConnection(updatedConnectionString))
                {
                    string query = "DELETE FROM Produtos WHERE ID_Produto = @ID_Produto";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID_Produto", SqlDbType.Int).Value = idProduto;

                        try
                        {
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registro excluído com sucesso!");
                                btnBuscar_Click(null, null); 
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro foi excluído.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir.");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(strCon);
            builder.TrustServerCertificate = true;
            string updatedConnectionString = builder.ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(updatedConnectionString))
            {

                strSql = "INSERT INTO Produtos (ID_Produto, Nome, Descricao, Categoria, Preco_Unitario, Nivel_Estoque) values (@ID_Produto,@nome, @Descricao,@Categoria,@Preco_Unitario, @Nivel_Estoque)";
                //sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@ID_Produto", SqlDbType.Int).Value = int.Parse(ID_Produto.Text);
                comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = Nome.Text;
                comando.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = Descricao.Text;
                comando.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = Categoria.Text;
                comando.Parameters.Add("@Preco_Unitario", SqlDbType.Decimal).Value = decimal.Parse(Preco_Unitario.Text);
                comando.Parameters.Add("@Nivel_Estoque", SqlDbType.Int).Value = int.Parse(Nivel_Estoque.Text);

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    sqlCon.Close();
                }
            }

            
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=ALLYSON\\SQLSERVER;Initial Catalog=ProjetoFinal;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                    builder.TrustServerCertificate = true;
                    connectionString = builder.ConnectionString;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        MessageBox.Show("Conexão bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                       
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Supondo que você tenha TextBoxes chamados ID_Produto, Nome, Descricao, Categoria, Preco_Unitario, Nivel_Estoque
                ID_Produto.Text = row.Cells["ID_Produto"].Value?.ToString();
                Nome.Text = row.Cells["Nome"].Value?.ToString();
                Descricao.Text = row.Cells["Descricao"].Value?.ToString();
                Categoria.Text = row.Cells["Categoria"].Value?.ToString();
                Preco_Unitario.Text = row.Cells["Preco_Unitario"].Value?.ToString();
                Nivel_Estoque.Text = row.Cells["Nivel_Estoque"].Value?.ToString();
            }
        }
    }
}