using System.ComponentModel.DataAnnotations;
using ModeloPortalAgoraBlazor.Validations;

namespace ModeloPortalAgoraBlazor.Dtos;

public class Passo02Dto
{
    [Display(Name = "Aplicação financeira")]
    [Required(ErrorMessage = "Aplicação financeira é obrigatória")]
    public string AplicacaoFinanceira { get; set; }
    
    [Display(Name = "Empréstimos e financiamentos")]
    [Required(ErrorMessage = "Empréstimos e financiamentos é obrigatório")]
    public string EmprestimosFinanciamentos { get; set; }
    
    [Display(Name = "Patrimônio líquido")]
    [Required(ErrorMessage = "Patrimônio líquido é obrigatório")]
    public string PatrimonioLiquido { get; set; }
    
    [Display(Name = "Faturamento")]
    [Required(ErrorMessage = "Faturamento é obrigatório")]
    public string Faturamento { get; set; }
    
    [Display(Name = "Tipo de endereço")]
    [Required(ErrorMessage = "Tipo de endereço é obrigatório.")]
    public string TipoEnderecoCorrespondencia { get; set; }
    
    [Display(Name = "Especificação do endereço")]
    [ComparePropertiesValidation("TipoEnderecoCorrespondencia", ErrorMessage = "Especificação de endereço é obrigatório.")]
    public string EspecificacaoEnderecoCorrespondencia { get; set; }
}