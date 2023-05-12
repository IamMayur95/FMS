using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using FMS.Core.Common.Contracts.Grid.Enums;

namespace FMS.Core.Common.Contracts.Grid.Dtos
{
    public class PredicateLeafDto
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public PredicateType Predicate { get; set; }

        public string PropertyName { get; set; }
        public object Value { get; set; }
    }
}
