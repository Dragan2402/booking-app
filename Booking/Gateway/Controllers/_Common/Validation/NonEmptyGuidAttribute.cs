using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers._Common.Validation;

[AttributeUsage(AttributeTargets.Property)]
public class NonEmptyGuidAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext) =>
        ((value is Guid guid) && guid == default) ?
            new ValidationResult(FormatErrorMessage(validationContext.DisplayName)) :
            ValidationResult.Success;
}
