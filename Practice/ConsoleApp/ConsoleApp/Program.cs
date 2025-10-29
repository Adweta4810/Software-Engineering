using ConsoleAppDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public void display()
        {
            Console.WriteLine("Welcome to learn C#. Net Language");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program obj = new Program();
            obj.display();

            int result = obj.add(1, 2);
            Console.WriteLine("The sum of 1 and 2 is: " + result);

            Student student = new Student();
            student.displayDetails();

            Student student1 = new Student(2, "Shyam");
            student1.displayDetails();

            Console.WriteLine("Enter your Registration id");
            int regid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Student student2 = new Student(regid, name);
            student2.displayDetails();

            Console.Read();
        }
    }
}
