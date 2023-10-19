using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();
            triangulo1.presentarayb();
            float area = triangulo1.calcArea();
            Console.WriteLine("El area es: " + area);
        }

    }
}
