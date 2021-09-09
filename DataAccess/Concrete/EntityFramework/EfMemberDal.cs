using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMemberDal : EfEntityRepositoryBase<Member, GymContext>, 
        IMemberDal
    {
        public List<MemberDetailDto> GetDetails()
        {
            using (GymContext context= new GymContext() )
            {
                var result = from m in context.Members
                             join ms in context.MembershipInfos
                             on m.MembershipTimeId equals ms.Id
                             join gt in context.GymTimes
                             on m.GymTimeId equals gt.Id
                             select new MemberDetailDto
                             {
                                 Id=m.Id,
                                 FirstName=m.FirstName,
                                 LastName=m.LastName,
                                 Age=m.Age,
                                 Height=m.Height,
                                 Weight=m.Weight,
                                 GymTime=gt.Time,
                                 MembershipTime=ms.Time,
                                 Fee=ms.Fee
                             };
                return result.ToList();
            }
        }
    }
}
