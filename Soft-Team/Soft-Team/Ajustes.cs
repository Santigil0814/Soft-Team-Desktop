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
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Ajustes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);

            labelUsuario.Text = General.UsuUsuario;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(General.UsuUsuario))
            {
                MessageBox.Show("Por favor, seleccione un registro", "Alerta");
            }
            else
            {
                CambiarContrasena Cc = new CambiarContrasena();
                Cc.ShowDialog();
                this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);
                General.UsuUsuario = string.Empty;
            }
            
        }
    }
}
