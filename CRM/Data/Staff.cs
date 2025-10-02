﻿using System.ComponentModel.DataAnnotations;

namespace CRM.Data
{
    public class Staff
    {
        public Guid StaffId { get; set; }
        [Required]
        public string UserID { get; set; }
        [Required]
        public string StaffName { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Project> AssignedProjects { get; set; } = new List<Project>();
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
    }
}
