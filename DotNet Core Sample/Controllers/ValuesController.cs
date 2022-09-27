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
        private IEmployeeRepository _repository;
        public ValuesController(IEmployeeRepository employeeRepository)
        {
            _repository = employeeRepository;
        }
        [HttpGet]
        public List<Employee> Get()
        {
            List<Employee> employees = _repository.GetAll();
            return employees;
        }
        [HttpGet("{id}")]
        public Employee GetById(int id)
        {
            return _repository.GetById(id);
        }
        [HttpPost]
        public void Post(Employee emp)
        {
            _repository.Post(emp);
        }
    }
}
