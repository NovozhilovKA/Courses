using System;
namespace StudentGroup
{
    public abstract class Person
    {
        private string[] FI { get; set; }
        public Person()
        {
            FI = new string[2];
        }
        public Person(string Name, string Surname):this()
        {
            this.FI[0] = Name;
            this.FI[1] = Surname;
        }
        string Name
        {
            get
            {
                return FI[0];
            }
            set
            {
                FI[0] = value;
            }
        }
        string Surname
        {
            get
            {
                return FI[1];
            }
            set
            {
                FI[1] = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Name, this.Surname);
        }
    }
}
