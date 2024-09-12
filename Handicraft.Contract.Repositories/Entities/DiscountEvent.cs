using Handicraft.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.Contract.Repositories.Entities
{
    public class DiscountEvent : BaseEntity
    {
        [Required]
        public DateTime StartDate  { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }
        public float DiscountPercent { get; set; }
        public double DiscountPrice { get; set; }

    }
}
