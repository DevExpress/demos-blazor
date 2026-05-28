using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BlazorDemo.CRM.Utils;

class PhoneConverter : JsonConverter<string> {
    public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        var value = reader.GetString();
        return Regex.Replace(value ?? "", @"^(\d{3})(\d{3})(\d{4})$", "($1) $2-$3");
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options) {
        writer.WriteStringValue(Regex.Replace(value, @"\D", ""));
    }
}
