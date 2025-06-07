using System.ComponentModel.DataAnnotations;

namespace ASPNET_Site_1.Models.Account;

public class LoginViewModel
{
    [Display(Name = "Електронна пошта")]
    [Required(ErrorMessage = "Вкажіть електронну пошту")]
    [EmailAddress(ErrorMessage = "Пошту вказано не вірно")]
    public string Email { get; set; } = string.Empty;

    [Display(Name = "Пароль")]
    [Required(ErrorMessage = "Вкажіть пароль")]
    public string Password { get; set; } = string.Empty;
}
