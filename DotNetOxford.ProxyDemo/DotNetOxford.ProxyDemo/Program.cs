﻿// See https://aka.ms/new-console-template for more information

using DotNetOxford.ProxyDemo.Model;
using DotNetOxford.ProxyDemo.Services;

var manager = new EngineeringManager("Laid Back Larry");
var lead = new LeadSoftwareEngineer("Meticulous Max");
var snr = new SeniorSoftwareEngineer("Picky Johnny Coder");
var jnr = new SoftwareEngineer("Little Bobby Tables");

manager.DirectReports.AddRange(new[] { lead, snr, jnr });
lead.TeamMates.AddRange(new[] { snr, jnr });

Console.WriteLine("Concrete instances");
Console.WriteLine(manager.RequestCodeFromTeam());
Console.ReadLine();

// Proxies
Console.WriteLine("Proxy instance");
var proxyManager = new EngineeringManagerProxy(manager);
Console.WriteLine(proxyManager.AttentionLevel);
Console.WriteLine(proxyManager.RequestCodeFromTeam());

Console.ReadLine();
var messageService = new MessageService();
var messageServiceProxy = new MessageServiceProxy(messageService);
var userService = new UserService(messageServiceProxy);

userService.DisplayUserMessage(manager, "Do some work!");

Console.ReadLine();
