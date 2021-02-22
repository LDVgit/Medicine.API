using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medicine.API.Models;

namespace Medicine.API.Services
{
    public interface IEmployee
    {
        delegate void EmployeeHandler(string message);
        event EmployeeHandler ActionEmployee;
        IEnumerable<Employee> GetAll();
        Employee GetEmployeeById(int id);
        void CreateEmployee(Employee employee);
        void RemoveEmployee(int id);
        void UpdateEmployee(Employee employee);
        bool ExistsEmployee(int id);
    }
}
