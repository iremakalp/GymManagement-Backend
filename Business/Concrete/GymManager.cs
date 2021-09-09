using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GymManager : IGymService
    {
        IGymDal _gymDal;
        public GymManager(IGymDal gymDal)
        {
            _gymDal = gymDal;
        }

        public IResult Add(Gym gym)
        {
            _gymDal.Add(gym);
            return new SuccessResult();
        }

        public IResult Delete(Gym gym)
        {
            _gymDal.Delete(gym);
            return new SuccessResult();
        }

        public IDataResult<List<Gym>> GetAll()
        {
            return new SuccessDataResult<List<Gym>>(_gymDal.GetAll());
        }

        public IResult Update(Gym gym)
        {
            _gymDal.Update(gym);
            return new SuccessResult();
        }
    }
}
