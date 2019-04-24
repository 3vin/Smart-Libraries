using System.ComponentModel.DataAnnotations;

namespace SmartLibraries.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}