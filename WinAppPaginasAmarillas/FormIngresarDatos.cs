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
    public partial class FormIngresarDatos : Form
    {
        private List<cServicio> servicios = new List<cServicio>();
        private int edit_indice = -1;

        public FormIngresarDatos()
        {
            InitializeComponent();
        }

        private void FormIngresarDatos_Load(object sender, EventArgs e)
        {

        }

        private void actualizarGrid()
        {
            dgvListadoServicios.DataSource = null;
            dgvListadoServicios.DataSource = servicios; 
        }
        private void reseteo()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            txtPropietario.Clear();
            txtEmail.Clear();
            txtTelefono.clear();
            txtTipoServicio.Clear();
            txtDireccion.Clear();

        }

        private void dgvListadoServicios_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvListadoServicios.SelectedRows[0];
            //almacena en cual fila estoy

            int posicion = dgvListadoServicios.Rows.IndexOf(selected);
            //copio esa variable en índice editado

            edit_indice = posicion; 
            cServicio servicio = servicios[posicion];
            //lo que tiene el atributo se lo doy al textbox
            txtTitulo.Text = servicio.getTitulo();
            txtDescripcion = servicio.getDescripcion();
            txtPropietario = servicio.getPropietario();
            txtEmail = servicio.getEmail();
            txtTelefono = servicio.getTelefono();
            txtTipoServicio = servicio.getTipoServicio();
            txtDireccion = servicio.getDireccion();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cServicio servicio = new cServicio(1);

            servicio.setTitulo(txtTitulo.Text);
            servicio.setDescripcion(txtTitulo.Text);
            servicio.setTelefono(txtTitulo.Text);
            servicio.setDireccion(txtTitulo.Text);
            servicio.setPropietario(txtTitulo.Text);
            servicio.setTipoServicio(txt.TipoServicio.text);
            servicio.setEmail(txtTitulo.Text);

            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            reseteo(); //llamamos al método que resetea

        }
    }
}
