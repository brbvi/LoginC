using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace LoginC {
    public partial class FrmRegistro : Form {
        //Referencia da conexão
        SqlConnection Conexao = new SqlConnection("Data Source=DESKTOP-80QOQ43;Initial Catalog=LoginC;Integrated Security=True");
        SqlCommand reg;
        public FrmRegistro() {
            InitializeComponent();
            txtUsernameReg.Select();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void btnEnviarReg_Click(object sender, EventArgs e) {
            Conexao.Open();

            // Verificação input vazios
            if (txtUsernameReg.Text == "" && txtPasswordReg.Text == "") { 
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsernameReg.Select();
            } else {
                string query = "SELECT * FROM Usuario WHERE Username = '" + txtUsernameReg.Text + "' AND Password = '" + txtPasswordReg.Text + "' ";
                SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                if (dt.Rows.Count != 0) {
                    MessageBox.Show("Usuario já registrado tente novamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsernameReg.Text = ""; // Resetando input usuário 
                    txtPasswordReg.Text = ""; // Resetando input password
                    txtUsernameReg.Select();
                } else {
                    we login = new we();
                    reg = new SqlCommand("INSERT INTO Usuario VALUES ('" + txtUsernameReg.Text + "', '" + txtPasswordReg.Text + "')", Conexao);
                    reg.ExecuteNonQuery();
                    MessageBox.Show("Usuario criado com sucesso");
                    this.Hide();
                    login.Show();
                    Conexao.Close();
                }                
            } 
            Conexao.Close();

        }
    }
}
