using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosConstructores
{
    class Triangulo
    {
        public float baase;
        public float altura;

        public Triangulo()
        {
            altura = 7f;
            baase = 4f;
        }

        public Triangulo(float valorAltura, float valorBaase)
        {
            altura = valorAltura;
            baase = valorBaase;
        }

        public void presentarayb()
        {
            Console.WriteLine("La altura del triangulo es: "
                + altura + ", y su base es:" + baase);
        }

        public float calcArea()
        {
            return altura * baase/ 2; 
        }
    }
}
