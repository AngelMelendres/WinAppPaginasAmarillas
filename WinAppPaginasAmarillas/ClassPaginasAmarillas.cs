﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppPaginasAmarillas
{
    
    class ClassPaginasAmarillas
    {
        private List<cServicio> servicios = new List<cServicio>();

        

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

    }

   



    

}
