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
       
        
        List<cServicio> lista = ClassPaginasAmarillas.Instance.mostrarTodosServicios();
        private int id = 0;
        public FormEliminar()
        {
            InitializeComponent();
            actualizarGrid(lista);



        }
        private void FormEliminar_Load(object sender, EventArgs e)
        {
            actualizarGrid(ClassPaginasAmarillas.Instance.mostrarTodosServicios());

        }

        private void actualizarGrid(List<cServicio> lista)
        {
            dgvListadoServicios.Rows.Clear();

            dgvListadoServicios.Refresh();
            // dgvListadoServicios.DataSource = null;
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
                dgvListadoServicios.Rows[j].Cells[7].Value = lista.ToArray()[j].getId();


            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (id!= 0) //verifica si hay un índice seleccionado
            {
                MessageBox.Show("Seguro de eliminar el srvicio: ", id.ToString());
                ClassPaginasAmarillas.Instance.eliminarServicio(id);
                actualizarGrid(lista);
                id = 0;
            }
            else
            {
                MessageBox.Show("Dar doble click sobre elemento para seleccionar y borrar ");
                actualizarGrid(lista);

            }

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

        

        
        private void dgvListadoServicios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             id = Convert.ToInt32(dgvListadoServicios.Rows[e.RowIndex].Cells[7].Value);

        }
    }
    
}
