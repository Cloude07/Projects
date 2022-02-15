using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public abstract class Shapes
    {
        public abstract string Name { get; }
        public abstract void Draw();
    }
}
