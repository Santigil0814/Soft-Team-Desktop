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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }


        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.LlamarUnUsuario(this._Soft_Team1DataSet.Usuario, General.UsuUsuario);
            this.contrasenaTextBox1.Text = Encriptar.descencriptar1(this.contrasenaTextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.nom_1TextBox.Text))
            {
                MessageBox.Show("Digite el primer nombre", "Alerta");
                this.nom_1TextBox.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.ape_1TextBox.Text))
                {
                    MessageBox.Show("Digite el primer apellido", "Alerta");
                    this.ape_1TextBox.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.rolComboBox.Text))
                    {
                        MessageBox.Show("Seleccione el rol", "Alerta");
                        this.rolComboBox.Focus();
                    }

                    else
                    {
                        if (string.IsNullOrEmpty(this.usuarioTextBox1.Text))
                        {
                            MessageBox.Show("Digite el usuario", "Alerta");
                            this.usuarioTextBox1.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.contrasenaTextBox1.Text))
                            {
                                MessageBox.Show("Digite la contraseña", "Alerta");
                                this.contrasenaTextBox1.Focus();
                            }
                            else
                            {
                                try
                                {
                                    this.contrasenaTextBox1.Text = Encriptar.encriptar1(this.contrasenaTextBox1.Text);
                                    usuarioTableAdapter.ActualizarUsuarios(
                                        this.nom_1TextBox.Text,
                                        this.nom_2TextBox.Text,
                                        this.ape_1TextBox.Text,
                                        this.ape_2TextBox.Text,
                                        this.rolComboBox.Text,
                                        this.usuarioTextBox1.Text,
                                        this.contrasenaTextBox1.Text,
                                        this.correoTextBox.Text);
                                    MessageBox.Show("Registro actualizado", "Notificación");
                                    this.Close();
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("El registro no se puede actualizar", "Alerta");
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rolComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
