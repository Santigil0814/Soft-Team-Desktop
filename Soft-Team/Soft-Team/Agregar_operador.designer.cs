
namespace Soft_Team
{
    partial class Agregar_operador
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_operador));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._Soft_Team1DataSet = new Soft_Team._Soft_Team1DataSet();
            this.operadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operadoresTableAdapter = new Soft_Team._Soft_Team1DataSetTableAdapters.OperadoresTableAdapter();
            this.tableAdapterManager = new Soft_Team._Soft_Team1DataSetTableAdapters.TableAdapterManager();
            this.nom_1TextBox = new System.Windows.Forms.TextBox();
            this.nom_2TextBox = new System.Windows.Forms.TextBox();
            this.ape_1TextBox = new System.Windows.Forms.TextBox();
            this.ape_2TextBox = new System.Windows.Forms.TextBox();
            this.fichaOperadorTextBox = new System.Windows.Forms.TextBox();
            nom_1Label = new System.Windows.Forms.Label();
            nom_2Label = new System.Windows.Forms.Label();
            ape_1Label = new System.Windows.Forms.Label();
            ape_2Label = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Soft_Team1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_1Label
            // 
            nom_1Label.AutoSize = true;
            nom_1Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_1Label.Location = new System.Drawing.Point(116, 143);
            nom_1Label.Name = "nom_1Label";
            nom_1Label.Size = new System.Drawing.Size(90, 13);
            nom_1Label.TabIndex = 3;
            nom_1Label.Text = "Primer Nombre:*";
            // 
            // nom_2Label
            // 
            nom_2Label.AutoSize = true;
            nom_2Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_2Label.Location = new System.Drawing.Point(102, 173);
            nom_2Label.Name = "nom_2Label";
            nom_2Label.Size = new System.Drawing.Size(94, 13);
            nom_2Label.TabIndex = 5;
            nom_2Label.Text = "Segundo Nombre:";
            // 
            // ape_1Label
            // 
            ape_1Label.AutoSize = true;
            ape_1Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ape_1Label.Location = new System.Drawing.Point(114, 203);
            ape_1Label.Name = "ape_1Label";
            ape_1Label.Size = new System.Drawing.Size(92, 13);
            ape_1Label.TabIndex = 7;
            ape_1Label.Text = "Primer Apellido:*";
            // 
            // ape_2Label
            // 
            ape_2Label.AutoSize = true;
            ape_2Label.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ape_2Label.Location = new System.Drawing.Point(100, 236);
            ape_2Label.Name = "ape_2Label";
            ape_2Label.Size = new System.Drawing.Size(96, 13);
            ape_2Label.TabIndex = 9;
            ape_2Label.Text = "Segundo Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(115, 271);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 13);
            label2.TabIndex = 10;
            label2.Text = "Ficha Operador:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Nuevo Operador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(371, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(471, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _Soft_Team1DataSet
            // 
            this._Soft_Team1DataSet.DataSetName = "_Soft_Team1DataSet";
            this._Soft_Team1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operadoresBindingSource
            // 
            this.operadoresBindingSource.DataMember = "Operadores";
            this.operadoresBindingSource.DataSource = this._Soft_Team1DataSet;
            // 
            // operadoresTableAdapter
            // 
            this.operadoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.maquinaria_mantenimientoTableAdapter = null;
            this.tableAdapterManager.MaquinasTableAdapter = null;
            this.tableAdapterManager.OperadoresTableAdapter = this.operadoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Soft_Team._Soft_Team1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // nom_1TextBox
            // 
            this.nom_1TextBox.Location = new System.Drawing.Point(247, 139);
            this.nom_1TextBox.Name = "nom_1TextBox";
            this.nom_1TextBox.Size = new System.Drawing.Size(378, 20);
            this.nom_1TextBox.TabIndex = 1;
            // 
            // nom_2TextBox
            // 
            this.nom_2TextBox.Location = new System.Drawing.Point(247, 169);
            this.nom_2TextBox.Name = "nom_2TextBox";
            this.nom_2TextBox.Size = new System.Drawing.Size(378, 20);
            this.nom_2TextBox.TabIndex = 2;
            // 
            // ape_1TextBox
            // 
            this.ape_1TextBox.Location = new System.Drawing.Point(247, 199);
            this.ape_1TextBox.Name = "ape_1TextBox";
            this.ape_1TextBox.Size = new System.Drawing.Size(378, 20);
            this.ape_1TextBox.TabIndex = 3;
            // 
            // ape_2TextBox
            // 
            this.ape_2TextBox.Location = new System.Drawing.Point(247, 232);
            this.ape_2TextBox.Name = "ape_2TextBox";
            this.ape_2TextBox.Size = new System.Drawing.Size(378, 20);
            this.ape_2TextBox.TabIndex = 4;
            // 
            // fichaOperadorTextBox
            // 
            this.fichaOperadorTextBox.Location = new System.Drawing.Point(247, 267);
            this.fichaOperadorTextBox.Name = "fichaOperadorTextBox";
            this.fichaOperadorTextBox.Size = new System.Drawing.Size(378, 20);
            this.fichaOperadorTextBox.TabIndex = 5;
            this.fichaOperadorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fichaOperadorTextBox_KeyPress);
            // 
            // Agregar_operador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.fichaOperadorTextBox);
            this.Controls.Add(this.ape_2TextBox);
            this.Controls.Add(this.ape_1TextBox);
            this.Controls.Add(this.nom_2TextBox);
            this.Controls.Add(this.nom_1TextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(label2);
            this.Controls.Add(ape_2Label);
            this.Controls.Add(ape_1Label);
            this.Controls.Add(nom_2Label);
            this.Controls.Add(nom_1Label);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar_operador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_operador";
            this.Load += new System.EventHandler(this.Agregar_operador_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Soft_Team1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operadoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private _Soft_Team1DataSet _Soft_Team1DataSet;
        private System.Windows.Forms.BindingSource operadoresBindingSource;
        private _Soft_Team1DataSetTableAdapters.OperadoresTableAdapter operadoresTableAdapter;
        private _Soft_Team1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nom_1TextBox;
        private System.Windows.Forms.TextBox nom_2TextBox;
        private System.Windows.Forms.TextBox ape_1TextBox;
        private System.Windows.Forms.TextBox ape_2TextBox;
        private System.Windows.Forms.TextBox fichaOperadorTextBox;
    }
}