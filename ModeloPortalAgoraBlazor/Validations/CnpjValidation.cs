using System.ComponentModel.DataAnnotations;

namespace ModeloPortalAgoraBlazor.Validations;

public class CnpjValidation: ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        return ValidarCnpj(value.ToString()) ? null : new ValidationResult("CNPJ inválido.");
    }

    private bool ValidarCnpj(string cnpj)
        {
            var multiplicador1 = new[] {5,4,3,2,9,8,7,6,5,4,3,2};
            var multiplicador2 = new[] {6,5,4,3,2,9,8,7,6,5,4,3,2};
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            var tempCnpj = cnpj[..12];
            var soma = 0;
            for(var i=0; i<12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            var resto = (soma % 11);
            if ( resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            var digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (var i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
}