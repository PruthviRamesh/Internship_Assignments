using System;
using Newtonsoft.Json;
using System.Numerics;
//class Student
//{
//    public string name;
//    public int age;
//    public int classId;
//    public Student(string name, int age, int classId)
//    {
//        this.name = name;
//        this.age = age;
//        this.classId = classId;
//    }
//}
//class Class
//{
//    public string name;
//    public int Id;
//    public Class(string name, int Id)
//    {
//        this.name = name;
//        this.Id = Id;
//    }
//}
//class Program1
//{
//    static void Main(string[] args)
//    {
//        List<Student> Student = new List<Student>();
//        Student.Add(new Student("Pruthvi", 18, 2));
//        Student.Add(new Student("Rashmi", 19, 3));
//        Student.Add(new Student("Harshitha", 20, 4));
//        Student.Add(new Student("Anu", 17, 1));
//        Student.Add(new Student("John", 19, 3));
//        Student.Add(new Student("Smith", 20, 4));

//        List<Class> classes = new List<Class>();
//        classes.Add(new Class("Physics", 1));
//        classes.Add(new Class("Biology", 2));
//        classes.Add(new Class("Chemistry", 3));
//        classes.Add(new Class("Mathematics", 4));

//        var studentsOlderThan18 = from student in Student
//                                  where student.age > 18
//                                  select student;

//        var classOlderthan18 = from clas in classes join student in studentsOlderThan18 on clas.Id equals student.classId select new { StudentName = student.name, ClassId = clas.Id, ClassName = clas.name, StudentAge = student.age };

//        Console.WriteLine("Students older than 18:");
//        foreach (var student in studentsOlderThan18)
//        {
//            Console.WriteLine("Name : " + student.name + ", Class Id : " + student.classId + ", Age : " + student.age);
//        }
//        Console.WriteLine("\nClasses with students older than 18:");
//        foreach (var clas in classOlderthan18)
//        {
//            Console.WriteLine("Class Name : " + clas.ClassName + ", Class Id :" + clas.ClassId + ", Student Name : " + clas.StudentName + ", Student Age : " + clas.StudentAge);
//        }
//    }
//}

//class Employee
//{
//    public string name;
//    public int id;
//    public int salary;
//    public Employee(string name, int id, int salary)
//    {
//        this.name = name;
//        this.id = id;
//        this.salary = salary;
//    }
//}
//class Program2
//{
//    static void Main(string[] args)
//    {
//        List<Employee> employee = new List<Employee>();
//        employee.Add(new Employee("Smith", 111, 2000));
//        employee.Add(new Employee("John", 222, 10000));
//        employee.Add(new Employee("Turner", 333, 1800));
//        employee.Add(new Employee("Ward", 444, 3000));
//        employee.Add(new Employee("Mark", 555, 20000));
//        var Sal = from emp in employee where emp.salary >= 800 && emp.salary <= 6000 select emp;
//        foreach (Employee emp in Sal)
//        {
//            Console.WriteLine("Name : " + emp.name + ", Salary : " + emp.salary);
//        }
//    }
//}

//class Employee
//{
//    public string name;
//    public int id;
//    public int salary;
//    public Employee(string name, int id, int salary)
//    {
//        this.name = name;
//        this.id = id;
//        this.salary = salary;
//    }
//}

//class Program3
//{
//    static void Main(string[] args)
//    {
//        List<Employee> list = new List<Employee>();
//        char c;
//        do
//        {
//            Console.WriteLine("Enter the Employee name ,Id and Salary");
//            string ename = Console.ReadLine();
//            int id = Convert.ToInt32(Console.ReadLine());
//            int sal = Convert.ToInt32(Console.ReadLine());
//            list.Add(new Employee(ename, id, sal));
//            Console.WriteLine("Press 'c' to continue");
//            c = Convert.ToChar(Console.ReadLine());

//        } while (c == 'c');

//        Console.WriteLine("Employees with name consisting less than 4 characters are :");
//        var res = from emp in list where emp.name.Length < 4 select emp;
//        foreach (Employee emp in res)
//        {
//            Console.WriteLine(emp.name);
//        }
//    }
//}

//class Employee
//{
//    public string name;
//    public int id;
//    public int salary;
//    public Employee(string name, int id, int salary)
//    {
//        this.name = name;
//        this.id = id;
//        this.salary = salary;
//    }
//}
//class Program4
//{
//    static void Main(string[] args)
//    {
//        List<Employee> list = new List<Employee>();
//        char c;
//        do
//        {
//            Console.WriteLine("Enter the Employee name ,Id and Salary");
//            string ename = Console.ReadLine();
//            int id = Convert.ToInt32(Console.ReadLine());
//            int sal = Convert.ToInt32(Console.ReadLine());
//            list.Add(new Employee(ename, id, sal));
//            Console.WriteLine("Press 'c' to continue");
//            c = Convert.ToChar(Console.ReadLine());

//        } while (c == 'c');
//        Console.WriteLine("All the employee details");
//        foreach (Employee e in list)
//        {
//            Console.WriteLine("Name : " + e.name + ", Id : " + e.id + ", Salary : " + e.salary);
//        }
//        Console.WriteLine("********************************************");
//        Console.WriteLine("Enter 1 or 2 to filter details greater than specific value \n1.By Salary \n2.By Id");
//        Console.WriteLine("********************************************");
//        int choice = Convert.ToInt32(Console.ReadLine());
//        switch (choice)
//        {
//            case 1:
//                Console.WriteLine("Enter the minimum Salary");
//                int minSalary = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Employees with Salary greater than " + minSalary + " are:");
//                foreach (Employee e in list)
//                {
//                    if (e.salary > minSalary)
//                    {
//                        Console.WriteLine("Name : " + e.name + ", Id : " + e.id + ", Salary : " + e.salary);
//                    }
//                }
//                break;

//            case 2:
//                Console.WriteLine("Enter the minimum Id");
//                int minId = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Employees with Id greater than " + minId + " are:");
//                foreach (Employee e in list)
//                {
//                    if (e.id > minId)
//                    {
//                        Console.WriteLine("Name : " + e.name + ", Id : " + e.id + ", Salary : " + e.salary);
//                    }
//                }
//                break;
//            default:
//                Console.WriteLine("Invalid choice");
//                break;
//        }

//    }
//}

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        BigInteger factorialResult = await Task.Run(() => FactorialAsync(20));
//        Console.WriteLine("Factorial of 20: " + factorialResult);

//        BigInteger fibonacciResult = await Task.Run(() => FibonacciAsync(20));
//        Console.WriteLine("20th term of Fibonacci sequence: " + fibonacciResult);
//    }

//    static async Task<BigInteger> FactorialAsync(int n)
//    {
//        if (n == 0)
//            return 1;
//        return n * await FactorialAsync(n - 1);
//    }

//    static async Task<BigInteger> FibonacciAsync(int n)
//    {
//        if (n <= 1)
//            return n;
//        return await FibonacciAsync(n - 1) + await FibonacciAsync(n - 2);
//    }
//}

//class Bank
//{
//    private static string bankName;
//    private const double minBalance = 1000;
//    private const double interestRate = 0.07;
//    private const int interestPeriodicity = 6;
//    private double balance;
//    static Bank()
//    {
//        Console.WriteLine("Enter the Bank Name");
//        bankName = Console.ReadLine();
//    }
//    public void rename(string newName)
//    {
//        bankName = newName;
//        Console.WriteLine("Bank name successfully renamed to " + bankName);
//    }
//    public void deposit(double amount)
//    {
//        balance += amount;
//        Console.WriteLine("You have deposited {0} . Current balance is {1} ", amount, balance);
//    }
//    public void withdraw(double amount)
//    {
//        if ((balance - amount) < minBalance)
//        {
//            Console.WriteLine("Insufficient fund...Minimum balance should be 1000");
//        }
//        else
//        {
//            balance = balance - amount;
//            Console.WriteLine("You have withdrawn {0} . Available balance {1} ", amount, balance);
//        }
//    }
//    public void checkBalance()
//    {
//        Console.WriteLine("Balance is " + balance);
//    }
//    public void addInterest()
//    {
//        double addamount = balance * interestRate * (interestPeriodicity / 12.0);
//        balance += addamount;
//        Console.WriteLine("Interest Added . New Balance is " + balance);
//    }
//}
//class BankDriver
//{
//    static void Main(string[] args)
//    {
//        Bank bank = new Bank();
//        int i = 0;
//        while (i == 0)
//        {
//            Console.WriteLine("Enter \n1.To Deposit \n2.To Withdraw \n3.To Rename Bank \n4.To check balance \n5.To add interest \n6.To exit");
//            int choice = Convert.ToInt32(Console.ReadLine());
//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("Enter the amount to deposit");
//                    double deposit_amount = Convert.ToDouble(Console.ReadLine());
//                    bank.deposit(deposit_amount);
//                    break;
//                case 2:
//                    Console.WriteLine("Enter the amount to withdraw");
//                    double withdraw_amount = Convert.ToDouble(Console.ReadLine());
//                    bank.withdraw(withdraw_amount);
//                    break;
//                case 3:
//                    Console.WriteLine("Enter the name");
//                    string name = Console.ReadLine();
//                    bank.rename(name);
//                    break;
//                case 4:
//                    bank.checkBalance();
//                    break;
//                case 5:
//                    bank.addInterest();
//                    break;
//                case 6:
//                    i = 1;
//                    Console.WriteLine("Exited");
//                    break;
//                default:
//                    Console.WriteLine("Invalid choice");
//                    break;
//            }
//        }
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product(1, "Phone", 9000, 2));
        products.Add(new Product(2, "Watch", 3000, 3));
        products.Add(new Product(2, "Headphones", 4000, 1));
        products.Add(new Product(4, "Chair", 500, 10));
        products.Add(new Product(5, "TV", 30000, 2));

        string jsonString = JsonConvert.SerializeObject(products);

        Console.WriteLine("JSON string:");
        Console.WriteLine(jsonString);

        List<Product> deserializedProducts = JsonConvert.DeserializeObject<List<Product>>(jsonString);

        Console.WriteLine("\nDeserialized Products:");
        foreach (var product in deserializedProducts)
        {
            Console.WriteLine("ProductId : {0}, ProductName : {1}, Price : {2}, Quantity : {3}", product.ProductId, product.ProductName, product.Price, product.Quantity);
        }
    }
}

class Product
{
    public int ProductId;
    public string ProductName;
    public int Price;
    public int Quantity;
    public Product(int productId, string productName, int price, int quantity)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }
}
