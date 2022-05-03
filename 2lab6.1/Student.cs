using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab6._1
{
    public class Student
    {
        private Man man;
        string spec;
        int rik;
        static int counter;
        public class Man
        {
            private string name;
            private int age;
            private string stat;
            private int vaga;
            private static int counter = 0;
            public Man()
            {
                name = "";
                age = 0;
                stat = "";
                vaga = 0;
                counter++;
            }
            public Man(String name, int age, String stat, int vaga)
            {
                this.name = name;
                this.age = age;
                this.stat = stat;
                this.vaga = vaga;
                counter++;
            }
            public Man(Man m)
            {
                this.name = m.name;
                this.age = m.age;
                this.stat = m.stat;
                this.vaga = m.vaga;
                counter++;
            }
            public int GetAge() { return this.age; }
            public string GetName() { return this.name; }
            public int GetVaga() { return this.vaga; }
            public string GetStat() { return this.stat; }
            public static int GetCounter() { return counter; }
            public void SetAge(int age) { this.age = age; }
            public void SetName(String name) { this.name = name; }
            public void SetVaga(int vaga) { this.vaga = vaga; }
            public void SetStat(String stat) { this.stat = stat; }
            public bool Init(string name, int age, string stat, int vaga)
            {
                if (age > 0 && age < 100)
                {
                    SetName(name);
                    SetAge(age);
                    SetStat(stat);
                    SetVaga(vaga);
                    return true;
                }
                return false;
            }
            public void Display()

            { Console.WriteLine("Name: {0}, age: {1} ,Stat: {2}, vaga: {3}", name, age,stat,vaga); }

            public void Read()
            {
                String n,s;
                int a,v;
                do
                {
                    Console.WriteLine("Name: ");
                    n = Console.ReadLine();
                    Console.WriteLine("Age: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Stat: ");
                    s = Console.ReadLine();
                    Console.WriteLine("Vaga: ");
                    v = Convert.ToInt32(Console.ReadLine());
                } while (!Init(n, a,s,v));
            }
            public static Man operator ++(Man m) { return new Man(m.name, m.age++, m.stat,m.vaga++); }
            public static Man operator --(Man m) { return new Man(m.name, m.age--, m.stat,m.vaga--); }
            public override string ToString()
            {
                return "Man: [name: " + this.name + ", "
              + "age: " + this.age + ", "
              + "stat:" + this.stat + ", "
              + "vaga;" + this.vaga + 
              "]";
            }
        }
        public Student()
        {
            this.man = new Man();
            this.rik= 0;
            counter++;
        }
        public Student(Man man, int rik)
        {
            this.man = man;
            this.rik = rik;
            counter++;
        }
        public Student(Student student)
        {
            this.man = student.man;
            this.rik = student.rik;
            counter++;
        }
        public Student(String name, int age,String stat,int vaga, int spec)
        {
            this.rik = rik;
            this.man = new Man(name, age,stat,vaga);
            counter++;
        }
        public Man GetMan() { return this.man; }
        public int GetRik() { return this.rik; }
        public static int GetCounter() { return counter; }
        public void SetMan(Man man) { this.man = man; }
        public void SetSpec(int rik) { this.rik = rik; }
        public void Display()
        {
            Console.WriteLine("Rik: {0}", this.rik);
            this.man.Display();
        }
        public void Read()
        {
            string stat, name;
            int age,vaga,rik;
            do
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Stat: ");
                stat = Console.ReadLine();
                Console.WriteLine("Vaga: ");
                vaga = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Rik: ");
                rik = Convert.ToInt32(Console.ReadLine());
            } while (!this.man.Init(name, age,stat,vaga));
            this.rik = rik;
        }
        public static Student operator ++(Student student)
        {
            return new Student(student.man++, student.rik++);
        }
        public static Student operator --(Student student)
        {
            return new Student(student.man--, student.rik--);
        }
        public override string ToString()
        {
            return "Student: [" + this.man.ToString() + ", "
            + "rik: " + this.rik +
            "]";
        }
    }
}
