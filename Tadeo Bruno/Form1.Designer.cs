namespace Tadeo_Bruno
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoMascota = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numUDCantPersnonas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnSi = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtDescripcionMascota = new System.Windows.Forms.TextBox();
            this.txtDescripcionOtroAnimal = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCantPersnonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione tipo de mascota:";
            // 
            // cmbTipoMascota
            // 
            this.cmbTipoMascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMascota.FormattingEnabled = true;
            this.cmbTipoMascota.Location = new System.Drawing.Point(433, 23);
            this.cmbTipoMascota.Name = "cmbTipoMascota";
            this.cmbTipoMascota.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMascota.TabIndex = 3;
            this.cmbTipoMascota.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMascota_SelectedIndexChanged);
            this.cmbTipoMascota.SelectedValueChanged += new System.EventHandler(this.cmbTipoMascota_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad de personas con las que convive:";
            // 
            // numUDCantPersnonas
            // 
            this.numUDCantPersnonas.Location = new System.Drawing.Point(230, 103);
            this.numUDCantPersnonas.Name = "numUDCantPersnonas";
            this.numUDCantPersnonas.ReadOnly = true;
            this.numUDCantPersnonas.Size = new System.Drawing.Size(36, 20);
            this.numUDCantPersnonas.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "¿Convive con otros animales?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rbtnSi
            // 
            this.rbtnSi.AutoSize = true;
            this.rbtnSi.Location = new System.Drawing.Point(167, 144);
            this.rbtnSi.Name = "rbtnSi";
            this.rbtnSi.Size = new System.Drawing.Size(34, 17);
            this.rbtnSi.TabIndex = 7;
            this.rbtnSi.TabStop = true;
            this.rbtnSi.Text = "Si";
            this.rbtnSi.UseVisualStyleBackColor = true;
            this.rbtnSi.CheckedChanged += new System.EventHandler(this.rbtnSi_CheckedChanged);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(207, 144);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(39, 17);
            this.rbtnNo.TabIndex = 8;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.rbtnNo_CheckedChanged);
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(65, 23);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMascota.TabIndex = 9;
            this.txtNombreMascota.TextChanged += new System.EventHandler(this.txtNombreMascota_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(308, 202);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDescripcionMascota
            // 
            this.txtDescripcionMascota.Location = new System.Drawing.Point(289, 50);
            this.txtDescripcionMascota.Multiline = true;
            this.txtDescripcionMascota.Name = "txtDescripcionMascota";
            this.txtDescripcionMascota.Size = new System.Drawing.Size(265, 58);
            this.txtDescripcionMascota.TabIndex = 12;
            // 
            // txtDescripcionOtroAnimal
            // 
            this.txtDescripcionOtroAnimal.Location = new System.Drawing.Point(15, 167);
            this.txtDescripcionOtroAnimal.Multiline = true;
            this.txtDescripcionOtroAnimal.Name = "txtDescripcionOtroAnimal";
            this.txtDescripcionOtroAnimal.Size = new System.Drawing.Size(265, 58);
            this.txtDescripcionOtroAnimal.TabIndex = 13;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(479, 202);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 14;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 240);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtDescripcionOtroAnimal);
            this.Controls.Add(this.txtDescripcionMascota);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNombreMascota);
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.rbtnSi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numUDCantPersnonas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoMascota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Datos de la mascota";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDCantPersnonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoMascota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUDCantPersnonas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnSi;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtDescripcionMascota;
        private System.Windows.Forms.TextBox txtDescripcionOtroAnimal;
        private System.Windows.Forms.Button btnContinuar;
    }
}

