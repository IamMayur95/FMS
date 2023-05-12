using System.Collections.Generic;
using Newtonsoft.Json;

namespace FMS.Entities.DTOs
{
    public class MapConfDataParserDTO
    {
        public Assets assets { get; set; }
        public Models models { get; set; }
        public Areas areas { get; set; }
        public Sections sections { get; set; }
    }

    public class Pic
    {
        public string name { get; set; }
        public string @ref { get; set; }
    }

    public class Svg
    {
        public string name { get; set; }
        public string @ref { get; set; }
    }

    public class Assets
    {
        public Pic pic { get; set; }
        public Svg svg { get; set; }
    }

    public class Mod
    {
        public string name { get; set; }
        public string template { get; set; }
    }

    public class Models
    {
        [JsonProperty("Mod-1")]
        public Mod Mod1 { get; set; }

        [JsonProperty("Mod-2")]
        public Mod Mod2 { get; set; }

        [JsonProperty("Mod-3")]
        public Mod Mod3 { get; set; }

        [JsonProperty("Mod-4")]
        public Mod Mod4 { get; set; }

        [JsonProperty("Mod-5")]
        public Mod Mod5 { get; set; }

        [JsonProperty("Mod-6")]
        public Mod Mod6 { get; set; }
    }

    public class Area
    {
        public string tag { get; set; }
    }

    public class Areas
    {
        [JsonProperty("Area-1")]
        public Area Area1 { get; set; }

        [JsonProperty("Area-2")]
        public Area Area2 { get; set; }

        [JsonProperty("Area-3")]
        public Area Area3 { get; set; }

        [JsonProperty("Area-4")]
        public Area Area4 { get; set; }

        [JsonProperty("Area-5")]
        public Area Area5 { get; set; }

        [JsonProperty("Area-6")]
        public Area Area6 { get; set; }

        [JsonProperty("Area-7")]
        public Area Area7 { get; set; }

        [JsonProperty("Area-8")]
        public Area Area8 { get; set; }

        [JsonProperty("Area-9")]
        public Area Area9 { get; set; }

        [JsonProperty("Area-10")]
        public Area Area10 { get; set; }

        [JsonProperty("Area-11")]
        public Area Area11 { get; set; }

        [JsonProperty("Area-12")]
        public Area Area12 { get; set; }

        [JsonProperty("Area-13")]
        public Area Area13 { get; set; }

        [JsonProperty("Area-14")]
        public Area Area14 { get; set; }

        [JsonProperty("Area-15")]
        public Area Area15 { get; set; }

        [JsonProperty("Area-16")]
        public Area Area16 { get; set; }

        [JsonProperty("Area-17")]
        public Area Area17 { get; set; }

        [JsonProperty("Area-18")]
        public Area Area18 { get; set; }
    }

    public class Unit
    {
        public string tag { get; set; }
        public string active { get; set; }
        public string @ref { get; set; }
        public string transform { get; set; }
    }

    public class Section
    {
        public string tag { get; set; }
        public string active { get; set; }
        public List<Unit> units { get; set; }
    }

    public class Sections
    {
        [JsonProperty("Section-1")]
        public Section Section1 { get; set; }

        [JsonProperty("Section-2")]
        public Section Section2 { get; set; }

        [JsonProperty("Section-3")]
        public Section Section3 { get; set; }

        [JsonProperty("Section-4")]
        public Section Section4 { get; set; }

        [JsonProperty("Section-5")]
        public Section Section5 { get; set; }

        [JsonProperty("Section-6")]
        public Section Section6 { get; set; }

        [JsonProperty("Section-7")]
        public Section Section7 { get; set; }

        [JsonProperty("Section-8")]
        public Section Section8 { get; set; }

        [JsonProperty("Section-9")]
        public Section Section9 { get; set; }

        [JsonProperty("Section-10")]
        public Section Section10 { get; set; }

        [JsonProperty("Section-11")]
        public Section Section11 { get; set; }

        [JsonProperty("Section-12")]
        public Section Section12 { get; set; }

        [JsonProperty("Section-13")]
        public Section Section13 { get; set; }

        [JsonProperty("Section-14")]
        public Section Section14 { get; set; }

        [JsonProperty("Section-15")]
        public Section Section15 { get; set; }
    }
}
