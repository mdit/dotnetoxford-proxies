namespace DotNetOxford.ProxyDemo.Model
{
    public class DevTeamMember
    {
        public DevTeamMember(string name) => Name = name;

        public string Name { get; set; }

        public string RoleName => GetType().Name;
    }
}