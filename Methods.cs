using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    public static class Methods
    {
        public static void GaussNormal(double[][] data, int column)
        {
            // sum of terms
            double sum = 0.0;
            for (int i = 0; i < data.Length; i++)
                sum += data[i][column];
            double mean = sum / data.Length;

            // sum of sqaures
            double sumSquares = 0.0;
            for (int i = 0; i < data.Length; i++)
                sumSquares += Math.Pow((data[i][column] - mean), 2);

            // standar deviation
            double standarDeviation = Math.Sqrt(sumSquares / data.Length);
            for (int i = 0; i < data.Length; i++)
                data[i][column] = (data[i][column] - mean) / standarDeviation;
        }

        public static void MinMaxNormal(double[][] data, int column)
        {
            double min = data[0][column];
            double max = data[0][column];

            //sorting values
            for (int row = 0; row < data.Length; row++)
            {
                if(data[row][column] < min)
                    min = data[row][column];
                if(data[row][column] > max)
                    max = data[row][column];
            }

            double range = max - min;
            if(range == 0.0)
            {
                for (int row = 0; row < data.Length; row++)
                    data[row][column] = 0.5;
                return;
            }

            for(int row = 0; row < data.Length; row++)
                data[row][column] = (data[row][column] - min) / range;
        }

        public static void ShowMatrix(double[][] matrix, int decimals)
        {
            for(int row = 0; row < matrix.Length; row++)
            {
                for(int column = 0; column < matrix[row].Length; column++)
                {
                    double value = Math.Abs(matrix[row][column]);
                    if (matrix[row][column] >= 0.0)
                        Console.Write(" ");
                    else
                        Console.Write("-");
                    Console.Write(value.ToString("F" + decimals).PadRight(5) + " ");
                }
                Console.Write(string.Empty);
            }
        }

        public static void ShowData(string[] rawData)
        {
            for(int i = 0; i < rawData.Length; i++)
            {
                Console.WriteLine(rawData[i]);
            }
            Console.WriteLine(string.Empty);
        }

        
    }
}
