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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Soft_Team1DataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Agregar_usuario au = new Agregar_usuario();
            au.ShowDialog();
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(General.UsuUsuario))
            {
                MessageBox.Show("Por favor, seleccione un registro", "Alerta");
            }
            else
            {
                EditarUsuario edu = new EditarUsuario();
                edu.ShowDialog();
                this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario );
                General.UsuUsuario = string.Empty;
            }
        }

        private void usuarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            General.UsuUsuario = (usuarioDataGridView.Rows[e.RowIndex].Cells[6].Value).ToString();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(General.UsuUsuario))
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
                    usuarioTableAdapter.Eliminar_Usuario(General.UsuUsuario);
                    usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);
                    MessageBox.Show("Registro eliminado con éxito", "Notificación");
                    General.UsuUsuario = string.Empty;
                }
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.BuscarPorUsuario(this._Soft_Team1DataSet.Usuario, this.toolStripTextBox1.Text);
        }

        private void Administrador_Resize(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            Maquinas p = new Maquinas();
            p.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            // Creo una instancia del reporte de crystal 
            CrystalUsuarios reporte = new CrystalUsuarios();

            //Llenamos el table adpter (o la tabla productos con fill)
            this.usuarioTableAdapter.Fill(this._Soft_Team1DataSet.Usuario);

            //Asignamos los datos al reporte a traves del metodo SetDataSource()
            reporte.SetDataSource(this._Soft_Team1DataSet);

            Cursor.Current = Cursors.Default;
            //Asignamos reporte al CrystalReportView
            ReporteUsuarios Ru= new ReporteUsuarios();
            Ru.crystalReportViewer1.ReportSource = reporte;
            Ru.ShowDialog();
            Ru.Close();
        }
    }
}
