using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IGymTimeService
    {
        IResult Add(GymTime gymTime);
        IResult Update(GymTime gymTime);
        IResult Delete(GymTime gymTime);
        IDataResult<List<GymTime>> GetAll();
    }
}
