using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Team
{
    public partial class Generar_reporte : Form
    {
        public Generar_reporte()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajustesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ajustes A = new Ajustes();
            A.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Fi, Ff;
            Cursor.Current = Cursors.WaitCursor;

            //Creo una instancia del reporte de crystal
            CrystalReporteFecha reportePorFecha = new CrystalReporteFecha();

            //Creamos una instancia del dataset
            _Soft_Team1DataSet ds1 = new _Soft_Team1DataSet();

            DataTable tabla = new DataTable();

            SqlConnection conexion = new SqlConnection("Data Source = (Local)\\SQLEXPRESS; Initial Catalog = Soft-Team1; Integrated Security = True");
            conexion.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.maquinaria_mantenimiento.* " +
                                                   "FROM dbo.maquinaria_mantenimiento INNER JOIN " +
                                                   "dbo.Maquinas ON dbo.maquinaria_mantenimiento.id_maquina = dbo.Maquinas.id_Maquina INNER JOIN " +
                                                   "dbo.Usuario ON dbo.maquinaria_mantenimiento.id_usuario = dbo.Usuario.id_Usuario", conexion);
            da.Fill(tabla);

            conexion.Close();

            // Asignamos los datos al reporte a traves del metodo SetDataSource()
            reportePorFecha.SetDataSource(tabla);

            // Parametros
            Fi = Fecha1.ToString().Substring(44, 10) + " 00:00:00.000";
            Ff = Fecha2.ToString().Substring(44, 10) + " 23:59:59.000";
            reportePorFecha.SetParameterValue("Fecha1", Convert.ToDateTime(Fi));
            reportePorFecha.SetParameterValue("Fecha2", Convert.ToDateTime(Ff));

            ReportePorFecha rp = new ReportePorFecha();
            Cursor.Current = Cursors.Default;
            // Asignamos reporte al CrystalReportView
            rp.crystalReportViewer1.ReportSource = reportePorFecha;
            rp.ShowDialog();
            rp.Close();
            //ds1.Personas.Dispose();
            //ds1.Registros.Dispose();
            ds1.Dispose();
            reportePorFecha.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Dt1, Dt2;
            Cursor.Current = Cursors.WaitCursor;

            //Creo una instancia del reporte de crystal
            CrystalReporteFecha reportePorFecha = new CrystalReporteFecha();

            //Creamos una instancia del dataset
            _Soft_Team1DataSet ds2 = new _Soft_Team1DataSet();

            // llenamos el table adpter (o la tabla productos con fill)
            //General.per.Fill(ds2.Personas);
            //General.regi.Fill(ds2.Registros);

            // Asignamos los datos al reporte a traves del metodo SetDataSource()
            reportePorFecha.SetDataSource(ds2);

            // Parametros
            Dt1 = dateTime1.ToString().Substring(44, 10) + " 00:00:00";
            Dt2 = dateTime2.ToString().Substring(44, 10) + " 23:59:59";
            reportePorFecha.SetParameterValue("dateTime1", Convert.ToDateTime(dateTime1));
            reportePorFecha.SetParameterValue("dateTime2", Convert.ToDateTime(dateTime2));
            //reporte.SetParameterValue("Codigo_Ficha", p.Ficha.Text);
            //reporte.SetParameterValue("Fecha2", Fecha2);

            ReportePorFecha rp = new ReportePorFecha();
            Cursor.Current = Cursors.Default;
            // Asignamos reporte al CrystalReportView
            rp.crystalReportViewer1.ReportSource = reportePorFecha;
            rp.ShowDialog();
            rp.Close();
            //ds1.Personas.Dispose();
            //ds1.Registros.Dispose();
            ds2.Dispose();
            reportePorFecha.Dispose();
        }

        private void maquinaria_mantenimientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.maquinaria_mantenimientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Soft_Team1DataSet);

        }

        private void Generar_reporte_Load(object sender, EventArgs e)
        {
        }
    }
}
