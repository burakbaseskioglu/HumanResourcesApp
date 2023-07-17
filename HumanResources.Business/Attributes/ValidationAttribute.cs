namespace HumanResources.Business.Attributes;

[AttributeUsage(AttributeTargets.All)]
public class ValidationAttribute: Attribute
{
    public Type Type { get; set; }

    public ValidationAttribute(Type type)
    {
        Type = type;
    }
}
