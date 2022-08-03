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
    public partial class load : Form
    {
        //cria conexão
        MySqlConnection mConn = new MySqlConnection(
           "Persist Security Info = False;" +
           "server = localhost;" +
           "database = login;" +
           "uid = root;" +
           "pwd ="

         );

        int idSelecionado = -1;

        Thread nt;

        public load()
        {
            InitializeComponent();
        }

        //
        private void load_Load(object sender, EventArgs e)
        {
            try
            {
                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    dtgLoad.ColumnCount = 3;

                    dtgLoad.Columns[0].Width = 39;
                    dtgLoad.Columns[0].Name = "#";

                    dtgLoad.Columns[1].Width = 130;
                    dtgLoad.Columns[1].Name = "Usuário";

                    dtgLoad.Columns[2].Width = 130;
                    dtgLoad.Columns[2].Name = "Tipo";


                    MySqlCommand comandoSQL = mConn.CreateCommand();

                    comandoSQL.CommandText = "SELECT id, usuario, tipo FROM contas";

                    comandoSQL.Connection = mConn;

                    MySqlDataReader dadosJog = comandoSQL.ExecuteReader();

                    string[] linha;

                    while (dadosJog.Read())
                    {
                        linha = new string[]
                        {
                            dadosJog["id"].ToString(),
                            dadosJog["usuario"].ToString(),
                            dadosJog["tipo"].ToString(),
                        };

                        dtgLoad.Rows.Add(linha);

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
        }

        //
        private void dtgLoad_Click(object sender, EventArgs e)
        {
            int linha = dtgLoad.CurrentRow.Index;

            int coluna = 0;

            idSelecionado = Convert.ToInt32(dtgLoad.Rows[linha].Cells[coluna].Value.ToString());

            Kenner.idSelecionado = idSelecionado;
        }

        //
        private void button1_Click(object sender, EventArgs e)
        {
            if (Kenner.idSelecionado >= 0)
            {
                login frmCon = new login(idSelecionado);

                button2.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(login);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void login()
        {
            Application.Run(new login(idSelecionado));
        }


        //

    }
}
