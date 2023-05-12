using NPOI.SS.Formula.Functions;
using System;

namespace FMS.Entities.DTOs
{
    public class PhotoTypeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsLocationRequired { get; set; }

    }

}
