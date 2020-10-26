using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mapper.Models
{
    // Dùng để Mapping lấy dữ liệu từ các trường trong Object ra trường đơn
    public class ProjectionCalenderEventForm
    {
        public DateTime EventDate { get; set; }
        public int EventHour { get; set; }
        public int EventMinute { get; set; }
        public string Title { get; set; }
    }
}
