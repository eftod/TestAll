using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test1;
using Test1.TypesFigure;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircle()
        {
            var TestCircle = new Circle();
            TestCircle.Sides = new List<float>(){1};
            //проверка функции нахождения площади круга
            Assert.IsTrue(Math.Abs(TestCircle.Area- (float)Math.PI) <= float.Epsilon);
        }

        [TestMethod]
        public void TestTriangle1()
        {
            var TestTriangle = new Triangle();
            TestTriangle.Sides = new List<float>() { 3, 4, 5};

            //проверка функции нахождения площади треугольника
            Assert.AreEqual(TestTriangle.Area, 6);

            // проверка функции определения прямоугольный ли треугольник
            Assert.IsTrue(TestTriangle.IsRectangular);
        }

        [TestMethod]
        public void TestTriangle2()
        {
            var TestTriangle = new Triangle();
            TestTriangle.Sides = new List<float>() { 1, 1, 1 };

            //проверка функции нахождения площади треугольника
            Assert.IsTrue(Math.Abs((float)Math.Sqrt(3)/4 - TestTriangle.Area) < float.Epsilon);

            // проверка функции определения прямоугольный ли треугольник
            Assert.IsFalse(TestTriangle.IsRectangular);
        }

        [TestMethod]
        public void TestFigure()
        {
            var list = new List<IFigure>();
            //создание списка фигур из треугольников и кругов
            for (int i = 1; i < 100; i++)
            {
                list.Add(new Circle(){Sides = new List<float>() { i}});
                list.Add(new Triangle() { Sides = new List<float>() { 3 * i, 4 * i, 5 * i } });
            }
            
            //проверка площадей всех фигур, не зависимо от типа фигуры
            foreach (var figure in list)
            {
                var a = figure.Area;
                if (figure.GetType()==typeof(Circle))
                {
                    Assert.IsTrue((float)Math.Abs(figure.Area - (float)(Math.PI * Math.Pow(figure.Sides[0], 2))) <= float.Epsilon);
                }
                if (figure.GetType() == typeof(Triangle))
                {
                    Assert.IsTrue((float)Math.Abs(figure.Area - figure.Sides[0] * figure.Sides[1] / 2) <= float.Epsilon);
                }

            }
        }
    }
}
