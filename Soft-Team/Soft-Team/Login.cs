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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            Inicio I = new Inicio();
            I.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Txtusuario.Text))
            {
                MessageBox.Show("Por favor, digite el usuario", "Alerta");
                this.Txtusuario.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.Txtcontrasena.Text))
                {
                    MessageBox.Show("Por favor, digite la contraseña", "Alerta");
                    this.Txtcontrasena.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty((string)this.usuarioTableAdapter.VerificaUsuario(this.Txtusuario.Text)))
                    {
                        MessageBox.Show("El usuario no existe. Por favor, digite un usuario existente", "Alerta");
                        this.Txtusuario.Focus();
                        this.Txtusuario.Text = string.Empty;
                        this.Txtcontrasena.Text = string.Empty;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty((string)this.usuarioTableAdapter.VerificaUsuario(this.Txtusuario.Text)))
                        {
                            MessageBox.Show("La contraseña es incorrecta. Por favor, verifique la contraseña", "Error");
                            this.Txtcontrasena.Focus();
                            this.Txtcontrasena.Text = string.Empty;
                            this.Txtusuario.Text = string.Empty;
                        }
                        else
                        {
                            General.NomUsuario = this.Txtusuario.Text;
                            if (this.Txtcontrasena.Text == Encriptar.descencriptar1(this.usuarioTableAdapter.TraerContraseña(this.Txtusuario.Text)))
                            {
                                this.Visible = false;
                                this.Enabled = false;
                                General.DatoRol = (string)this.usuarioTableAdapter.TraerRol(this.Txtusuario.Text);
                                General.EstadoUsu = (string)this.usuarioTableAdapter.TraerEstado(this.Txtusuario.Text);
                                if(General.DatoRol == "Administrador" && General.EstadoUsu == "Habilitado")
                                {
                                    this.Visible = false;
                                    Administrador m = new Administrador();
                                    m.ShowDialog();
                                }
                                else
                                {
                                    if(General.DatoRol == "Supervisor" && General.EstadoUsu == "Habilitado")
                                    {
                                        this.Visible = false;
                                        Supervisor s = new Supervisor();
                                        s.ShowDialog();
                                    }
                                    else
                                    {
                                        if(General.DatoRol == "Mecanico Recepcionista" && General.EstadoUsu == "Habilitado")
                                        {
                                            this.Visible = false;
                                            captura_info c = new captura_info();
                                            c.ShowDialog();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El rol no existe o se encuentra inhabiltado", "Advertencia");
                                        }
                                    }
                                }
                                this.Visible = true;
                                this.Enabled = true;
                                this.Txtusuario.Text = string.Empty;
                                this.Txtcontrasena.Text = string.Empty;
                                this.Txtusuario.Focus();
                            }
                            else
                            {
                                MessageBox.Show("La contraseña es incorrecta. Por favor, verifique la contraseña", "Error");
                                this.Visible = true;
                                this.Enabled = true;
                                this.Txtusuario.Text = string.Empty;
                                this.Txtcontrasena.Text = string.Empty;
                                this.Txtusuario.Focus();
                            }
                        }
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar_usuario Ru = new Recuperar_usuario();
            Ru.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar_contraseña Rc = new Recuperar_contraseña();
            Rc.ShowDialog();
        }

        private void Txtcontrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255) || (e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64))
            {
                MessageBox.Show("Por favor, digite solo letras y números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
