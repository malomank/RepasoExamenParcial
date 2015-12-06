namespace Vista
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDedicacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código: ";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(79, 16);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(111, 20);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(79, 57);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(198, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(79, 99);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(111, 20);
            this.textBoxDNI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dedicación:";
            // 
            // comboBoxDedicacion
            // 
            this.comboBoxDedicacion.FormattingEnabled = true;
            this.comboBoxDedicacion.Items.AddRange(new object[] {
            "TC - Tiempo Completo",
            "TPA - Tiempo Parcial por Asignaturas",
            "TPC20: Tiempo Parcial 20 horas",
            "TPC30: Tiempo Parcial 30 horas"});
            this.comboBoxDedicacion.Location = new System.Drawing.Point(79, 208);
            this.comboBoxDedicacion.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDedicacion.Name = "comboBoxDedicacion";
            this.comboBoxDedicacion.Size = new System.Drawing.Size(327, 21);
            this.comboBoxDedicacion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoría:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Profesor Contratado",
            "Profesor Ordinario - Auxiliar",
            "Profesor Ordinario - Asociado",
            "Profesor Ordinario - Principal"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(79, 252);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(324, 21);
            this.comboBoxCategoria.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 372);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha Inicio:";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(83, 290);
            this.dateTimePickerInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(135, 20);
            this.dateTimePickerInicio.TabIndex = 13;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(83, 336);
            this.dateTimePickerFin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(135, 20);
            this.dateTimePickerFin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Fin:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(13, 137);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 16;
            this.lblCorreo.Text = "Correo:";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(79, 134);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(198, 20);
            this.textBoxCorreo.TabIndex = 17;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(13, 172);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(79, 169);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(111, 20);
            this.textBoxTelefono.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 409);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDedicacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Agregar Profesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDedicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
    }
}