using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennoLink.Models
{
    public interface IConfig
    {
        string MotdUrl { get; set; }
        string StatusUrl { get; set; }
    }

    public class Config : IConfig
    {
        public string MotdUrl { get; set; }

        public string StatusUrl { get; set; }
    }
}