using System;

namespace TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] arr1 = { 1, 2, 34, 5, 6, 7, 5 };
            //int[] arr3 = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}



            //int[] nums = new int[5];
            //nums[0] = 2;
            //nums[1] = 8;
            //nums[2] = 17;
            //Array.Resize(ref nums, 20);
            //nums[8] = 11;

            //int[] arr1 = { 1, 2, 34, 5, 6, 7, 5 };

            //Array.Reverse(arr1);

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(arr1);

            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //int[,] arr2 = { { 1, 2, 3 }, { 4, 6, 7 } };

            //Console.WriteLine(arr2.Rank);


            //int a = 5;
            //var t = a.ToString();
            //t += "100";
            //Console.WriteLine(t);


            #endregion

            #region Object
            //string stuName1 = "Qoshqar";
            //string stuSurname1 = "Narimanli";
            //int stuAge1 = 29;
            //bool isMarried = true;

            //string stuName2 = "Mehemmed";
            //string stuSurname2 = "Mehtiyev";
            //int stuAge2 = 15;
            //bool isMarried2 = false;

            //string stuName3 = "Resul";
            //string stuSurname3 = "Hesenov";
            //int stuAge3 = 15;
            //bool isMarried3 = false;

            //string stuName4 = "Vugar";
            //string stuSurname4 = "Rustamov";
            //int stuAge4 = 38;
            //bool isMarried4 = true;

            //string stuName5 = "Cavid";
            //string stuSurname5 = "Aliyev";
            //int stuAge5 = 25;
            //bool isMarried5 = false;


            ////Console.WriteLine($"{ stuName3} {stuSurname3} {stuAge3}");

            ////Console.WriteLine($"{ stuName5} {stuSurname5} {stuAge5}");

            //var stu1 = new
            //{
            //    name = "Qoshqar",
            //    surname = "Narimanli",
            //    age = 29,
            //    isMarried = true
            //};

            //var stu2 = new
            //{
            //    name = "Mehemmed",
            //    surname = "Mehtiyev",
            //    age = 15,
            //    isMarried = false
            //};

            //var stu3 = new
            //{
            //    name = "Resul",
            //    surname = "Hesenov",
            //    age = 15,
            //    isMarried = false
            //};

            //var stu4 = new
            //{
            //    name = "Cavid",
            //    surname = "Aliyev",
            //    age = 29,
            //    isMarried = true
            //};


            ////Console.WriteLine($"{stu4.name} {stu4.surname} {stu4.age}");

            ////object[] students = { stu1, stu2, stu3, stu4 };

            ////foreach (var item in students)
            ////{
            ////    Console.WriteLine(item);
            ////}
            #endregion

            #region Task Account
            //Account pass = new Account();
            //Console.WriteLine(pass.Login("cavid123", "Cavid1993"));
            #endregion

            #region Task Factorial
            //Factorial factorial = new Factorial();
            //factorial.FindFactorial(5);



            #endregion

            #region Task Calculator

            Calculator calculate = new Calculator();

            Console.WriteLine("Enter First Number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operation");
            //int n = int.Parse(Console.ReadLine());

            Console.WriteLine(calculate.Calculate(x, y));

            #endregion

                
            //Car car1 = new Car();
            //car1.name = "BMW";
            //car1.color = "Red";
            //car1.price = 15000;

            //int age = 66;

            //Car car3 = new Car();

            //Car car2 = new Car();
            //car2.name = "Toyota";
            //car2.color = "Black";
            //car2.price = 30000.2;

            //Console.WriteLine(car1.name + " " + car1.color);
            //Console.WriteLine(car2.name + " " + car2.color);

            //Employee employee1 = new Employee();

            // Console.WriteLine(employee1.GetFullData());

            //Employee emp1 = new Employee();
            //emp1.GetFullName();

            //Animal animal1 = new Animal("Dog");

            //Console.WriteLine(animal1.name);

            //Employee emp1 = new Employee(false);

            //Book book1 = new Book();
            //book1.name = "Xosrov ve shirin";
            //book1.author = "Nizami";

            //Console.WriteLine(book1.name + " " + book1.author);

            //book1.BookName();

            //Console.WriteLine(emp1.GetFullData());



        }

    }



    //class Employee
    //{
    //    public string name;
    //    public string surname;
    //    public int age;
    //    public string address;
    //    public bool isMarried;
        
    //    public Employee():this(33)
    //    {
    //        Console.WriteLine("Hello p414");
    //    }

    //    public Employee(int number)
    //    {
    //        Console.WriteLine(number);
    //    }

    //    public Employee(string empName, string empSurname, int empAge)
    //    {
    //        age = empAge;
    //        name = empName;
    //        surname = empSurname;
    //        Console.WriteLine(empName +" "+ empSurname);
    //    }

    //    public Employee(string empAddress):this()
    //    {
    //        address = empAddress;
    //        Console.WriteLine(address);
    //    }

    //    public Employee(bool married):this("ehmedli")
    //    {
    //        isMarried = married;
    //        Console.WriteLine(isMarried);
    //    }

    //    public string GetFullName()
    //    {
    //        return name + " " + surname;
    //    }
    //    public string GetFullData()
    //    {
    //        return $"{GetFullName()} {age}";
    //    }
    
    //}

    //class Animal
    //{
    //    public string name;

    //    public Animal(string dogName)
    //    {
    //        name = dogName;
    //    }

    //}

    //class Car
    //{
    //    public string name;
    //    public string color;
    //    public double price;

    //}
}
