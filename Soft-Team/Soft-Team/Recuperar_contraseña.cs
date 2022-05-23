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
    public partial class Recuperar_contraseña : Form
    {
        public Recuperar_contraseña()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void Recuperar_contraseña_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.correoTextBox.Text))
            {
                MessageBox.Show("Por favor, digite su correo", "Alerta");
                this.correoTextBox.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty((string)this.usuarioTableAdapter.LlamarPorCorreo(this.correoTextBox.Text)))
                {
                    MessageBox.Show("El correo no se encuentra registrado.", "Alerta");
                    this.correoTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Se ha enviado su contraseña al correo digitado.", "Alerta");
                    this.correoTextBox.Text = string.Empty;
                }
            }
        }
    }
}
