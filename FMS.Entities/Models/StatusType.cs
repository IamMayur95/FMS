using FMS.Entities.Models.Base;
using FMS.Entities.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FMS.Entities.Models
{
    public class StatusType : BaseAuditableModel
    {

        [StringLength(4000)]
        [Required]
        public string Name { get; set; }

        public FMSBookingType Type { get; set; }


    }
}
