using System.ComponentModel.DataAnnotations;

namespace Metech.SimpleWebApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}