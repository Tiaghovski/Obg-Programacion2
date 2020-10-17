using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empresa
    {
        private List<Usuario> colUsuarios;
        private List<ClienteEm> colClientes;
        private List<Edificio> colEdificios;
        private static Empresa instanciaEmpresa = null;

        public static Empresa Instancia
        {
            get
            {
                if (instanciaEmpresa == null)
                {
                    instanciaEmpresa = new Empresa();
                }
                return instanciaEmpresa;
            }
        }

        public List<ClienteEm> ClientesEm
        {
            get
            {
                return new List<ClienteEm>(colClientes);
            }
        }

        public List<Edificio> Edificios
        {
            get
            {
                return new List<Edificio>(colEdificios);
            }
        }

        public Empresa()
        {
            colUsuarios = new List<Usuario>();
            CargarUsuariosPorDefecto();
            colClientes = new List<ClienteEm>();
            colEdificios = new List<Edificio>();
        }




        private void CargarUsuariosPorDefecto()
        {
            Usuario u1 = new Administrador();
            u1.Apellido = "Silva";
            u1.Nombre = "Santiago";
            u1.Clave = "123";
            u1.NombreUsuario = "ssilva";
            colUsuarios.Add(u1);       
        }

        public List<Usuario> Usuarios
        {
            get
            {
                return new List<Usuario>(colUsuarios);
            }
        }

        public Usuario BuscarUsuario(String xNombreUsuario, String xClave)
        {
            foreach (Usuario u in colUsuarios)
            {
                if (u.NombreUsuario.Equals(xNombreUsuario) && u.Clave.Equals(xClave))
                {
                    return u;
                }
            }
            return null;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            colUsuarios.Add(usuario);
        }

        public ClienteEm BuscarCliente(string documento)
        {
            foreach (ClienteEm cli in colClientes)
            {
                if (cli.Documento == documento)
                {
                    return cli;
                }
            }
            return null;
        }

        public bool AgregarCliente(ClienteEm cliente)
        {
            if (BuscarCliente(cliente.Documento) == null)
            {
                colClientes.Add(cliente);
                return true;
            }
            return false;
        }

        public bool EliminarCliente(string documento)
        {
            foreach(ClienteEm cli in colClientes)
            {                
                if (cli.Documento == documento)
                {
                    colClientes.Remove(cli);
                    return true;
                }
            }
            return false;
        }

        public void ModificarCliente(string Nombre, string Apellido, string Documento, string Direccion, string Telefono)
        {
            ClienteEm cli = BuscarCliente(Documento);
            cli.Nombre = Nombre;
            cli.Apellido = Apellido;
            cli.Direccion = Direccion;
            cli.Telefono = Telefono;
        }

        public Edificio BuscarEdificio(string nombre)
        {
            foreach (Edificio edi in colEdificios)
            {
                if (edi.Nombre == nombre)
                {
                    return edi;
                }
            }
            return null;
        }

        public bool AgregarEdificio(Edificio edificio)
        {
            if (BuscarEdificio(edificio.Nombre) == null)
            {
                colEdificios.Add(edificio);
                return true;
            }
            return false;
        }

        public List<Apartamento> ListarApartamentosPorPrecioX(float precio)
        {
            List<Apartamento> ListAp = new List<Apartamento>();
            foreach (Edificio edi in colEdificios)
            {
                ListAp.AddRange(edi.ListarApartamentosPorPrecio(precio));

            }
            return ListAp;           
        }

        public List<Edificio> ListarEdificiosAp(int min, int max, Orientacion ori)
        {
            List<Edificio> ListEdi = new List<Edificio>();
            foreach (Edificio edi in colEdificios)
            {
                if (edi.ListarApartamentosPorMinMaxOrientacion(min, max, ori).Count > 0)
                {
                    ListEdi.Add(edi);
                }
            }
            return ListEdi;

        }

        public List<Apartamento> ListarApartamentosPorMetrajeX(float metraje)
        {
            List<Apartamento> ListAp = new List<Apartamento>();
            foreach (Edificio edi in colEdificios)
            {
                ListAp.AddRange(edi.ListarApartamentosPorMetraje(metraje));

            }
            return ListAp;
        }

        public List<Apartamento> ListarTodosLosApartamentos()
        {
            List<Apartamento> ListAp = new List<Apartamento>();
            foreach (Edificio edi in colEdificios)
            {
                ListAp.AddRange(edi.Apartamentos);

            }
            return ListAp;
        }

        public List<Venta> ListarVentas()
        {
            List<Venta> ListVen = new List<Venta>();
            foreach (Usuario usu in colUsuarios)
            {
                ListVen.AddRange(usu.Ventas);

            }
            return ListVen;
        }



    }
}
