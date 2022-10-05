using System.ComponentModel.DataAnnotations;

namespace ModeloPortalAgoraBlazor.Dtos;

public class ContaBancariaDto
{
    public string Id { get; set; }
        
    [Display(Name = "Tipo")]
    [Required(ErrorMessage = "Tipo é obrigatório")]
    public string Tipo { get; set; }

    [Display(Name = "Agência")]
    [Required(ErrorMessage = "Agência é obrigatório")]
    public int? Agencia { get; set; }
        
    [Display(Name = "Conta")]
    [Required(ErrorMessage = "A Conta é obrigatória")]
    public int? Conta { get; set; }
    
    [Display(Name = "Dígito")]
    [Required(ErrorMessage = "Dígito é obrigatório")]
    public int? Digito { get; set; }
        
    [Display(Name = "Banco")]
    [Required(ErrorMessage = "Banco é obrigatório")]
    public string Banco { get; set; }
}
public class ControladorDto
{
    public string Id { get; set; }

    [Display(Name = "Razão social")]
    [Required(ErrorMessage = "Razão social é obrigatório")]
    public string RazaoSocial { get; set; }
    
    [Display(Name = "CNPJ")]
    [Required(ErrorMessage = "CNPJ é obrigatório")]
    public string Cnpj { get; set; }
    
    [Display(Name = "Controlador")]
    public string ControladorPai { get; set; }
    
    [Display(Name = "Participação")]
    [Required(ErrorMessage = "Participação é obrigatório")]
    public decimal Participacao { get; set; }
}