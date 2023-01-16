using System.ComponentModel;
namespace HRWebApp.Models;
public class Employee
{
    public int Id { get; set; }

    [DisplayName("Firstname")]
    public string FirstName { get; set; }

    [DisplayName("Lastname")]
    public string LastName { get; set; }

    [DisplayName("Email")]
    public string Email { get; set; }

    [DisplayName("Address")]
    public string Address { get; set; }

    [DisplayName("Password")]
    public string Password { get; set; }

    [DisplayName("Department Id")]
    public int DeptId { get; set; }

    [DisplayName("Manager Id")]
    public int ManagerId { get; set; }


}
