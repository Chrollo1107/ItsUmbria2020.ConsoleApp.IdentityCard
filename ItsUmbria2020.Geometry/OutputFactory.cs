using System;
using System.Collections.Generic;
using System.Text;

namespace ItsUmbria2020.Geometry
{
    class OutputFactory
    {
        static GeometryFactory GeometryFactory = new ConsoleAppGeometryFactory();
        public string GetOutput()
        {
            Console.WriteLine("Selezionare: 1.Perimetro, 2.Area");
            int.TryParse(Console.ReadLine(), out int figure);
            switch (figure)
            {
                case 1:
                    IAreable area = GeometryFactory.GetAreable();
                    return area.GetArea();
                case 2:

            }
        }
    }
}
