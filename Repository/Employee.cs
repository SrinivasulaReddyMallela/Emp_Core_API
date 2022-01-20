using Angular.API.Context;
using Angular.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.API.Repository
{
    public class EmployeeRepository : IEmployeeRepository<Employee>
    {
        readonly EmployeeDbContext _employeeContext;
        public EmployeeRepository(EmployeeDbContext context)
        {
            _employeeContext = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeContext.Employees.ToList();
        }
        public Employee Get(int id)
        {
            return _employeeContext.Employees
                  .FirstOrDefault(e => e.employeeid == id);
        }
        public void Add(Employee entity)
        {
            _employeeContext.Employees.Add(entity);
            _employeeContext.SaveChanges();
        }
        public void Update(Employee employee, Employee entity)
        {
            employee.empname = entity.empname;
            employee.emailid = entity.emailid;
            _employeeContext.SaveChanges();
        }
        public void Delete(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();
        }
    }
}
