using System;
using System.Linq;
using Newtonsoft.Json.Converters;

namespace TennoLink.Utils.JsonConverters
{
    public class EnumIdentifierConverter : StringEnumConverter 
    {
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            var attribute = GetAttribute(type, name);

            if (attribute == null || string.IsNullOrEmpty(attribute.Value))
            {
                base.WriteJson(writer, value, serializer);
            }
            else
            {
                writer.WriteValue(attribute.Value);
            }
        }

        public override object ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            object value = null;
            foreach(var field in Enum.GetNames(objectType))
            {
                var attribute = GetAttribute(objectType, field);
                if (attribute != null && 
                    !string.IsNullOrEmpty(attribute.Value) && 
                    attribute.Value.ToLower().Trim() == reader.Value.ToString().ToLower().Trim())
                {
                    value = Enum.Parse(objectType, field);
                }
            }

            if (value == null)
            {
                value = base.ReadJson(reader, objectType, existingValue, serializer);
            }

            return value;
        }

        protected IdentifierAttribute GetAttribute(Type type, string field)
        {
            return type.GetField(field)
                       .GetCustomAttributes(false)
                       .OfType<IdentifierAttribute>()
                       .SingleOrDefault();
        }
    }
}