using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentAPI.Models
{
    public class AppointmentDetail
    {
        [Key]
        public int AppointmentId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PatientName { get; set; }
        [Column(TypeName = "nvarchar(3)")]    
        public string PatientAge { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PatientGender { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string PatientNumber { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SelectDoctor { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string SelectDate { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string UserId { get; set; }





    }
}
