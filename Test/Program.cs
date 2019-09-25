using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Group uus = new Group("KlassTAR");

            Student Karl = new Student("Karl", "Karl", 565656, true);
            Student Teet = new Student("Teet", "Teet", 545245, true);
            Student Aivar = new Student("Aivar", "Aivar", 5454545, true);

            uus.AddStudent(Karl);
            uus.AddStudent(Teet);
            uus.AddStudent(Aivar);

            uus.Print();

            Console.ReadLine();
        }
    }
}
