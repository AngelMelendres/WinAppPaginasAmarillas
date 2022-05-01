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


        ClassPaginasAmarillas objPagina = new ClassPaginasAmarillas();
        List<cServicio> lista = ClassPaginasAmarillas.Instance.mostrarTodosServicios();

        public FormIngresarDatos()
        {
            InitializeComponent();
        }

        private void FormIngresarDatos_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void actualizarGrid()
        {

            // dgvListadoServicios.DataSource = null;
            //dgvListadoServicios.AutoGenerateColumns = true;
            //dgvListadoServicios.DataSource = objPagina.mostrarTodosServicios();

            for (int j = 0; j < lista.Count; j++)
            {
                dgvListadoServicios.Rows.Add();


                dgvListadoServicios.Rows[j].Cells[0].Value = lista.ToArray()[j].getTitulo();
                dgvListadoServicios.Rows[j].Cells[1].Value = lista.ToArray()[j].getPropietario();
                dgvListadoServicios.Rows[j].Cells[2].Value = lista.ToArray()[j].getDescripcion();
                dgvListadoServicios.Rows[j].Cells[3].Value = lista.ToArray()[j].getCategoria();
                dgvListadoServicios.Rows[j].Cells[4].Value = lista.ToArray()[j].getTelefono();
                dgvListadoServicios.Rows[j].Cells[5].Value = lista.ToArray()[j].getEmail();
                dgvListadoServicios.Rows[j].Cells[6].Value = lista.ToArray()[j].getDireccion();
               


            }




        }
        private void reseteo()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            txtPropietario.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            comboBoxCategoria.Items.Clear();
            txtDireccion.Clear();

        }


        public bool validarDatos()
        {
            

            if (txtTitulo.Text == null || txtTitulo.Text=="")
            {
                MessageBox.Show("Ingrese titulo");
                
                return true ;
                
            }
            if (txtDescripcion.Text == null || txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese Descripcion");
                return true;

            }
            if (txtPropietario.Text == null || txtPropietario.Text == "")
            {
                MessageBox.Show("Ingrese Propietario");
                return true;
            }
            if (txtTelefono.Text == null || txtTelefono.Text == "")
            {
                MessageBox.Show("Ingrese telefono");
                return true;
            }
            if (txtEmail.Text == null || txtEmail.Text == "")
            {
                MessageBox.Show("Ingrese Email");
                return true;
            }
            if (txtDireccion.Text == null || txtDireccion.Text == "")
            {
                MessageBox.Show("Ingrese direccion");
                return true;
            }
            if(comboBoxCategoria.SelectedIndex.ToString()==null || comboBoxCategoria.SelectedIndex.ToString()== "")
            {
                MessageBox.Show("Ingrese Categoria");
                return true;
            }


            return false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //if (validarDatos()) { return; }
            ClassPaginasAmarillas.Instance.agregarServicio(txtTitulo.Text,txtDescripcion.Text,txtTelefono.Text,txtPropietario.Text,txtEmail.Text,txtDireccion.Text, comboBoxCategoria.SelectedIndex.ToString());
            actualizarGrid();//llamamos al procedimiento que guarda en datagrid
            reseteo(); //llamamos al método que resetea
            
           
        }

       
    }
}
