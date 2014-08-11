using System;
using System.Collections.Generic;
using System.Linq;

namespace TennoLink.Services.Interfaces
{
    public interface ILocalisationService
    {
        List<string> SupportedLanguages { get; }
        string LocaliseValue(string locale, string value);
    }
}