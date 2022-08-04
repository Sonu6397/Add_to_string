using System;

namespace Add_to_string
{
   public class student
    {
        public void Add()
        {
            Console.WriteLine("enter first string");
            string s1 = (Console.ReadLine());
            Console.WriteLine("enter second string");
            string s2 = (Console.ReadLine());

            Console.WriteLine(string.Concat(s1,s2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.Add();
            Console.ReadLine();
        }
    }
}
