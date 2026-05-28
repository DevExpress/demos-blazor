using System.Text.Json.Serialization;

//https://github.com/dotnet/aspnetcore/issues/52947
namespace BlazorDemo.CRM.Utils {
    public class KeyValuePairSerializer<TKey, TValue> {
        public KeyValuePairSerializer(TKey key, TValue value) {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }

        public TValue Value { get; set; }

        [JsonIgnore] public KeyValuePair<TKey, TValue> ToKeyValuePair => new(Key, Value);
    }
}
