using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TennoLink.Utils.JsonConverters
{
    public class MongoDateConverter : DateTimeConverterBase
    {
        private static readonly DateTime epoch = DateTime.SpecifyKind(new DateTime(1970,1,1), DateTimeKind.Utc);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var timeSinceEpoch = ((DateTime)value).Subtract(epoch);
            writer.WriteStartObject();
            writer.WritePropertyName("sec");
            writer.WriteValue(timeSinceEpoch.TotalSeconds);
            writer.WritePropertyName("usec");
            writer.WriteValue(timeSinceEpoch.Milliseconds);
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            long seconds = 0;
            long milliseconds = 0;
            
            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    if (reader.Value.ToString().ToLower() == "sec")
                    {
                        var valueString = reader.ReadAsString();
                        long.TryParse(valueString, out seconds);
                    }
                    if (reader.Value.ToString().ToLower() == "usec")
                    {
                        var valueString = reader.ReadAsString();
                        long.TryParse(valueString, out milliseconds);
                    }
                }
                if (reader.TokenType == JsonToken.EndObject)
                {
                    break;
                }
            }

            return epoch.AddSeconds(seconds).AddMilliseconds(milliseconds);
        }
    }
}