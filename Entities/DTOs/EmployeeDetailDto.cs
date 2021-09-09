using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class EmployeeDetailDto:IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        public DateTime JoinDate { get; set; }
        public string WorkingHour { get; set; }
        public int Salary { get; set; }

    }
}
