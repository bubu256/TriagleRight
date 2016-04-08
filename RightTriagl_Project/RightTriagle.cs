using System;

namespace RightTriagl_Project
{
    public class RightTriagle
    {
        public static double Area(double a, double b, double hypotenuse)
        {
            double delta = 0.001;
            if ( Math.Abs((hypotenuse * hypotenuse) - (a * a + b * b)) > delta )
                throw new System.ArgumentException("Некорректно заданы параметры: Cумма квадратов катетов должна быть равна квадрату гипотенузы");
            if ((a<=0)||(b<=0)||(hypotenuse<=0))
                throw new System.ArgumentException("Некорректно заданы параметры: Все стороны треугольника должны быть больше нуля"); 
            
            return a * b / 2;
        } 
    }
}
