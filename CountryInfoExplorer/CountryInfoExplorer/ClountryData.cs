using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

public class Country
{
    [JsonProperty("name")]
    public Name Name { get; set; }

    [JsonProperty("population")]
    public long Population { get; set; }

    [JsonProperty("region")]
    public string Region { get; set; }

    [JsonProperty("subregion")]
    public string Subregion { get; set; }

    [JsonProperty("capital")]
    public List<string> Capital { get; set; }

    [JsonProperty("flags")]
    public Flags Flags { get; set; }
}

public class Name
{
    [JsonProperty("common")]
    public string Common { get; set; }

    [JsonProperty("official")]
    public string Official { get; set; }
}

public class Flags
{
    [JsonProperty("png")]
    public string Png { get; set; }
    [JsonProperty("svg")]
    public string Svg { get; set; } 
}
