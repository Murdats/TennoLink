namespace TennoLink.Models.Interfaces
{
    public interface IConfig
    {
        string MotdUrl { get; set; }

        string StatusUrl { get; set; }
    }
}