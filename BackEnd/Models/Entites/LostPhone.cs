﻿namespace Lost_and_Found.Models.Entites
{
    public class LostPhone
    {
        public int ID { get; set; }
        public byte[]? PhonePhoto { get; set; }
        public string ImageName { get; set; }       
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Government { get; set; }
        public string Center { get; set; }
        public string Street { get; set; }
        public string ForiegnKey_UserEmail { get; set; }
        public User User { get; set; }                      // One To Many relation
    }
}

