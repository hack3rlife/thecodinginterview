﻿/*
 * @autor: Some smart guy on internet
 * @date: 04/28/2015
 * @project: QuickSort
 * 
 */

using System.Diagnostics;

namespace com.hack3rlife.algorithms.sorting
{
    /// <summary>
    /// QuickSort is an efficient sorting algorithm, serving as a systematic method for placing the elements of an array in order.
    /// When implemented well, it can be about two or three times faster than its main competitors, merge sort and heapsort.
    /// Quicksort is a comparison sort, meaning that it can sort items of any type for which a "less-than" relation is defined. 
    /// In efficient implementations it is not a stable sort, meaning that the relative order of equal sort items is not preserved. 
    /// Quicksort can operate in-place on an array, requiring small additional amounts of memory to perform the sorting.
    /// On average, the algorithm takes O(n log n) comparisons to sort n items. In the worst case, it makes O(n2) comparisons, though this behavior is rare.
    /// </summary>
    /// <remarks>
    /// Worst case: О(n2)
    /// Average case: О(n log n)
    /// Best Case: О(n log n)
    /// Space Required: O(n)
    /// </remarks>
    /// <see cref="https://en.wikipedia.org/wiki/Quicksort"/>
    public static class QuickSort
    {
        /// <summary>
        /// Quicksort is a divide and conquer algorithm. Quicksort first divides a large array into two smaller sub-arrays: the low elements and the high elements. 
        /// Quicksort can then recursively sort the sub-arrays.
        /// </summary>
        /// <param name="input">Unsorted array of intergers</param>
        /// <param name="left">0..q</param>
        /// <param name="right">q+1..input.length-1</param>
        public static void Sort(int[] input, int left, int right)
        {
            Print(input);

            if (left < right)
            {
                var q = Partition(input, left, right);

                Sort(input, left, q - 1);
                Sort(input, q + 1, right);
            }            
        }

        /// <summary>
        /// Sort the elements of the unsorted array based on the pivot
        /// </summary>
        /// <param name="input"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private static int Partition(int[] input, int left, int right)
        {
            var pivot = input[right]; //left + (right-left)/2
            var storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (input[i] < pivot)
                {
                    Swap(input, i, storeIndex++);
                    Print(input);
                }
            }

            //restore pivot to its correct position
            Swap(input, storeIndex, right);
            Print(input);

            return storeIndex;
        }

        /// <summary>
        /// Swaps two integers if they are differents
        /// </summary>
        /// <param name="input">Input integer array</param>
        /// <param name="a">Indice a</param>
        /// <param name="b">Indice b</param>
        private static void Swap(int[] input, int a, int b)
        {
            if (a != b)
            {
                input[a] ^= input[b];
                input[b] ^= input[a];
                input[a] ^= input[b];
            }
        }

        private static void Print(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Debug.Write(string.Format(" {0} ", input[i]));
            }
            Debug.WriteLine(string.Empty);
            
        }
    }
}
