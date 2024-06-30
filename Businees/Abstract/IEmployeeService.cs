using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Abstract
{
    public interface IEmployeeService
    {
        void addEmployee(Employee employee);
        void updateEmployee(Employee employee);

        void deleteEmployee(Employee employee);

        List<Employee> getAllEmployees(Expression<Func<Employee, bool>> filter = null);

        Employee getEmployee(Expression<Func<Employee, bool>> filter);
    }
}
