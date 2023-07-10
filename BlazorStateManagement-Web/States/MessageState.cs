namespace BlazorStateManagement_Web;

public class MessageState
{
    private IEnumerable<Message> messages = new List<Message>();

    public List<Message> GetMessages() => messages.ToList();
    public event Action? OnChange;

    /*
    When multiple clients opened throws exception. 
    An exception of type 'System.InvalidOperationException' occurred in 
    Microsoft.AspNetCore.Components.dll but was not handled in user code: 
    'The current thread is not associated with the Dispatcher. Use InvokeAsync() to switch execution 
    to the Dispatcher when triggering rendering or component state.'
    */
    private void NotifyStateChanged() => OnChange?.Invoke();

    public void SendMessage(Message message)
    {
        messages = messages.Append(message);
        NotifyStateChanged();
    }
}
