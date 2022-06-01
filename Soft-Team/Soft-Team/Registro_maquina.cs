using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Team
{
    public partial class Registro_maquina : Form
    {
        public Registro_maquina()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_cosechadora aco = new Agregar_cosechadora();
            aco.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Agregar_tractor atr = new Agregar_tractor();
            atr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar_alzadora aal = new Agregar_alzadora();
            aal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agregar_tractocamion atc = new Agregar_tractocamion();
            atc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Agregar_camion aca = new Agregar_camion();
            aca.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Agregar_vehiculo_liviano avl = new Agregar_vehiculo_liviano();
            avl.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Agregar_motocicleta am = new Agregar_motocicleta();
            am.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registro_maquina_Load(object sender, EventArgs e)
        {

        }
    }
}
