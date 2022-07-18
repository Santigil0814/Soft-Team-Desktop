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
    public partial class Operadores : Form
    {
        public Operadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajustesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ajustes A = new Ajustes();
            A.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void operadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void operadoresBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.operadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void Operadores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Operadores' Puede moverla o quitarla según sea necesario.
            this.operadoresTableAdapter.Fill(this._Soft_Team1DataSet.Operadores);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            Agregar_operador Ao = new Agregar_operador();
            Ao.ShowDialog();
            this.operadoresTableAdapter.Fill(this._Soft_Team1DataSet.Operadores);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(General.OpeOperador))
            {
                MessageBox.Show("Por favor, seleccione un registro", "Alerta");
            }
            else
            {
                Editar_operador edo = new Editar_operador();
                edo.ShowDialog();
                this.operadoresTableAdapter.Fill(this._Soft_Team1DataSet.Operadores);
                General.OpeOperador = string.Empty;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(General.OpeOperador))
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
                    operadoresTableAdapter.EliminarOperador(General.OpeOperador);
                    operadoresTableAdapter.Fill(this._Soft_Team1DataSet.Operadores);
                    MessageBox.Show("Registro eliminado con éxito", "Notificación");
                    General.OpeOperador = string.Empty;
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            Maquinas p = new Maquinas();
            p.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            Administrador a = new Administrador();
            a.ShowDialog();
        }

        private void Operadores_Resize(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void OperadoresGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            General.OpeOperador = (OperadoresGridView1.Rows[e.RowIndex].Cells[4].Value).ToString();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.operadoresTableAdapter.BuscarPorNoFicha(this._Soft_Team1DataSet.Operadores, this.toolStripTextBox1.Text);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // Creo una instancia del reporte de crystal 
            CrystalOperadores reporte = new CrystalOperadores();

            //Llenamos el table adpter (o la tabla productos con fill)
            this.operadoresTableAdapter.Fill(this._Soft_Team1DataSet.Operadores);

            //Asignamos los datos al reporte a traves del metodo SetDataSource()
            reporte.SetDataSource(this._Soft_Team1DataSet);

            Cursor.Current = Cursors.Default;
            //Asignamos reporte al CrystalReportView
            ReporteOperadores Ro = new ReporteOperadores();
            Ro.crystalReportViewer1.ReportSource = reporte;
            Ro.ShowDialog();
            Ro.Close();
        }
    }
}
