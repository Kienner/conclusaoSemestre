using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Kenner
{
    public partial class login : Form
    {
        //cria conexão
        MySqlConnection mConn = new MySqlConnection(
           "Persist Security Info = False;" +
           "server = localhost;" +
           "database = login;" +
           "uid = root;" +
           "pwd ="

         );

        Thread nt;

        string senha;
        string tipo;
        string senhaDig;
        

        public login(int ID)
        {
            InitializeComponent();

            ID = Kenner.idSelecionado;

            //seleciona dados do banco
            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comandoSQL = mConn.CreateCommand();

                    comandoSQL.CommandText = "SELECT * FROM contas WHERE id=" + ID;
                    comandoSQL.Connection = mConn;

                    MySqlDataReader linha = comandoSQL.ExecuteReader();

                    //recebe dados do BD
                    if (linha.Read())
                    {
                        textBox1.Text = linha["usuario"].ToString();
                        senha = linha["senha"].ToString();
                        tipo = linha["tipo"].ToString();
                    }

                    mConn.Close();


                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro detectado, entre em contato com Dev.\n\n" + erro.Message,
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            mConn.Close();

            Kenner.idSelecionado = ID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //recebe senha digitada
            senhaDig = textBox2.Text;

            //caso seja perfil de programador
            if (tipo == "Programador")
            {
                if (senha.CompareTo(senhaDig) == 0)
                {
                    

                    button1.PerformClick();
                }
                else
                {
                    MessageBox.Show("Senha incorreta, tente novamente");
                }
            }
            //caso seja perfil de empresa
            else
            {
                if (tipo == "Empresa")
                {
                    if (senha.CompareTo(senhaDig) == 0)
                    {
                        
                        button3.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta, tente novamente");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(Form2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Form2()
        {
            Application.Run(new Form2());
        }
        
        //
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(Form3);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void Form3()
        {
            Application.Run(new Form3());
        }

        private void login_Load(object sender, EventArgs e)
        {
          
        }


       
    }
}
