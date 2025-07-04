namespace _7oras.UI.MVC.ViewModels;

public class BaseErrorResponse
{
    public Guid ErrorId { get; set; } = Guid.NewGuid();
    public string FriendlyMessage { get; set; }
    public IList<string> TechMessage { get; set; } = new List<string>();
}
