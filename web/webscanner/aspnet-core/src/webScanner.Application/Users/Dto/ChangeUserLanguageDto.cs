using System.ComponentModel.DataAnnotations;

namespace webScanner.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}