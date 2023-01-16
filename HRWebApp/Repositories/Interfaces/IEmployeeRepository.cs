using HRWebApp.Models;
namespace HRWebApp.Repositories.Interfaces;
public interface IEmployeeRepository{
    List<Employee> GetAllEmployee();
    Employee GetEmployeeById(int id);
    void InsertEmployee(Employee employee);

    void DeleteEmployee(int id);
}