using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kenner
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Kenner.change <= 3)
            {
                Kenner.change = Kenner.change + 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Kenner.change > 1)
            {
                Kenner.change = Kenner.change - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Kenner.change == 2)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"img/foto_de_perfil.jpg");

                label1.Text = "               Nicolas \n\n" +
                    "O manso \n               Qualidades: \n                 -Cursando nivel superior;\n                -Conhecimento em PHP;\n                -MySql.\n\n                Exigências:\n               -Plano de saúde;\n                -DressCode;\n                -Bolsa salário.";

            }
            else
            {
                if (Kenner.change == 1)
                {
                    pictureBox1.BackgroundImage = Image.FromFile(@"img/IMG-20210701-WA0001.jpg");

                    label1.Text = "               Eduardo MADEIRA Migliori \n\n" +
                        "    O mago. \n               Qualidades: \n                 -Solteiro;\n                 -Cursando nivel superior;\n                -Conhecimento em PHP;\n                -MySql.\n\n                Exigências:\n               -Plano de saúde;\n                -DressCode;\n                -Bolsa salário.";

                }
                else
                {
                    if (Kenner.change == 3)
                    {
                        pictureBox1.BackgroundImage = Image.FromFile(@"img/programador3.jpg");

                        label1.Text = "               Kenner \n\n" +
                            "    Kenner \n               Kenner: \n                 -Cursando nivel superior;\n                -Conhecimento em PHP;\n                -MySql.\n\n                Kenner:\n               -Plano de saúde;\n                -DressCode;\n                -Bolsa salário.";

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programador marcado com sucesso");

        }
    }
}
