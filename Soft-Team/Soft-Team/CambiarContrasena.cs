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
    public partial class CambiarContrasena : Form
    {
        public CambiarContrasena()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtContrasena.Text))
            {
                MessageBox.Show("Por favor, digite su contraseña", "Alerta");
                this.TxtContrasena.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.TxtNuevaContra.Text))
                {
                    MessageBox.Show("Por favor, digite su nueva contraseña", "Alerta");
                    this.TxtNuevaContra.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.TxtRepetirContra.Text))
                    {
                        MessageBox.Show("Por favor, repita su nueva contraseña", "Alerta");
                        this.TxtRepetirContra.Focus();
                    }
                    else
                    {
                        if (this.TxtContrasena.Text == Encriptar.descencriptar1(this.usuarioTableAdapter.TraerContrasena(this.TxtContrasena.Text)))
                        {
                            if (this.TxtRepetirContra.Text == this.TxtNuevaContra.Text)
                            {
                                try
                                {
                                    this.TxtRepetirContra.Text = Encriptar.encriptar1(this.TxtRepetirContra.Text);
                                    usuarioTableAdapter.CambiarContra(
                                        this.labelUsuario.Text,
                                        this.TxtRepetirContra.Text
                                        );
                                    MessageBox.Show("Registro actualizado", "Notificación");
                                    this.Close();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("El registro no se puede actualizar", "Alerta");
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Las contraseñas no coinciden", "Alerta");
                                this.TxtNuevaContra.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña actual es incorrecta. Por favor, verifique la contraseña", "Error");
                            this.TxtContrasena.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void CambiarContrasena_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);
            this.TxtRepetirContra.Text = Encriptar.descencriptar1(this.TxtRepetirContra.Text);

            labelUsuario.Text = General.UsuUsuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
