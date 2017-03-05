using Newtonsoft.Json;
using MixinExplorer.Utilities;


namespace MixinExplorer.Mixins.Core
{
    /// <summary>
    /// Contains implementation of the core functionality offerd by the JSON Serializable Mixin
    /// </summary>
    [JsonConverter(typeof(ToStringJsonConverter))]
    public static class JsonSerializableMixinCore
    {
        public static string ToJson(this JsonSerializableMixin subject) =>
            JsonConvert.SerializeObject(subject, Formatting.Indented);

        public static void FromJson<T>(this JsonSerializableMixin subject, string json) =>
            JsonConvert.DeserializeObject<T>(json);
    }
}
