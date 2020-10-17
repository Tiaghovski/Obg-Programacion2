using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Oficina : Apartamento
    {
        public int cantPuestos { get; set; }
        public bool equipamiento { get; set; }
        public static float monto { get; set; } = 1000;

        public Oficina (int piso, int numero, int metrajeTotal, float precioBase, Orientacion orientacion, int cantPuestos, bool equipamiento, Edificio edificio)
            :base (piso, numero, metrajeTotal, precioBase, orientacion, edificio)
        {
            this.cantPuestos = cantPuestos;
            this.equipamiento = equipamiento;
        }

        public override float CalcularPrecio()
        {
            float recargoEquipamiento = 0;
            float precioTotal = 0;            
            if (equipamiento == true)
            {
                recargoEquipamiento = ((monto * cantPuestos) * 10 / 100);
                precioTotal = ((precioBase * metrajeTotal) + (monto * cantPuestos) + recargoEquipamiento);
            }
            else
            {
                precioTotal = ((precioBase * metrajeTotal) + (monto * cantPuestos));
            }
            return precioTotal;
        }
    }
}
