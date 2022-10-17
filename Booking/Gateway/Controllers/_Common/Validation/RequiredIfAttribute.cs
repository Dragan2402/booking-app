using System.ComponentModel.DataAnnotations;

namespace Booking.Gateway.Controllers._Common.Validation;

public class RequiredIfAttribute : RequiredAttribute
{
    public string PropertyName { get; set; } = string.Empty;

    public object DesiredValue { get; set; } = default!;

    protected override ValidationResult? IsValid(object? value, ValidationContext context)
    {
        var instance = context.ObjectInstance;
        var type = instance.GetType();
        var actualValue = type.GetProperty(PropertyName)?.GetValue(instance);

        if (actualValue!.GetHashCode() == DesiredValue.GetHashCode())
        {
            return base.IsValid(value, context);
        }

        return ValidationResult.Success;
    }
}