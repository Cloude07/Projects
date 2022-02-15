using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Quadrilateral : Polygon
    {
        public override string Name { get; } = "Пятиугольник";

        public override void Draw()
        {
            Console.WriteLine("Рисуем " + Name);
        }
    }
}
