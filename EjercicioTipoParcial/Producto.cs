using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoParcial
{
    abstract public class Producto:IComparable
    {
        protected double precioBase;
        protected double largo;
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Producto(double precioBase, double largo)
        {
            this.precioBase = precioBase;
            this.largo = largo;
        }

        abstract public double Peso();

        abstract public double Precio();

        public override string ToString()
        {
            return codigo.ToString();
        }

        public int CompareTo(object obj)
        {            
            /*
            Esa porción de código en C# corresponde a la implementación del método CompareTo de la interfaz IComparable, 
            y lo que hace es permitir comparar un objeto Producto con otro Producto para poder ordenarlos, por ejemplo en una lista.
            */

            Producto otro = obj as Producto;        // Intenta convertir el objeto recibido a tipo Producto
            if (otro != null)                                  // Si la conversión fue exitosa (es realmente un Producto)...
                return codigo.CompareTo(otro.codigo);    // Compara el campo "codigo" de este objeto con el del otro
            return 1;                                           // Si no se pudo convertir, devuelve 1 (indica que es "mayor")


        }
    }
}

