namespace TennoLink.Services.Interfaces
{
    public interface IUserLocaleService
    {
        string CurrentLanguage { get; set; }
        string LocaliseValue(string value);
    }
}