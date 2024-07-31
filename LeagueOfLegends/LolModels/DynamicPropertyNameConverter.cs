using Newtonsoft.Json;
using System;

public class DynamicPropertyNameConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(int);
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        int intValue = (int)value;
        if (intValue >= 1 && intValue <= 9)
        {
            writer.WriteStartObject();
            writer.WritePropertyName(intValue.ToString());
            writer.WriteValue(intValue);
            writer.WriteEndObject();
        }
        else
        {
            throw new JsonSerializationException("Property value must be between 1 and 9.");
        }
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.StartObject)
        {
            reader.Read();
            if (reader.TokenType == JsonToken.PropertyName)
            {
                string propertyName = (string)reader.Value;
                if (int.TryParse(propertyName, out int value) && value >= 1 && value <= 9)
                {
                    reader.Read();
                    int intValue = reader.ReadAsInt32().Value;
                    reader.Read();
                    return intValue;
                }
            }
        }
        throw new JsonSerializationException("Invalid JSON format for dynamic property name.");
    }
}
