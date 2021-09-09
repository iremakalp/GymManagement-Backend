using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IResult Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(Employee employee);
        IDataResult<List<Employee>> GetAll();
        IDataResult<List<EmployeeDetailDto>> GetEmployeeDetails();
        IDataResult<List<Employee>> GetByGender(string gender);
        IDataResult<List<Employee>> GetByDepartment(int departmentId);
        IDataResult<List<Employee>> GetByJoinDate(DateTime joinDate);
        IDataResult<List<Employee>> GetByWorkingHour(int workingHourId);
        IDataResult<List<EmployeeDetailDto>> GetBySalary(int minSalary);
    }
}
