using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SinkunegCourses.Models;

public class Premium
{
    [Key]
    [Display(Name = "Premium ID")]
    public int PremiumID { get; set; }
    
    [Required(ErrorMessage = "Informe o título do Premium")]
    [StringLength(80, ErrorMessage = "O título deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O título não pode ter menos que 5 caracteres")]
    [Display(Name = "Título")]
    public string Titulo { get; set; }
    
    [DataType(DataType.DateTime)]
    [DisplayName("Inicio")]
    public DateTime Inicio { get; set; }
    
    [DataType(DataType.DateTime)]
    [DisplayName("Termino")]
    public DateTime Termino { get; set; }
    
    [Display(Name = "Aluno")]
    [Required(ErrorMessage = "Aluno Inválido")]
    public string StudentId{ get; set; }

    public Student? Student { get; set; }
}