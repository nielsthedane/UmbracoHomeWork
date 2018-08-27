using System;
using System.Collections.Generic;
using System.Text;

namespace UmbracoClassLibary.Models
{
    public class Submission
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public Guid SerialNumber { get; set; }
    }
}
