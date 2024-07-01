using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Прямоугольник
    {
        private double width; // Ширина прямоугольника
        private double height; // Высота прямоугольника

        public Прямоугольник(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Метод для вычисления площади прямоугольника
        public double Площадь()
        {
            return width * height;
        }
        public double Периметр()
        {
            return (width + height) * 2;
        }
    }


}
