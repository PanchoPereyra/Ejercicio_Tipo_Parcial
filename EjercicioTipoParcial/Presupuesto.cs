using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoParcial
{
    internal class Presupuesto
    {
        ArrayList listaProductos = new ArrayList();
        public double Precio
        {
            get
            {
                double total = 0;
                foreach (Producto p in listaProductos)
                {
                    total += p.Precio();    //polimorfismo
                }
                return total;
            }
        }

        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string Direccion
        {
            get { return Direccion; }
            set {  Direccion = value; }
        }

        private Cliente solicitante;
        public Presupuesto(string nombre, string direccion)
        {
            solicitante = new Cliente(nombre, direccion);
        }

        public void AgregarProducto(Producto producto)
        {
            listaProductos.Add(producto);
        }

        public bool QuitarProducto(int codigo)
        {
            listaProductos.Sort();
            Producto buscado = BuscarProducto(codigo);
            if (buscado != null) 
            {
                listaProductos.Remove(buscado);
                return true;
            }
            return false;
        }

        public Producto BuscarProducto(int codigo)
        {
            int inf = 0;
            int sup = listaProductos.Count - 1;
            int centro = (sup + inf) / 2;
            while (inf < sup) 
            {
                Producto prueba = listaProductos[centro] as Producto;
                if (prueba == null) return null;
                if (prueba.Codigo == codigo) return prueba;
                else if (codigo < prueba.Codigo) sup = centro - 1;
                else inf= centro - 1;
                centro = (sup + inf) / 2;
            }
            return null;
        }

        public string[] Resumen()
        {
            string[] result = new string[listaProductos.Count + 2];
            int n = 0;
            result[n++] = solicitante.ToString();
            foreach(Producto p in listaProductos)
            {
                result[n++] = $"{p.Codigo} - Peso{p.Peso()} - Precio:${p.Precio():f2}";
            }
            result[n++] = $"Total: ${Precio:f2}";
            return result;
        }
    }
}
