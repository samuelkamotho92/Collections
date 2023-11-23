using System;
//Import Generic class
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics
{
    public class learnList
    {
        public void getList()
        {
            List<string> teams = new List<string>();
            List<string> coaches = new List<string>();
            //add values
            teams.Add("Manu");
            teams.Add("Man City");

            coaches.Add("E-tieg");
            coaches.Add("Pep Quardiola");

            //add range
            teams.AddRange(coaches);

//loop over List
            foreach(string team in teams)
            {
                Console.WriteLine(team);
            }

            for (int i = 0; i < teams.Count; i++)
            {
                //reassign value
                teams[1] = "manchester city";
                Console.WriteLine(teams[i]);
            }
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public string Gender { get;set; }

        public void createEmployee()
        {
            //create objects based on the Employee class we have created
            Employee empOne = new Employee();
            empOne.Name = "Samuel";
            empOne.Id = 1;
            empOne.Gender = "Male";
            Employee empTwo = new Employee() { Name = "John Doe", Id = 2, Gender = "Male" };
            Employee empThree = new Employee() { Name = "Zipeta", Id = 3, Gender = "Female" };

            //Create a List having the Data type has the Class
            List<Employee> staffs = new List<Employee>() { empOne,empTwo, empThree};
            Console.WriteLine("Check value if does exists");
            // find,findLast, returns an object
            //  Employee searchEmpl = staffs.FindLast(staff => staff.Gender.Equals("Male"));

            //findAll - returns an array we can iterate through
          List < Employee> searchEmpl = staffs.FindAll(staff => staff.Gender == "Male" );
            Console.WriteLine(searchEmpl);
            foreach(Employee emp in searchEmpl )
            {
                Console.WriteLine(emp.Name);
            }
         /*   if(searchEmpl != null)
            {
                Console.WriteLine($"The Employee Name is {searchEmpl.Name}");
            }
            else
            {
                Console.WriteLine($"No employee with that name");
            }*/
        }
    }
}
