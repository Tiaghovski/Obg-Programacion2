using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Casa_Habitacion : Apartamento
    {
        public int cantDormitorios { get; set; }
        public int cantBaños { get; set; }
        public bool garage { get; set; }
        public static float monto { get; set; } = 2000;

        public Casa_Habitacion(int piso, int numero, int metrajeTotal, float precioBase, Orientacion orientacion, int cantDormitorios, int cantBaños, bool garage, Edificio edificio)
           :base(piso, numero, metrajeTotal, precioBase, orientacion, edificio)
        {
            this.cantDormitorios = cantDormitorios;
            this.cantBaños = cantBaños;
            this.garage = garage;
        }

        public override float CalcularPrecio()
        {
            float precioTotal = 0;
            float precioB = precioBase * metrajeTotal;                    
            if (cantDormitorios > 4)
            {
               precioB = precioB + (precioB * 20 / 100);
            }
            else if (cantDormitorios > 2)
            {
                precioB = precioB + (precioB * 10 / 100);
            }
            else
            {
                precioB = precioB + (precioB * 5 / 100);
            }
            if (garage == true)
            {
                precioTotal = precioB + monto;
            }
            else
            {
                precioTotal = precioB;
            }
            if (orientacion == Orientacion.NO || orientacion == Orientacion.N || orientacion == Orientacion.NE)
            {
                precioTotal = precioTotal + (precioTotal * 15 / 100);
            }
          
            return precioTotal;


        }
     }
  }

