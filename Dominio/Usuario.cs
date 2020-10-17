using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String NombreUsuario { get; set; }
        public String Clave { get; set; }
        public List<Venta> colVentas;


        public Usuario()
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

        public bool AgregarVenta(Venta venta)
        {
            colVentas.Add(venta);
            return true;
        }

        public Venta BuscarVenta(Apartamento apartamento)
        {
            foreach (Venta ven in colVentas)                
            {
                if (ven.apartamento == apartamento)
                {
                    return ven;
                }
            }
            return null;
        }

        public override string ToString()
        {

            return "Nombre: " +Nombre+ " " + Apellido + " - " + "Nombre de Usuario: " + NombreUsuario;

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

