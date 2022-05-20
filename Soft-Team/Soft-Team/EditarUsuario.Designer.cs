
namespace Soft_Team
{
    partial class EditarUsuario
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
            System.Windows.Forms.Label nom_1Label;
            System.Windows.Forms.Label nom_2Label;
            System.Windows.Forms.Label ape_1Label;
            System.Windows.Forms.Label ape_2Label;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label rolLabel;
            System.Windows.Forms.Label label2;
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Soft_Team1DataSet = new Soft_Team._Soft_Team1DataSet();
            this.usuarioTableAdapter = new Soft_Team._Soft_Team1DataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new Soft_Team._Soft_Team1DataSetTableAdapters.TableAdapterManager();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.ape_2TextBox = new System.Windows.Forms.TextBox();
            this.ape_1TextBox = new System.Windows.Forms.TextBox();
            this.nom_2TextBox = new System.Windows.Forms.TextBox();
            this.nom_1TextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox1 = new System.Windows.Forms.TextBox();
            nom_1Label = new System.Windows.Forms.Label();
            nom_2Label = new System.Windows.Forms.Label();
            ape_1Label = new System.Windows.Forms.Label();
            ape_2Label = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Soft_Team1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_1Label
            // 
            nom_1Label.AutoSize = true;
            nom_1Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            nom_1Label.Location = new System.Drawing.Point(66, 125);
            nom_1Label.Name = "nom_1Label";
            nom_1Label.Size = new System.Drawing.Size(90, 13);
            nom_1Label.TabIndex = 1;
            nom_1Label.Text = "Primer Nombre:*";
            // 
            // nom_2Label
            // 
            nom_2Label.AutoSize = true;
            nom_2Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            nom_2Label.Location = new System.Drawing.Point(55, 158);
            nom_2Label.Name = "nom_2Label";
            nom_2Label.Size = new System.Drawing.Size(94, 13);
            nom_2Label.TabIndex = 3;
            nom_2Label.Text = "Segundo Nombre:";
            // 
            // ape_1Label
            // 
            ape_1Label.AutoSize = true;
            ape_1Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            ape_1Label.Location = new System.Drawing.Point(64, 195);
            ape_1Label.Name = "ape_1Label";
            ape_1Label.Size = new System.Drawing.Size(92, 13);
            ape_1Label.TabIndex = 5;
            ape_1Label.Text = "Primer Apellido:*";
            // 
            // ape_2Label
            // 
            ape_2Label.AutoSize = true;
            ape_2Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            ape_2Label.Location = new System.Drawing.Point(53, 228);
            ape_2Label.Name = "ape_2Label";
            ape_2Label.Size = new System.Drawing.Size(96, 13);
            ape_2Label.TabIndex = 7;
            ape_2Label.Text = "Segundo Apellido:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            usuarioLabel.Location = new System.Drawing.Point(101, 326);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(48, 13);
            usuarioLabel.TabIndex = 11;
            usuarioLabel.Text = "Usuario:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            contraseñaLabel.Location = new System.Drawing.Point(85, 357);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(63, 13);
            contraseñaLabel.TabIndex = 13;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            rolLabel.Location = new System.Drawing.Point(122, 292);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(27, 13);
            rolLabel.TabIndex = 24;
            rolLabel.Text = "Rol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            label2.Location = new System.Drawing.Point(107, 259);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 13);
            label2.TabIndex = 33;
            label2.Text = "Correo:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(300, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Usuario";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.button1.Location = new System.Drawing.Point(323, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.button2.Location = new System.Drawing.Point(423, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this._Soft_Team1DataSet;
            // 
            // _Soft_Team1DataSet
            // 
            this._Soft_Team1DataSet.DataSetName = "_Soft_Team1DataSet";
            this._Soft_Team1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaquinasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Soft_Team._Soft_Team1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(162, 255);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(322, 20);
            this.correoTextBox.TabIndex = 34;
            // 
            // rolComboBox
            // 
            this.rolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "rol", true));
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Location = new System.Drawing.Point(162, 288);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(153, 21);
            this.rolComboBox.TabIndex = 35;
            this.rolComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rolComboBox_KeyPress);
            // 
            // ape_2TextBox
            // 
            this.ape_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "ape_2", true));
            this.ape_2TextBox.Location = new System.Drawing.Point(162, 224);
            this.ape_2TextBox.Name = "ape_2TextBox";
            this.ape_2TextBox.Size = new System.Drawing.Size(354, 20);
            this.ape_2TextBox.TabIndex = 36;
            // 
            // ape_1TextBox
            // 
            this.ape_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "ape_1", true));
            this.ape_1TextBox.Location = new System.Drawing.Point(162, 191);
            this.ape_1TextBox.Name = "ape_1TextBox";
            this.ape_1TextBox.Size = new System.Drawing.Size(354, 20);
            this.ape_1TextBox.TabIndex = 37;
            // 
            // nom_2TextBox
            // 
            this.nom_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nom_2", true));
            this.nom_2TextBox.Location = new System.Drawing.Point(162, 154);
            this.nom_2TextBox.Name = "nom_2TextBox";
            this.nom_2TextBox.Size = new System.Drawing.Size(354, 20);
            this.nom_2TextBox.TabIndex = 38;
            // 
            // nom_1TextBox
            // 
            this.nom_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nom_1", true));
            this.nom_1TextBox.Location = new System.Drawing.Point(162, 121);
            this.nom_1TextBox.Name = "nom_1TextBox";
            this.nom_1TextBox.Size = new System.Drawing.Size(354, 20);
            this.nom_1TextBox.TabIndex = 39;
            // 
            // usuarioTextBox1
            // 
            this.usuarioTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "usuario", true));
            this.usuarioTextBox1.Location = new System.Drawing.Point(162, 322);
            this.usuarioTextBox1.Name = "usuarioTextBox1";
            this.usuarioTextBox1.Size = new System.Drawing.Size(232, 20);
            this.usuarioTextBox1.TabIndex = 40;
            // 
            // contrasenaTextBox1
            // 
            this.contrasenaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "contrasena", true));
            this.contrasenaTextBox1.Location = new System.Drawing.Point(162, 353);
            this.contrasenaTextBox1.Name = "contrasenaTextBox1";
            this.contrasenaTextBox1.Size = new System.Drawing.Size(218, 20);
            this.contrasenaTextBox1.TabIndex = 41;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 475);
            this.Controls.Add(this.contrasenaTextBox1);
            this.Controls.Add(this.usuarioTextBox1);
            this.Controls.Add(this.nom_1TextBox);
            this.Controls.Add(this.nom_2TextBox);
            this.Controls.Add(this.ape_1TextBox);
            this.Controls.Add(this.ape_2TextBox);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(rolLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(ape_2Label);
            this.Controls.Add(ape_1Label);
            this.Controls.Add(nom_2Label);
            this.Controls.Add(nom_1Label);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Soft_Team1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private _Soft_Team1DataSet _Soft_Team1DataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private _Soft_Team1DataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private _Soft_Team1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.TextBox ape_2TextBox;
        private System.Windows.Forms.TextBox ape_1TextBox;
        private System.Windows.Forms.TextBox nom_2TextBox;
        private System.Windows.Forms.TextBox nom_1TextBox;
        private System.Windows.Forms.TextBox usuarioTextBox1;
        private System.Windows.Forms.TextBox contrasenaTextBox1;
    }
}