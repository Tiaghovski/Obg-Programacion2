using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
       
        public float precioVenta { get; set; }
        public Usuario usuario { get; set; }
        public Apartamento apartamento { get; set; }
        public ClienteEm cliente { get; set; }



        public Venta(float precioVenta, Usuario usuario, Apartamento apartamento, ClienteEm cliente)
        {
            
            this.precioVenta = apartamento.CalcularPrecio();
            this.usuario = usuario;
            this.apartamento = apartamento;
            this.cliente = cliente;
        }

        public override string ToString()
        {

            return "Cliente comprador: " + cliente.Datos + '\n' +
                    "|| Apartamento vendido: " + apartamento.Datos;
                   
                  
    
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
