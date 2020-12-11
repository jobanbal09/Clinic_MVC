using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Clinic_MVC.Models
{
    public class Customer
    {
      
        public int Id { get; set; }//Id interger input

        public string Customer_Name { get; set; }//to add  Customername

        public string Address { get; set; } // to add address

        public string Customer_Age { get; set; } //to add customer age 

        public DateTime Joining_Date { get; set; }//to add start date 

    }
}
