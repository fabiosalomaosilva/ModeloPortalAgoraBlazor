using ModeloPortalAgoraBlazor.Services.Interfaces;

namespace ModeloPortalAgoraBlazor.Services;

public class ChangeService : IChangeService
{
    public event Action OnChange;
    public void Change()
    {
        OnChange?.Invoke();
    }
}