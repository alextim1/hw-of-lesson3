using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixReader;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidMatrixInput()
        {
            //arrange
            string filePath = @"D:\matrix.txt";
            int[,] matrix;
            int[,] check=new int [,] { { 1,2,3},{ 4,5,0},{ 0,0,0} };

            //act
            Program.MatrixReaderFromFile(filePath, out matrix);

            //assert
            Assert.AreEqual(check,matrix);

        }
    }
}
