using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class WorkingHourManager : IWorkingHourService
    {
        IWorkingHourDal _workingDal;
        public WorkingHourManager(IWorkingHourDal workingDal)
        {
            _workingDal = workingDal;
        }

        public IResult Add(WorkingHour workingHour)
        {
            _workingDal.Add(workingHour);
            return new SuccessResult();
        }

        public IResult Delete(WorkingHour workingHour)
        {
            _workingDal.Delete(workingHour);
            return new SuccessResult();
        }

        public IDataResult<List<WorkingHour>> GetAll()
        {
            var result = _workingDal.GetAll();
            return new SuccessDataResult<List<WorkingHour>>(result);
        }

        public IResult Update(WorkingHour workingHour)
        {
            _workingDal.Update(workingHour);
            return new SuccessResult();
        }
    }
}
