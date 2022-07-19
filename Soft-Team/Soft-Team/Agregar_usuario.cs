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
    public partial class Agregar_usuario : Form
    {
        public Agregar_usuario()
        {
            InitializeComponent();
        }

        private void Agregar_usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.nom_1TextBox.Text))
            {
                MessageBox.Show("Primer Nombre requerido", "¡Advertencia!");
                this.nom_1TextBox.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.ape_1TextBox.Text))
                {
                    MessageBox.Show("Primer Apellido requerido", "¡Advertencia!");
                    this.ape_1TextBox.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.correoTextBox.Text))
                    {
                        MessageBox.Show("Correo requerido", "¡Advertencia!");
                        this.correoTextBox.Focus();
                    }
                    else
                    if (string.IsNullOrEmpty(this.rolComboBox.Text))
                    {
                        MessageBox.Show("Rol requerido", "¡Advertencia!");
                        this.rolComboBox.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.usuarioTextBox.Text))
                        {
                            MessageBox.Show("Usuario requerido", "¡Advertencia!");
                            this.usuarioTextBox.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.contrasenaTextBox.Text))
                            {
                                MessageBox.Show("Contraseña requerida", "¡Advertencia!");
                                this.contrasenaTextBox.Focus();
                            }
                            else
                            {
                                try
                                {
                                    this.contrasenaTextBox.Text = Encriptar.encriptar1(this.contrasenaTextBox.Text);
                                    this.usuarioTableAdapter.AgregarUsuario(this.nom_1TextBox.Text, this.nom_2TextBox.Text, this.ape_1TextBox.Text, this.ape_2TextBox.Text, this.rolComboBox.Text, this.usuarioTextBox.Text, this.contrasenaTextBox.Text, this.correoTextBox.Text, this.estadoComboBox.Text);
                                    MessageBox.Show("Registro insertado con éxito", "¡Felicidades!");
                                    this.Close();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("El registro no se puede guardar en la base de datos", "Error");
                                    throw;
                                }
                            }
                        }
                    }

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void rolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rolComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void correoTextBox_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.usuarioTableAdapter.VerificarCorreo(this.correoTextBox.Text)))
            {
                MessageBox.Show("El correo ya existe", "Notificación");
                this.correoTextBox.Focus();
                return;
            }
        }

        private void usuarioTextBox_Validated(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty((string)this.usuarioTableAdapter.VerificaUsuario(this.usuarioTextBox.Text))))
            {
                MessageBox.Show("El usuario ya existe", "Notificación");
                this.usuarioTextBox.Focus();
                return;
            }
        }

        private void correoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255) || (e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64))
            {
                MessageBox.Show("Por favor, digite solo letras y números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void rolComboBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void estadoComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
