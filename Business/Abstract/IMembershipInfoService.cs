using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMembershipInfoService
    {
        IResult Add(MembershipInfo membershipInfo);
        IResult Update(MembershipInfo membershipInfo);
        IResult Delete(MembershipInfo membershipInfo);
        IDataResult<List<MembershipInfo>> GetAll();
    }
}
