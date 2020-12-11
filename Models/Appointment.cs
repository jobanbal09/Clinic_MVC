using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinic_MVC.Models
{
    public class Appointment
    {
      
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }


      
     
    }
}
