using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5Variant10;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1Method1()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Class1.matrix[i, j] = 1; // например, заполняем такими числами
                }
            }
            double expected = 1;
            double actual = Class1.method1();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test2Method1()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Class1.matrix[i, j] = 2; // например, заполняем такими числами
                }
            }
            double expected = 2;
            double actual = Class1.method1();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test3Method1()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Class1.matrix[i, j] = -1; // например, заполняем такими числами
                }
            }
            double expected = 0;
            double actual = Class1.method1();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test4Method1()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Class1.matrix[i, j] = i - 1; // например, заполняем такими числами
                }
            }
            double expected = 2.5;
            double actual = Class1.method1();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test5Method1()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Class1.matrix[i, j] = i - 2; // например, заполняем такими числами
                }
            }
            double expected = 2;
            double actual = Class1.method1();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test1Method2()
        {
            double[,] expected = new double[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Class1.matrix[i, j] = i; // например, заполняем такими числами
                    expected[i, j] = i;
                }
            }

            // приводим expected к её правильному виду
            for (int i = 0; i < 7; i++)
            {
                if (expected[i, 3] == 6) expected[i, 3] = 100;
            }

            Class1.method2();
            double[,] actual = Class1.matrix;
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test2Method2()
        {
            double[,] expected = new double[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Class1.matrix[i, j] = i+j; // например, заполняем такими числами
                    expected[i, j] = i+j;
                }
            }

            // приводим expected к её правильному виду
            for (int i = 0; i < 7; i++)
            {
                if (expected[i, 3] == 6) expected[i, 3] = 100;
            }

            Class1.method2();
            double[,] actual = Class1.matrix;
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test3Method2()
        {
            double[,] expected = new double[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Class1.matrix[i, j] = i - j; // например, заполняем такими числами
                    expected[i, j] = i - j;
                }
            }

            // приводим expected к её правильному виду
            for (int i = 0; i < 7; i++)
            {
                if (expected[i, 3] == 6) expected[i, 3] = 100;
            }

            Class1.method2();
            double[,] actual = Class1.matrix;
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test4Method2()
        {
            double[,] expected = new double[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Class1.matrix[i, j] = i*j; // например, заполняем такими числами
                    expected[i, j] = i*j;
                }
            }

            // приводим expected к её правильному виду
            for (int i = 0; i < 7; i++)
            {
                if (expected[i, 3] == 6) expected[i, 3] = 100;
            }

            Class1.method2();
            double[,] actual = Class1.matrix;
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Test5Method2()
        {
            double[,] expected = new double[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Class1.matrix[i, j] = i+1; // например, заполняем такими числами
                    expected[i, j] = i+1;
                }
            }

            // приводим expected к её правильному виду
            for (int i = 0; i < 7; i++)
            {
                if (expected[i, 3] == 6) expected[i, 3] = 100;
            }

            Class1.method2();
            double[,] actual = Class1.matrix;
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
