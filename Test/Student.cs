using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Student
    {
        public string FirstName {get;set;}
        public string LastName { get; set; }

        public int PersonalCode { get; set; }

        public bool IsStudying { get; set; }

        public Student(string firstName, string lastName, int personalCode, bool isStudying)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalCode = personalCode;
            IsStudying = isStudying;
        }

        


    }
}
