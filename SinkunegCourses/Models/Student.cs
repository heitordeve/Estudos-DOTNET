using System.ComponentModel.DataAnnotations;

namespace SinkunegCourses.Models;

public class Student
{
    [Key]
    [Display(Name = "Student ID")]
    public int StudentID { get; set; }
    
    [Required(ErrorMessage = "Informe o nome do estudante")]
    [StringLength(80, ErrorMessage = "O nome do estudante de ter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome não pode ter menos que 5 caracteres")]
    [Display(Name = "Nome completo")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Informe o e-mail do estudante")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    [Display(Name = "E-mail")]
    public string Email { get; set; }

    public List<Premium> Premiums { get; set; } = new();

}