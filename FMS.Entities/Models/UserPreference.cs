using FMS.Entities.Models.Base;
using FMS.Entities.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS.Entities.Models
{
    public class UserPreference : BaseAuditableModel
    {

        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }

        public virtual User User { get; set; }

        public UserPreferenceType UserPreferenceType { get; set; }

        [ForeignKey(nameof(LocationDetail))]
        public int? LocationDetailId { get; set; }

        public virtual LocationDetail LocationDetail { get; set; }

        [ForeignKey(nameof(BuildingDetail))]
        public int? BuildingDetailId { get; set; }

        public virtual BuildingDetail BuildingDetail { get; set; }

        [ForeignKey(nameof(WingDetail))]
        public int? WingDetailId { get; set; }

        public virtual WingDetail WingDetail { get; set; }

        [ForeignKey(nameof(FloorDetail))]
        public int? FloorDetailId { get; set; }
        public virtual FloorDetail FloorDetail { get; set; }
    }
}
