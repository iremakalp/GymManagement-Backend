using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class MembershipInfoManager : IMembershipInfoService
    {
        IMembershipInfoDal _membershipDal;
        public MembershipInfoManager(IMembershipInfoDal membershipDal)
        {
            _membershipDal = membershipDal;
        }
        public IResult Add(MembershipInfo membershipInfo)
        {
            _membershipDal.Add(membershipInfo);
            return new SuccessResult();
        }

        public IResult Delete(MembershipInfo membershipInfo)
        {
            _membershipDal.Delete(membershipInfo);
            return new SuccessResult();
        }

        public IDataResult<List<MembershipInfo>> GetAll()
        {
            var result = _membershipDal.GetAll();
            return new SuccessDataResult<List<MembershipInfo>>(result);
        }

        public IResult Update(MembershipInfo membershipInfo)
        {
            _membershipDal.Update(membershipInfo);
            return new SuccessResult();
        }
    }
}
