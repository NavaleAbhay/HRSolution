using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRWebApp.Services.Interfaces;
using HRWebApp.Models;

namespace HRWebApp.Controllers;

public class EmployeeController : Controller
{
    private readonly IEmployeeService _employeeservice;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeservice=employeeService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult ShowAll(){
        ViewData["allEmployees"]=_employeeservice.GetAllEmployee();
        return View();
    }
  
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
