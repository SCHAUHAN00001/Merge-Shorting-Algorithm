using System;

namespace Merge_Sorting_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 9, 3, 5, 7 };
            MergeSort(arr, 0, arr.Length - 1); 
            Console.WriteLine("Sorted Array:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();

        }

        public static void MergeSort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(A, left, mid);
                MergeSort(A, mid + 1, right);
                Merge(A, left, mid, right);
            }
        }

        public static void Merge(int[] A, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                L[i] = A[left + i];
            }

            for (int j = 0; j < n2; j++)
            {
                R[j] = A[mid + 1 + j];
            }

            int i1 = 0, i2 = 0, k = left;

            while (i1 < n1 && i2 < n2)
            {
                if (L[i1] <= R[i2])
                {
                    A[k] = L[i1];
                    i1++;
                }
                else
                {
                    A[k] = R[i2];
                    i2++;
                }
                k++;
            }

            while (i1 < n1)
            {
                A[k] = L[i1];
                i1++;
                k++;
            }

            while (i2 < n2)
            {
                A[k] = R[i2];
                i2++;
                k++;
            }
        }

       
    }
}

