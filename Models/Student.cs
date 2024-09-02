using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crud_aspnet_core_mvc_balta.Models;

public class Student
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(80, ErrorMessage = "O nome deve ter no máximo 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve ter no mínimo 5 caracteres")]
    [DisplayName("NOme completo")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe o Email")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    [DisplayName("E-mail")]
    public string Email { get; set; } = string.Empty;

    public List<Premium> Premiums { get; set; } = new();
}