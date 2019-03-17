using System;
using System.Collections.Generic;

namespace Test1.TypesFigure
{
    public class Circle: IFigure
    {
        /// <summary>
        ///     Имя фигуры
        /// </summary>
        public string FigureName { get; set; } = "Круг";

        /// <summary>
        ///     Площадь фигуры
        /// </summary>
        public float Area
        {
            get
            {
                //если в поле Sides более одного значения - заданная фигура не круг. Исключение
                if (Sides.Count != 1)
                {
                    return -1;
                }

                return (float)(Math.PI * Math.Pow(Sides[0],2));
            }
        }
        /// <summary>
        ///     Список, состоящий из одного значения радиуса, в случае круга
        /// </summary>
        public List<float> Sides { get; set; } = new List<float>() { 0 };
    }
}
