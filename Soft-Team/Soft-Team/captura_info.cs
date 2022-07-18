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
    public partial class captura_info : Form
    {
        public captura_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void maquinaria_mantenimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.maquinaria_mantenimientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void captura_info_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Operadores' Puede moverla o quitarla según sea necesario.
            this.operadoresTableAdapter.Fill(this._Soft_Team1DataSet.Operadores);
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Maquinas' Puede moverla o quitarla según sea necesario.
            this.maquinasTableAdapter.Fill(this._Soft_Team1DataSet.Maquinas);
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.maquinaria_mantenimiento' Puede moverla o quitarla según sea necesario.
            //this.maquinaria_mantenimientoTableAdapter.Fill(this._Soft_Team1DataSet.maquinaria_mantenimiento);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.id_MaquinaTextBox.Text))
            {
                MessageBox.Show("Número interno de la Máquina requerido", "¡Advertencia!");
                this.id_MaquinaTextBox.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(Convert.ToString(fecha_hora_ingresoDateTimePicker)))
                {
                    MessageBox.Show("Fecha de ingreso de la máquina requerido", "¡Advertencia!");
                    this.fecha_hora_ingresoDateTimePicker.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.fichaOperadorTextBox.Text))
                    {
                        MessageBox.Show("Ficha del operador de la máquina requerido", "¡Advertencia!");
                        this.fichaOperadorTextBox.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.horometro_actualTextBox.Text))
                        {
                            MessageBox.Show("Horómetro de la máquina requerido", "¡Advertencia!");
                            this.horometro_actualTextBox.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.tipo_mantenimientoComboBox.Text))
                            {
                                MessageBox.Show("Tipo de mantenimiento de la máquina requerido", "¡Advertencia!");
                                this.tipo_mantenimientoComboBox.Focus();
                            }
                            else
                            {
                                try
                                {
                                    string id_ma = this.maquinasTableAdapter.Traerid_maquina(id_MaquinaTextBox.Text).ToString();
                                    string id_us = this.usuarioTableAdapter.Llamarid_usuario(General.NomUsuario).ToString();
                                    this.maquinaria_mantenimientoTableAdapter.AgregarMantenimiento(Convert.ToInt32(id_ma), Convert.ToInt32(id_us), Convert.ToDateTime(fecha_hora_ingresoDateTimePicker.Value), Convert.ToDateTime(fecha_hora_salidaDateTimePicker.Value), this.observacionesTextBox.Text, this.fichaOperadorTextBox.Text, Convert.ToInt32(horometro_actualTextBox.Text), this.tipo_mantenimientoComboBox.Text, this.seccion_1ComboBox.Text, this.seccion_2ComboBox.Text, this.seccion_3ComboBox.Text, this.seccion_4ComboBox.Text, this.seccion_5ComboBox.Text, this.seccion_6ComboBox.Text, this.seccion_7ComboBox.Text, this.seccion_8ComboBox.Text, this.seccion_9ComboBox.Text);
                                    MessageBox.Show("Matenimiento insertado con éxito", "¡Felicidades!");
                                }
                                catch (Exception x)
                                {
                                    MessageBox.Show("El registro no se puede guardar en la base de datos "+ x.ToString(), "Error");
                                    throw;
                                }
                                this.id_MaquinaTextBox.Text = string.Empty;
                                this.fecha_hora_ingresoDateTimePicker.Text = string.Empty;
                                this.fichaOperadorTextBox.Text = string.Empty;
                                this.horometro_actualTextBox.Text = string.Empty;
                                this.tipo_mantenimientoComboBox.Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }

        private void tipo_mantenimientoComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void seccion_1ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void seccion_2ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void seccion_3ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void seccion_4ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void seccion_5ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void seccion_6ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void seccion_7ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void seccion_8ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void seccion_9ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void id_MaquinaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_MaquinaTextBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)this.maquinasTableAdapter.VerificarN_Interno(this.id_MaquinaTextBox.Text)))
            {
                MessageBox.Show("El Número Interno ingresado no existe. Por favor, digite un Número Interno existente", "Alerta");
                this.id_MaquinaTextBox.Focus();
                this.id_MaquinaTextBox.Text = string.Empty;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fichaOperadorTextBox_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)this.operadoresTableAdapter.RevisarFichaOperador(this.fichaOperadorTextBox.Text)))
            {
                MessageBox.Show("La ficha de operador ingresado no existe. Por favor, digite una ficha de operador existente", "Alerta");
                this.fichaOperadorTextBox.Focus();
                this.fichaOperadorTextBox.Text = string.Empty;
            }
        }

        private void fichaOperadorTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
