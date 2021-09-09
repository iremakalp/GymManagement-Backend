using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMemberService
    {
        IResult Add(Member member);
        IResult Update(Member member);
        IResult Delete(Member member);
        IDataResult<List<Member>> GetAll();
        IDataResult<List<MemberDetailDto>> GetMemberDetails();
        IDataResult<List<Member>> GetByAge(int minAge);
        IDataResult<List<Member>> GetByGender(string gender);
        IDataResult<List<Member>> GetByWeight(float minWeight, float maxWeight);
        IDataResult<List<Member>> GetByHeight(float minHeight, float maxHeight);
        IDataResult<List<Member>> GetByMembership(int membershipTimeId);
        IDataResult<List<Member>> GetByGymTime(int gymTimeId);
        IDataResult<List<MemberDetailDto>> GetByFee(float minFee,float maxFee);
    }
}
