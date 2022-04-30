using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppPaginasAmarillas
{
  
    class ClassPaginasAmarillas
    {
        cServicio[] servicios = new cServicio[20];
        int contador = 0;


        public void agregarServicio()
        {
     
             string titulo="";
             string descripcion = "";
             string propietario = "";
             string telefono = "";
             string tipoServicio = "";
             string email = "";
             string direccion = "";

            servicios[contador] = new cServicio(contador);
            servicios[contador].agregarServicio(titulo,descripcion,propietario,telefono,tipoServicio,email,direccion);
            contador++;

        }

        public void eliminarServicio(int id)
        {
            
        }

        public void editarServicio(int id)
        {

        }

        public void mostrarServicioId(int id)
        {

        }   

        public void mostrarTodosServicios()
        {

        }

    }

   



    

}
