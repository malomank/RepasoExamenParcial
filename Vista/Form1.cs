using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;
using Modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Practica2.Modelo;
using Practica2.Vista;
using System.Threading;


namespace Vista
{
    public partial class Form1 : Form
    {
        //UsuarioRegistrado usuario = null;
        public MyTimer mytimer;
        public Thread t;
        private bool IsThreadRunning;
        Practica2.ServiceReference1.GestorUsuarioClient cliente;
        Practica2.ServiceReference2.GestorTutoriaClient clienteTutoria;
        ReunionesPorFecha reporteReuniones;
        Form2 formularioProfesor;
        FormAlumno formularioALumno;
        formRegistrarUsuario formRegistrar;
        FormReunion formularioReunion;
        int tipoUsuario;
        string nombreUsuario;
        bool logueado = false;
        public Form1()
        {
            //crearBinario();
            InitializeComponent();
            this.dataGridView1.Visible = false;            
            mytimer = new MyTimer(0, 1, 0); //Tiempo de Timer
            label1.Visible = true;
            IsThreadRunning = false;
            cliente = new Practica2.ServiceReference1.GestorUsuarioClient();
            //clienteTutoria = new Practica2.ServiceReference2.GestorTutoriaClient();
        }
        /* Pregunta 6 */
        /// <summary>
        /// Este método debe mostrar la ventana de Login como un cuadro de diálogo modal
        /// Y verificar el usuario con respecto a los usuarios registrados en un
        /// archivo binario.
        /// </summary>
        /// <param name="sender">Genera el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //Si se pudo verificar el usuario debe mostrarse la información
            Login f = new Login(/*cliente*/);
            //f.ShowDialog(this);
            //crearBinario();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                clienteTutoria = new Practica2.ServiceReference2.GestorTutoriaClient();
                //usuario = Login.usuarioActual;
                //Console.WriteLine(Login.usuarioActual.Username);
                logueado = true;
                nombreUsuario = f.Nombre;
                tipoUsuario = f.Tipo;
                this.label1.Text = mytimer.imprimirFormato();
                this.label2.Text = "Usuario: " + nombreUsuario;
                label2.Visible = true;
                label1.Visible = true;
                t = new Thread(ActualizarTimer);
                t.Start();
                IsThreadRunning = true;
                
                iniciarSesiónToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = true;
                dataGridView1.Visible = true;
                cerrarSesiónToolStripMenuItem.Visible = true;
                if (tipoUsuario == 0)
                {
                    registrarUsuarioToolStripMenuItem.Visible = true;                    
                }
                
                cargarDatosDeBinario();
                cargarArbol();
                //cargarAlumnosDeBinario();
            }                
            //que se recupera de un archivo binario y cargar el arbol.
        }

        private void ActualizarTimer()
        {
            while (mytimer.quedaTiempo())
            {
                this.mytimer.tick_timer();

                /*Cambiar LABEL1*/
                MethodInvoker inv = delegate
                {
                    this.label1.Text = this.mytimer.imprimirFormato();
                };

                this.Invoke(inv);
                /*Cambiar LABEL1*/

                Thread.Sleep(1000);
            }

            if (MessageBox.Show("Tiempo de sesión culminado.", "Sesión finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {

                MethodInvoker inve = delegate
                {
                    logueado = false;
                    cerrarSesiónToolStripMenuItem.Visible = false;
                    reportesToolStripMenuItem.Visible = false;
                    iniciarSesiónToolStripMenuItem.Visible = true;
                    registrarUsuarioToolStripMenuItem.Visible = false;
                    //treeView1.Visible = false;
                    treeView1.Nodes.Clear();
                    dataGridView1.Visible = false;
                    dataGridView1.Rows.Clear();
                    crearDatosDeBinario();
                    this.label2.Text = "";
                    this.label2.Visible = false;
                    this.label1.Visible = false;
                    
                    if (reporteReuniones != null && reporteReuniones.Enabled == true && reporteReuniones.Visible == true)
                    {
                        reporteReuniones.Close();
                    }
                    if (formularioProfesor != null && formularioProfesor.Enabled == true && formularioProfesor.Visible == true)
                    {
                        formularioProfesor.Close();
                    }
                    if (formularioALumno != null && formularioALumno.Enabled == true && formularioALumno.Visible == true)
                    {
                        formularioALumno.Close();
                    }
                    if (formRegistrar != null && formRegistrar.Enabled == true && formRegistrar.Visible == true)
                    {
                        formRegistrar.Close();
                    }
                    if (formularioReunion != null && formularioReunion.Enabled == true && formularioReunion.Visible == true)
                    {
                        formularioReunion.Close();
                    }                    
                };

                this.Invoke(inve);

                AbortarThreadTimer();
            }
        }

        private void AbortarThreadTimer()
        {
            if (IsThreadRunning)
            {                
                mytimer.restablecer(0, 1, 0);

                /*Aborta Thread Timer*/
                if (!t.Join(0))
                {
                    t.Abort();
                }                
            }
        }

        /* Pregunta 5 */
        private void crearBinario()
        {
            FileStream outPut = new FileStream("usuarios.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter Formateador = new BinaryFormatter();
            UsuarioRegistrado[] usuarios =
            {
                new UsuarioRegistrado("Carlo Alva","Cohello19",0),
                new UsuarioRegistrado("Jaimy Taco","noDJ",1),
                new UsuarioRegistrado("Kevin Cruzado","1234",2)
            };
            foreach (UsuarioRegistrado u in usuarios)
            {
                Formateador.Serialize(outPut, u);
            }
            outPut.Close();
        }
        /* Pregunta 5 */
        private void cargarArbol()
        {
            /* Pregunta 6 */
            this.treeView1.BeginUpdate();
            this.treeView1.Nodes.Clear();
            //Practica2.ServiceReference2.Especialidad especialidad = clienteTutoria.getEspecialidad(1);
            this.treeView1.Nodes.Add("Especialidad","Ingeniería Informática");
            int numTutores = clienteTutoria.getNumeroTutores();
            //Practica2.ServiceReference2.Profesor tutor;
            //Practica2.ServiceReference2.Alumno[] ListaAlumno;
            for (int i = 0; i < numTutores; i++){
                Practica2.ServiceReference2.Profesor tutor = clienteTutoria.getTutor(i);             
                this.treeView1.Nodes[0].Nodes.Add("Profesor", tutor.Codigo + "-" + tutor.Nombre);
                Practica2.ServiceReference2.Alumno[] ListaAlumno = clienteTutoria.getAlumnos(tutor);
                for (int j=0;j< ListaAlumno.Length; j++){
                //for (int j=0;j<GestorTutores.Tutores[i].ListaAlumno.Count;j++){
                    string mostrar = ListaAlumno[j].Codigo + "-" + ListaAlumno[j].Nombre + " (" + ListaAlumno[j].Unidad + ")";
                    //string mostrar = GestorTutores.Tutores[i].ListaAlumno[j].Codigo + "--" + GestorTutores.Tutores[i].ListaAlumno[j].Nombre;
                    if (tipoUsuario == 0)
                    {
                        this.treeView1.Nodes[0].Nodes[i].Nodes.Add("Alumno", mostrar);
                        /*
                        if (GestorTutores.Tutores[i].ListaAlumno[j] is AlumnoEEGGCC)
                        {
                            mostrar = mostrar + " (EEGGCC)";
                        }
                        else
                        {
                            mostrar = mostrar + " (FCI)";
                        }
                        this.treeView1.Nodes[0].Nodes[i].Nodes.Add("Alumno", mostrar);*/
                    }
                    else if (tipoUsuario == 1  && ListaAlumno[j].Unidad=="EEGGCC" )
                    {
                        this.treeView1.Nodes[0].Nodes[i].Nodes.Add("Alumno", mostrar);
                        /*if (GestorTutores.Tutores[i].ListaAlumno[j] is AlumnoEEGGCC)
                        {
                            mostrar = mostrar + " (EEGGCC)";
                            this.treeView1.Nodes[0].Nodes[i].Nodes.Add("Alumno", mostrar);
                        }*/
                    }
                    else if (tipoUsuario == 2 && ListaAlumno[j].Unidad=="FCI" )
                    {
                        this.treeView1.Nodes[0].Nodes[i].Nodes.Add("Alumno", mostrar);
                        /*if (GestorTutores.Tutores[i].ListaAlumno[j] is AlumnoFCI)
                        {
                            mostrar = mostrar + " (FCI)";
                            this.treeView1.Nodes[0].Nodes[i].Nodes.Add("Alumno", mostrar);
                        }*/
                    }                   
                }                      
            }
            this.treeView1.EndUpdate();
        }

        private void nodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Button==MouseButtons.Left){
                if (e.Node.Name == "Alumno") {
                    this.dataGridView1.Visible = true;
                    cargarTabla(e.Node);
                }                                   
            }
            else
                if (e.Button == MouseButtons.Right)
                {
                    if (e.Node.Name == "Especialidad")
                    {
                        e.Node.ContextMenu = new ContextMenu();
                        e.Node.ContextMenu.MenuItems.Add("Agregar Profesor");
                        //treeView1.SelectedNode = e.Node;
                        e.Node.ContextMenu.MenuItems[0].Click += new EventHandler(agregarProfesor);                         
                    }
                    else if(e.Node.Name == "Profesor")
                    {
                        e.Node.ContextMenu = new ContextMenu();
                        e.Node.ContextMenu.MenuItems.Add("Agregar Alumno");
                        treeView1.SelectedNode = e.Node;
                        e.Node.ContextMenu.MenuItems[0].Click += new EventHandler(agregarAlumno);
                    }
                        else if(e.Node.Name == "Alumno")
                {
                    e.Node.ContextMenu = new ContextMenu();
                    e.Node.ContextMenu.MenuItems.Add("Agregar Reunión");
                    treeView1.SelectedNode = e.Node;
                    e.Node.ContextMenu.MenuItems[0].Click += new EventHandler(agregarReunion);
                }                  
                }
                    

        }
        /// <summary>
        /// Este método debe cargar la tabla con todas las reuniones del alumno
        /// seleccionado
        /// </summary>
        /// <param name="node">Alumno seleccionado</param>
        private void cargarTabla(TreeNode node)
        {
            string[] palabras = node.Text.Split('-');
            int codigo = extraerCodigo(palabras[0]);
            //int codigo = extraerCodigo(node.Text);
            //Alumno alumno = clienteTutoria.buscarAlumno(codigo);
            //Practica2.ServiceReference2.Alumno alumno = clienteTutoria.buscarAlumno(codigo);
            Practica2.ServiceReference2.Reunion[] listaReuniones = clienteTutoria.buscarReuniones(codigo);
            //Alumno alumno = GestorAlumnos.buscarAlumno(codigo);            
            ColumnAlumno.Visible = true;
            ColumnFecha.Visible = true;
            ColumnTema.Visible = true;
            ColumnaReunion.Visible = false;
            this.dataGridView1.Rows.Clear();
            //Para todas las reuniones
            foreach (Practica2.ServiceReference2.Reunion reu in listaReuniones)
            {//El 0 va xq reuniones está oculto
                this.dataGridView1.Rows.Add(reu.Profesor.Nombre, "0", reu.Fecha, reu.Tema, reu.Alumno.Nombre + " (" + reu.Alumno.Unidad+")");
            }
            
        }

        private int extraerCodigo(string p)
        {
            return int.Parse(p);
        }

        private void agregarProfesor(object sender, EventArgs e)
        {
            //Profesor profesor;
            formularioProfesor = new Form2(clienteTutoria);
            formularioProfesor.ShowDialog(this);
            if(formularioProfesor.DialogResult == DialogResult.OK)
                clienteTutoria.agregarProfesorTutor(Form2.ProfesorAgregado);
                //GestorTutores.Tutores.Add(new ProfesorTutor(Form2.ProfesorAgregado));
            cargarArbol();
        }

        private void agregarAlumno(object sender, EventArgs e)
        {
            //Mostrar el formulario de alumno
            formularioALumno = new FormAlumno(tipoUsuario, clienteTutoria);
            formularioALumno.ShowDialog(this);
            string[] palabras = this.treeView1.SelectedNode.Text.Split('-');
            if (formularioALumno.DialogResult == DialogResult.OK)
            {
                Practica2.ServiceReference2.Profesor p = clienteTutoria.buscarProfesor(extraerCodigo(palabras[0]));
                Console.Out.WriteLine("codigo: " + extraerCodigo(palabras[0]));
                FormAlumno.AlumnoAgregado.Tutor = p;
                clienteTutoria.agregarAlumno(FormAlumno.AlumnoAgregado);
            }
            cargarArbol();
        }

        private void agregarReunion(object sender, EventArgs e)
        {
            //Mostrar el formulario de reunion
            string[] label_alumno = this.treeView1.SelectedNode.Text.Split('-');
            
            formularioReunion = new FormReunion(clienteTutoria.buscarAlumno(extraerCodigo(label_alumno[0])));
            formularioReunion.ShowDialog(this);
            
            if (formularioReunion.DialogResult == DialogResult.OK) {

                Practica2.ServiceReference2.Alumno alumnoN = clienteTutoria.buscarAlumno(extraerCodigo(label_alumno[0]));
                Practica2.ServiceReference2.Profesor profesorN = clienteTutoria.buscarProfesor(alumnoN.Tutor.Codigo);

                clienteTutoria.agregarReunion(alumnoN, profesorN, FormReunion.ReunionAgregado.Fecha, FormReunion.ReunionAgregado.Tema, FormReunion.ReunionAgregado.Sugerencias);
            }
        }
        /* Pregunta 5 */
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logueado == false) { cargarDatosDeBinario(); }
            this.AbortarThreadTimer();
            //Validar que se guarda todo en archivos binarios
            crearDatosDeBinario();
            //cliente.guardarUsuarios();
            this.Dispose();
        }

        private void crearAlumnosDeBinario()
        {
            //GestorAlumnos.Alumnos.Add(new Alumno(20090217, "Carlo", 71313909, "carlo@pucp", 987199729, 7, 120));
            //GestorAlumnos.Alumnos.Add(new Alumno(20102115, "Jaimy noDJ", 12345678, "Jaimy@pucp", 123456789, 7, 119));
            FileStream outPut = new FileStream("alumnos.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter Formateador = new BinaryFormatter();
            Formateador.Serialize(outPut, GestorAlumnos.Alumnos);
            
            outPut.Close();
        }

        private void crearProfesoresDeBinario()
        {
            //GestorAlumnos.Alumnos.Add(new Alumno(20090217, "Carlo", 71313909, "carlo@pucp", 987199729, 7, 120));
            //GestorAlumnos.Alumnos.Add(new Alumno(20102115, "Jaimy noDJ", 12345678, "Jaimy@pucp", 123456789, 7, 119));
            FileStream outPut = new FileStream("tutores.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter Formateador = new BinaryFormatter();
            Formateador.Serialize(outPut, GestorTutores.Tutores);

            outPut.Close();
        }

        private void crearDatosDeBinario()
        {
            crearAlumnosDeBinario();
            crearProfesoresDeBinario();
        }

        private void cargarAlumnosDeBinario()
        {
            FileStream input = new FileStream("alumnos.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter Formateador = new BinaryFormatter();
            GestorAlumnos.Alumnos = (List<Alumno>)Formateador.Deserialize(input);
            foreach(Alumno nA in GestorAlumnos.Alumnos)
            {
                //Console.WriteLine(nA.formatearMostrar());
            }
            input.Close();
        }

        private void cargarProfesoresDeBinario()
        {
            FileStream input = new FileStream("tutores.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter Formateador = new BinaryFormatter();
            GestorTutores.Tutores = (List<ProfesorTutor>)Formateador.Deserialize(input);

            input.Close();
        }

        private void cargarDatosDeBinario()
        {
            try{ 
            cargarAlumnosDeBinario();
            cargarProfesoresDeBinario();
            }
            catch (FileNotFoundException e)
            {

            }
        }
        /* Pregunta 5 */
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logueado = false;
            cerrarSesiónToolStripMenuItem.Visible = false;
            reportesToolStripMenuItem.Visible = false;
            //treeView1.Visible = false;
            treeView1.Nodes.Clear();
            dataGridView1.Visible = false;
            dataGridView1.Rows.Clear();
            registrarUsuarioToolStripMenuItem.Visible = false;
            iniciarSesiónToolStripMenuItem.Visible = true;
            this.label2.Text = "";
            this.label2.Visible = false;
            this.label1.Visible = false;

            //treeView1.Visible = false;
            //dataGridView1.Visible = false;
            //cliente.guardarUsuarios();

            //clienteTutoria.desconectarBD_DesdeGestor();
            crearDatosDeBinario();
            AbortarThreadTimer();
        }
        /* Pregunta 5 */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logueado == false) { cargarDatosDeBinario(); }            
            //Validar que se guarda todo en archivos binarios
            //cliente.guardarUsuarios();
            crearDatosDeBinario();
            this.AbortarThreadTimer();
            this.Dispose();
        }
        /* Pregunta 6 */ 
        private void atencionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            this.dataGridView1.Rows.Clear();
            ColumnAlumno.Visible = false;
            ColumnFecha.Visible = false;
            ColumnTema.Visible = false;
            ColumnaReunion.Visible = true;

            if (tipoUsuario == 0) { 
                foreach (ProfesorTutor profe in GestorTutores.Tutores)
                {//El 0 va xq reuniones está oculto                                   
                    this.dataGridView1.Rows.Add(profe.Profesor.Nombre, profe.ListaReunion.Count.ToString(), "0", "0", "0");
                }
            }
            if (tipoUsuario == 1)
            {
                for (int i = 0; i < GestorTutores.Tutores.Count; i++)
                {
                    int atendidos = 0;
                    for (int j = 0; j < GestorTutores.Tutores[i].ListaReunion.Count; j++)
                    {
                        if (GestorTutores.Tutores[i].ListaReunion[j].Alumno is AlumnoEEGGCC)
                            atendidos++;
                    }

                    this.dataGridView1.Rows.Add(GestorTutores.Tutores[i].Profesor.Nombre, atendidos, "0", "0", "0");
                }
            }
            if (tipoUsuario == 2)
            {
                for (int i = 0; i < GestorTutores.Tutores.Count; i++)
                {
                    int atendidos = 0;
                    for (int j = 0; j < GestorTutores.Tutores[i].ListaReunion.Count; j++)
                    {
                        if (GestorTutores.Tutores[i].ListaReunion[j].Alumno is AlumnoFCI)
                            atendidos++;
                    }

                    this.dataGridView1.Rows.Add(GestorTutores.Tutores[i].Profesor.Nombre, atendidos, "0", "0", "0");
                }
            }

        }

        private void pintar()
        {
            Graphics g = this.splitContainer1.Panel2.CreateGraphics();
            
            Font fTexto = this.splitContainer1.Panel2.Font;
            Brush b = Brushes.Black;

            //g.DrawString("Aqui va el Grafico", fTexto, b, 200, 100);
            int max1 = -1, max2 = -1, max3 = -1;
            string nombre1 = "", nombre2 = "", nombre3 = "";

            foreach (ProfesorTutor p in GestorTutores.Tutores)
            {
                int numReunion = p.ListaReunion.Count;

                if (numReunion > max1)
                {
                    max1 = numReunion;
                    nombre1 = p.Profesor.Nombre;
                }
                else
                {
                    if (numReunion > max2)
                    {
                        max2 = numReunion;
                        nombre2 = p.Profesor.Nombre;
                    }
                    else
                    {
                        if (numReunion > max3)
                        {
                            max3 = numReunion;
                            nombre3 = p.Profesor.Nombre;
                        }
                    }
                }

            }



            //Grafico
            int x = 1, y = 40, tamanho = 5;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            g.DrawString("Top 3 de Reuniones por profesor", fTexto, b, new Point(x + 100, y-20));
            g.DrawLine(pen, x + 100, y, x + 100, y + 250);
            g.DrawLine(pen, x + 100, y + 250, x + 500, y + 250);

            /*Numeros del eje Y*/
            for (int i = 0; i < 250 / tamanho; i += tamanho)
            {
                if (i > 0)
                {
                    string etiqueta = "" + i;
                    if (i < 10) etiqueta += "    -";
                    else etiqueta += "  -";
                    g.DrawString(etiqueta, fTexto, b, x + 100 - 20, y + 250 - i * tamanho);
                }
            }

            g.DrawString(nombre1 + "     " + nombre2 + "      " + nombre3, fTexto, b, x + 150, y + 270);

            //Cantidades
            if (max1 > 0)
                g.DrawString("" + max1, fTexto, b, x + 175, y + 170 + (50 - tamanho) - tamanho * (max1 - 1));
            if (max2 > 0)
                g.DrawString("" + max2, fTexto, b, x + 175 + 100, y + 170 + (50 - tamanho) - tamanho * (max2 - 1));
            if (max3 > 0)
                g.DrawString("" + max3, fTexto, b, x + 175 + 100 + 100, y + 170 + (50 - tamanho) - tamanho * (max3 - 1));

            //Rectangulos
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);

            if (max1 > 0)
            {
                Rectangle rectangle1 = new Rectangle(x + 100 + 70, y + 200 + (50 - tamanho) - tamanho * (max1 - 1), 20, tamanho * max1);
                g.FillRectangle(myBrush, rectangle1);
            }
            if (max2 > 0)
            {
                Rectangle rectangle2 = new Rectangle(x + 100 + 70 + 100, y + 200 + (50 - tamanho) - tamanho * (max2 - 1), 20, tamanho * max2);
                g.FillRectangle(myBrush, rectangle2);
                //g.DrawRectangle(Pens.Blue, x + 100 + 70 + 100, y + 200 + (50 - tamanho) - tamanho * (max2 - 1), 20, tamanho * max2); //de max2
            }
            if (max3 > 0)
            {
                Rectangle rectangle3 = new Rectangle(x + 100 + 70 + 200, y + 200 + (50 - tamanho) - tamanho * (max3 - 1), 20, tamanho * max3);
                g.FillRectangle(myBrush, rectangle3);
                //g.DrawRectangle(Pens.Green, x + 100 + 70 + 200, y + 200 + (50 - tamanho) - tamanho * (max3 - 1), 20, tamanho * max3); //de max3
            }
            
        }

         private void graficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            pintar();
        }



        private void graficoPieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atencionesToolStripMenuItem_Click(sender, e);
            PieChart grafico1 = new PieChart();

            grafico1.Show(this);
        }

        private void graficoColumnasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atencionesToolStripMenuItem_Click(sender, e);
            ColumnChart grafico1 = new ColumnChart();

            grafico1.Show(this);
        }
        /* Pregunta 6 */
        private void reunionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteReuniones = new ReunionesPorFecha(this);
            if (reporteReuniones.ShowDialog(this) == DialogResult.None && !t.IsAlive)
            {
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //MessageBox.Show("MenuStrip1 Click");
            mytimer.restablecer(0, 1, 0);
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Tree View1 Click");
            mytimer.restablecer(0, 1, 0);   
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Grid 1 Click");
            mytimer.restablecer(0, 1, 0);
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRegistrar = new formRegistrarUsuario();
            //Practica2.ServiceReference1.Service1Client cliente2 = new Practica2.ServiceReference1.Service1Client();
            if (formRegistrar.ShowDialog(this) == DialogResult.OK)
            {
                //cliente2.agregarUsuario(formRegistrarUsuario.usuarioNuevo.Username, formRegistrarUsuario.usuarioNuevo.Password, formRegistrarUsuario.usuarioNuevo.Tipo);
            }
        }
    }
}
