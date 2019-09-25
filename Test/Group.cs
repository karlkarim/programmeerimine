using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Group(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
            student.IsStudying = true;
      
        }

        public void Print()
        {
            Console.WriteLine($"{Name}: ");
            foreach(var student in Students)
            {
                Console.WriteLine(student.FirstName + ", " + student.LastName + ", " + student.PersonalCode + ", " + "Kas õpib: " + student.IsStudying);
            }
        }
    }
}
