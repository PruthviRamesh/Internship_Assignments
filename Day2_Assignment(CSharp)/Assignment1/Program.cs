using System;

//Inheritance
class Student
{
    public string name;
    public int age;
    public string address;
    public Student(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }
    public void StudentDetails()
    {
        Console.WriteLine("Student Details are");
        Console.WriteLine("Name:{0},Age :{1},Address:{2}", name, age, address);
    }
}
class Teacher : Student
{
    public string subject;
    public Teacher(string name, int age, string address, string subject) : base(name, age, address)
    {
        this.subject = subject;
    }
    public void TeacherDetails()
    {
        Console.WriteLine("Teacher Details are");
        Console.WriteLine("Name:{0},Age :{1},Address:{2},Subject:{3} ", name, age, address, subject);
    }
}
class Driver
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter \n 1 To view Teacher details \n 2 To view student details");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter the Subject");
                string subject = Console.ReadLine();
                Teacher t = new Teacher(name, age, address, subject);
                t.TeacherDetails();
                break;
            case 2:
                Console.WriteLine("Enter the name");
                string name1 = Console.ReadLine();
                Console.WriteLine("Enter the age");
                int age1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the address");
                string address1 = Console.ReadLine();
                Student s = new Student(name1, age1, address1);
                s.StudentDetails();
                break;
        }
    }
}

//Polymorphism
//public class DigitalWallet
//{
//    public virtual void transaction()
//    {
//        Console.WriteLine("Money transferred through Digital Wallet");
//    }
//}
//public class BankTransfer : DigitalWallet
//{
//    public override void transaction()
//    {
//        Console.WriteLine("Money transferred through Bank");
//    }
//}
//public class CreditCard : DigitalWallet
//{
//    public override void transaction()
//    {
//        Console.WriteLine("Money transferred through Creditcard");
//    }
//}
//class Driver
//{
//    static void Main(string[] args)
//    {
//        DigitalWallet d = new DigitalWallet();
//        d.transaction();
//        DigitalWallet d1 = new CreditCard();
//        d1.transaction();
//        DigitalWallet d2 = new BankTransfer();
//        d2.transaction();
//    }
//}

//Encapsulation

//class Employee
//{
//    private string name;
//    private int id;
//    private int sal;
//    public void setName(string name)
//    {
//        this.name = name;
//    }
//    public string getName()
//    {
//        return this.name;
//    }
//    public void setId(int id)
//    {
//        this.id = id;
//    }
//    public int getId()
//    {
//        return this.id;
//    }
//    public void setSal(int sal)
//    {
//        this.sal = sal;
//    }
//    public int getSal()
//    {
//        return this.sal;
//    }
//}
//class Driver
//{
//    static void Main(string[] args)
//    {
//        Employee e = new Employee();
//        e.setName("John");
//        e.setId(123);
//        e.setSal(20000);
//        Console.WriteLine("Name is " + e.getName() + ", Id is " + e.getId() + " , Salary is " + e.getSal());

//    }
//}


//abstract class shape
//{
//    public abstract void calculateArea();
//}
//class Circle : shape
//{
//    public double radius;
//    public Circle(double radius)
//    {
//        this.radius = radius;
//    }
//    public override void calculateArea()
//    {
//        Console.WriteLine("Area of Circle is " + 3.14 * radius * radius);
//    }
//}
//class Triangle : shape
//{
//    public double length;
//    public double breadth;
//    public Triangle(double length, double breadth)
//    {
//        this.length = length;
//        this.breadth = breadth;
//    }
//    public override void calculateArea()
//    {
//        Console.WriteLine("Area of Triangle is " + 0.5 * length * breadth);
//    }
//}
//class Square : shape
//{
//    public double length;
//    public Square(double length)
//    {
//        this.length = length;
//    }
//    public override void calculateArea()
//    {
//        Console.WriteLine("Area of Triangle is " + length * length);
//    }
//}
//class Driver
//{
//    static void Main(string[] args)
//    {
//        Circle c = new Circle(2.3);
//        c.calculateArea();
//        Triangle t = new Triangle(10, 20);
//        t.calculateArea();
//        Square s = new Square(10.5);
//        s.calculateArea();

//    }
//}