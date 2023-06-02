namespace DotNetOxford.ProxyDemo.Model;

public class EngineeringManager : DevTeamMember
{
    public EngineeringManager(string name) : base(name)
    {
    }

    public List<SoftwareEngineer> DirectReports = new();

    public IEnumerable<LeadSoftwareEngineer> LeadEngineers => DirectReports.OfType<LeadSoftwareEngineer>();

    public string RequestCodeFromTeam() =>
        string.Join(
            Environment.NewLine,
            LeadEngineers.SelectMany(x => x.GetTeamToWriteCode()).Select(x => x.Syntax));
}