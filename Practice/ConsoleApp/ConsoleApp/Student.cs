using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Student
    {
        private int regid;
        private string name;
        public Student()
        {
            regid = 1;
            name = "Ram";
        }

        public Student (int regid, string name)
        {
            this.regid = regid;
            this.name = name;
        }

        public void displayDetails()
        {
            Console.WriteLine("Registartion Id: " + regid);
            Console.WriteLine("Name:" + name);
        }
      
    }
}