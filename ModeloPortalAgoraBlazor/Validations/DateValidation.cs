using System.ComponentModel.DataAnnotations;

namespace ModeloPortalAgoraBlazor.Validations;

public class DateValidation : ValidationAttribute
{
    public string MaxDate { get; set; }
    public string MinDate { get; set; }
    public bool MaxDateCurrentDay { get; set; } = false;
    
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var minDate = string.IsNullOrEmpty(MinDate) ? DateTime.MinValue : Convert.ToDateTime(MinDate);
        var maxDate = string.IsNullOrEmpty(MaxDate) ? DateTime.MaxValue : Convert.ToDateTime(MaxDate);
        maxDate = MaxDateCurrentDay ? DateTime.Now : maxDate;
        var dateValue = Convert.ToDateTime(value);
        
        if (dateValue >= minDate || dateValue <= maxDate) return null;
        if (dateValue < minDate) ErrorMessage = "Data informada inferior à mínima permitida";
        if (dateValue > maxDate) ErrorMessage = "Data informada superior à máxima permitida";
        return new ValidationResult(ErrorMessage);
    }

    
}