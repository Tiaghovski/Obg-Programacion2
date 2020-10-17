using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClienteEm
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<Venta> colVentas;

        public ClienteEm(string Nombre, string Apellido, string Documento, string Direccion, string Telefono)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Documento = Documento;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            colVentas = new List<Venta>();
        }

        public ClienteEm()
        {
            colVentas = new List<Venta>();
        }

        public List<Venta> Ventas
        {
            get
            {
                List<Venta> ven = new List<Venta>();
                ven.AddRange(this.colVentas);
                return ven;
            }
        }

        public override string ToString()
        {

            return Nombre + " " + Apellido + " - " + "C.I: " + Documento + " - " + "Dirección: " + Direccion + " - " + "Teléfono: " + Telefono;

        }

        public string Datos
        {
            get
            {
                return ToString();
            }
        }

    }
}
