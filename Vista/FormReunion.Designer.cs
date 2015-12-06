namespace Practica2.Vista
{
    partial class FormReunion
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTema = new System.Windows.Forms.TextBox();
            this.textBoxSugerencia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(85, 193);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(100, 39);
            this.buttonAceptar.TabIndex = 0;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(236, 193);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(106, 39);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(107, 148);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sugerencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tema:";
            // 
            // textBoxTema
            // 
            this.textBoxTema.Location = new System.Drawing.Point(107, 93);
            this.textBoxTema.Name = "textBoxTema";
            this.textBoxTema.Size = new System.Drawing.Size(235, 20);
            this.textBoxTema.TabIndex = 6;
            // 
            // textBoxSugerencia
            // 
            this.textBoxSugerencia.Location = new System.Drawing.Point(107, 48);
            this.textBoxSugerencia.Name = "textBoxSugerencia";
            this.textBoxSugerencia.Size = new System.Drawing.Size(235, 20);
            this.textBoxSugerencia.TabIndex = 7;
            // 
            // FormReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.textBoxSugerencia);
            this.Controls.Add(this.textBoxTema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "FormReunion";
            this.Text = "FormReunion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTema;
        private System.Windows.Forms.TextBox textBoxSugerencia;
    }
}