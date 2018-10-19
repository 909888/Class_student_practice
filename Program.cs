using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practiceTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Stude nt("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.hasHonors());
            Console.WriteLine(student2.hasHonors());


            Console.ReadLine();
        }
    }
}
