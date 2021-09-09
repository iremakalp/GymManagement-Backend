using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IWorkingHourService
    {
        IResult Add(WorkingHour workingHour);
        IResult Update(WorkingHour workingHour);
        IResult Delete(WorkingHour workingHour);
        IDataResult<List<WorkingHour>> GetAll();
    }
}
