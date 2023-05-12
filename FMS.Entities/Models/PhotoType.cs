using FMS.Entities.Models.Base;
using System;

namespace FMS.Entities.Models
{
    public class PhotoType : BaseAuditableModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsLocationRequired { get; set; }
    }
}
