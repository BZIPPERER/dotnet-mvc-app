

using System.ComponentModel.DataAnnotations;
namespace gameapplication.Models
{
    public class formClass
    {
        [Required(ErrorMessage = "Geben Sie Ihren Nutzer-Namen an:")]
        [ StringLength(14,MinimumLength = 3)] //" BEN" "Ben"
        public string? Name { get; set; }
        public string? Email { get; set; }

        // string property in model class
public string ExperienceLevel { get; set; }
    }
}