using System;
using System.Text.RegularExpressions;
//public class TemperatureException : Exception
//{
//    public TemperatureException(string message) : base(message) { }
//}
//class Program1
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the temperature");
//        int temp = Convert.ToInt32(Console.ReadLine());
//        try
//        {
//            if (temp > 0)
//            {
//                Console.WriteLine("The temperature is " + temp);
//            }
//            else
//            {
//                throw new TemperatureException("Temperature is zero");
//            }
//        }
//        catch (TemperatureException t)
//        {
//            Console.WriteLine(t.GetType() + ":" + t.Message);
//        }
//    }
//}

//public class Program2
//{
//    static void Main(string[] args)
//    {
//        List<string> l = new List<string>();
//        l.Add("Apple");
//        l.Add("Banana");
//        l.Add("Kiwi");
//        l.Add("Watermelon");
//        Console.WriteLine("********************Using for loop***************************");
//        for (int i = 0; i < l.Count; i++)
//        {
//            Console.WriteLine(l[i]);
//        }
//        Console.WriteLine("********************Using foreach*****************************");
//        foreach (string s in l)
//        {
//            Console.WriteLine(s);
//        }
//        Console.WriteLine("**************************using Index Positions***********************");
//        Console.WriteLine("1st position "+l[0] + "\n" +"2nd position "+l[1] + "\n"+"3rd position "+ l[2] + "\n" +"4th position "+ l[3]);
//    }
//}

//class Program3
//{
//    static void Main(string[] args)
//    {
//        string path = @"E:\test.txt";
//        File.Create(path);
//        if (File.Exists(path))
//        {
//            Console.WriteLine("File Created Successfully");
//        }
//        else
//        {
//            Console.WriteLine("File not Created");
//        }
//    }
//}

//class Program4
//{
//    static void Main(string[] args)
//    {
//        string path = @"E:\test.txt";
//        File.WriteAllText(path, "Hello Good afternoon \n");
//        Console.WriteLine(File.ReadAllText(path));
//        Console.WriteLine("Enter the text");
//        string text = Console.ReadLine();
//        File.AppendAllText(path, text + "\n");
//        Console.WriteLine("*****File Content********");
//        Console.WriteLine(File.ReadAllText(path));
//    }
//}

//class Program5
//{
//    private string[] details = new string[6];

//    public string this[int index]
//    {
//        get
//        {
//            return details[index];
//        }
//        set
//        {
//            details[index] = value;
//        }
//    }
//}
//class Driver
//{
//    static void Main(string[] args)
//    {
//        Program5 emp = new Program5();
//        Console.WriteLine("Enter the Id");
//        emp[0] = Console.ReadLine();
//        Console.WriteLine("Enter the name");
//        emp[1] = Console.ReadLine();
//        Console.WriteLine("Enter the Job");
//        emp[2] = Console.ReadLine();
//        Console.WriteLine("Enter the Salary");
//        emp[3] = Console.ReadLine();
//        Console.WriteLine("Enter the Location");
//        emp[4] = Console.ReadLine();
//        Console.WriteLine("Enter the Gender");
//        emp[5] = Console.ReadLine();
//        Console.WriteLine("************************Employee Details are**************************");
//        Console.WriteLine("ID - {0} \nName - {1} \nJob - {2} \nSalary - {3} \nLocation - {4} \nGender - {5}", emp[0], emp[1], emp[2], emp[3], emp[4], emp[5]);
//        Console.WriteLine("Enter 0,1,2,3,4,5 to modify id,name,job,salary,location,Gender respectively");
//        int choice = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter the modified content");
//        emp[choice] = Console.ReadLine();
//        Console.WriteLine("******************************After Modification***************************");
//        Console.WriteLine("ID - {0} \nName - {1} \nJob - {2} \nSalary - {3} \nLocation - {4} \nGender - {5}", emp[0], emp[1], emp[2], emp[3], emp[4], emp[5]);
//    }
//}

//class Program6
//{
//    static void Main(string[] args)
//    {
//        File.WriteAllText(@"E:\test.txt", "This is CSharp Program");
//        File.Copy(@"E:\test.txt", @"E:\renamed_Copied.txt");
//        Console.WriteLine("Contents of Original file");
//        Console.WriteLine(File.ReadAllText(@"E:\test.txt"));
//        Console.WriteLine("Contents of Copied file");
//        Console.WriteLine(File.ReadAllText(@"E:\renamed_Copied.txt"));
//    }
//}

//class Program7
//{
//    //static int[] mergedArray(int[] a, int[] b)
//    //{
//    //    int[] merged_array = new int[a.Length + b.Length];
//    //    int k = 0;
//    //    for (int i = 0; i < merged_array.Length; i++)
//    //    {
//    //        if (i < a.Length)
//    //        {
//    //            merged_array[i] = a[i];
//    //        }
//    //        else
//    //        {
//    //            merged_array[i] = b[k++];
//    //        }
//    //    }
//    //    Array.Sort(merged_array);
//    //    return merged_array;
//    //}
//    static void Main(string[] args)
//    {
//        int[] a = { 5, 4, 3, 2, 10 };
//        int[] b = { 2, 1, 6 };
//        int[] c = a.Concat(b).ToArray();
//        Array.Sort(c);
//        Console.WriteLine(string.Join(",", c));
//        //Console.WriteLine(string.Join(",", mergedArray(a, b)));
//    }
//}

//class Program8
//{
//    static void Main(string[] args)
//    {
//        int[] a = { 1, 2, 1, 2, 3, 4, 5, 6, 3 };
//        Dictionary<int, int> frequency = new Dictionary<int, int>();
//        foreach (int num in a)
//        {
//            if (frequency.ContainsKey(num))
//            {
//                frequency[num]++;
//            }
//            else
//            {
//                frequency[num] = 1;
//            }
//        }
//        Console.WriteLine("Element --> Frequency");
//        foreach (var pair in frequency)
//        {
//            Console.WriteLine(pair.Key + "-->" + pair.Value);
//        }
//    }
//}

//class Program9
//{
//    static void Main(string[] args)
//    {
//        int[] arr = { 3, 6, 2, 4, 1, 7, 8 };
//        int[] odd = new int[arr.Length];
//        int[] even = new int[arr.Length];
//        int oddCount = 0;
//        int evenCount = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] % 2 == 0)
//            {
//                even[evenCount++] = arr[i];
//            }
//            else
//            {
//                odd[oddCount++] = arr[i];
//            }
//        }
//        Array.Resize(ref odd, oddCount);
//        Array.Resize(ref even, evenCount);
//        Console.WriteLine("Odd Elements are " + string.Join(",", odd));
//        Console.WriteLine("Even Elements are " + string.Join(", ", even));
//    }
//}

//class Program10
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter X Coordinate");
//        double x = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Enter Y Coordinate");
//        double y = Convert.ToDouble(Console.ReadLine());
//        if (x > 0 && y > 0)
//        {
//            Console.WriteLine("The point lies in I Quadrant");
//        }
//        else if (x < 0 && y > 0)
//        {
//            Console.WriteLine("The point lies in II Quadrant");
//        }
//        else if (x < 0 && y < 0)
//        {
//            Console.WriteLine("The point lies in III Quadrant");
//        }
//        else if (x > 0 && y < 0)
//        {
//            Console.WriteLine("The point lies in IV Quadrant");
//        }
//        else if (x == 0 && y != 0)
//        {
//            Console.WriteLine("The point lies on Y-axis");
//        }
//        else if (y == 0 && x != 0)
//        {
//            Console.WriteLine("The point lies on X-axis");
//        }
//        else
//        {
//            Console.WriteLine("The point is origin");
//        }
//    }
//}

class Program11
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter customer name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter customer ID:");
        string id = Console.ReadLine();

        Console.WriteLine("Enter units consumed:");
        int unitsConsumed = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter due amount:");
        int dueAmount = Convert.ToInt32(Console.ReadLine());

        double electricity_bill = dueAmount + (unitsConsumed * 6.50);
        Console.WriteLine("Customer name : " + name);
        Console.WriteLine("Customer ID : "+id);
        Console.WriteLine("Due Amount : " + dueAmount);
        Console.WriteLine("Units Consumed : " + unitsConsumed);
        Console.WriteLine("Electricity Bill : " + electricity_bill);
    }
}

//class Program12
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a String");
//        string input = Console.ReadLine();
//        string pattern = "[^a-zA-Z0-9 _-]";
//        string updatedString = Regex.Replace(input, pattern, "");
//        Console.WriteLine("Updated String is " + updatedString);
//    }
//}

//class linq
//{
//    static void Main(string[] args)
//    {
//        int[] a = { 10, 11, 3, 14, 6, 2, 15 };
//        var b = from i in a where i > 10 orderby i descending select i;
//        foreach(int s in b)
//        {
//            Console.Write(s + " ");
//        }
//    }
//}