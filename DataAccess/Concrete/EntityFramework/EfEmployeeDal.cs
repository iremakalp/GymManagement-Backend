using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, GymContext>, 
        IEmployeeDal
    {
        public List<EmployeeDetailDto> GetDetails()
        {
            using (GymContext context= new GymContext())
            {
                var result = from e in context.Employees
                             join d in context.Departments
                             on e.DepartmentId equals d.Id
                             join h in context.WorkingHours
                             on e.WorkingHourId equals h.Id
                             select new EmployeeDetailDto
                             {
                                 Id = e.Id,
                                 FirstName = e.FirstName,
                                 LastName = e.LastName,
                                 Department = d.DepartmentName,
                                 Salary=d.Salary,
                                 WorkingHour = h.Hours,
                                 JoinDate = e.JoinDate,
                                 Phone = e.Phone
                             };
                return result.ToList();
            }
        }
    }
}
