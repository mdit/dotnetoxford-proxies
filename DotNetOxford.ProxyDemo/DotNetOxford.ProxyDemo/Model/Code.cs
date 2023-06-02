namespace DotNetOxford.ProxyDemo.Model;

public sealed class Code
{
    public Code(string syntax, string language)
    {
        Syntax = syntax;
        Language = language;
    }

    public string Syntax { get; set; }

    public string Language { get; set; }
}