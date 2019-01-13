using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?redirectedfrom=MSDN&view=netframework-4.7.2
        static void Main(string[] args)
        {
            SandBox s1 = new SandBox();
            s1.TestFrame1();
        }
    }

    struct Employee
    {
        public int empID;
        public string Name;
        public string Department;
    }

    class SandBox
    {

        public void TestFrame1()
        {
            List<Employee> employees = new List<Employee>()
{
new Employee() { empID = 001, Name = "Tom", Department= "Sales"},
new Employee() { empID = 024, Name = "Joan", Department= "HR"},
new Employee() { empID = 023, Name = "Fred", Department= "Accounting" },
new Employee() { empID = 040, Name = "Mike", Department= "Sales" },
};

            // Find the member of the list that has an employee id of 023
            Employee match = employees.Find((Employee p) => { return p.empID == 023; });
            Console.WriteLine("empID: {0}\nName: {1}\nDepartment: {2}", match.empID, match.Name, match.Department);
            Console.ReadLine();
        }
    }
}
