﻿namespace Lost_and_Found.Models.DTO
{
    public class FindPhoneDTO
    {
        //public string PhoneNumber { get; set; }
        public IFormFile? PhonePhoto { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Government { get; set; }
        public string Center { get; set; }
        public string Street { get; set; }
        public string FinderEmail { get; set; }
    }
}
