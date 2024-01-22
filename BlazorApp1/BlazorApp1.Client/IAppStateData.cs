using BlazorApp1.Shared.HubModels;
public class AppStateData : IAppState
{
    public int TimeToLiveInSeconds { get; set; }
    public DateTime LastAccessed { get; set; }
      public int Counter { get; set; }
    public bool IsLoggedIn { get; set; }
    public HubUserModel? CurrentUser { get; }
    public bool IsDevelopment { get; set; }
    public string PlanPageState { get; set; }
    public string? Token { get; set; }
    public string? CurrentPage { get; set; }
    public string? CurrentPageTarget { get; set; }
    public string? UserFullName { get; set; }
    public string?  ActiveMainTab { get; set; }
    public string? ActiveMainTabTarget { get; set; }
    public int? PlanPageActiveTabIndex { get; set; }
    public int? PlanPageTargetTabIndex { get; set; }
    public int? ResearchPageActiveTabIndex { get; set; }
    public int? ResearchPageTargetTabIndex { get; set; }
    public int SelectedClientId { get; set; }
    public int SelectedPlanId { get; set; }
    public int SelectedManagerId { get; set; }
    public int SelectedProductId { get; set; }
    public int SelectedVehicleId { get; set; }
    public string? CurrentEntityType { get; set; }
    public string? CurrentEntityName { get; set; }
    public int? CurrentEntityId { get; set; }
}