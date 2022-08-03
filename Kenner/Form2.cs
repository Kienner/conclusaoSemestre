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
    public partial class Form2 : Form
    {
        public Form2()
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
            if (Kenner.change >1)
            {
                Kenner.change = Kenner.change - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Kenner.change ==  2)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"img/empresa2.png");

                label1.Text = "               Empresa Ghost Drgon \n\n" +
                    "Somos uma empresa focada no ramo automotivo e distribuição de peças. \n               Requisitos: \n                 -Cursando nivel superior;\n   -Conhecimento em PHP;\n   -inglês;\n               -Conhecimento em PHP;\n                -MySql.\n\n                Bêneficios:\n               -Plano de saúde;\n                -DressCode;\n                -Bolsa salário.";

            }
            else
            {
                if (Kenner.change == 1)
                {
                    pictureBox1.BackgroundImage = Image.FromFile(@"img/empresa1.jpg");

                    label1.Text = "               Empresa Paper \n\n" +
                        "    Somos uma empresa com o foco em oferecer serviços tecnologicos para papelarias  e livrarias. \n               Requisitos: \n                 -Cursando nivel superior;\n                -Conhecimento em PHP;\n                -MySql.\n\n                Bêneficios:\n               -Plano de saúde;\n                -DressCode;\n                -Bolsa salário.";

                }
                else
                {
                    if(Kenner.change == 3)
                {
                        pictureBox1.BackgroundImage = Image.FromFile(@"img/empresa3.jpg");

                        label1.Text = "               Empresa Positive \n\n" +
                            "             Requisitos: \n                 -Cursando nivel superior;\n                -Conhecimento em PHP;\n                -MySql.\n\n                Bêneficios:\n               -Plano de saúde;\n                -DressCode;\n                -Bolsa salário.";

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curriculo enviado com sucesso");
        }
    }
}
