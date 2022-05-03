using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab6._1
{
    internal class Program
        {
            public static void Main(String[] args)
            {
                Student s1 = new Student();
                Console.WriteLine("Student: {0}", Student.GetCounter());
                Console.WriteLine("Student::Man: {0}", Student.Man.GetCounter());
                Student s2 = new Student("Raphaël Ambrosius Costeau", 25, "Male",80,2019);
                Console.WriteLine("Student local: {0}", Student.GetCounter());
                Console.WriteLine("Student::Man local: {0}",
                Student.Man.GetCounter());
                Console.WriteLine("s2: {0}", s2.ToString());
                s2++;
                Console.WriteLine("s2++: {0}", s2.ToString());
                Console.ReadKey();
            }
        }
}
