using BlazorApp1.Shared.HubModels;

public interface IAppState
{
    int TimeToLiveInSeconds { get; set; }
    DateTime LastAccessed { get; set; }
    int Counter { get; }
    bool IsLoggedIn { get; }
    HubUserModel? CurrentUser { get; }
    public bool IsDevelopment { get;}
    public string PlanPageState { get;  }
    public string? Token { get;  }
    public string? CurrentPage { get; }
    public string? CurrentPageTarget { get; }
    public string? UserFullName { get; }
    public string? ActiveMainTab { get; set; }
    public string? ActiveMainTabTarget { get; set; }
    public int? PlanPageActiveTabIndex { get; }
    public int? PlanPageTargetTabIndex { get; }
    public int? ResearchPageActiveTabIndex { get; }
    public int? ResearchPageTargetTabIndex { get; }
    public int SelectedClientId { get; }
    public int SelectedPlanId { get; set; }
    public int SelectedManagerId { get; }
    public int SelectedProductId { get; }
    public int SelectedVehicleId { get; }
    public string? CurrentEntityType { get;}
    public string? CurrentEntityName { get; }
    public int? CurrentEntityId { get; }
}