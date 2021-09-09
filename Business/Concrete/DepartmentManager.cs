using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
        public IResult Add(Department department)
        {
               
            _departmentDal.Add(department);
            return new SuccessResult(Messages.DepartmentAdded);
        }

        public IResult Delete(Department department)
        {
            _departmentDal.Delete(department);
            return new SuccessResult();
        }

        public IDataResult<List<Department>> GetAll()
        {
            var result = _departmentDal.GetAll();
            return new SuccessDataResult<List<Department>>(result);
        }

        public IResult Update(Department department)
        {
            
            _departmentDal.Update(department);
            return new SuccessResult(Messages.DepartmentUpdated);
        }

        private IResult CheckIfDepartmentNameExists(string departmentName)
        {
            var result = _departmentDal.GetAll(d=>d.DepartmentName == departmentName).Any();
            if (result)
            {
                return new ErrorResult(Messages.DepartmentNameExist);
            }
            return new SuccessResult();
        }
        private IResult CheckDepartmentCount()
        {
            var result = _departmentDal.GetAll().Count;
            if (result==15)
            {
                return new ErrorResult(Messages.DepartmentCount);
            }
            return new SuccessResult();
        }
    }
}
