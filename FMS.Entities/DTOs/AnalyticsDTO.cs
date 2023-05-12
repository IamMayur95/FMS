using System.Collections.Generic;

namespace FMS.Entities.DTOs
{
    public class AnalyticsDTO
    {
        public List<string> ChartLabels { get; set; }
        public List<AnalyticData> ChartData { get; set; }
    }
}
