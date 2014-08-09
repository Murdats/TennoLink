using Itenso.Rtf;
using Itenso.Rtf.Converter.Html;
using Itenso.Rtf.Parser;
using Itenso.Rtf.Support;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Windows.Forms;
using TennoLink.Models;
using TennoLink.Services.Interfaces;

namespace TennoLink.Services
{
    public class MotdService : IMotdService
    {
        private readonly IConfig config;

        public MotdService(IConfig config)
        {
            this.config = config;
        }

        public string GetMotd()
        {
            // Convert the RTF to plain text.
            using(var rtBox = new RichTextBox())
            {
                rtBox.Rtf = GetMotdRaw();
                return rtBox.Text;
            }
        }

        public HtmlString GetMotdHtml()
        {
            var rtf = GetMotdRaw();
            var parserLogger = new RtfParserListenerFileLogger(@"F:\Code\Personal\TennoLink\TennoLink\rtfLog.txt");
            var rtfGroup = RtfParserTool.Parse(rtf, parserLogger);
            var rtfDocument = RtfInterpreterTool.BuildDoc(rtfGroup);

            var htmlConverter = new RtfHtmlConverter(rtfDocument);

            return new HtmlString(htmlConverter.Convert());
        }

        public string GetMotdRaw()
        {
            var encodedMessage = GetMessage(config.MotdUrl);
            if (encodedMessage == null)
                return "";
            //remove null terminator
            return (Decode(encodedMessage) ?? "").Trim('\0').Trim();
        }

        protected byte[] GetMessage(string url)
        {
            byte[] message = null;
            var client = new HttpClient();
            var request = client.GetAsync(url);

            request.Wait();

            var requestResult = request.Result;

            if (requestResult.StatusCode == HttpStatusCode.OK)
            {
                var resultBody = requestResult.Content.ReadAsByteArrayAsync();
                resultBody.Wait();

                message = resultBody.Result;
            }

            return message;
        }

        protected string Decode(byte[] message)
        {
            var output = new MemoryStream();
            var input = new MemoryStream(message);
            var decoder = new SevenZip.Compression.LZMA.Decoder();

            // Read the decoder properties
            var properties = new byte[5];
            input.Read(properties, 0, 5);

            decoder.SetDecoderProperties(properties);

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