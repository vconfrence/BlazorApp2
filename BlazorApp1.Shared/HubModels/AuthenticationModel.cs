namespace BlazorApp1.Shared.HubModels;


public class AuthenticationModel
{
    public AuthenticationModel()
    {
            
    }
    public int Id { get; set; } = 0;
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public bool AdStatusOk { get; set; } = false;
}
