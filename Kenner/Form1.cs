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

namespace Kenner
{
    public partial class cadastrar : Form
    {
        //cria conexão
        MySqlConnection mConn = new MySqlConnection(
           "Persist Security Info = False;" +
           "server = localhost;" +
           "database = login;" +
           "uid = root;" +
           "pwd ="

         );

        public cadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mConn.Open();


                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comandoSQL = new MySqlCommand();

                    comandoSQL.CommandText = $"INSERT INTO contas (usuario ,senha, tipo) VALUES" +
                        "('" + textBox1.Text + "','"
                        + textBox2.Text + "','"
                        + comboBox1.Text + "')";


                    comandoSQL.Connection = mConn;

                    comandoSQL.ExecuteNonQuery();

                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.Text = "";

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            load load = new load();
            load.ShowDialog();
        }
    }
}
