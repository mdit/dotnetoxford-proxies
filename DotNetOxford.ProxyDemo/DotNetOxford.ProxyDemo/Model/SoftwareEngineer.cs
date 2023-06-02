namespace DotNetOxford.ProxyDemo.Model;

public class SoftwareEngineer : DevTeamMember
{
    public SoftwareEngineer(string name) : base(name)
    {
    }

    public virtual Code WriteCode()
    {
        return new Code($"Console.WriteLine(\"Hello .NET Oxford, I'm {Name} and I'm a {RoleName}).\"", "C#");
    }
}