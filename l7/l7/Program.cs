using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student su = new Student("Student Name","12345678");

            try
            {
                
                su.GPA = 4.0f;
                Console.WriteLine("Student name : " + su.Name);
                Console.WriteLine("Student ID   : " + su.ID);
                Console.WriteLine("Student GPA  : " + su.GPA);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
    class Student
    {
        private string name;
        private string id;
        private float gpa;   
        public Student(string Name, string ID)
        {
            this.name = Name;   // assign auto variable to the field
            this.id = ID;
        }
        public string Name
        {
            get { return name; }
        }
        public string ID
        {
            get { return id; }
        }

        public float GPA
        {
            get
            {
                return gpa;
            }
            set
            {
                if (value > 0.0 && value <= 4.0)
                    gpa = value;
                else
                    throw (new Exception("Error!!!! invalid GPA"));
            }
        }
    }

}
