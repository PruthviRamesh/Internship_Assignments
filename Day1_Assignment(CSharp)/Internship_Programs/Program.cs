using System;
//class Progarm1
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a String");
//        string input = Console.ReadLine();
//        int count = 0;
//        for (int i = 0; i < input.Length; i++)
//        {
//            if ((i == 0 && input[i] != ' ') || (input[i] != ' ' && input[i - 1] == ' '))
//            {
//                count++;
//            }
//        }
//        Console.WriteLine("Number of words in {0} string is {1}", input, count);
//    }
//}

//class Program2
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter first number");
//        int num1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter second number");
//        int num2 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter third number");
//        int num3 = Convert.ToInt32(Console.ReadLine());
//        int avg = (num1 + num2 + num3) / 3;
//        Console.WriteLine("The average of {0}, {1}, and {2} is: {3}", num1, num2, num3, avg);
//    }
//}

//class Program3
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the Principal amount");
//        double principal = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Enter the time in years");
//        double time = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Enter the interest rate in percentage");
//        double rate = Convert.ToDouble(Console.ReadLine());
//        double simpleInterest = (principal * time * rate) / 100;
//        Console.WriteLine("Simple interest is {0}", simpleInterest);
//    }
//}

//class Program4
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the first num");
//        int num1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter the second num");
//        int num2 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter the third num");
//        int num3 = Convert.ToInt32(Console.ReadLine());
//        if (num1 > num2 && num1 > num3)
//        {
//            Console.WriteLine("{0} is biggest among {1},{2} and {3} ", num1, num1, num2, num3);
//        }
//        else if (num2 > num3)
//        {
//            Console.WriteLine("{0} is biggest among {1},{2} and {3} ", num2, num1, num2, num3);
//        }
//        else
//        {
//            Console.WriteLine("{0} is biggest among {1},{2} and {3} ", num3, num1, num2, num3);
//        }
//    }
//}

//class Program5
//{
//    //static void Main(string[] args)
//    //{
//    //    int[] a = { 1, 1, 2, 3, 4, 2 };
//    //    int count = 0;
//    //    for (int i = 0; i < a.Length; i++)
//    //    {
//    //        for (int j = i + 1; j < a.Length; j++)
//    //        {
//    //            if (a[i] == a[j] && a[i] != -1 && a[j] != -1)
//    //            {
//    //                a[j] = -1;
//    //                count++;
//    //            }
//    //        }
//    //    }
//    //    int temp = 0;
//    //    int[] b = new int[a.Length - count];
//    //    for (int i = 0; i < a.Length; i++)
//    //    {
//    //        if (a[i] != -1)
//    //        {
//    //            b[temp++] = a[i];
//    //        }
//    //    }
//    //    for (int i = 0; i < b.Length; i++)
//    //    {
//    //        Console.WriteLine(b[i]);
//    //    }
//    //}

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the size");
//        int size = Convert.ToInt32(Console.ReadLine());
//        int[] array = new int[size];
//        Console.WriteLine("Enter array Elements");
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = Convert.ToInt32(Console.ReadLine());
//        }
//        int[] uniqueArray = array.Distinct().ToArray();
//        Console.WriteLine("Unique values:");
//        foreach (int item in uniqueArray)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

//class Program6
//{
//    static void Main(string[] args)
//    {
//      TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
//      Console.WriteLine("Local Time Zone:");
//      Console.WriteLine($"ID: {localTimeZone.Id}");
//      Console.WriteLine($"Display Name: {localTimeZone.DisplayName}");

//        //string timeZoneId = "pacific Standard Time";
//        //TimeZoneInfo specificTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
//        //Console.WriteLine("Time Zone: {timeZoneId}");
//        //Console.WriteLine("ID: {specificTimeZone.Id}");
//        //Console.WriteLine("Display Name: {specificTimeZone.DisplayName}");
//    }
//}