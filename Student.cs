using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practiceTwo
{
    class Student
    {

        public string name;
        public string major;
        public double gpa;

        //constructor:
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;

        }


        //method to check if student is honor student
        public bool hasHonors()
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }




    }
}
