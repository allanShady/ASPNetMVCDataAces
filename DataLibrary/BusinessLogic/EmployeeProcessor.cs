using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAcess;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName, string lastName, string email)
        {
            Employee data = new Employee
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                EmailAdress = email
            };

            string sqlQuery = @"INSERT INTO Employees(EmployeeId, FirstName, LastName, EmailAdress) VALUES 
                                (@EmployeeId, @FirstName, @LastName, @EmailAdress)";

            return SQLDataAcess.SaveData(sqlQuery, data);
        }

        public static List<Employee> LoadEmployees()
        {
            string SQL = @"SELECT Id, EmployeeId, FirstName, LastName, EmailAdress FROM Employees";
            return SQLDataAcess.LoadData<Employee>(SQL);
        }
    }
}
