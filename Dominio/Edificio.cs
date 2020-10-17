using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Edificio
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }        
        public List<Apartamento> colApartamentos;


        public Edificio(string xNombre, string xDireccion)
        {
            this.Nombre = xNombre;
            this.Direccion = xDireccion;
            colApartamentos = new List<Apartamento>();
        }

        public Edificio()
        {
            colApartamentos = new List<Apartamento>();
        }

        public List<Apartamento> Apartamentos
        {
            get
            {
                List<Apartamento> apa = new List<Apartamento>();
                apa.AddRange(this.colApartamentos);
                return apa;
            }
        }      
        


        public override string ToString()
        {

            return "Nombre: " + Nombre + " - " + "Dirección: " + Direccion;

        }

        public string Datos
        {
            get
            {
                return ToString();
            }
        }

        public Apartamento BuscarApartamento(int numero)
        {
            foreach (Apartamento apa in colApartamentos)
            {
                if (apa.numero == numero)
                {
                    return apa;
                }
            }
            return null;
        }

        public bool AgregarApartamento(Apartamento apartamento)
        {
            if (BuscarApartamento(apartamento.numero) == null)
            {
                colApartamentos.Add(apartamento);
                return true;
            }
            return false;
        }

        public List<Apartamento> ListarApartamentosPorPrecio(float precio)
        {
            List<Apartamento> ListAp = new List<Apartamento>();
            foreach (Apartamento apa in colApartamentos)
            {
                if (apa.CalcularPrecio() < precio)
                {
                    ListAp.Add(apa);
                }
            }
            return ListAp;
        }

        public List<Apartamento> ListarApartamentosPorMinMaxOrientacion(int min, int max, Orientacion ori)
        {
            List<Apartamento> ListAp = new List<Apartamento>();
            foreach (Apartamento apa in colApartamentos)
            {
                if (apa.metrajeTotal > min && apa.metrajeTotal < max && ori == Orientacion.N || ori == Orientacion.S)
                {
                    ListAp.Add(apa);
                }
            }
            return ListAp;
        }

        public List<Apartamento> ListarApartamentosPorMetraje(float metraje)
        {
            List<Apartamento> ListAp = new List<Apartamento>();
            foreach (Apartamento apa in colApartamentos)
            {
                if (apa.metrajeTotal < metraje)
                {
                    ListAp.Add(apa);
                }
            }
            return ListAp;
        }



    }
}
