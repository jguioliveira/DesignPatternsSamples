namespace GO.Patterns.Strategy
{
    public interface IMask
    {
        string Pattern { get; }
        string Format { get; }
        string Transform(string value);
    }
}
