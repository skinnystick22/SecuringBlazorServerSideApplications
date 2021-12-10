﻿using System.Collections.Generic;
using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Api.Models;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAllEmployees();
    Employee GetEmployeeById(int employeeId);
    Employee AddEmployee(Employee employee);
    Employee UpdateEmployee(Employee employee);
    void DeleteEmployee(int employeeId);
}