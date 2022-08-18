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
    public partial class SalidaMaquina : Form
    {
        public SalidaMaquina()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajustesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ajustes A = new Ajustes();
            A.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            captura_info Ci = new captura_info();
            Ci.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generar_reporte Gr = new Generar_reporte();
            Gr.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SalidaMaquina Sm = new SalidaMaquina();
            Sm.ShowDialog();
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
                                    this.maquinaria_mantenimientoTableAdapter.AgrgarSalidaMaquina(Convert.ToInt32(id_ma), Convert.ToInt32(id_us), Convert.ToDateTime(fecha_hora_ingresoDateTimePicker.Value), this.observacionesTextBox.Text, this.fichaOperadorTextBox.Text, Convert.ToInt32(horometro_actualTextBox.Text), this.tipo_mantenimientoComboBox.Text, this.seccion_1ComboBox.Text, this.seccion_2ComboBox.Text, this.seccion_3ComboBox.Text, this.seccion_4ComboBox.Text, this.seccion_5ComboBox.Text, this.seccion_6ComboBox.Text, this.seccion_7ComboBox.Text, this.seccion_8ComboBox.Text, this.seccion_9ComboBox.Text);
                                    MessageBox.Show("Matenimiento insertado con éxito", "¡Felicidades!");
                                }
                                catch (Exception x)
                                {
                                    MessageBox.Show("El registro no se puede guardar en la base de datos " + x.ToString(), "Error");
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

        private void SalidaMaquina_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Maquinas' Puede moverla o quitarla según sea necesario.
            this.maquinasTableAdapter.Fill(this._Soft_Team1DataSet.Maquinas);
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Operadores' Puede moverla o quitarla según sea necesario.
            this.operadoresTableAdapter.Fill(this._Soft_Team1DataSet.Operadores);
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);
            General.idMaquina = this.id_MaquinaTextBox.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.id_MaquinaTextBox.Text))
            {
                MessageBox.Show("Número interno de la Máquina requerido", "¡Advertencia!");
                this.id_MaquinaTextBox.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(General.idMaquina))
                {
                    string id_ma = this.maquinasTableAdapter.Traerid_maquina(id_MaquinaTextBox.Text).ToString();
                    this.maquinaria_mantenimientoTableAdapter.TraerDatosMaquina(Convert.ToInt32(id_ma));
                    General.idMaquina = string.Empty;
                }
            }
        }
    }
}
