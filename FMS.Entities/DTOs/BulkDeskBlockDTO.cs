using FMS.Entities.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.Entities.DTOs
{
    public class BulkDeskBlockDTO
    {
        public List<int> DeskIds { get; set; } = new List<int>();
    }
}
