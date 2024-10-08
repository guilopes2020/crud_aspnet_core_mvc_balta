using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crud_aspnet_core_mvc_balta.Models;

public class Premium
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o título do Premium")]
    [StringLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O título deve ter no mínimo 5 caracteres")]
    [DisplayName("Título")]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    [DisplayName("Inicio")]
    public DateTime StartDate { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayName("Término")]
    public DateTime EndDate { get; set; }

    [DisplayName("Aluno")]
    [Required(ErrorMessage = "Aluno Inválido")]
    public int StudentId { get; set; }

    public Student? Student { get; set; }
}