using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace QuizScoreTracker.Converters
{
    public class DateConverter : DateTimeConverterBase
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }
            else
            {
                if (reader.TokenType == JsonToken.String)
                {
                    try
                    {
                        return DateTime.Parse((string)reader.Value);
                    }
                    catch (Exception ex)
                    {
                        throw new JsonSerializationException($"Error parsing DateTime string: {reader.Value}", ex);
                    }
                }
                else
                {
                    throw new JsonSerializationException($"Unexpected token or value when parsing DateTime. Token: {reader.TokenType}, Value: {reader.Value}");
                }
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else if (value is DateTime)
            {
                writer.WriteValue($"{value:yyyy-MM-dd}");
            }
            else
            {
                throw new JsonSerializationException("Expected DateTime object value");
            }
        }
    }
}