using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class MembershipInfo: IEntity
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public int Fee { get; set; }
    }
}
