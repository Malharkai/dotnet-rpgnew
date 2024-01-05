using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Fighter = 1,
        Cleric = 2,
        Druid = 3,
        Ranger = 4,
        Mage = 5,
        Rouge = 6

    }
}