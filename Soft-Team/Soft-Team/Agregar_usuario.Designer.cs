
namespace Soft_Team
{
    partial class Agregar_usuario
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
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label rolLabel;
            System.Windows.Forms.Label ape_2Label;
            System.Windows.Forms.Label ape_1Label;
            System.Windows.Forms.Label nom_2Label;
            System.Windows.Forms.Label nom_1Label;
            System.Windows.Forms.Label label2;
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._Soft_Team1DataSet = new Soft_Team._Soft_Team1DataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Soft_Team._Soft_Team1DataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new Soft_Team._Soft_Team1DataSetTableAdapters.TableAdapterManager();
            this.nom_1TextBox = new System.Windows.Forms.TextBox();
            this.nom_2TextBox = new System.Windows.Forms.TextBox();
            this.ape_1TextBox = new System.Windows.Forms.TextBox();
            this.ape_2TextBox = new System.Windows.Forms.TextBox();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            contraseñaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            ape_2Label = new System.Windows.Forms.Label();
            ape_1Label = new System.Windows.Forms.Label();
            nom_2Label = new System.Windows.Forms.Label();
            nom_1Label = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Soft_Team1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contraseñaLabel.Location = new System.Drawing.Point(81, 353);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(63, 13);
            contraseñaLabel.TabIndex = 14;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(99, 322);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(48, 13);
            usuarioLabel.TabIndex = 12;
            usuarioLabel.Text = "Usuario:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rolLabel.Location = new System.Drawing.Point(119, 288);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(27, 13);
            rolLabel.TabIndex = 10;
            rolLabel.Text = "Rol:";
            // 
            // ape_2Label
            // 
            ape_2Label.AutoSize = true;
            ape_2Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ape_2Label.Location = new System.Drawing.Point(52, 218);
            ape_2Label.Name = "ape_2Label";
            ape_2Label.Size = new System.Drawing.Size(96, 13);
            ape_2Label.TabIndex = 8;
            ape_2Label.Text = "Segundo Apellido:";
            // 
            // ape_1Label
            // 
            ape_1Label.AutoSize = true;
            ape_1Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ape_1Label.Location = new System.Drawing.Point(66, 185);
            ape_1Label.Name = "ape_1Label";
            ape_1Label.Size = new System.Drawing.Size(92, 13);
            ape_1Label.TabIndex = 6;
            ape_1Label.Text = "Primer Apellido:*";
            // 
            // nom_2Label
            // 
            nom_2Label.AutoSize = true;
            nom_2Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_2Label.Location = new System.Drawing.Point(54, 155);
            nom_2Label.Name = "nom_2Label";
            nom_2Label.Size = new System.Drawing.Size(94, 13);
            nom_2Label.TabIndex = 4;
            nom_2Label.Text = "Segundo Nombre:";
            // 
            // nom_1Label
            // 
            nom_1Label.AutoSize = true;
            nom_1Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_1Label.Location = new System.Drawing.Point(66, 125);
            nom_1Label.Name = "nom_1Label";
            nom_1Label.Size = new System.Drawing.Size(90, 13);
            nom_1Label.TabIndex = 2;
            nom_1Label.Text = "Primer Nombre:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Nuevo Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(323, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 9;
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
            this.button2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(423, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _Soft_Team1DataSet
            // 
            this._Soft_Team1DataSet.DataSetName = "_Soft_Team1DataSet";
            this._Soft_Team1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaquinasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Soft_Team._Soft_Team1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // nom_1TextBox
            // 
            this.nom_1TextBox.Location = new System.Drawing.Point(162, 121);
            this.nom_1TextBox.MaxLength = 15;
            this.nom_1TextBox.Name = "nom_1TextBox";
            this.nom_1TextBox.Size = new System.Drawing.Size(354, 20);
            this.nom_1TextBox.TabIndex = 1;
            // 
            // nom_2TextBox
            // 
            this.nom_2TextBox.Location = new System.Drawing.Point(162, 151);
            this.nom_2TextBox.MaxLength = 15;
            this.nom_2TextBox.Name = "nom_2TextBox";
            this.nom_2TextBox.Size = new System.Drawing.Size(354, 20);
            this.nom_2TextBox.TabIndex = 2;
            // 
            // ape_1TextBox
            // 
            this.ape_1TextBox.Location = new System.Drawing.Point(162, 178);
            this.ape_1TextBox.MaxLength = 15;
            this.ape_1TextBox.Name = "ape_1TextBox";
            this.ape_1TextBox.Size = new System.Drawing.Size(354, 20);
            this.ape_1TextBox.TabIndex = 3;
            // 
            // ape_2TextBox
            // 
            this.ape_2TextBox.Location = new System.Drawing.Point(162, 214);
            this.ape_2TextBox.MaxLength = 15;
            this.ape_2TextBox.Name = "ape_2TextBox";
            this.ape_2TextBox.Size = new System.Drawing.Size(354, 20);
            this.ape_2TextBox.TabIndex = 4;
            // 
            // rolComboBox
            // 
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.rolComboBox.Location = new System.Drawing.Point(162, 284);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(153, 21);
            this.rolComboBox.TabIndex = 6;
            this.rolComboBox.SelectedIndexChanged += new System.EventHandler(this.rolComboBox_SelectedIndexChanged);
            this.rolComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rolComboBox_KeyPress);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(162, 318);
            this.usuarioTextBox.MaxLength = 10;
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(232, 20);
            this.usuarioTextBox.TabIndex = 7;
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Location = new System.Drawing.Point(162, 349);
            this.contrasenaTextBox.MaxLength = 1000;
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.PasswordChar = '*';
            this.contrasenaTextBox.Size = new System.Drawing.Size(218, 20);
            this.contrasenaTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(107, 253);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 13);
            label2.TabIndex = 26;
            label2.Text = "Correo:*";
            // 
            // correoTextBox
            // 
            this.correoTextBox.Location = new System.Drawing.Point(162, 249);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(322, 20);
            this.correoTextBox.TabIndex = 5;
            // 
            // Agregar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 475);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(this.ape_2TextBox);
            this.Controls.Add(this.ape_1TextBox);
            this.Controls.Add(this.nom_2TextBox);
            this.Controls.Add(this.nom_1TextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(rolLabel);
            this.Controls.Add(ape_2Label);
            this.Controls.Add(ape_1Label);
            this.Controls.Add(nom_2Label);
            this.Controls.Add(nom_1Label);
            this.Controls.Add(this.label1);
            this.Name = "Agregar_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_usuario";
            this.Load += new System.EventHandler(this.Agregar_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Soft_Team1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox nom_1TextBox;
        private System.Windows.Forms.TextBox nom_2TextBox;
        private System.Windows.Forms.TextBox ape_1TextBox;
        private System.Windows.Forms.TextBox ape_2TextBox;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
    }
}