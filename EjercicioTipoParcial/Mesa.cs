using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoParcial
{
    internal class Mesa : Producto
    {
        private double ancho;
        private double grosor;
        //private double precio;
        //private double peso;


        public Mesa(double precio, double largo, double ancho, double grosor) : base(precio, largo)
        {
            this.ancho = ancho;
            this.grosor = grosor; 
         }

        override public double Precio()
        {
            return precioBase * 1.25;
         }

        override public double Peso()
        {
            return (largo * ancho * grosor) * 0.3;
        }
    }
}
