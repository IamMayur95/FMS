using FMS.Entities.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Entities.DTOs
{
    public class GetDeskDetailDTO
    {
        public string DeskNumber { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

    }
}
