using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using TennoLink.Models;
using TennoLink.Models.Interfaces;
using TennoLink.Services.Interfaces;
using TennoLink.Utils.JsonConverters;

namespace TennoLink.Services
{
    public class WarframeStatusService : IWarframeStatusService
    {
        private readonly IConfig config;

        public WarframeStatusService(IConfig config)
        {
            this.config = config;
        }

        public Status GetStatus()
        {
            var json = GetStatusJson(config.StatusUrl);
            
            return JsonConvert.DeserializeObject<Status>(json, new MongoDateConverter(), new EnumIdentifierConverter(), new LocalisationStringConverter());

        }

        protected string GetStatusJson(string url)
        {
            string message = null;
            var client = new HttpClient();
            var request = client.GetAsync(url);

            request.Wait();

            var requestResult = request.Result;

            if (requestResult.StatusCode == HttpStatusCode.OK)
            {
                var resultBody = requestResult.Content.ReadAsStringAsync();
                resultBody.Wait();

                message = resultBody.Result;
            }

            return message;
        }
    }
}