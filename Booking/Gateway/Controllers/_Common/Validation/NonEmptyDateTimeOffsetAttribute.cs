using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers._Common.Validation;

[AttributeUsage(AttributeTargets.Property)]
public class NonEmptyDateTimeOffsetAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        return ((value is DateTimeOffset date) && date == default)
            ? new ValidationResult(FormatErrorMessage(validationContext.DisplayName)) : ValidationResult.Success;
    }
}