using System.ComponentModel.DataAnnotations;

namespace ModeloPortalAgoraBlazor.Dtos;

public class DadosIniciais
{
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string NomeUsuario { get; set; }
    
    [Display(Name = "CNPJ")]
    [Required(ErrorMessage = "CNPJ é obrigatório")]
    public string Cnpj { get; set; }
    
    [Display(Name = "E-mail")]
    [EmailAddress(ErrorMessage = "o campo deve ter formato de e-mail")]
    [Required(ErrorMessage = "E-mail é obrigatório")]
    public string Email { get; set; }

    [Display(Name = "Teste")]
    public string Teste { get; set; }
}