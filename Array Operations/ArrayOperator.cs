using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    class ArrayOperator
    {

        public void Merge(ref int[] arr, int start, int end, int middle)
        {
            int[] output = new int[end - start + 1];
            int i = start;
            int j = middle + 1;
            int oCounter = 0;
            while (j != end + 1 && i != middle + 1)
            {
                int largeIndex = j;
                if (arr[i] < arr[j])
                {
                    largeIndex = i;
                    i++;
                }
                else
                {
                    largeIndex = j;
                    j++;
                }
                output[oCounter] = arr[largeIndex];
                oCounter++;
            }

            while (j < end + 1)
            {
                output[oCounter] = arr[j];
                j++;
                oCounter++;
            }
            while (i < middle + 1)
            {
                output[oCounter] = arr[i];
                i++;
                oCounter++;
            }

            for (int k = 0; k < output.Length; k++)
            {
                arr[start + k] = output[k];
            }


        }


        public void MergeSort(ref int[] arr, int start, int end)
        {
            int middle = (end + start) / 2;
            if (end > start)
            {
                MergeSort(ref arr, start, middle);
                MergeSort(ref arr, middle + 1, end);
                Merge(ref arr, start, end, middle);
            }
        }

        public void MergeSortInit(int[] arr)
        {
            MergeSort(ref arr, 0, arr.Length - 1);
        }


        public void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        public int QuickSortPartitioner(ref int[] arr, int start, int end)
        {
            //Partitioning element
            int pIndex = (end + start) / 2;
            int partElement = arr[pIndex];
            int i = start - 1;
            for (int j = start; j <= end; j++)
            {
                
                if (arr[j] < partElement)
                {
                    i++;
                    if (i == pIndex)
                    {
                        pIndex = j;
                    }
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            Swap(ref arr[pIndex], ref arr[i + 1]);
            return i + 1;

        }

        public void QuickSort(ref int[] arr, int start, int end)
        {
            if (end > start)
            {
                int p = QuickSortPartitioner(ref arr, start, end);
                QuickSort(ref arr, start, p - 1);
                QuickSort(ref arr, p + 1, end);
            }
        }

        public void QuickSortInit(int[] arr)
        {
            QuickSort(ref arr, 0, arr.Length - 1);
        }
    }
}
