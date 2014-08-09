using System;
using System.Linq;

namespace TennoLink.Models
{
    public class Config : IConfig
    {
        public string MotdUrl { get; set; }

        public string StatusUrl { get; set; }
    }
}