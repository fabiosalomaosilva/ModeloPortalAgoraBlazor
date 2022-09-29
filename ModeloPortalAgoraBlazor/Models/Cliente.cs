using System.ComponentModel.DataAnnotations;

namespace ModeloPortalAgoraBlazor.Models
{
    public class Cliente
    {
        public int Id { get; set; }

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
        
        public string DenominacaoComercial { get; set; }
        public DateTime DataConstituicao { get; set; }
        public string FormaConstituicao { get; set; }
        public string Nire { get; set; }
        public string PrincipalObjetoSocial { get; set; }
        public string PrincipalAtividade { get; set; }
        public string PossuiVinculocomAgora { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string InformacoesSocietarias { get; set; }
        public string OperoCarteira { get; set; }
        public List<ContaBancaria> ContasBancarias { get; set; }
        public decimal? AplicacaoFinanceira { get; set; }
        public decimal? EmprestimosFinanciamentos { get; set; }
        public decimal? PatrimonioLiquido { get; set; }
        public decimal? Faturamento { get; set; }
        public string TipoEnderecoCorrespondencia { get; set; }
        public string EspecificacaoEnderecoCorrespondencia { get; set; }
        public List<Controlador> Controladores { get; set; }
        public List<PessoaProprietaria> PessoasProprietarias { get; set; }
        public List<Administrador> Administradores { get; set; }
        public List<Procurador> Procuradores { get; set; }
        public List<EmissorOrdem> EmissoresOrdees { get; set; }

    }

    public class ContaBancaria
    {
        public string Id { get; set; }
        public string Tipo { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public int Digito { get; set; }
        public int Banco { get; set; }
    }
    
    public class Controlador
    {
        public string Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string ControladorPai { get; set; }
        public decimal Participacao { get; set; }
    }
    
    public class Administrador
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string OrgaoEmissor { get; set; }
    }
    public class EmissorOrdem
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string OrgaoEmissor { get; set; }
    }
    
    public class Procurador
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string OrgaoEmissor { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public bool PessoaExpostaPoliticamente { get; set; }
    }
    
    public class PessoaProprietaria
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string OrgaoEmissor { get; set; }
        public string TipoVinculo { get; set; }
        public bool VinculoComAgora { get; set; }
        public bool PessoaExpostaPoliticamente { get; set; }
        public bool PossuiOutraNacionalidade { get; set; }
        public bool TemResidenciafiscalOutroPais { get; set; }
        public bool PossuiVistoPermanenteOutroPais { get; set; }
        public string ControladorPai { get; set; }
        public List<Nif> Nifs { get; set; }
    }

    public class Nif
    {
        public string Id { get; set; }
        public string Referencia { get; set; }
        public string Pais { get; set; }
        public string Numero { get; set; }
        public string Motivo { get; set; }
        public string PessoaControladoraId { get; set; }
    }
}
