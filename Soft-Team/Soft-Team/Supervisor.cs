using System;
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
    public partial class Supervisor : Form
    {
        public Supervisor()
        {
            InitializeComponent();
        }

        private void Supervisor_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Supervisor_Resize(object sender, EventArgs e)
        {
        }

        //private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = true;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string correoqueenvia = "soft.team2001@gmail.com";
                string correoquerecibe = this.Para.Text;
                string msjContra = this.suSolicitudEs.Text;

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
                MailMessage mail = new MailMessage(correoqueenvia, msjContra + correoquerecibe, this.TxtAsunto.Text, this.suSolicitudEs.Text + this.aprobado.Text);
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mail);
                MessageBox.Show("Se ha enviado su respuesta", "Felicitaciones");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Correo No Enviado " + ex.ToString(), "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string correoqueenvia = "soft.team2001@gmail.com";
                string correoquerecibe = this.Para.Text;
                string msjContra = this.suSolicitudEs.Text;

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
                MailMessage mail = new MailMessage(correoqueenvia, msjContra + correoquerecibe, this.TxtAsunto.Text, this.suSolicitudEs.Text + this.rechazado.Text);
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mail);
                MessageBox.Show("Se ha enviado su respuesta", "Felicitaciones");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Correo No Enviado " + ex.ToString(), "Error");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
