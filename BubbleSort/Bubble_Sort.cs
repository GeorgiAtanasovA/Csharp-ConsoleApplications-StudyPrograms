﻿using System;

namespace Bubble_Sort
{
   class Program
   {
      public static void BubbleSort(int[] arr)
      {
         int i = 0;
         int checkForEndLoop = arr.Length - 2;

         while (true)
         {
            if (arr[i] > arr[i + 1])
            {
               int tempNumb = arr[i];
               arr[i] = arr[i + 1];
               arr[i + 1] = tempNumb;
            }
            else if (checkForEndLoop == 0)
            { break; }
            else { checkForEndLoop--; }

            i++;
            if (i + 1 == arr.Length)
            {
               i = 0; checkForEndLoop = arr.Length - 2;
            }
         }
      }
      private static void PrintNumbers(int[] arr)
      {
         foreach (var item in arr)
         {
            Console.Write(item + " ");
         }
         Console.WriteLine();
      }
      static void Main(string[] args)
      {
         Console.WriteLine(" Start numbers");
         int[] arr = { 6, 5, 8, 4, 2, 1, 7, 9, 3, 10, 4, 11, 8, 12, 7 };

         PrintNumbers(arr);

         Console.WriteLine("\n Bubble sort");
         BubbleSort(arr);
         PrintNumbers(arr);

         Console.WriteLine(" \nEND!");
         Console.ReadLine();
      }
   }
}

