using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class AdminInfo
    {
        [Key]
        public string EmailId { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
