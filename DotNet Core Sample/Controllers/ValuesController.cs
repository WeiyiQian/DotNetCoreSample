using DotNet_Core_Sample.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DotNet_Core_Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private EmployeeRepository _repository = null;
        public ValuesController(EmployeeRepository employeeRepository)
        {
            _repository = employeeRepository;
        }
        [HttpGet]
        public List<Employee> Get()
        {
            List<Employee> employees = _repository.GetAll();
            return employees;
        }
        [HttpGet]
        public Employee GetById(int Id)
        {
            return _repository.GetById(Id);
        }
        [HttpPost]
        public void Post(Employee emp)
        {
            _repository.Post(emp);
        }
    }
}
