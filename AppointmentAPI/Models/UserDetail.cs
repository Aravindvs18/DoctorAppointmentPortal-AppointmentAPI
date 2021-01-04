using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentAPI.Models
{
    public class UserDetail
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        
        public String UserName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public String UserEmail { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public String UserPassword { get; set; }



    }
}
