using FMS.Entities.Models.Base;
using FMS.Entities.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS.Entities.Models
{
    public class MapConfiguration : BaseAuditableModel
    {
        public string MapId { get; set; }

        [Column(TypeName = "json")]
        public string JsonMapData { get; set; }
        public string Version { get; set; }
    }
}
