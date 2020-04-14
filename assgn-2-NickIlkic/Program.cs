using assgn_2_NickIlkic;
using System;
using System.Text;

namespace assgn_2_Nicklkic
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - By using stringbuilder Append a sentence by using your fname, lastname and email
            StringBuilder sb = new StringBuilder("Nick ");
            sb.Append("Ilkic ");
            sb.Append("1295607@johnabbottcollege.net");
            Console.WriteLine(sb);

            //2 - Create 2 partial class (optional structure)
            PartialClass partial = new PartialClass();
            Console.WriteLine(partial.partial1);
            Console.WriteLine(partial.partial2);

            //3- Use static methods and static fields in a static class to calculate the area of a circle.
            Console.WriteLine(StaticCircle.CalculateArea(5));

            //4-Create a 2D JaggedArray and 3D JaggedArray with optioanl type and fill them with values and print them in the console.
            int[][] jArr2d = new int[2][]
            {
                new int[2] {1,2},
                new int[2] {3,4}
        };


            for (int i = 0; i< jArr2d.Length; i++)
            {
                for (int j = 0; j < jArr2d.Length; j++)
                {
                    Console.WriteLine(jArr2d[i][j]);
                }
            }
            //5-Create indexer optional structure to have access to the private data in the class.(optional structure)

            //6-Create a method that takes tuple as an input and returns tuple as the output...(optional structure)

        }
    }
}
