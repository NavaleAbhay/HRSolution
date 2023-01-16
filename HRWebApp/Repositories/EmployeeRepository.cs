using System.Collections.Generic;
using System.Linq;
using HRWebApp.Models;
using HRWebApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HRWebApp.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    public List<Employee> GetAllEmployee()
    {

        using (var context = new CollectionContext())
        {
            var employees = from emp in context.Employees select emp;
            return employees.ToList<Employee>();
        }
    }

    public Employee GetEmployeeById(int id)
    {
        using (var context = new CollectionContext())
        {
            var employee = context.Employees.Find(id);
            return employee;

        }
    }

    public void InsertEmployee(Employee employee )
    {
        using(var context=new CollectionContext())
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }
    }

public void UpdateEmployee(Employee employee)
{
    using(var context =new CollectionContext())
    {
        var emp =context.Employees.Find(employee.Id);
        emp.Id=employee.Id;
        emp.FirstName=employee.FirstName;
        emp.LastName=employee.LastName;
        emp.Address=employee.Address;
        emp.Email=employee.Email;
        emp.Password=employee.Password;
        emp.DeptId=employee.DeptId;
        emp.ManagerId=employee.ManagerId;
        context.SaveChanges();
    }
}
    public void DeleteEmployee(int id)
    {
        using(var context= new CollectionContext())
        {
            context.Employees.Remove(context.Employees.Find(id));
            context.SaveChanges();
        }
    }
}