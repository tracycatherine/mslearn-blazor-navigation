using System.Globalization;

namespace BlazingPizza;

public static class Currency
{
    public static string Format(decimal amount)
    {
        return amount.ToString("C2", CultureInfo.CurrentCulture);
    }
}
