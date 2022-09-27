using System.Collections.Generic;

namespace DotNet_Core_Sample.Data
{
    public interface IEmployeeRepository
    {
        public Employee GetById(int id);
        public List<Employee> GetAll();
        public void Post(Employee employee);

    }
}
