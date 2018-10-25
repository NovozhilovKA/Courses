using System;

namespace StudentGroup
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Fear", "Me");
            Console.WriteLine(student.Id.ToString());
        }
    }
}
