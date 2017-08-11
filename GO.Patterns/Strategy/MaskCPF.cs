using System.Text.RegularExpressions;

namespace GO.Patterns.Strategy
{
    public class MaskCPF : IMask
    {
        public string Pattern => @"(\d{3})(\d{3})(\d{3})(\d{2})";
        public string Format => "$1.$2.$3-$4";

        public string Transform(string value)
        {
            return Regex.Replace(value, Pattern, Format);
        }
    }
}
