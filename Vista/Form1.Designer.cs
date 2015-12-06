namespace Vista
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atencionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoPieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoColumnasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reunionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaReunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesiónToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.registrarUsuarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
            this.iniciarSesiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Visible = false;
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarUsuarioToolStripMenuItem.Visible = false;
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atencionesToolStripMenuItem,
            this.reunionesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Visible = false;
            // 
            // atencionesToolStripMenuItem
            // 
            this.atencionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficoToolStripMenuItem,
            this.graficoPieToolStripMenuItem,
            this.graficoColumnasToolStripMenuItem});
            this.atencionesToolStripMenuItem.Name = "atencionesToolStripMenuItem";
            this.atencionesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.atencionesToolStripMenuItem.Text = "Atenciones";
            this.atencionesToolStripMenuItem.Click += new System.EventHandler(this.atencionesToolStripMenuItem_Click);
            // 
            // graficoToolStripMenuItem
            // 
            this.graficoToolStripMenuItem.Name = "graficoToolStripMenuItem";
            this.graficoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.graficoToolStripMenuItem.Text = "Grafico";
            this.graficoToolStripMenuItem.Click += new System.EventHandler(this.graficoToolStripMenuItem_Click);
            // 
            // graficoPieToolStripMenuItem
            // 
            this.graficoPieToolStripMenuItem.Name = "graficoPieToolStripMenuItem";
            this.graficoPieToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.graficoPieToolStripMenuItem.Text = "Grafico Pie";
            this.graficoPieToolStripMenuItem.Click += new System.EventHandler(this.graficoPieToolStripMenuItem_Click);
            // 
            // graficoColumnasToolStripMenuItem
            // 
            this.graficoColumnasToolStripMenuItem.Name = "graficoColumnasToolStripMenuItem";
            this.graficoColumnasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.graficoColumnasToolStripMenuItem.Text = "Grafico Columnas";
            this.graficoColumnasToolStripMenuItem.Click += new System.EventHandler(this.graficoColumnasToolStripMenuItem_Click);
            // 
            // reunionesToolStripMenuItem
            // 
            this.reunionesToolStripMenuItem.Name = "reunionesToolStripMenuItem";
            this.reunionesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.reunionesToolStripMenuItem.Text = "Reuniones";
            this.reunionesToolStripMenuItem.Click += new System.EventHandler(this.reunionesToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(763, 427);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(252, 427);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nodeMouseClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaProfesor,
            this.ColumnaReunion,
            this.ColumnFecha,
            this.ColumnTema,
            this.ColumnAlumno});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 427);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ColumnaProfesor
            // 
            this.ColumnaProfesor.HeaderText = "Profesor";
            this.ColumnaProfesor.Name = "ColumnaProfesor";
            this.ColumnaProfesor.ReadOnly = true;
            // 
            // ColumnaReunion
            // 
            this.ColumnaReunion.HeaderText = "Reuniones";
            this.ColumnaReunion.Name = "ColumnaReunion";
            this.ColumnaReunion.ReadOnly = true;
            this.ColumnaReunion.Visible = false;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnTema
            // 
            this.ColumnTema.HeaderText = "Tema";
            this.ColumnTema.Name = "ColumnTema";
            this.ColumnTema.ReadOnly = true;
            // 
            // ColumnAlumno
            // 
            this.ColumnAlumno.HeaderText = "Alumno";
            this.ColumnAlumno.Name = "ColumnAlumno";
            this.ColumnAlumno.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atencionesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaReunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAlumno;
        private System.Windows.Forms.ToolStripMenuItem graficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoPieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoColumnasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reunionesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
    }
}