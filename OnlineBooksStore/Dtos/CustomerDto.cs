﻿using OnlineBooksStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBooksStore.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
      
        //MembershipType value
        public byte MembershipTypeId { get; set; }

        //[Min18YearsIfCustomer]
        public DateTime? DateOfBirth { get; set; }
    }
}