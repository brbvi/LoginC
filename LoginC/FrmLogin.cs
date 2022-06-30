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
    public partial class we : Form {
        //Referencia da conexão
        SqlConnection Conexao = new SqlConnection("Data Source=DESKTOP-80QOQ43;Initial Catalog=LoginC;Integrated Security=True");

        public we() {
            InitializeComponent();
            txtUsuario.Select();
        }



        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void FrmLogin_Load(object sender, EventArgs e) {

        }

       

        /*
          void verificar() {
            if (txtUsuario.Text == "" && txtPassword.Text == "") {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Select();
           }
        }
         try {
                if (dt.Rows.Count == 1) {
                    FrmPrincipal principal = new FrmPrincipal();
                    this.Hide();
                    principal.Show();
                    Conexao.Close(); // Fechar a conexão
                }
            } catch (Exception erro) {
                MessageBox.Show("Usuário ou Password incorretos" + erro);
                txtUsuario.Text = ""; // Resetando input usuário 
                txtPassword.Text = ""; // Resetando input password
                txtUsuario.Select(); // Cursor irá sinalizar o primeiro input                
            }
            Conexao.Close();//Fechar conexão
         */

        // Botão Entrar
        private void btnEntrar_Click(object sender, EventArgs e) {
            Conexao.Open(); // Abrir conexão

            // Verificação para inputs vazios
            if (txtUsuario.Text == "" && txtPassword.Text == "") {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Select();
            } else {
                string query = "SELECT * FROM Usuario WHERE Username = '" + txtUsuario.Text + "' AND Password = '" + txtPassword.Text + "' ";
                SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                if (dt.Rows.Count == 1) {
                    FrmPrincipal principal = new FrmPrincipal();
                    this.Hide();
                    principal.Show();
                    Conexao.Close(); // Fechar a conexão
                } else {
                    MessageBox.Show("Usuário ou Password incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Text = ""; // Resetando input usuário 
                    txtPassword.Text = ""; // Resetando input password
                    txtUsuario.Select(); // Cursor irá sinalizar o primeiro input 
                }
                
            }
            Conexao.Close();
        }

        //Botão Sair
        private void btnSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {
            FrmRegistro registro = new FrmRegistro();
            this.Hide();
            registro.Show();
            Conexao.Close(); // Fechar a conexão
        }
    }
}
