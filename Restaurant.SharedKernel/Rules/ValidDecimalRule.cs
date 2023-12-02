using Restaurant.SharedKernel.Core;

namespace Restaurant.SharedKernel.Rules;

public class ValidDecimalRule : IBussinessRule
{
    private readonly decimal _value;

    public string Message => "Value is not a valid decimal";

    public ValidDecimalRule(decimal value)
    {
        _value = value;
    }
    public bool IsValid()
    {
        return _value >= 0;
    }
}
