using System.ComponentModel.DataAnnotations;

namespace ModeloPortalAgoraBlazor.Dtos;

public class Passo01
{
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string NomeUsuario { get; set; }

    [Display(Name = "Principal objetivo comercial")]
    [Required(ErrorMessage = "Principal Objetivo Comercial é obrigatório")]
    public string PrincipalObjetivoComercial { get; set; }

    [Display(Name = "Telefone")]
    [Required(ErrorMessage = "Telefone é obrigatório")]
    public string Telefone { get; set; }

    [Display(Name = "Ramal")]
    public int Ramal { get; set; }

    [Display(Name = "E-mail")]
    [EmailAddress(ErrorMessage = "o campo deve ter formato de e-mail")]
    [Required(ErrorMessage = "E-mail é obrigatório")]
    public string Email { get; set; }

    [Display(Name = "Confirmação do e-mail")]
    [EmailAddress(ErrorMessage = "o campo deve ter formato de e-mail")]
    [Compare("Email", ErrorMessage = "A comparação deve ser igual ao compo de e-mail")]
    public string ConfirmarEmail { get; set; }

    [Display(Name = "CNPJ")]
    [Required(ErrorMessage = "CNPJ é obrigatório")]
    public string Cnpj { get; set; }
        
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string DenominacaoComercial { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public DateTime DataConstituicao { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string FormaConstituicao { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string Nire { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string PrincipalObjetoSocial { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string PrincipalAtividade { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string PossuiVinculocomAgora { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string Cep { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string Endereco { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string Numero { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string Complemento { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string Bairro { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string Estado { get; set; }
    
    [Display(Name = "Nome de usuário")]
    [Required(ErrorMessage = "Nome de usuário é obrigatório")]
    public string Cidade { get; set; }
}