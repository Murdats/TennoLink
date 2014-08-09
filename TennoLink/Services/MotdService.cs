using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using TennoLink.Models;

namespace TennoLink.Services
{
    public interface IMotdService
    {
        string GetMotd();
    }

    public class MotdService : IMotdService
    {
        private readonly IConfig _config;

        public MotdService(IConfig config)
        {
            _config = config;
        }

        public string GetMotd()
        {
            var encodedMessage = GetMessage(_config.MotdUrl);
            return Decode(encodedMessage);
        }

        protected string GetMessage(string url)
        {
            var message = "";
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

        protected string Decode(string message)
        {
            var output = new MemoryStream();
            var input = new MemoryStream(Encoding.UTF8.GetBytes(message));
            var decoder = new SevenZip.Compression.LZMA.Decoder();

            // Read the decoder properties
            var properties = new byte[5];
            input.Read(properties, 0, 5);

            // Read in the decompress file size.
            var fileLengthBytes = new byte[8];
            input.Read(fileLengthBytes, 0, 8);
            var fileLength = BitConverter.ToInt64(fileLengthBytes, 0);

            decoder.Code(input, output, input.Length, fileLength, null);

            output.Position = 0;

            return new StreamReader(output).ReadToEnd();
        }
    }
}