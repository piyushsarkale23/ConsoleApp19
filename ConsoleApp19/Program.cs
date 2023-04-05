using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeCrud employeeCrud = new EmployeeCrud();
            int c = 0;
            do
            {
                Console.WriteLine("1 Employee List ");
                Console.WriteLine("2 Add Employee in list");
                Console.WriteLine("3 Update Employee in list");
                Console.WriteLine("4 Delete Employee in list");
                Console.WriteLine("Select above options");
                Console.WriteLine("5 Employee Get by ID");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        List<Employee> emp = employeeCrud.List();
                        Console.WriteLine("Id \t Name \t\t Salary");
                        foreach (Employee e in emp)
                        {
                            Console.WriteLine($"{e.Id} \t {e.Name} \t\t {e.Salary}");

                        }
                        break;

                    case 2:
                        Employee e1 = new Employee();
                        Console.WriteLine("Enter an id");
                        e1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter an name");
                        e1.Name = Console.ReadLine();
                        Console.WriteLine("Enter a salary");
                        e1.Salary = Convert.ToInt32(Console.ReadLine());
                        employeeCrud.AddEmployee(e1);
                        Console.WriteLine("Employee Added..");
                        break;

                    case 3:
                        Employee e2 = new Employee();
                        Console.WriteLine("Enter Id");
                        e2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new Employee name");
                        e2.Name = Console.ReadLine();
                        Console.WriteLine("Enter Salary");
                        e2.Salary = Convert.ToInt32(Console.ReadLine());
                        employeeCrud.UpdateEmployee(e2);
                        Console.WriteLine("Product updated..");
                        break;

                    case 4:
                        Console.WriteLine("Enter id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        employeeCrud.DeleteEmployee(id);
                        Console.WriteLine("Employee Deleted");
                        break;

                    case 5:
                        Console.WriteLine("Enter employee id to serach");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        Employee employee = employeeCrud.GetEmployeeById(id2);
                        if(employee.Id>0)
                        {
                            Console.WriteLine($"Id = {employee.Id} , Name ={employee.Name}, Salary= {employee.Salary}");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found");
                        }
                        break;
                }
                Console.WriteLine("Select 1 for continue");
                c = Convert.ToInt32((Console.ReadLine()));

            }
            while (c == 1);
        }
    }
}
