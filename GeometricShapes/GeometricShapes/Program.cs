using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] shapesArray = {new Circle(), new Oval(), new Triangle(), new Quadrilateral(), new Pentagon() };

            foreach(Shapes shapes in shapesArray)
            {
                InfoShapes(shapes);
            }
        }

        static void InfoShapes(Shapes shapes)
        {
            Console.WriteLine("Название фигуры: {0}", shapes.Name);
            shapes.Draw();
            Console.WriteLine("\n");
        }
    }
}
