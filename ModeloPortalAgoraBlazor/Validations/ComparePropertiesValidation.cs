using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ModeloPortalAgoraBlazor.Validations;

public class ComparePropertiesValidation : ValidationAttribute
{
    public ComparePropertiesValidation(string otherProperty)
    {
        OtherProperty = otherProperty ?? throw new ArgumentNullException(nameof(otherProperty));
    }

    private string OtherProperty { get; }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var otherPropertyInfo = validationContext.ObjectType.GetRuntimeProperty(OtherProperty);
        var otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);
        var text = value != null ? value.ToString() : "";
        if ((string)otherPropertyValue == "Outro" && string.IsNullOrEmpty(text))
            return new ValidationResult(ErrorMessage);
        else
            return null;
    }
}