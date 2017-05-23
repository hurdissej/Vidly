using System.ComponentModel.DataAnnotations;

namespace Empty.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}