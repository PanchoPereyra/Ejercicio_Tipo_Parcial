using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoParcial
{
    public class Banco:Producto
    {
        public double ancho;
        public double grosor;
        public double peso;
        public double precio;

        public Banco(double precio, double largo):base(precio, largo)
        {
        }

        //El peso del banco se calcula con una densidad de 0,42 Kg/m3: peso = (largo*0.25) * 0.42
        public override double Peso()
        {
            peso = (largo * ancho * grosor) * 0.42;
            return peso;
        }

        //El precio final del banco se calcula con: precio = peso * precioBase *1.15
        public override double Precio()
        {
            precio = peso * precioBase * 1.15;
            return precio;
        }
    }
}
