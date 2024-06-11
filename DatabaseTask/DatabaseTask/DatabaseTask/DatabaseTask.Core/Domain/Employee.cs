using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public int EmployeeNumber { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [Required]
        public string? FirstName { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [Required]
        public string? LastName { get; set; }

        public int PID { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [Required]
        public string? Address { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [Required]
        public string? Email { get; set; }

        public DateTime WorkingSince { get; set; }
        public DateTime? WorkingUntil { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string? Comment { get; set; }

        public virtual ICollection<AccessPermission> AccessPermissions { get; set; }

        public int JobTitleId { get; set; }
        [ForeignKey("JobTitleId")]
        public virtual JobTitle JobTitle { get; set; }

        public virtual ICollection<WorkingHistory> WorkingHistories { get; set; }
        public virtual ICollection<EmployeeChild> EmployeeChildren { get; set; }
        public virtual ICollection<SickLeave> SickLeaves { get; set; }
        public virtual ICollection<Holiday> Holidays { get; set; }
        public virtual ICollection<HealthInspection> HealthInspections { get; set; }
        public virtual ICollection<Renting> Rentings { get; set; }
        public virtual ICollection<Request> Requests { get; set; }

        public int BranchOfficeId { get; set; }
        [ForeignKey("BranchOfficeId")]
        public virtual BranchOffice BranchOffice { get; set; }
    }
}


