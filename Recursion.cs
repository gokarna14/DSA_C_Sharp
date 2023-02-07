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
        public static string reverseString(string s, string res = "")
        {
            if (s.Length == 0)
            {
                return "";
            }
            // string pp = "GOKARNA";
            // System.Console.WriteLine(pp.Remove(0, 1));

            string ss = reverseString(s.Remove(0, 1), res);
            // System.Console.WriteLine(ss);
            res = ss + s[0];

            return res;
        }

        public static int factorial(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return n*factorial(n-1);
        }
    
        public static long binaryToDecimal(int n, long binary = 0)
        {
            if (n <= 0)
            {
                return 0;
            }

            long binary_ = binaryToDecimal(n/2, binary);

            binary = binary_*10 + n%2;
            // System.Console.Write(binary);


            return binary;
        }
    
        public static bool isPrime(int n, int d=2)
        {
            if (n%d == 0 || n <= 2) 
            {
                return false;
            }
            if (d >= n)
            {
                return true;
            }

            return isPrime(n, n+1);
        }
    
        // find the LCM of two numbers
        public static int LCM(int x, int y, int res = 2)
        {
            System.Console.WriteLine("x->{0}, y->{1}, res->{2}", x, y, res);
            if (x == 1 && y == 1)
            {
                return 1;
            }
            if (x%res == 0 && y%res == 0)
            {
                return res*LCM(x/res, y/res, res); 
            }
            else if (x%res == 0)
            {
                return res*LCM(x/res, y, res); 
            }
            else if (y%res == 0)
            {
                return res*LCM(x, y/res, res); 
            }

            return LCM(x, y, ++res);
        }

        // print even or odd numbers in given range
        public static void printNum(int start, int end, string toPrint = "odd")
        {
            // System.Console.WriteLine(start + " <-");
            if (start >= end)
            {
                return;
            }
            if (toPrint.ToLower() == "odd" && start%2 == 1)
            {
                System.Console.WriteLine(start);
                printNum(start+2, end, toPrint);
            }
            else if (toPrint.ToLower() == "even" && start%2 == 0)
            {
                System.Console.WriteLine(start);
                printNum(start+2, end, toPrint);
            }
            else
                printNum(++start, end, toPrint);
        }

        // public static v
    }
}