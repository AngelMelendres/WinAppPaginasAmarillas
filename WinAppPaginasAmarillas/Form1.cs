using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPaginasAmarillas
{
    public partial class Form1 : Form
    {
        



        public Form1()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
        

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormIngresarDatos>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormBuscar>();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormEliminar>();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormModificar>();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormMostrarDatos>();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormListar>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormIngresarDatos forme = new FormIngresarDatos();
            
            
            forme.ShowDialog();
        }
    }
}
