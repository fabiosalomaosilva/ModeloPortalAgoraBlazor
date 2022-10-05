namespace ModeloPortalAgoraBlazor.Services.Interfaces;

public interface IChangeService
{
    event Action OnChange;
    void Change();
}
