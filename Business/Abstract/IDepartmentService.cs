using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        IResult Add(Department department);
        IResult Update(Department department);
        IResult Delete(Department department);
        IDataResult<List<Department>> GetAll();
    }
}
