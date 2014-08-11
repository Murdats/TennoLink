using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TennoLink.Utils.JsonConverters
{
    public class LocalisationStringConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue((value as LocalisationString).ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            LocalisationString value = reader.Value.ToString();
            return value;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LocalisationString);
        }
    }
}