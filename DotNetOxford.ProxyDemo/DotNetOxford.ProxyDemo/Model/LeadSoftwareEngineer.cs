namespace DotNetOxford.ProxyDemo.Model;

public sealed class LeadSoftwareEngineer : SeniorSoftwareEngineer
{
    public LeadSoftwareEngineer(string name) : base(name)
    {
    }

    public List<SoftwareEngineer> TeamMates { get; } = new();

    public Code[] GetTeamToWriteCode() => TeamMates
                                          .Select(x => x.WriteCode())
                                          .Concat(new[] { WriteCode() })
                                          .ToArray();

    public override string ReviewCode(Code code)
    {
        return IsGreat(code) ? "This code is great, nice one, let's merge it" : "This code should be great, can you check it";
    }

    private static bool IsGreat(Code code)
    {
        return code.Syntax.Contains("Great");
    }
}