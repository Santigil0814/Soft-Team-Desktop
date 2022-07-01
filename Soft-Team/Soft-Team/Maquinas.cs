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
    public partial class Maquinas : Form
    {
        public Maquinas()
        {
            InitializeComponent();
        }

        private void maquinasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.maquinasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void Maquinas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Maquinas' Puede moverla o quitarla según sea necesario.
            this.maquinasTableAdapter.Fill(this._Soft_Team1DataSet.Maquinas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            Administrador m = new Administrador();
            m.ShowDialog();
            this.Close();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Registro_maquina rm = new Registro_maquina();
            rm.ShowDialog();
        }

        private void maquinasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            General.MaNoInterno = maquinasDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(General.MaNoInterno))
            {
                MessageBox.Show("Por favor, seleccione un registro", "Alerta");
            }
            else
            {
                this.Visible = false;
                this.Enabled = false;
                if (General.TipoMaquina == "Cosechadora")
                {
                    this.Visible = false;
                    Editar_cosechadora Ec = new Editar_cosechadora();
                    Ec.ShowDialog();
                }
                else
                {
                    if (General.TipoMaquina == "Tractor")
                    {
                        this.Visible = false;
                        Editar_tractor Et = new Editar_tractor();
                        Et.ShowDialog();
                    }
                    else
                    {
                        if (General.TipoMaquina == "Alzadora")
                        {
                            this.Visible = false;
                            Editar_alzadora Ea = new Editar_alzadora();
                            Ea.ShowDialog();
                        }
                        else
                        {
                            if (General.TipoMaquina == "Tractocamión")
                            {
                                this.Visible = false;
                                Editar_tractocamion Etr = new Editar_tractocamion();
                                Etr.ShowDialog();
                            }
                            else
                            {
                                if (General.TipoMaquina == "Camión")
                                {
                                    this.Visible = false;
                                    Editar_camion Eca = new Editar_camion();
                                    Eca.ShowDialog();
                                }
                                else
                                {
                                    if (General.TipoMaquina == "Vehiculo liviano")
                                    {
                                        this.Visible = false;
                                        Editar_vehiculo_liviano Evl = new Editar_vehiculo_liviano();
                                        Evl.ShowDialog();
                                    }
                                    else
                                    {
                                        if (General.TipoMaquina == "Motocicleta")
                                        {
                                            this.Visible = false;
                                            Editar_motocicleta Em = new Editar_motocicleta();
                                            Em.ShowDialog();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El rol no existe", "Advertencia");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    this.Visible = true;
                    this.Enabled = true; 
                }
            }
        }

        private void maquinasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // Creo una instancia del reporte de crystal 
            CrystalMaquinaria reporte = new CrystalMaquinaria();

            //Llenamos el table adpter (o la tabla productos con fill)
            this.maquinasTableAdapter.Fill(this._Soft_Team1DataSet.Maquinas);

            //Asignamos los datos al reporte a traves del metodo SetDataSource()
            reporte.SetDataSource(this._Soft_Team1DataSet);

            Cursor.Current = Cursors.Default;
            //Asignamos reporte al CrystalReportView
            ReporteMaquinaria Rm = new ReporteMaquinaria();
            Rm.crystalReportViewer1.ReportSource = reporte;
            Rm.ShowDialog();
            Rm.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(General.MaNoInterno))
            {
                MessageBox.Show("Por favor, seleccione un registro", "Alerta");
            }
            else
            {
                if (MessageBox.Show("¿Seguro que quiere eliminar este registro?",
                    "Eliminar registro",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    maquinasTableAdapter.Eliminar_maquina(General.MaNoInterno);
                    maquinasTableAdapter.Fill(this._Soft_Team1DataSet.Maquinas);
                    MessageBox.Show("Registro eliminado con éxito", "Notificación");
                    General.MaNoInterno = string.Empty;
                }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.maquinasTableAdapter.BuscarPorN_interno(this._Soft_Team1DataSet.Maquinas, this.toolStripTextBox1.Text);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            Administrador a = new Administrador();
            a.ShowDialog();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajustesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ajustes A = new Ajustes();
            A.ShowDialog();
        }
    }
}
