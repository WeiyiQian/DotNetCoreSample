using System.Collections.Generic;
using System.Linq;

namespace DotNet_Core_Sample.Data
{
    public class EmployeeRepository: IEmployeeRepository
    {
        List<Employee> DataSource= new List<Employee>()
            {
                new Employee() { ID = 1, Name = "April"},
                new Employee() { ID = 2, Name = "Bob"}
    };

    public List<Employee> GetAll()
        {
            return DataSource;
        }

        public Employee GetById(int id)
        {
            return DataSource.FirstOrDefault(e => e.ID == id);
        }
        public void Post(Employee employee)
        {
            DataSource.Add(employee);
        }
    }
}
