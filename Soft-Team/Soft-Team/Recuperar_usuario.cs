﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Team
{
    public partial class Recuperar_usuario : Form
    {
        public Recuperar_usuario()
        {
            InitializeComponent();
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
                General.EstadoUsu = (string)this.usuarioTableAdapter.LlamarPorCorreo(this.correoTextBox.Text);
                if (string.IsNullOrEmpty((string)this.usuarioTableAdapter.LlamarPorCorreo(this.correoTextBox.Text)) && (General.EstadoUsu == "Inhabilitado"))
                {
                    MessageBox.Show("El correo electrónico digitado no se encuentra registrado o se encuentra inhabilitado.", "Alerta");
                    this.correoTextBox.Focus();
                }
                else
                {
                    this.usuarioTextBox.Text = Encriptar.descencriptar1(this.usuarioTextBox.Text);
                    usuarioTableAdapter.RecuperarUsuario(
                    this.usuarioTextBox.Text
                    );

                    try
                    {
                        General.Idusuario = this.usuarioTableAdapter.TraerUnId(this.correoTextBox.Text).ToString();
                        General.Tusuario = (string)this.usuarioTableAdapter.TraerUnUsuario(Convert.ToInt32(General.Idusuario));
                        string correoqueenvia = "soft.team2001@gmail.com";
                        string correoquerecibe = this.correoTextBox.Text;
                        string msjContra = this.suContraEs.Text;

                        SmtpClient client = new SmtpClient();
                        client.Port = 587;
                        //client.Port = 25;
                        // utilizamos el servidor SMTP de gmail
                        client.Host = "smtp.gmail.com";
                        client.EnableSsl = true;
                        client.Timeout = 10000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = true;
                        // nos autenticamos con nuestra cuenta de gmail
                        client.Credentials = new System.Net.NetworkCredential(correoqueenvia, "kusekinggmypcaka");
                        MailMessage mail = new MailMessage(correoqueenvia, msjContra + correoquerecibe, this.TxtAsunto.Text, this.suContraEs.Text + General.Tusuario + this.aviso.Text);
                        mail.BodyEncoding = UTF8Encoding.UTF8;
                        mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                        client.Send(mail);
                        MessageBox.Show("Se ha enviado su usuario al correo digitado", "Felicitaciones");
                        this.correoTextBox.Focus();
                        this.correoTextBox.Text = string.Empty;
                        this.correoTextBox.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Correo No Enviado " + ex.ToString(), "Error");
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

        private void Recuperar_usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
