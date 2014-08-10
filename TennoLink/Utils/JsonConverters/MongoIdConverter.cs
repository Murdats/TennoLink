using System;
using System.Linq;
using Newtonsoft.Json;

namespace TennoLink.Utils.JsonConverters
{
    public class MongoIdConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("$id");
            writer.WriteValue(value.ToString());
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var id = "";

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName && reader.Value.ToString().ToLower() == "$id")
                {
                    id = reader.ReadAsString();
                }
                if (reader.TokenType == JsonToken.EndObject)
                {
                    break;
                }
            }

            return id;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}