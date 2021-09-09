using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class GymTimeManager : IGymTimeService
    {
        IGymTimeDal _gymTimeDal;
        public GymTimeManager(IGymTimeDal gymTimeDal)
        {
            _gymTimeDal = gymTimeDal;
        }
        public IResult Add(GymTime gymTime)
        {
            _gymTimeDal.Add(gymTime);
            return new SuccessResult();
        }

        public IResult Delete(GymTime gymTime)
        {
            _gymTimeDal.Delete(gymTime);
            return new SuccessResult();
        }

        public IDataResult<List<GymTime>> GetAll()
        {
            var result = _gymTimeDal.GetAll();
            return new SuccessDataResult<List<GymTime>>(result);
        }

        public IResult Update(GymTime gymTime)
        {
            _gymTimeDal.Update(gymTime);
            return new SuccessResult();
        }
    }
}
