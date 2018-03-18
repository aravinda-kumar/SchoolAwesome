using System.ComponentModel.DataAnnotations;

namespace SchoolAwesome.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}