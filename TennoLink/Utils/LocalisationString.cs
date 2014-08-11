using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TennoLink.Services.Interfaces;

namespace TennoLink.Utils
{
    public class LocalisationString
    {
        private readonly IUserLocaleService userLocaleService;
        private readonly Dictionary<string, string> localisedValues = new Dictionary<string, string>();

        public string Value { get; set; }

        public LocalisationString(IUserLocaleService userLocaleService)
        {
            this.userLocaleService = userLocaleService;
        }

        public string GetLocalisedValue()
        {
            if (!localisedValues.ContainsKey(userLocaleService.CurrentLanguage))
            {
                localisedValues.Add(userLocaleService.CurrentLanguage, userLocaleService.LocaliseValue(Value));
            }
             
            return localisedValues[userLocaleService.CurrentLanguage];
        }

        public override string ToString()
        {
            return GetLocalisedValue();
        }

        public static implicit operator LocalisationString(string value)
        {
            return new LocalisationString(DependencyResolver.Current.GetService<IUserLocaleService>())
            {
                Value = value
            };
        }

        public static implicit operator string(LocalisationString value)
        {
            return value.ToString();
        }
    }
}