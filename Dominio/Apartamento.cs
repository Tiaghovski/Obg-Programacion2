using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Apartamento
    {
        public int piso { get; set; }
        public int numero { get; set; }
        public int metrajeTotal { get; set; }
        public float precioBase { get; set; }
        public Orientacion orientacion { get; set; }
        public Edificio edificio { get; set; }

        public Apartamento(int piso, int numero, int metrajeTotal, float precioBase, Orientacion orientacion, Edificio edificio)
        {
            this.piso = piso;
            this.numero = numero;
            this.metrajeTotal = metrajeTotal;
            this.precioBase = precioBase;
            this.orientacion = orientacion;
            this.edificio = edificio;           
        }

        public abstract float CalcularPrecio();

        public override string ToString()
        {

            return "Edificio: " + edificio.Nombre + " - " + "Piso Nº: " + piso + " - " + "Número: " + numero + " - " + "Metraje Total: " + metrajeTotal + " - " + "Precio Base: $ " + precioBase + " - " + "Orientación: " + orientacion + " - " + "Precio Total: $ " + CalcularPrecio();

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
