using HRWebApp.Models;
using HRWebApp.Repositories;
using HRWebApp.Repositories.Interfaces;
using HRWebApp.Services.Interfaces;
namespace HRWebApp.Services;
public class EmployeeService:IEmployeeService{
    private readonly IEmployeeRepository _employeerepo;
    public EmployeeService(IEmployeeRepository employeeRepository){
        this._employeerepo=employeeRepository;
    }
    public List<Employee> GetAllEmployee()=>_employeerepo.GetAllEmployee();

    public Employee GetEmployeeById(int id)=>_employeerepo.GetEmployeeById(id);

    public void InsertEmployee(Employee employee)=>_employeerepo.InsertEmployee(employee);

    public void DeleteEmployee(int id)=> _employeerepo.DeleteEmployee(id);

    public void UpdateEmployee(Employee employee) => _employeerepo.UpdateEmployee(employee);
}