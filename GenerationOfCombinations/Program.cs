using System;
using System.Collections.Generic;

namespace GenerationOfCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            var array = new List<int> { 0, 1, 2 };
            array.Add(5);
            array.Add(0);

            while(true)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                for (j = 0; j < array.Count-1; j++)
                {
                    if (array[j] + 1 == array[j + 1])
                        array[j] = j;
                    else break;
                }
                if (j < 3) array[j] += 1;
                else break;
            }
        }
    }
}
