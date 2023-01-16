using HRWebApp.Models;
namespace HRWebApp.Repositories.Interfaces;
public interface IEmployeeRepository{
    List<Employee> GetAllEmployee();
}