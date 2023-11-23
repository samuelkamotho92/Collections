using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Non_Generic
{
    public class LearnArray
    {
        public void studentRecord()
        {
            //Array Disavdantages
            //1)Inserting and removing arrays
            //2)Array Size is fixed

            //out of bound exceptions
            string[] students = { "samuel", "john", "chris" };
            foreach(string s in students)
            {
                Console.WriteLine(s);
            }
            for (int i = 0; i < students.Length; i++)
            {
                students[2] = "timothy";
                Console.WriteLine(i);
            }
        }
    }
}
