using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class MemberDetailDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public Nullable<Double> Weight { get; set; }
        public string MembershipTime { get; set; }
        public int Fee { get; set; }
        public string GymTime { get; set; }
    }
}
