using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //Employee[] employees = new Employee[]
            //{
            //new Employee(1,"Youssef", 7000),
            //new Employee(1,"Mohamed", 5000),
            //new Employee(1,"Mostafa", 8000),
            //new Employee(1,"Amr", 6000)
            //};
            //foreach (Employee employee in employees) Console.WriteLine(employee);
            //Console.WriteLine();
            //Console.WriteLine("After Sorting");
            //Console.WriteLine();
            //SortingAlgorithm<Employee>.Sort(employees);
            //foreach (Employee employee in employees) Console.WriteLine(employee);
            #endregion

            #region Problem2
            //int[] numbers = { 5, 2, 9, 1, 7, 3 };
            //SortingTwo<int>.Sort(numbers, (num1, num2) => num1 < num2);
            //foreach (int num in numbers) Console.Write(num + " ");
            #endregion

            #region Problem3
            //string[] arr = { "computer", "cs", "All", "Nymar", "sort" };
            //SortingTwo<string>.Sort(arr, (a, b) => a.Length > b.Length);
            //foreach(string s in arr)Console.WriteLine(s);
            #endregion

            #region Problem4
            //Manger[] Mangers = new Manger[]
            //{
            //new Manger(1,"Youssef", 7000),
            //new Manger(1,"Mohamed", 5000),
            //new Manger(1,"Mostafa", 8000),
            //new Manger(1,"Amr", 6000)
            //};

            //SortingAlgorithm<Manger>.Sort(Mangers);
            //foreach(Manger Manger in Mangers) Console.WriteLine(Manger.ToString());
            #endregion

            #region Problem5
            //Employee[] employees = new Employee[]
            //{
            //new Employee(1,"Yousseffffff", 7000),
            //new Employee(1,"Mohameddd", 5000),
            //new Employee(1,"Mostafa", 8000),
            //new Employee(1,"Amr", 6000)
            //};

            //Func<Employee, Employee, bool> CompareFunc = (a, b) => a.Name.Length > b.Name.Length;
            //SortingTwo<Employee>.Sort(employees,CompareFunc);
            //foreach (Employee employee in employees) Console.WriteLine(employee); 
            #endregion

            #region Problem6
            //int[] numbers = { 5, 2, 9, 1, 7, 3 };
            //Func<int, int, bool> CompareFunc1 = delegate (int a, int b) { return a > b; };
            //SortingTwo<int>.Sort(numbers, CompareFunc1);
            //foreach (int a in numbers) Console.Write(a + " ");
            //Console.WriteLine();
            //Func<int, int, bool> CompareFunc2 = (a, b) => a < b;
            //SortingTwo<int>.Sort(numbers, CompareFunc2);
            //foreach (int a in numbers) Console.Write(a + " ");
            #endregion

            #region Problem7
            //int[] numbers = { 5, 2, 9, 1, 7, 3 };
            //Swap<int>(ref numbers[0], ref numbers[2]);
            //foreach (int i in numbers) Console.Write(i + " ");
            #endregion

            #region Problem8
            //Employee[] employees = new Employee[]
            //{
            //new Employee(1,"Yousseffffff", 7000),
            //new Employee(1,"Mohameddd", 7000),
            //new Employee(1,"Mostafa", 5000),
            //new Employee(1,"Amr", 4000)
            //};

            //Func<Employee,Employee,bool> CompareFunc = delegate (Employee em1,Employee em2)
            //                                           {
            //                                               if (em1.Salary != em2.Salary) return em1.Salary > em2.Salary;
            //                                               else return em1.Name.Length > em2.Name.Length;
            //                                           };   
            //SortingTwo<Employee>.Sort(employees, CompareFunc);
            //foreach(Employee em in employees) Console.WriteLine(em);

            #endregion

            #region Problem9
            //int temp1 = GetDefault<int>();
            //Console.WriteLine(temp1);
            //string temp2 = GetDefault<string>();
            //Console.WriteLine(temp2 == null ? "null" : temp2);
            //Employee em1 = GetDefault<Employee>();
            //Console.WriteLine(temp2 == null ? "null" : temp2);
            #endregion

            #region Problem10
            //Employee[] emp1 = new Employee[]
            //{
            //new Employee(1,"Yousseffffff", 7000),
            //new Employee(1,"Mohameddd", 7000),
            //new Employee(1,"Mostafa", 5000),
            //new Employee(1,"Amr", 4000)
            //};
            //Employee[] emp2 = new Employee[emp1.Length];
            //for (int i = 0; i < emp1.Length; i++) emp2[i] = (Employee)emp1[i].Clone();
            //foreach(Employee emp in emp1) Console.WriteLine(emp.ToString());
            //Console.WriteLine();
            //SortingAlgorithm<Employee>.Sort(emp2);
            //foreach(Employee emp in emp2) Console.WriteLine(emp.ToString());
            #endregion

            #region Problem11
            //List<string> arr = new List<string>()
            //{
            //    "Youssef",
            //    "Mohamed",
            //    "Amr",
            //    "Mostafa"
            //};
            //Func<string, string> Transformer = (a) => a.ToUpper();
            //Func<string, string> Transformer2 = (a) => new string(a.ToCharArray().Reverse().ToArray());
            //DatatypeOperations.Transform(arr, Transformer);
            //foreach (string s in arr) Console.Write(s + " ");
            //Console.WriteLine();
            //DatatypeOperations.Transform(arr, Transformer2);
            //foreach (string s in arr) Console.Write(s + " ");
            #endregion

            #region Problem12
            //int a = 7, b = 8;
            //Func<int, int, int> f1 = (x, y) => x + y;
            //Func<int, int, int> f2 = (x, y) => x - y;
            //Func<int, int, int> f3 = (x, y) => x * y;
            //Func<int, int, int> f4 = (x, y) => x / y;
            //Console.WriteLine(DatatypeOperations.TransformInt(a, b, f1));
            //Console.WriteLine(DatatypeOperations.TransformInt(a, b, f2));
            //Console.WriteLine(DatatypeOperations.TransformInt(a, b, f3));
            //Console.WriteLine(DatatypeOperations.TransformInt(a, b, f4));
            #endregion

            #region Problem13
            //List<int> arr = new List<int>() { 1, 2, 3, 4, 5 };
            //foreach(int i in arr) Console.Write(i + " ");
            //Func<int,string> Transformer = (i) => i.ToString();
            //Console.WriteLine();
            //Console.Write("tostring representation: ");
            //List<string> arr2 = DatatypeOperations.TransformGen<int, string>(arr, Transformer);
            //foreach (string i in arr2) Console.Write(i + " ");
            //Console.WriteLine();
            #endregion

            #region Problem14
            //List<int> arr = new List<int>() { 1, 2, 3, 4, 5 };
            //foreach (int i in arr) Console.Write(i + " ");
            //Func<int, int> Transformer = (i) => i * i;
            //Console.WriteLine();
            //Console.Write("nums squared: ");
            //List<int> arr2 = DatatypeOperations.TransformGen<int, int>(arr, Transformer);
            //foreach (int i in arr2) Console.Write(i + " ");
            //Console.WriteLine();
            #endregion

            #region Problem15
            //List<string> arr = new List<string>()
            //{
            //    "Youssef",
            //    "Mohamed",
            //    "Amr",
            //    "Mostafa"
            //};

            //Action<string> f1 = (s) => Console.WriteLine(s);

            //DatatypeOperations.TransformPritner<string>(arr, f1);
            #endregion

            #region Problem16
            //List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //Predicate<int> f1 = (a) => a % 2 == 0;
            //List<int> modified = DatatypeOperations.TransformE<int>(arr, f1);
            //foreach (int i in modified) Console.Write(i + " ");
            //Console.WriteLine();
            #endregion

            #region Problem17
            //List<string> arr = new List<string>()
            //{
            //    "Youssef",
            //    "Mohamed",
            //    "Amr",
            //    "Mostafa"
            //};
            //Predicate<string> f1 = (a) => (a.Contains("ss"));
            //Predicate<string> f2 = (a) => (a.StartsWith('A'));
            //List<string>ret1 = DatatypeOperations.TransformE<string>(arr, f1);    
            //List<string>ret2 = DatatypeOperations.TransformE<string>(arr, f2);
            //foreach(string ret in ret1)Console.Write(ret + " ");
            //Console.WriteLine();
            //foreach(string ret in ret2)Console.Write(ret + " ");
            //Console.WriteLine();
            #endregion

            #region Problem18
            //int a = 5, b = 8;
            //Func<int, int, int> add = delegate (int x, int y) { return x + y; };
            //Func<int, int, int> mul = delegate (int x, int y) { return x * y; };
            //Console.WriteLine(add(a, b));
            //Console.WriteLine(mul(a, b));
            #endregion

            #region Problem19
            //List<string> arr = new List<string>()
            //{
            //    "Youssef",
            //    "Mohamed",
            //    "el",
            //    "Mo"
            //};
            //List<string> ret = DatatypeOperations.TransformE(arr, (a) => (a.Length > 2 || a.Contains('e')));
            //foreach(string s in ret)Console.Write(s + " ");
            #endregion

            #region Problem20
            //double x = 8.0, y = 2.0;
            //Func<double,double,double> f1 = (x, y) => x / y;    
            //Func<double,double,double> f2 = (x, y) =>  Math.Pow(x,y);
            //Console.WriteLine(f1(x, y));
            //Console.WriteLine(f2(x, y));
            #endregion


        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static T GetDefault<T>()
        { return default(T); }
    }
}
