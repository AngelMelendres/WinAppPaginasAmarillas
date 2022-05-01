using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppPaginasAmarillas
{
    
    class ClassPaginasAmarillas
    {
        

        private static ClassPaginasAmarillas instance;
        public static ClassPaginasAmarillas Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClassPaginasAmarillas();
                return instance;
            }
        }
        private List<cServicio> servicios;


        public ClassPaginasAmarillas()
        {
            nuevaLista();
        }


        public void nuevaLista()
        {
            servicios = new List<cServicio>();
        }
          
    
        public void agregarServicio(string titulo, string descripcion, string telefono, string propietario, string email, string direccion, string categoria)
        {

            cServicio servicio = new cServicio();
            servicio.setTitulo(titulo);
            servicio.setDescripcion(descripcion);
            servicio.setTelefono(telefono);
            servicio.setDireccion(direccion);
            servicio.setPropietario(propietario);
            servicio.setCategoria(categoria);
            servicio.setEmail(email);

            servicios.Add(servicio);

          

        }

        public void eliminarServicio(int id)
        {
            servicios.RemoveAt(id);
        }

        public void editarServicio(int id)
        {

        }

        public void mostrarServicioId(int id)
        {
            
        }

        public List<cServicio> mostrarTodosServicios()
        {
            return this.servicios;

        }

        public List<cServicio> busquedaPorTitulo(string busqueda)
        {
            
            List < cServicio > coinsidencias = new List<cServicio>();

            for (int i = 0; i < servicios.Count; i++)
            {
                if (busqueda == servicios[i].getTitulo())
                {
                    coinsidencias.Add(servicios[i]);
                    
                }
            }

            return coinsidencias;

        }



    }

   



    

}
