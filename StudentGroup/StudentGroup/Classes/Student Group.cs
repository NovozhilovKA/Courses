using System;
using System.Collections;
using System.Text;

namespace StudentGroup
{
    public class Student_Group:IEnumerable
    {
        private ArrayList _students;

        public Student Head { get; set; }

        public Student_Group()
        {
            this._students = new ArrayList();
        }

        public void Add(Student newStudent)
        {
            _students.Add(newStudent);
        }

        public Student byId(int id)
        {
            Student result = null;
            foreach(Student student in this)
            {
                if (student.Id == id)
                {
                    result = student;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public StudentsEnum GetEnumerator()
        {
            return new StudentsEnum(_students);
        }

        public override string ToString()
        {
            var students = new StringBuilder();
            foreach(Student student in this)
            {
                students.Append(string.Format(student.ToString() + "/n"));
            }
            return students.ToString();
        }

    }

    public class StudentsEnum : IEnumerator
    {
        public ArrayList _students;

        public StudentsEnum(ArrayList list)
        {
            _students = list;
        }

        int position = -1;

        public bool MoveNext()
        {
            position++;
            return (position < _students.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public object Current
        {
            get
            {
                try
                {
                    return _students[position];
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

}
