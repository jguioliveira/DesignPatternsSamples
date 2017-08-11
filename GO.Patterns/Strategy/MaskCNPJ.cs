using System.Text.RegularExpressions;

namespace GO.Patterns.Strategy
{
    public class MaskCNPJ : IMask
    {
        public string Pattern => @"(\d{2})(\d{3})(\d{3})(\d{4})(\d{2})";

        public string Format => "$1.$2.$3/$4-$5";

        public string Transform(string value)
        {
            return Regex.Replace(value, Pattern, Format);
        }
    }
}
