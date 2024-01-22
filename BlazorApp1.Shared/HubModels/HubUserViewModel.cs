using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.HubModels;

public class HubUserViewModel
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Company { get; set; }
    public string? RoleType { get; set; }
    public string? RoleProfile { get; set; }
    public string? RoleTeam { get; set; }
    public int? RoleTeamId { get; set; }
    public int? RoleTypeId { get; set; }

    public string? HubUserNameEmail
    {
        get { return LastName + ", " + FirstName + " <" + Email + ">"; }
    }
    //public DateTime? LastLogin { get; set; }
    //virtual for holding data paging total records
    [NotMapped]
    public int? _TotalRecords { get; set; }
}
