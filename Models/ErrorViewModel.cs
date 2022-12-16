namespace MvcBook.Models;

public class ErrorViewModel
{
    //Start here
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
