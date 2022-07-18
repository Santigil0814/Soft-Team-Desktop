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
    public partial class Editar_operador : Form
    {
        public Editar_operador()
        {
            InitializeComponent();
        }

        private void Editar_operador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Operadores' Puede moverla o quitarla según sea necesario.
            this.operadoresTableAdapter.LlamarUnOperador(this._Soft_Team1DataSet.Operadores, General.OpeOperador);
            this.operadoresTableAdapter.Fill(this._Soft_Team1DataSet.Operadores);

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
                        if (string.IsNullOrEmpty(this.fichaOperadorTextBox.Text))
                        {
                            MessageBox.Show("Ficha del Operador requerido", "¡Advertencia!");
                            this.fichaOperadorTextBox.Focus();
                        }
                        else
                        {
                            try
                            {
                                operadoresTableAdapter.ActualizarOperadores(
                                    this.nom_1TextBox.Text,
                                    this.nom_2TextBox.Text,
                                    this.ape_1TextBox.Text,
                                    this.ape_2TextBox.Text,
                                    this.fichaOperadorTextBox.Text
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
                    }
                }
            }
        }
    }
}
