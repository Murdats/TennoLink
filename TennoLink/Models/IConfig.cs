namespace TennoLink.Models
{
    public interface IConfig
    {
        string MotdUrl { get; set; }

        string StatusUrl { get; set; }
    }
}