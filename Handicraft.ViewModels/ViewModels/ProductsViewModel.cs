using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.ViewModels.ViewModels
{
    public class ProductsViewModel
    {
        public string Id { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public string CategoryId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Size { get; set; } = null!;
        public string Material { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public List<ImagesViewModel> Images { get; set; } = null!;
    }
}
