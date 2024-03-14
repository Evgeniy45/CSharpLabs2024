using System;
using System.Reflection.Metadata;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1, Варіант 18
            Console.WriteLine("Task 1:");
            GetAndPrintNumbersInrange();
            Console.WriteLine();


            // Завдання 2
            Console.WriteLine("Task 2:");
            GetSidesAndPrintTriangle();
            Console.WriteLine();

            // Завдання 3
            Console.WriteLine("Task 3:");
            FindMinAndMaxInArray();
            Console.WriteLine();

            // Завдання 4
            Console.WriteLine("Task 3:");
            PrintAllArrays();
            Console.WriteLine();
        }

        /*Метод для завдання 1*/
        static void GetAndPrintNumbersInrange()
        {
             Console.WriteLine("Enter three integer numbers separated by 'Enter' ");
             int num1 = int.Parse(Console.ReadLine());
             int num2 = int.Parse(Console.ReadLine());
             int num3 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter start and end of the rangeseparated by 'Enter'");
             int start = int.Parse(Console.ReadLine());
             int end = int.Parse(Console.ReadLine());

            CheckingNumbersInRange(num1, start, end);
            CheckingNumbersInRange(num2, start, end);
            CheckingNumbersInRange(num3, start, end);
        }

        /*Метод для завдання 1*/
        static void CheckingNumbersInRange(int num, int start, int end)
        {
            if( num >= start && num <= end )
            {
                Console.WriteLine($"The number {num} is in the range [1;18]");
            }
        }


        /*Метод для завдання 2*/
        static void GetSidesAndPrintTriangle()
        {
            Console.WriteLine("Enter sides of triangle separated by 'Enter' ");
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double side3 = double.Parse(Console.ReadLine());

            CalculatePerimAndArea(side1, side2, side3);
            TypeOfTriangle(side1, side2, side3);

        }

        /*Метод для завдання 2*/
        static void CalculatePerimAndArea(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("A triangle with the given sides does not exist.");
                return;
            }
            double perimeter = side1 + side2 + side3 ;
            double halfPerimeter = perimeter / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));

            Console.WriteLine($"Perimeter: {perimeter}");
            Console.WriteLine($"Area: {area}");
        }

        /*Метод для завдання 2*/
        static void TypeOfTriangle(double side1, double side2, double side3){
            string triangleType;
            if (side1 == side2 && side2 == side3)
                triangleType = "equitable";//рівносторонній
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                triangleType = "isosceles";//рівнобедрений
            else
                triangleType = "versatile";//різносторонній

            Console.WriteLine($"Type of triangle: {triangleType}");
        }

        /*Метод для завдання 3*/
        static void FindMinAndMaxInArray()
        {
            int[] X = new int[18];

            ArrayWithRandomNumbers(X);

            int min = X[0];
            int max = X[0];
            foreach (int num in X)
            {
                if (num < min)
                {
                    min = num;
                }
                else if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Масив Х:");
            PrintArray(X);
        }
 
        /*Метод для завдання 3 та 4*/
        static void ArrayWithRandomNumbers(int[] arr)
        {
            Random random = new Random();

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 101);
            }
        }

        /*Метод для завдання 3 та 4*/
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        /*Метод для завдання 4*/
        static int[] GetFilteredArray(int[] X, int M)
        {
            int[] result = new int[X.Length];
            int count = 0;

            foreach (int num in X)
            {
                if (Math.Abs(num) > M)
                {
                    result[count] = num;
                    count++;
                }
            }
            int[] filteredArray = new int[count];
            Array.Copy(result, filteredArray, count);
            return filteredArray;
        }

        /*Метод для завдання 4*/
        static void PrintAllArrays()
        {
            int[] X = new int[18];

            ArrayWithRandomNumbers(X);

            int M = 8;

            int[] Y = GetFilteredArray(X, M);

            Console.WriteLine($"Number M: {M}");
            Console.WriteLine("Array Х:");
            PrintArray(X);
            Console.WriteLine("Array Y:");
            PrintArray(Y);
        }
    }
}