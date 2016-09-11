using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectedToAPI.Models;
using Plugin.RestClient;

namespace ConnectedToAPI.Services
{
    public class EmployeeServices
    {

        //Get data from DB
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            RestClient<Employee> restcluClient = new RestClient<Employee>();
            var EmployeesList = await restcluClient.GetAsync();
            return EmployeesList;
        }
        //public List<Employee> GetEmployeesAsync()
        //{
        //    var EmployeesList=new List<Employee>
        //    {
        //        new Employee
        //        {
        //            Id = 1,
        //            e_empno = "8320",
        //            e_namear = "Said",
        //           e_nameen = "Said Said"
        //        },
        //        new Employee
        //        {
        //            Id = 1,
        //            e_empno = "8320",
        //            e_namear = "Ali",
        //           e_nameen = "Ali Said"
        //        }
        //    };
        //    return EmployeesList;
        //}
        public async Task PostEmployeeAsync(Employee employee)
        {
            RestClient<Employee> restcluClient = new RestClient<Employee>();
            var employeesList = await restcluClient.PostAsync(employee);
        }
    }
}
