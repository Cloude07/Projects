using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Triangle : Polygon
    {
        public override string Name { get; } = "Треугольник";

        public override void Draw()
        {
            Console.WriteLine("Рисуем " + Name);
        }
    }
}
