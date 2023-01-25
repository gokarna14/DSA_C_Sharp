using System;


namespace DSA
{
    public static class Recursion
    {
        // Write a program to print first 50 natural numbers using recursion.
        public static void decToZero(int n)
        {
            if (n < 0)
            {
                return;
            }
            System.Console.WriteLine(n);
            decToZero(n - 1);
        }

        public static void countToN(int n, int count=0)
        {
            if (count > n)
            {
                return;
            }
            System.Console.WriteLine(count);
            countToN(n, ++count);
        }
        // Write a program to calculate the sum of numbers from 1 to n using recursion.
        public static int sumUpToN(int n)
        {
            if (n <= 1)
            {   
                return 1;
            }
            return n + sumUpToN(n-1);
        }


        // Fibonacci Series
        public static int Fibonacci(int n)
        {
            int res;
            if (n == 1 || n == 2)
            {
                res = 1;
            }
            else
            {
                res = Fibonacci(n - 1) + Fibonacci(n - 2); 
            }
            return res;
        }

        // print the array elements using recursion
        public static void printArrayElements(int[] arr, int i=0)
        {
            if (i >= arr.Length)
            {
                return;
            }
            System.Console.Write("{0}\t", arr[i]);
            printArrayElements(arr, ++i);
        }

        // count the number of digits
        public static int countDigits(int n)
        {
            if (n <= 9)
            {
                return 1;
            }
            return 1 + countDigits(n/10);
        }

        // sum of digits of a number
        public static int sumOfDigits(int n)
        {
            if (n < 10)
            {
                return n;
            }
            return n%10 +  sumOfDigits(n/10);
        }

        public static int GCD(int x, int y)
        {
            if (x == y)
            {
                return x;
            }
            return x>y ? GCD(x-y, y) : GCD(x, y-x) ;
        }

        public static int getLargestElement(int[] arr, int i = 0, int res= int.MinValue)
        {
            if (i >= arr.Length)
            {
                return res;
            }
            if (arr[i] > res)
            {
                res = arr[i];
            }
            return getLargestElement(arr, ++i, res);
        }

        //  reverse a string using recursion
        // public static string reverseString(string s, int i = 0)
        // {
        //     return reverseString(s[i], ++i);
        // }

    }
}