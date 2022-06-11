using System;

namespace LongestCommonSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "fish";
            string s2 = "fosh";

            int[,] grid = new int[s1.Length, s2.Length];

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        if (i == 0)
                            grid[i, j] = 1;
                        else
                            grid[i, j] = grid[i - 1, j - 1] + 1;
                    }
                    else
                        grid[i, j] = 0;
                }
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (i == 0)
                    Console.Write("\t");

                Console.Write(s2[i] + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                Console.Write(s1[i] + "\t");
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int max = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] >= max)
                        max = grid[i, j];
                }
            }

            Console.WriteLine($"\n longest common subString between these 2 words = {max}");

        }
    }
}
