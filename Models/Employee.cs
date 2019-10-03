using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        
        [Column(TypeName ="varchar(250)")]
        [Required]
        [System.ComponentModel.DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column (TypeName ="varchar(10)")]
        [System.ComponentModel.DisplayName("Emp Code")]
        public string EmpCode { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }
        [System.ComponentModel.DisplayName("Office Location")]
        [Column(TypeName = "varchar(100)")]

        public string OfficeLocation { get; set; }

    }
}
