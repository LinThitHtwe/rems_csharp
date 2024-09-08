﻿namespace REMS.Models.Agent;

public class AgentRequestModel
{
    public int UserId { get; set; }

    public string? AgentName { get; set; }

    public string? UserName { get; set; }

    public string? LicenseNumber { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public DateTime DateCreate { get; set; } = DateTime.Now;
}