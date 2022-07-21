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
    public partial class Editar_alzadora : Form
    {
        public Editar_alzadora()
        {
            InitializeComponent();
        }

        private void maquinasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.maquinasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void Editar_alzadora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Maquinas' Puede moverla o quitarla según sea necesario.
            this.maquinasTableAdapter.LlamarUnCamion(this._Soft_Team1DataSet.Maquinas, General.MaNoInterno);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.n_internoTextBox.Text))
            {
                MessageBox.Show("Nùmero interno de la Máquina requerido", "¡Advertencia!");
                this.n_internoTextBox.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.tipo_maquinaComboBox.Text))
                {
                    MessageBox.Show("Tipo de maquina requerido", "¡Advertencia!");
                    this.tipo_maquinaComboBox.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.estadoComboBox.Text))
                    {
                        MessageBox.Show("Estado de la máquina requerido", "¡Advertencia!");
                        this.estadoComboBox.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.referenciaTextBox.Text))
                        {
                            MessageBox.Show("Referencia de la máquina requerida", "¡Advertencia!");
                            this.referenciaTextBox.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.serieTextBox.Text))
                            {
                                MessageBox.Show("Serie de la Máquina requerida", "¡Advertencia!");
                                this.serieTextBox.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(this.u_tecnicaComboBox.Text))
                                {
                                    MessageBox.Show("Ubicación técnica de la Maquina requerida", "¡Advertencia!");
                                    this.u_tecnicaComboBox.Focus();
                                }
                                else
                                 if (string.IsNullOrEmpty(this.marcaComboBox.Text))
                                {
                                    MessageBox.Show("Marca de la Maquina requerida", "¡Advertencia!");
                                    this.marcaComboBox.Focus();
                                }
                                else
                                 if (string.IsNullOrEmpty(this.modeloTextBox.Text))
                                {
                                    MessageBox.Show("Modelo de la Maquina requerido", "¡Advertencia!");
                                    this.modeloTextBox.Focus();
                                }
                                else
                                 if (string.IsNullOrEmpty(this.horometro_Km_inicialTextBox.Text))
                                {
                                    MessageBox.Show("Horómetro o Kilometraje inicial de la Maquina requerido", "¡Advertencia!");
                                    this.horometro_Km_inicialTextBox.Focus();
                                }
                                else
                                 if (string.IsNullOrEmpty(this.horas_KmComboBox.Text))
                                {
                                    MessageBox.Show("Establecer horas o Kilometraje inicial de la Maquina requerida", "¡Advertencia!");
                                    this.horas_KmComboBox.Focus();
                                }
                                else
                                 if (string.IsNullOrEmpty(this.cilindrajeTextBox.Text))
                                {
                                    MessageBox.Show("Cilindraje de la Maquina requerida", "¡Advertencia!");
                                    this.cilindrajeTextBox.Focus();
                                }
                                else
                                 if (string.IsNullOrEmpty(this.rPMTextBox.Text))
                                {
                                    MessageBox.Show("RPM de la Maquina requerido", "¡Advertencia!");
                                    this.rPMTextBox.Focus();
                                }
                                else
                                {
                                    try
                                    {
                                        maquinasTableAdapter.Actualizar_Camion(
                                            this.n_internoTextBox.Text,
                                            this.tipo_maquinaComboBox.Text,
                                            this.referenciaTextBox.Text,
                                            this.serieTextBox.Text,
                                            this.u_tecnicaComboBox.Text,
                                            this.marcaComboBox.Text,
                                            this.modeloTextBox.Text,
                                            Convert.ToInt32(horometro_Km_inicialTextBox.Text),
                                            this.horas_KmComboBox.Text,
                                            this.cilindrajeTextBox.Text,
                                            this.rPMTextBox.Text,
                                            this.estadoComboBox.Text
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

        private void horometro_Km_inicialLabel_Click(object sender, EventArgs e)
        {

        }

        private void tipo_maquinaComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void estadoComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void u_tecnicaComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void marcaComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void horas_KmComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void horometro_Km_inicialTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor, digite solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cilindrajeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor, digite solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void rPMTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor, digite solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
