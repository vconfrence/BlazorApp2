using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.HubModels;

public class HubUserModel
{
    public HubUserModel()
    {
            
    }
    public int Id { get; set; }
    public int? RoleTypeId { get; set; }
    public int? RoleProfileId { get; set; }
    public int? SecurityLevelId { get; set; }
    [Required(ErrorMessage = "FirstName is required")]
    public string? FirstName { get; set; }
    [Required(ErrorMessage = "LastName is required")]
    public string? LastName { get; set; }
    [Required(ErrorMessage = "Username is required")]
    public string? Username { get; set; }
    public string? Password { get; set; }
    public DateTime? ReleaseNotesLastReadDate { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsEmployee { get; set; }
    [Required(ErrorMessage = "Company is required")]
    public string? Company { get; set; }
    [Required(ErrorMessage = "Email is required")]
    public string? Email { get; set; }
    public DateTime? LastLogin { get; set; }
    [NotMapped]
    public int? OldQDataContactsId { get; set; }
    [NotMapped]
    public int? OldQUserId { get; set; }
    [NotMapped]
    public DateTime? CreatedDate { get; set; }
    [NotMapped]
    public DateTime? LastUpdatedDate { get; set; }
    public bool? IsRecordActive { get; set; }
    [NotMapped]
    public string? RefreshInterval { get; set; }
    public string? Telephone1 { get; set; }
    public double? LastQuestionnaireStatus { get; set; }
    [NotMapped]
    public string? SalesForceAccountId { get; set; }
    [NotMapped] 
    public string? SalesForceContactId { get; set; }
    [NotMapped] 
    public string? TestEmailSync { get; set; }
    public bool? ExistsAsAttendee { get; set; }
    [NotMapped] 
    public bool? MarkForDupeDelete { get; set; }
    [NotMapped] 
    public bool? ExistsAsInvestmentDataContact { get; set; }
    public bool? IsCSuiteUser { get; set; }
    public int? SeniorityLevel { get; set; }
    public bool? IsOwner { get; set; }
    public bool? IsConsultant { get; set; }
    public bool? IsAccounting { get; set; }
    public bool? NotifyOfConsultantAnalystChange { get; set; }
    public int? RoleTeamId { get; set; }
    public bool? IsCst { get; set; }
    public DateTime? MrQuestionnaireDate { get; set; }
    public double? CompFactor { get; set; }
    public string? ComputerName { get; set; }
    public string? WinLogin { get; set; }
    public bool? IsTeamManagementUser { get; set; }
    public string? AuthPass { get; set; }
    public DateTime? AuthSentDate { get; set; }
    public string? AuthPassQMS { get; set; }
    public DateTime? AuthSentDateQMS { get; set; }
    public bool? ShowAuthPageQMS { get; set; }
    public string? PlanMeetingNoteCCEmail { get; set; }
    public bool? QMSUserSpecificRequest { get; set; }

    public string? Title { get; set; }

    public bool? PasswordReset { get; set; }
    public bool? IsDbContact { get; set; }
    public string? ContactFunction { get; set; }
    public bool? PersonalProposedView { get; set; }
    public int? UpdateUserId { get; set; }

    //derived elements NOTE: Mark with attribute [NotMapped]
    private string? _fullName;
    [NotMapped]
    public string? FullName
    {
        get
        {
            _fullName = LastName + ", " + FirstName;
            return _fullName;
        }
    }


    //virtual for holding data paging total records
    [NotMapped]
    public int? _TotalRecords { get; set; }
}
