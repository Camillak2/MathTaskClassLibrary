using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            // исходные данные 
            int a = 3;
            int b = 5;
            int expected = 15;


            // получение значения с помощью тестируемого метода
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }



        //public void AreaCircle_3_2827returned()
        //{
        //    // исходные данные 
        //    double r = 3.0;
        //    double expected = 28.2743338823;


        //    // получение значения с помощью тестируемого метода
        //    Geometry g = new Geometry();
        //    double actual = g.AreaCircle(r);

        //    // сравнение ожидаемого результата с полученным
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
