using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int el = 5;
            int[] A = new int[el];
            int row = 3, col = 4;
            double[,] B = new double[row, col];

            Console.WriteLine($"Enter {el} numbers: ");
            for (int i = 0; i < el; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Random rand = new Random();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    B[i, j] = rand.Next(100);

            Console.WriteLine("Array A: ");
            for (int i = 0; i < el; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array B: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int minA = A[0];
            int maxA = A[0];
            for (int i = 0; i < el; i++)
            {
                if (A[i] < minA) minA = A[i];
                if (A[i] > maxA) maxA = A[i];
            }
            Console.WriteLine($"Smallest element of array A: {minA}. Biggest element of array A: {maxA}");

            double maxB = B[0, 0];
            double minB = B[0, 0];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (B[j, i] < minB) minB = B[j, i];
                    if (B[j, i] > maxB) maxB = B[j, i];
                }
            }
            Console.WriteLine($"Smallest element of array B: {minB}. Biggest element of array B: {maxB}");


            int sumA = 0;
            double sumB = 0;
            foreach (int item in A)
            {
                sumA += item;
            }

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    sumB += B[i, j];

            Console.WriteLine($"Amount of numbers of array A: {sumA}. \nAmount of numbers of array B: {sumB}.\nCommon amount: {sumA + sumB}");


            int multA = 1;
            double multB = 1;
            foreach (int item in A)
            {
                multA *= item;
            }

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    multB *= B[i, j];

            Console.WriteLine($"Product of numbers of array A: {multA}.\nProduct of numbers of array B: {multB}.\nCommon product: {multA * multB}");


            int evenSum = 0;
            for (int i = 0; i < el; i++)
            {
                if (i % 2 == 0)
                    evenSum += A[i];
            }
            Console.WriteLine("Amount of even elements of array A: " + evenSum);


            double sumCol = 0;
            for (int i = 0; i < col; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 0; j < row; j++)
                    {
                        sumCol += B[j, i];
                    }
                }
            }
            Console.WriteLine("Amount of odd columns of array B: " + sumCol);

            Console.ReadKey();
        }
    }
}
