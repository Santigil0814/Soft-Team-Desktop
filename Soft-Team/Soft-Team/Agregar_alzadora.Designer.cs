﻿
namespace Soft_Team
{
    partial class Agregar_alzadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_alzadora));
            this.panel1 = new System.Windows.Forms.Panel();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rPMTextBox = new System.Windows.Forms.TextBox();
            this.cilindrajeTextBox = new System.Windows.Forms.TextBox();
            this.horas_KmComboBox = new System.Windows.Forms.ComboBox();
            this.horometro_Km_inicialTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.u_tecnicaComboBox = new System.Windows.Forms.ComboBox();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.tipo_maquinaComboBox = new System.Windows.Forms.ComboBox();
            this.n_internoTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._Soft_Team1DataSet = new Soft_Team._Soft_Team1DataSet();
            this.maquinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maquinasTableAdapter = new Soft_Team._Soft_Team1DataSetTableAdapters.MaquinasTableAdapter();
            this.tableAdapterManager = new Soft_Team._Soft_Team1DataSetTableAdapters.TableAdapterManager();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Soft_Team._Soft_Team1DataSetTableAdapters.UsuarioTableAdapter();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Soft_Team1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(371, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(303, 29);
            label1.TabIndex = 42;
            label1.Text = "Registrar nueva alzadora";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.estadoComboBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.rPMTextBox);
            this.panel1.Controls.Add(this.cilindrajeTextBox);
            this.panel1.Controls.Add(this.horas_KmComboBox);
            this.panel1.Controls.Add(this.horometro_Km_inicialTextBox);
            this.panel1.Controls.Add(this.modeloTextBox);
            this.panel1.Controls.Add(this.marcaComboBox);
            this.panel1.Controls.Add(this.u_tecnicaComboBox);
            this.panel1.Controls.Add(this.serieTextBox);
            this.panel1.Controls.Add(this.referenciaTextBox);
            this.panel1.Controls.Add(this.tipo_maquinaComboBox);
            this.panel1.Controls.Add(this.n_internoTextBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 617);
            this.panel1.TabIndex = 4;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Habilitado",
            "Inhabilitado"});
            this.estadoComboBox.Location = new System.Drawing.Point(351, 176);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 21);
            this.estadoComboBox.TabIndex = 3;
            this.estadoComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estadoComboBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label13.Location = new System.Drawing.Point(350, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 14);
            this.label13.TabIndex = 85;
            this.label13.Text = "Estado";
            // 
            // rPMTextBox
            // 
            this.rPMTextBox.Location = new System.Drawing.Point(351, 577);
            this.rPMTextBox.Name = "rPMTextBox";
            this.rPMTextBox.Size = new System.Drawing.Size(298, 20);
            this.rPMTextBox.TabIndex = 12;
            this.rPMTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rPMTextBox_KeyPress);
            // 
            // cilindrajeTextBox
            // 
            this.cilindrajeTextBox.Location = new System.Drawing.Point(352, 525);
            this.cilindrajeTextBox.Name = "cilindrajeTextBox";
            this.cilindrajeTextBox.Size = new System.Drawing.Size(297, 20);
            this.cilindrajeTextBox.TabIndex = 11;
            this.cilindrajeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cilindrajeTextBox_KeyPress);
            // 
            // horas_KmComboBox
            // 
            this.horas_KmComboBox.FormattingEnabled = true;
            this.horas_KmComboBox.Items.AddRange(new object[] {
            "Horas"});
            this.horas_KmComboBox.Location = new System.Drawing.Point(544, 475);
            this.horas_KmComboBox.Name = "horas_KmComboBox";
            this.horas_KmComboBox.Size = new System.Drawing.Size(125, 21);
            this.horas_KmComboBox.TabIndex = 10;
            this.horas_KmComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horas_KmComboBox_KeyPress);
            // 
            // horometro_Km_inicialTextBox
            // 
            this.horometro_Km_inicialTextBox.Location = new System.Drawing.Point(351, 475);
            this.horometro_Km_inicialTextBox.Name = "horometro_Km_inicialTextBox";
            this.horometro_Km_inicialTextBox.Size = new System.Drawing.Size(174, 20);
            this.horometro_Km_inicialTextBox.TabIndex = 9;
            this.horometro_Km_inicialTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horometro_Km_inicialTextBox_KeyPress);
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.Location = new System.Drawing.Point(351, 425);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(200, 20);
            this.modeloTextBox.TabIndex = 8;
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Items.AddRange(new object[] {
            "Case Austoft",
            "John Deere"});
            this.marcaComboBox.Location = new System.Drawing.Point(351, 374);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(200, 21);
            this.marcaComboBox.TabIndex = 7;
            this.marcaComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.marcaComboBox_KeyPress);
            // 
            // u_tecnicaComboBox
            // 
            this.u_tecnicaComboBox.FormattingEnabled = true;
            this.u_tecnicaComboBox.Items.AddRange(new object[] {
            "Campo",
            "Cosecha",
            "Servicios Generales",
            "Fábrica"});
            this.u_tecnicaComboBox.Location = new System.Drawing.Point(351, 325);
            this.u_tecnicaComboBox.Name = "u_tecnicaComboBox";
            this.u_tecnicaComboBox.Size = new System.Drawing.Size(200, 21);
            this.u_tecnicaComboBox.TabIndex = 6;
            this.u_tecnicaComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.u_tecnicaComboBox_KeyPress);
            // 
            // serieTextBox
            // 
            this.serieTextBox.Location = new System.Drawing.Point(351, 275);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(298, 20);
            this.serieTextBox.TabIndex = 5;
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.Location = new System.Drawing.Point(351, 225);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(298, 20);
            this.referenciaTextBox.TabIndex = 4;
            // 
            // tipo_maquinaComboBox
            // 
            this.tipo_maquinaComboBox.FormattingEnabled = true;
            this.tipo_maquinaComboBox.Items.AddRange(new object[] {
            "Alzadora"});
            this.tipo_maquinaComboBox.Location = new System.Drawing.Point(351, 126);
            this.tipo_maquinaComboBox.Name = "tipo_maquinaComboBox";
            this.tipo_maquinaComboBox.Size = new System.Drawing.Size(199, 21);
            this.tipo_maquinaComboBox.TabIndex = 2;
            this.tipo_maquinaComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_maquinaComboBox_KeyPress);
            // 
            // n_internoTextBox
            // 
            this.n_internoTextBox.Location = new System.Drawing.Point(351, 76);
            this.n_internoTextBox.Name = "n_internoTextBox";
            this.n_internoTextBox.Size = new System.Drawing.Size(298, 20);
            this.n_internoTextBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label12.Location = new System.Drawing.Point(541, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 14);
            this.label12.TabIndex = 73;
            this.label12.Text = "Horas / Kilometros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(350, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 66;
            this.label7.Text = "RPM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(349, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 14);
            this.label8.TabIndex = 65;
            this.label8.Text = "Cilindraje";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(348, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 14);
            this.label9.TabIndex = 64;
            this.label9.Text = "Horometro / Kilometraje inicial";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(348, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 14);
            this.label10.TabIndex = 63;
            this.label10.Text = "Modelo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(349, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 14);
            this.label11.TabIndex = 62;
            this.label11.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(349, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 14);
            this.label6.TabIndex = 56;
            this.label6.Text = "Ubicación técnica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(349, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 55;
            this.label5.Text = "Serie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(348, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 54;
            this.label4.Text = "Referencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(348, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 14);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tipo máquina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(349, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 14);
            this.label2.TabIndex = 52;
            this.label2.Text = "Número interno";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(194, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(89, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(78, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // _Soft_Team1DataSet
            // 
            this._Soft_Team1DataSet.DataSetName = "_Soft_Team1DataSet";
            this._Soft_Team1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maquinasBindingSource
            // 
            this.maquinasBindingSource.DataMember = "Maquinas";
            this.maquinasBindingSource.DataSource = this._Soft_Team1DataSet;
            // 
            // maquinasTableAdapter
            // 
            this.maquinasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.maquinaria_mantenimientoTableAdapter = null;
            this.tableAdapterManager.MaquinasTableAdapter = this.maquinasTableAdapter;
            this.tableAdapterManager.OperadoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Soft_Team._Soft_Team1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this._Soft_Team1DataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Agregar_alzadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 629);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar_alzadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_alzadora";
            this.Load += new System.EventHandler(this.Agregar_alzadora_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Soft_Team1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maquinasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private _Soft_Team1DataSet _Soft_Team1DataSet;
        private System.Windows.Forms.BindingSource maquinasBindingSource;
        private _Soft_Team1DataSetTableAdapters.MaquinasTableAdapter maquinasTableAdapter;
        private _Soft_Team1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tipo_maquinaComboBox;
        private System.Windows.Forms.TextBox n_internoTextBox;
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.ComboBox u_tecnicaComboBox;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.TextBox rPMTextBox;
        private System.Windows.Forms.TextBox cilindrajeTextBox;
        private System.Windows.Forms.ComboBox horas_KmComboBox;
        private System.Windows.Forms.TextBox horometro_Km_inicialTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private _Soft_Team1DataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ComboBox estadoComboBox;
    }
}