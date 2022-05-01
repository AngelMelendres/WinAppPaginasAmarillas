using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppPaginasAmarillas
{
    internal class cServicio
    {
        private int id;
        private string titulo;
        private string descripcion;
        private string propietario;
        private string telefono;
        private string tipoServicio;
        private string email;
        private string direccion;



        public cServicio()
        {
            this.id = 1;
            this.titulo = "s/t";
            this.descripcion = "s/d";
            this.propietario = "s/p";
            this.email = "sin email";
            this.telefono = "s/tlf";
            this.tipoServicio = "s/ts";
            this.direccion = "sin dir";
        }

        public int getId() { return this.id; }
        public string getTitulo() { return this.titulo; }
        public string getDescripcion() { return this.descripcion; }
        public string getPropietario() { return this.propietario; }
        public string getEmail() { return this.email; }
        public string getTelefono() { return this.telefono; }
        public string getTipoServicio() { return this.tipoServicio; }    
        public string getDireccion() { return this.direccion; }

        public void setTitulo(string titulo) { this.titulo = titulo; }
        public void setId(int id) { this.id = id; }
        public void setDescripcion( string descripcion) { this.descripcion = descripcion; }
        public void setPropietario(string propietario) { this.propietario = propietario; }
        public void setEmail(string email) { this.email = email; }
        public void setTelefono(string telefono) { this.telefono = telefono; }
        public void setTipoServicio(string tipoServicio) { this.tipoServicio = tipoServicio; }    
        public void setDireccion(string direccion) { this.direccion = direccion; }




          
        
       

    }
}
