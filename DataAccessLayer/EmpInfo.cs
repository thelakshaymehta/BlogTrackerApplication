using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class EmpInfo
    {
        [Key]
        public string EmailId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfJoining { get; set; }
        [Required]
        public int PassCode { get; set; }
    }

}
