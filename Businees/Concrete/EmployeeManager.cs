using Businees.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Concrete
{
    public class EmployeeManager : IEmployeeService
    {

        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal _employeeDal)
        {
            this._employeeDal = _employeeDal;
        }
        public void addEmployee(Employee employee)
        {
             _employeeDal.Add(employee);
        }

        public void deleteEmployee(Employee employee)
        {
           _employeeDal.Delete(employee);
        }

        public List<Employee> getAllEmployees(Expression<Func<Employee, bool>> filter = null)
        {
            return  _employeeDal.GetAll(filter);
        }

        public Employee getEmployee(Expression<Func<Employee, bool>> filter)
        {
              return _employeeDal.Get(filter);
        }

        public void updateEmployee(Employee employee)
        {
                  _employeeDal.Update(employee);
        }
    }
}
