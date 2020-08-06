using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    class Program
    {
        struct Student {
            public int sid, date, month, year;
            public string sname, course;
        }
        
        static void Main(string[] args)
        {
            Student[] s = new Student[3];
            int i;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Student ID");
                s[i].sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name");
                s[i].sname = Console.ReadLine();
                Console.WriteLine("Enter Course Name");
                s[i].course = Console.ReadLine();
                Console.WriteLine("Enter Date of DOB (1-31)");
                s[i].date = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Month of DOB (1-12)");
                s[i].month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Year of DOB");
                s[i].year = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\nStudent List\n");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Student ID :" + s[i].sid);
                Console.WriteLine("Student Name :" + s[i].sname);
                Console.WriteLine("Course Name :" + s[i].course);
                Console.WriteLine("Date of Birth :" + s[i].date+"-"+s[i].month+"-"+s[i].year);
            }
            Console.ReadLine();
        }
    }
}
