using DotNetOxford.ProxyDemo.Model;
using ProxyInterfaceGenerator;

namespace DotNetOxford.ProxyDemo.Model;

[Proxy(typeof(Code))]
public partial interface ICode
{
}

[Proxy(typeof(DevTeamMember))]
public partial interface IDevTeamMember
{
}

[Proxy(typeof(EngineeringManager))]
public partial interface IEngineeringManager : IDevTeamMember
{
}

[Proxy(typeof(SoftwareEngineer))]
public partial interface ISoftwareEngineer : IDevTeamMember
{
}

[Proxy(typeof(SeniorSoftwareEngineer))]
public partial interface ISeniorSoftwareEngineer : ISoftwareEngineer
{
}

[Proxy(typeof(LeadSoftwareEngineer))]
public partial interface ILeadSoftwareEngineer : ISeniorSoftwareEngineer
{
}