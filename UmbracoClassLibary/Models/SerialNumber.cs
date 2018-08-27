using System;

namespace UmbracoClassLibary.Models
{
    public class SerialNumber
    {
        public SerialNumber(Guid Id)
        {
            this.Id = Id;
        }
        public Guid Id { get; set; }
    }
}