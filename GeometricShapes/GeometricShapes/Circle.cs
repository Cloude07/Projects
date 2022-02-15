using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Circle : FigureNotСorners
    {
        public override string Name { get; } = "Круг";

        public override void Draw()
        {
            Console.WriteLine("Рисуем " + Name);
        }
    }
}
