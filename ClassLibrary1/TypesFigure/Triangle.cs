using System;
using System.Collections.Generic;

namespace Test1.TypesFigure
{
    public class Triangle: IFigure
    {
        /// <summary>
        ///     Имя фигуры
        /// </summary>
        public string FigureName { get; set; } = "Треугольник";
        
        /// <summary>
        ///     Площадь фигуры
        /// </summary>
        public float Area
        {
            get
            {
                //если в поле Sides не 3 значения - заданная фигура не треугольник. Исключение
                if (Sides.Count != 3)
                {
                    return -1;
                }

                //полупериметр
                var p = (Sides[0] + Sides[1] + Sides[2]) / 2;

                return (float)Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            }
        }

        /// <summary>
        ///     Список сторон треугольника
        /// </summary>
        public List<float> Sides { get; set; } = new List<float>() {0,0,0};

        /// <summary>
        ///     Проверка, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                
                if ( Math.Abs(Math.Pow(Sides[0], 2) - Math.Pow(Sides[1], 2) - Math.Pow(Sides[2], 2)) > float.Epsilon &&
                     Math.Abs(Math.Pow(Sides[1], 2) - Math.Pow(Sides[0], 2) - Math.Pow(Sides[2], 2)) > float.Epsilon &&
                     Math.Abs(Math.Pow(Sides[2], 2) - Math.Pow(Sides[1], 2) - Math.Pow(Sides[0], 2)) > float.Epsilon )
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
        }
    }


}
