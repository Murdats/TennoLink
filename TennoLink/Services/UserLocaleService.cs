using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TennoLink.Services.Interfaces;

namespace TennoLink.Services
{
    public class UserLocaleService : IUserLocaleService
    {
        private readonly ILocalisationService localisationService;

        private string language;

        protected const string DefaultLanguage = "en";
        protected const string cookieName = "lang";

        public UserLocaleService(ILocalisationService localisationService)
        {
            this.localisationService = localisationService;
        }

        public string CurrentLanguage
        {
            get
            {
                if (string.IsNullOrEmpty(language))
                {
                    language = GetUserLanguage();
                }

                return language;
            }
            set
            {
                language = value;
            }
        }

        public string LocaliseValue(string value)
        {
            return localisationService.LocaliseValue(CurrentLanguage, value);
        }

        protected string GetUserLanguage()
        {
            string lang = DefaultLanguage;

            if (HttpContext.Current != null && HttpContext.Current.Request != null)
            {
                var request = HttpContext.Current.Request;

                if (request.Cookies[cookieName] != null && !string.IsNullOrEmpty(request.Cookies[cookieName].Value))
                {
                    lang = request.Cookies["lang"].Value;
                }

                lang = request.UserLanguages.Select(p => p.Split('-').FirstOrDefault())
                    .Where(p => localisationService.SupportedLanguages.Contains(p))
                    .DefaultIfEmpty(DefaultLanguage).FirstOrDefault();
            }

            return lang;
        }
    }
}