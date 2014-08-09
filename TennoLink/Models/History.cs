using System;

namespace TennoLink.Models
{
    public class History
    {
        public string Def { get; set; }

        public string DefId { get; set; }

        public bool DefAli { get; set; }

        public string Att { get; set; }

        public string AttId { get; set; }

        public bool AttAli { get; set; }

        public string WinId { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }
    }
}