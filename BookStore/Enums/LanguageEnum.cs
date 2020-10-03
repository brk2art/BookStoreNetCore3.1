using System.ComponentModel.DataAnnotations;

namespace BookStore.Enums
{
    public enum LanguageEnum
    {
        [Display(Name = "Turkish language")]
        Turkish = 10,
        [Display(Name = "Hindi language")]
        Hindi = 11,
        [Display(Name = "English language")]
        English = 12,
        [Display(Name = "German language")]
        German = 13,
        [Display(Name = "Chinese language")]
        Chinese = 14,
        [Display(Name = "Dutch language")]
        Dutch = 15
    }
}
