using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Oval : FigureNotСorners
    {
        public override string Name { get; } = "Овал";

        public override void Draw()
        {
            Console.WriteLine("Рисуем " + Name);
        }
    }
}
