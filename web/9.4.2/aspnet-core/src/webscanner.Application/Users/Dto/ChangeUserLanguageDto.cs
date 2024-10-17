using System.ComponentModel.DataAnnotations;

namespace webscanner.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}