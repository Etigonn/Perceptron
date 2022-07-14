using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    public class PerceptronProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin data encoding and data normalization demon.\n");

            string[] sourceData = new string[]
            {
                " Sex.      Age.     Locale.      Income.      Poltics."  ,
                "==============================================",
                "Male       25      Rural       63,000      Conservative"  ,
                "Female     36      Suburban    55,000      Liberal"  ,
                "Male       40      Urban       74,000      Moderate"  ,
                "Female     23      Rural       28,000      Liberal"
            };

            Console.WriteLine("Dummy data in raw form:\n");
            Methods.ShowData(sourceData);

            string[] encodedData = new string[]
            {
                "-1 25  1  0 63,000 1 0 0",
                " 1 36  0  1 55,000 0 1 0",
                "-1 40 -1 -1 74,000 0 0 1",
                " 1 23  1  0 28,000 0 1 0",
            };

            Console.WriteLine("\nData after categorical encoding:\n");
            Methods.ShowData(encodedData);

            Console.WriteLine("\nNumeric data stored in matrix:\n");

            double[][] numericData = new double[4][];

            numericData[0] = new double[] { -1, 25.0,  1,  0, 63000.00, 1, 0, 0 };
            numericData[1] = new double[] { 1, 36.0,  0,  1, 55000.00, 0, 1, 0 };
            numericData[2] = new double[] { -1, 40.0, -1, -1, 74000.00, 0, 0, 1 };
            numericData[3] = new double[] { 1, 23.0,  1,  0, 28000.00, 0, 1, 0 };

            Methods.ShowMatrix(numericData, 2);

            Methods.GaussNormal(numericData, 1);
            Methods.MinMaxNormal(numericData, 4);

            Console.WriteLine("\nMatrix after normalization Guassian col. 1 and MixMax col. 4\n");
            Methods.ShowMatrix(numericData, 2);

            Console.WriteLine("\nEnd data encoding and normalization demon.");

            Console.ReadKey();
        }
    }
}
