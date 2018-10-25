using System;
namespace StudentGroup
{
    public class Student:Person
    {
        public Student(string Name, string Surname):base(Name, Surname)
        {
            this.Id = this.GetHashCode();
        }

        public int Id { get; set; }
    }
}
