using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TennoLink.Models;

namespace TennoLink.Services
{
    public interface IWarframeStatusService
    {
    }

    public class WarframeStatusService : IWarframeStatusService
    {
        public WarframeStatusService(IConfig config)
        {
        }
    }
}