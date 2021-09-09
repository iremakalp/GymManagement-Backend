using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Business.Constants;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public IResult Add(Employee employee)
        {
           
            _employeeDal.Add(employee);
            return new SuccessResult(Messages.EmployeeAdded);
        }

        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult(Messages.EmployeeDeleted);
        }

        public IDataResult<List<Employee>> GetAll()
        {
            var result = _employeeDal.GetAll();
            return new SuccessDataResult<List<Employee>>(result);
        }
        public IDataResult<List<Employee>> GetByDepartment(int departmentId)
        {
            var result = _employeeDal.GetAll(e => e.DepartmentId == departmentId);
            return new SuccessDataResult<List<Employee>>(result);
        }
        public IDataResult<List<Employee>> GetByGender(string gender)
        {
            var result = _employeeDal.GetAll(e => e.Gender == gender);
            return new SuccessDataResult<List<Employee>>(result);
        }
        public IDataResult<List<Employee>> GetByJoinDate(DateTime joinDate)
        {
            var result = _employeeDal.GetAll(e => e.JoinDate == joinDate);
            return new SuccessDataResult<List<Employee>>(result);
        }
        public IDataResult<List<EmployeeDetailDto>> GetBySalary(int minSalary)
        {
            var result = _employeeDal.GetDetails().Where(e => e.Salary >= minSalary).ToList();
            return new SuccessDataResult<List<EmployeeDetailDto>>(result);
        }
        public IDataResult<List<Employee>> GetByWorkingHour(int workingHourId)
        {
            var result = _employeeDal.GetAll(e => e.WorkingHourId == workingHourId);
            return new SuccessDataResult<List<Employee>>(result);
        }
        public IDataResult<List<EmployeeDetailDto>> GetEmployeeDetails()
        {
            var result = _employeeDal.GetDetails();
            return new SuccessDataResult<List<EmployeeDetailDto>>(result);
        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult(Messages.EmployeeUpdated);
        }
        private IResult CheckIfEmployeeExists(string firstName, string lastName)
        {
            var result = _employeeDal.GetAll(e => e.FirstName == firstName && e.LastName == lastName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CheckIfEmployeeExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfEmployeeCount(int departmentId,string gender)
        {
            var result = _employeeDal.GetAll(e =>e.DepartmentId==departmentId && e.Gender == gender).Count;
            if (gender =="Kadın" && result==3)
            {
                return new ErrorResult(Messages.CheckIfWomanCount);
            }
            else if (gender=="Erkek"&&result==3)
            {
                return new ErrorResult(Messages.CheckIfManCount);
            }
            return new SuccessResult();
        }
        private IResult CheckWorkingHour(int workingHourId)
        {
            var result = _employeeDal.GetAll(e => e.WorkingHourId == workingHourId).Count;
            if ( result == 20)
            {
                return new ErrorResult(Messages.CheckWorkingHour);
            }       
            return new SuccessResult();
        }
    }
}
