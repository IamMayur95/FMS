using System;
using System.Collections.Generic;
using FMS.Entities.Models;
using FMS.Entities.Models.Enums;

namespace FMS.Entities.DTOs
{
    public class AnalyticData
    {
        public string Label { get; set; }
        public List<int> Data { get; set; }
    }
}
