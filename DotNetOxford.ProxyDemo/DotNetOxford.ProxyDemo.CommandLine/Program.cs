// See https://aka.ms/new-console-template for more information

using DotNetOxford.ProxyDemo.Model;

var manager = new EngineeringManager("Laid Back Larry");
var lead = new LeadSoftwareEngineer("Meticulous Max");
var snr = new SeniorSoftwareEngineer("Picky Johnny Coder");
var jnr = new SoftwareEngineer("Little Bobby Tables");
manager.DirectReports.AddRange(new[] { lead, snr, jnr });
lead.TeamMates.AddRange(new[] { snr, jnr });

var code = manager.RequestCodeFromTeam();
Console.Write(code);
Console.ReadKey();