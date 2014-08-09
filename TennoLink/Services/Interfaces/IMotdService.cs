using System.Web;

namespace TennoLink.Services.Interfaces
{
    public interface IMotdService
    {
        string GetMotd();

        HtmlString GetMotdHtml();
    }
}