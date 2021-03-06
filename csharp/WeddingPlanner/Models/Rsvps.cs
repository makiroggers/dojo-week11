﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner
{
    public partial class Rsvps
    {
        [Key]
        public int RsvpId { get; set; }
        public int UserId { get; set; }
        public int WeddingId { get; set; }
        public Weddings Wedding { get; set; }
    }

    public partial class rsvp_users
    {
        [Key]
        public int RsvpId { get; set; }
        public int UserId { get; set; }
        public int WeddingId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}