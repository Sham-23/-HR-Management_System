using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystemCore.Models
{
    public class ProjectMembers
    {
        public int ProjectMembersId { get; set; }
        [Required]

        public int EmployeeId { get; set; }
        [Required]
        public int ProjectId { get; set; }
        public string Created { get; set; }
        public string LastModified { get; set; }
    }
}