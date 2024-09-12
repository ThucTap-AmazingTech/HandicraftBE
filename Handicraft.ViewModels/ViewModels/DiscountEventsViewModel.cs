using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.ViewModels.ViewModel
{
    public class DiscountEventsViewModel
    {
        public string? Id { get; private set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string? Description { get; set; }
        public float DiscountPercent { get; set; }
        public double DiscountPrice { get; set; }
    }
}
