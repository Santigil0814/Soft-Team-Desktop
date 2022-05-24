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
                            if (this.Txtcontrasena.Text == Encriptar.descencriptar1(this.usuarioTableAdapter.TraerContraseña(this.Txtusuario.Text)))
                            {
                                this.Visible = false;
                                this.Enabled = false;
                                General.DatoRol = this.usuarioTableAdapter.TraerRol(this.Txtusuario.Text);
                                Administrador m = new Administrador();
                                m.ShowDialog();
                                this.Txtusuario.Text = string.Empty;
                                this.Txtcontrasena.Text = string.Empty;
                                this.Txtusuario.Focus();
                            }
                            else
                            {
                                MessageBox.Show("La contraseña es incorrecta. Por favor, verifique la contraseña", "Error");
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
    }
}
