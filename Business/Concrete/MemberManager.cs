using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Business.Constants;

namespace Business.Concrete
{
    public class MemberManager : IMemberService
    {
        IMemberDal _memberDal;
        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }
        public IResult Add(Member member)
        {
            _memberDal.Add(member);
            return new SuccessResult("Yeni üye eklendi");
        }
        public IResult Delete(Member member)
        {
            _memberDal.Delete(member);
            return new SuccessResult("Üye silindi");
        }
        public IDataResult<List<Member>> GetAll()
        {
            var result = _memberDal.GetAll();
            return new SuccessDataResult<List<Member>>(result);
        }

        public IDataResult<List<Member>> GetByAge(int minAge)
        {
            var result = _memberDal.GetAll(m => m.Age >= minAge);
            return new SuccessDataResult<List<Member>>(result);
        }       
        public IDataResult<List<Member>> GetByGender(string gender)
        {
            var result = _memberDal.GetAll(m => m.Gender == gender);
            return new SuccessDataResult<List<Member>>(result);
        }
        public IDataResult<List<Member>> GetByGymTime(int gymTimeId)
        {
            var result = _memberDal.GetAll(m => m.GymTimeId == gymTimeId);
            return new SuccessDataResult<List<Member>>(result);
        }
        public IDataResult<List<Member>> GetByHeight(float minHeight, float maxHeight)
        {
            var result = _memberDal.GetAll(m => m.Height >= minHeight && m.Height <= maxHeight);
            return new SuccessDataResult<List<Member>>(result);
        }
        public IDataResult<List<Member>> GetByMembership(int membershipTimeId)
        {
            var result = _memberDal.GetAll(m => m.MembershipTimeId == membershipTimeId);
            return new SuccessDataResult<List<Member>>(result);
        }
        public IDataResult<List<Member>> GetByWeight(float minWeight, float maxWeight)
        {
            var result = _memberDal.GetAll(m => m.Weight >= minWeight && m.Weight <= maxWeight);
            return new SuccessDataResult<List<Member>>(result);
        }
        public IDataResult<List<MemberDetailDto>> GetByFee(float minFee, float maxFee)
        {
            var result = _memberDal.GetDetails().Where(m => m.Fee >= minFee && m.Fee <= maxFee).ToList();
            return new SuccessDataResult<List<MemberDetailDto>>(result);
        }
        public IDataResult<List<MemberDetailDto>> GetMemberDetails()
        {
            var result = _memberDal.GetDetails();
            return new SuccessDataResult<List<MemberDetailDto>>(result);
        }
        public IResult Update(Member member)
        {
            _memberDal.Update(member);
            return new SuccessResult("Üye bilgileri güncellendi");
        }
        private IResult CheckIfMemberExists(string firstName,string lastName)
        {
            var result = _memberDal.GetAll(m => m.FirstName == firstName && m.LastName == lastName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CheckIfMemberExists);
            }
            return new SuccessResult();
        }
        private IResult CheckMemberGymTime(int gymTimeId)
        {
            var result = _memberDal.GetAll(m => m.GymTimeId == gymTimeId).Count;
            if (result==15)
            {
                return new ErrorResult(Messages.CheckMemberGymTime);
            }
            return new SuccessResult();
        }
    }
}
