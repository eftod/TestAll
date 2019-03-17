using System.Collections.Generic;

namespace Test1
{
    
    public interface IFigure
    {
        /// <summary>
        ///     Имя фигуры
        /// </summary>
        string FigureName { get; set; }

        /// <summary>
        ///     Площадь фигуры
        /// </summary>
        float Area { get; }

        /// <summary>
        ///     Список сторон многоугольника. Для записи радиуса круга используется список с 1 значением (значением радиуса)
        /// </summary>
        List<float> Sides { get; set; }
        
    }
}
