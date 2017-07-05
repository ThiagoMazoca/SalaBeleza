using System.ComponentModel.DataAnnotations;

namespace SalaoBeleza.Models
{
    public class Email
    {
        [Required, Display(Name = "Seu Nome")]
        public string FromName { get; set; }

        [Required, Display(Name = "Seu Email"), EmailAddress]
        public string FromEmail { get; set; }

        [Required]
        public string Message { get; set; }
    }
}