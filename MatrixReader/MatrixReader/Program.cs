using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MatrixReader
{
    public class Program
    {
        public static void MatrixReaderFromFile(string fileName, out int[,] matrix)
        {
            StreamReader sr = new StreamReader(fileName);
            string dimensions = sr.ReadLine();
            string[] dimensionsOfMatrix = dimensions.Split('x');
            int Rows = int.Parse(dimensionsOfMatrix[0]);
            int Columns = int.Parse(dimensionsOfMatrix[1]);

            int[,] outputMatrix = new int[Rows, Columns];

            string nextLine;
            string[] nextLineArr;

            for (int i=0; i< Rows; i++)
            {
               
                if (sr.EndOfStream)
                {
                    for (int j = 0; j<Columns; j++)
                    {
                        outputMatrix[i, j] = 0;
                    }
                }
                else
                {
                    nextLine = sr.ReadLine();
                    nextLineArr = nextLine.Split(' ');
                    for (int j = 0; j < Columns; j++)
                    {
                        if (j>nextLineArr.Length-1)
                        {
                            outputMatrix[i, j] = 0;
                        }
                        else
                        {
                            outputMatrix[i, j] = int.Parse(nextLineArr[j]);
                        }
                       
                    }
                }
            }
            matrix = outputMatrix;
        }

        static void Main(string[] args)
        {
            int[,] matrix;
            MatrixReaderFromFile(@"D:\matrix.txt", out matrix);
            for (int i=0;i<=matrix.GetUpperBound(0);i++)
            {
                for (int j=0;j<=matrix.GetUpperBound(1);j++)
                {
                    Console.Write(" {0:D}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
