using System.ComponentModel.DataAnnotations;
using ModeloPortalAgoraBlazor.State;

namespace ModeloPortalAgoraBlazor.Validations;

public class ParticipacaoValidation: ValidationAttribute
{
    private readonly ClienteState _clienteState;

    public ParticipacaoValidation(ClienteState clienteState)
    {
        _clienteState = clienteState;
    }
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var decimalValue = Convert.ToDecimal(value);
        if (decimalValue > 100)
        {
            return new ValidationResult(ErrorMessage);
        }

        var lll = _clienteState.Cliente.Controladores.Count;
        return decimalValue > lll ? new ValidationResult(ErrorMessage) : null;
    }

}