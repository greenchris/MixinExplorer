using Newtonsoft.Json;
using System;
using MixinExplorer.Model;
using Newtonsoft.Json.Linq;

namespace MixinExplorer.Utilities
{
    public class CustomJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => true;
        public override bool CanRead => true;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            => writer.WriteValue(value.ToString());

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            var jObject = JObject.Load(reader);
            var target = new Ninja();

            using (JsonReader jObjectReader = CopyReaderForObject(reader, jObject))
            {
                serializer.Populate(jObjectReader, target);
            }
            return target;
        }

        #region private utils

        /// <summary>
        /// Creates new reader for the specified jObject, by copying the settings
        /// from an existing reader.
        /// </summary>
        private JsonReader CopyReaderForObject(JsonReader reader, JObject jObject)
        {
            JsonReader jObjectReader = jObject.CreateReader();

            jObjectReader.Culture = reader.Culture;
            jObjectReader.DateFormatString = reader.DateFormatString;
            jObjectReader.DateParseHandling = reader.DateParseHandling;
            jObjectReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
            jObjectReader.FloatParseHandling = reader.FloatParseHandling;
            jObjectReader.MaxDepth = reader.MaxDepth;
            jObjectReader.SupportMultipleContent = reader.SupportMultipleContent;

            return jObjectReader;
        }

        #endregion
    }
}
