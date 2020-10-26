using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mapper.Entities
{
    // Dùng để Mapping lấy dữ liệu từ các trường trong Object ra trường đơn
    public class ProjectionCalenderEvent
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
    }
}
