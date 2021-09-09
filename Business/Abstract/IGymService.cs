using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IGymService
    {
        IResult Add(Gym gym);
        IResult Update(Gym gym);
        IResult Delete(Gym gym);
        IDataResult<List<Gym>> GetAll();
    }
}
