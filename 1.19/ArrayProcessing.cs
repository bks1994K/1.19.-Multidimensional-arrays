using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._19_
{
    //1
    public static class ArrayProcessing
    {
        public static int MinElementOfArray(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        //2

        public static int MaxElementOfArray(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        //3

        public static int[] IndexOfMinElementOfArray(int[,] array)
        {
            int min = array[0, 0];
            int[] minIndex = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;

                    }
                }
            }
            return minIndex;
        }

        // 3.1

        public static void WriteToConsoleElementsOfArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }


        //4

        public static int[] IndexOfMaxElementOfArray(int[,] array)
        {
            int max = array[0, 0];
            int[] maxIndex = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;

                    }
                }
            }
            return maxIndex;
        }

        //5. Найти количество элементов массива, которые больше своих левого и нижнего соседа одновременно.

        public static int CountElementThatMoreLeftAndBottomElementsSameTime(int[,] array)
        {
            int count = 0;
            int j = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    int j1 = array[i, j];

                    if ((j-1>=0) && (array[i, j] > array[i, j - 1]))
                    {
                        if ((i <= array.GetLength(0) - 2) && (array[i, j] > array[i + 1, j]))
                        {
                            count = count + 1;
                        }
                    }
                }


            }
            return count;
        }


    }
}
