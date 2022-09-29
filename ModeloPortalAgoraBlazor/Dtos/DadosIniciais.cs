using System;
using System.ComponentModel.DataAnnotations;
using ModeloPortalAgoraBlazor.Validations;

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

    [CnpjValidation]
    [Display(Name = "CNPJ")]
    [Required(ErrorMessage = "CNPJ é obrigatório")]
    public string Cnpj { get; set; }
        
    [Display(Name = "Denominação comercial")]
    [Required(ErrorMessage = "Denominação comercial é obrigatório")]
    public string DenominacaoComercial { get; set; }
    
    [Display(Name = "Data de constituição")]
    [DateValidation(MinDate = "01/01/1800", MaxDateCurrentDay = true)]
    [Required(ErrorMessage = "Data de constituição é obrigatória")]
    public DateTime DataConstituicao { get; set; }
    
    [Display(Name = "Forma de constituição")]
    [Required(ErrorMessage = "Forma de constituição é obrigatória")]
    public string FormaConstituicao { get; set; }
    
    [Display(Name = "NIRE")]
    [Required(ErrorMessage = "NIRE é obrigatório")]
    public string Nire { get; set; }    
    
    [Display(Name = "Principal objetivo comercial")]
    [Required(ErrorMessage = "Principal objetivo comercial é obrigatório")]
    public string PrincipalObjetoSocial { get; set; }
    
    [Display(Name = "Principal atividade")]
    [Required(ErrorMessage = "Principal atividade é obrigatório")]
    public string PrincipalAtividade { get; set; }
    
    [Display(Name = "Possui vículo com a Ágora")]
    [Required(ErrorMessage = "Possui vículo com a Ágora é obrigatório")]
    public string PossuiVinculocomAgora { get; set; }
    
    [Display(Name = "CEP")]
    [Required(ErrorMessage = "CEP é obrigatório")]
    public string Cep { get; set; }
    
    [Display(Name = "Endereço")]
    [Required(ErrorMessage = "Endereço é obrigatório")]
    public string Endereco { get; set; }
    
    [Display(Name = "Número")]
    [Required(ErrorMessage = "Número é obrigatório")]
    public string Numero { get; set; }
    
    [Display(Name = "Complemento")]
    [Required(ErrorMessage = "Complemento é obrigatório")]
    public string Complemento { get; set; }
    
    [Display(Name = "Bairro")]
    [Required(ErrorMessage = "Bairro é obrigatório")]
    public string Bairro { get; set; }
    
    [Display(Name = "Estado")]
    [Required(ErrorMessage = "Estado é obrigatório")]
    public string Estado { get; set; }
    
    [Display(Name = "Cidade")]
    [Required(ErrorMessage = "Cidade é obrigatório")]
    public string Cidade { get; set; }
}