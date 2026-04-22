using System;
class JaggedArray
{
    public static void Main()
    {
        int[][] jaggedArray = new int[5][];

        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 1, 2, 3 };
        jaggedArray[2] = new int[] { 4, 5, 6 };
        jaggedArray[3] = new int[] { 7, 8, 9 };
        jaggedArray[4] = new int[] { 10, 11, 12 };


        for (int row = 0; row < jaggedArray.Length; row++)
        {
            for (int col = 0; col < jaggedArray[row].Length; col++)
            {
                Console.Write(jaggedArray[row][col]);
            }
            Console.WriteLine();
        }





    }
}