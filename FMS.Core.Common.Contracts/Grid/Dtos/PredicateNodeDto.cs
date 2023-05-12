using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using FMS.Core.Common.Contracts.Grid.Enums;

namespace FMS.Core.Common.Contracts.Grid.Dtos
{
    public class PredicateNodeDto
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public LogicalOperator Operator { get; set; }

        public List<PredicateNodeDto> Nodes { get; set; }
        public List<PredicateLeafDto> Leaves { get; set; }
    }
}
