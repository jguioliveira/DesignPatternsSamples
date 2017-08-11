namespace GO.Patterns.Strategy
{
    public static class MaskApply
    {
        public static string FormatApply(IMask mask, string value)
        {
            return mask.Transform(value);
        }
    }
}
