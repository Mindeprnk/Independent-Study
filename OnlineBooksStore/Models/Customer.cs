﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineBooksStore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required( ErrorMessage ="Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        
        public bool IsSubscribedToNewsLetter { get; set; }
        
        public MembershipType MembershipType { get; set; }

        //MembershipType value
        [Display(Name ="Membership Type")]
        public byte MembershipTypeId { get; set; }
           
        [Display(Name ="Date of Birth")]
        [Min18YearsIfCustomer]
        public DateTime? DateOfBirth { get; set; }
    }
}