using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class EmployeeCrud
    {
        private List<Employee> employees;
        public EmployeeCrud()
        {
            employees = new List<Employee>()
            {
                new Employee{Id = 1,Name="Mike",Salary = 10000},
                new Employee{Id = 2,Name="Jack",Salary = 20000},
            };
        }
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        public void UpdateEmployee(Employee emp)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == emp.Id)
                {
                    employees[i].Name = emp.Name;
                    employees[i].Salary = emp.Salary;
                    break;
                }
            }
        }
        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {

                if (employees[i].Id == id)
                {
                    employees.Remove(employees[i]);
                    break;
                }

            }
        }
        public Employee GetEmployeeById(int id2)
        {
            Employee employee = new Employee();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == id2)
                {
                    employee = employees[i];
                }
            }
            return employee;
        }
        public List<Employee> List()
        {
            return employees;
        }
    }
}