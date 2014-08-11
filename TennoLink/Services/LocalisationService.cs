using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Hosting;
using Newtonsoft.Json;
using TennoLink.Services.Interfaces;

namespace TennoLink.Services
{
    public class LocalisationService : ILocalisationService
    {
        protected Dictionary<string, Dictionary<string, string>> resources = new Dictionary<string, Dictionary<string, string>>();

        public List<string> SupportedLanguages { get; protected set; }

        public LocalisationService()
        {
            SupportedLanguages = new List<string>();
            var resourceFolder = HostingEnvironment.MapPath(@"~/Localisation/");

            foreach(var filePath in Directory.GetFiles(resourceFolder))
            {
                string locale = null;
                var localeMatch = Regex.Match(Path.GetFileNameWithoutExtension(filePath), ".*_(.*)", RegexOptions.Compiled);
                if (localeMatch.Groups.Count > 1)
                {
                    locale = localeMatch.Groups[1].Value;
                }

                if (!string.IsNullOrEmpty(locale))
                {
                    using (var file = File.OpenRead(filePath))
                    {
                        var reader = new StreamReader(file);
                        resources[locale] = JsonConvert.DeserializeObject<Dictionary<string, string>>(reader.ReadToEnd());
                    }

                    SupportedLanguages.Add(locale);
                }
            }
        }

        public string LocaliseValue(string locale, string value)
        {
            if (resources.ContainsKey(locale))
            {
                string result = null;
                resources[locale].TryGetValue(value, out result);
                return result;
            }

            return null;
        }
    }
}