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
    public partial class FormEliminar : Form
    {
        private int edit_indice = -1;

        ClassPaginasAmarillas objPagina = new ClassPaginasAmarillas();
        List<cServicio> lista = ClassPaginasAmarillas.Instance.mostrarTodosServicios();

        public FormEliminar()
        {
            InitializeComponent();
            
          
            
        }
        private void FormEliminar_Load(object sender, EventArgs e)
        {
            actualizarGrid(lista);

        }

        private void actualizarGrid(List<cServicio> lista)
        {
              dgvListadoServicios.DataSource = null;
            //dgvListadoServicios.AutoGenerateColumns = true;
            //dgvListadoServicios.DataSource = objPagina.mostrarTodosServicios();
            for (int j = 0; j <lista.Count; j++)
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                objPagina.eliminarServicio(edit_indice);
                edit_indice = -1; //resetea variable a -1
                actualizarGrid(objPagina.mostrarTodosServicios());
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
            }

        }

        private void dgvListadoServicios_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvListadoServicios.SelectedRows[0];
            int posicion = dgvListadoServicios.Rows.IndexOf(selected);
            edit_indice = posicion;
            cServicio servicio = objPagina.mostrarTodosServicios()[posicion];


        }


        private void textBoxBusID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //arreglar no cambia estado del txt2
            if(textBoxBusID.Text=="")
            {
                textBoxBusTitulo.Enabled = true;
            }

        }

   

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            actualizarGrid(ClassPaginasAmarillas.Instance.busquedaPorTitulo(textBoxBusTitulo.Text));
        }

      
    }
}
