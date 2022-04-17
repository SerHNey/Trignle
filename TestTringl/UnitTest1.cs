using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trignle;



namespace TestTringl
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPaBHobeDpeHHblTriangle_7_8_7_return_PaBHobeDpeHHblTriangle()
        {
            int a = 7, b = 8, c = 7;
            string result = "Треугольник равнобедренный!";
            MethodTrigl trignle = new MethodTrigl();
            string actual = trignle.Treug(a, b, c);
            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void TestPaBHobeCTopoHiuTriangle_7_7_7_return_PaBHobeCTopoHiuTriangle()
        {
            int a = 7, b = 7, c = 7;
            string result = "Треугольник равносторонний!";
            MethodTrigl trignle = new MethodTrigl();
            string actual = trignle.Treug(a,b,c);
            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void TestPa3HocToPoHiuTriangle_7_8_9_return_Pa3HocToPoHiuTriangle()
        {
            int a = 7, b = 8, c = 9;
            string result = "Треугольник разносторонний!";
            MethodTrigl trignle = new MethodTrigl();
            string actual = trignle.Treug(a, b, c);
            Assert.AreEqual(result, actual);
        }
        [TestMethod]
        public void TestHeCyiiiTreygol_1_2_3_return_HeCyiiiTreygol()
        {
            int a = 1, b = 2, c = 3;
            string result = "Треугольника с такими сторонами не существует!!!";
            MethodTrigl trignle = new MethodTrigl();
            string actual = trignle.Treug(a, b, c);
            Assert.AreEqual(result, actual);
        }
    }
}
