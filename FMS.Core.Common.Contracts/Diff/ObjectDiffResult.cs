using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;

namespace FMS.Core.Common.Contracts.Diff
{
    /// <summary>
    /// Result of a diff operation between two objects
    /// </summary>
    public class ObjectDiffResult
    {
        /// <summary>
        /// If the compared objects are equal.
        /// </summary>
        /// <value>True if the objects are equal; otherwise, false.</value>
        public bool AreEqual => OldValues == null && NewValues == null;

        /// <summary>
        /// The type of the compared objects.
        /// </summary>
        /// <value>The type of the compared objects.</value>
        [JsonIgnore]
        public Type Type { get; set; }

        /// <summary>
        /// The values modified in the original object.
        /// </summary>
        public JObject OldValues { get; set; }

        /// <summary>
        /// The values modified in the updated object.
        /// </summary>
        public JObject NewValues { get; set; }
    }
}
