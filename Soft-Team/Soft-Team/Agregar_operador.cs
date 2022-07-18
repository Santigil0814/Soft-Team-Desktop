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
    public partial class Agregar_operador : Form
    {
        public Agregar_operador()
        {
            InitializeComponent();
        }

        private void operadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void Agregar_operador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Operadores' Puede moverla o quitarla según sea necesario.
            this.operadoresTableAdapter.Fill(this._Soft_Team1DataSet.Operadores);

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
                    if (string.IsNullOrEmpty(this.fichaOperadorTextBox.Text))
                    {
                        MessageBox.Show("Ficha operador requerido", "¡Advertencia!");
                        this.ape_1TextBox.Focus();
                    }
                    {
                        try
                        {
                            this.operadoresTableAdapter.InsertarOperador(this.nom_1TextBox.Text, this.nom_2TextBox.Text, this.ape_1TextBox.Text, this.ape_2TextBox.Text, Convert.ToInt32(fichaOperadorTextBox.Text));
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

        private void fichaOperadorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
            
        
     
 