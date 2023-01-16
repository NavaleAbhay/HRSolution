using System.Collections.Generic;
using System.Linq;
using HRWebApp.Models;
using HRWebApp.Repositories.Interfaces;
namespace HRWebApp.Repositories;

public class EmployeeRepository:IEmployeeRepository{
    public List<Employee> GetAllEmployee(){

    using (var context=new CollectionContext()){
    var employees=from emp in context.Employees select emp;
    return employees.ToList<Employee>();
}
    }
}