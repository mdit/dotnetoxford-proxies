namespace DotNetOxford.ProxyDemo.Model;

public class SeniorSoftwareEngineer : SoftwareEngineer
{
    public SeniorSoftwareEngineer(string name) : base(name)
    {
    }

    public virtual string ReviewCode(Code code)
    {
        return IsSmelly(code)
            ? "This code is smelly, can you check it"
            : "This code doesn't smell, just merge it";
    }

    private static bool IsSmelly(Code code)
    {
        return code.Syntax.Contains("Code Smell");
    }
}