﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.ViewModels.ViewModel
{
    public class CartsViewModel
    {
        public string Id { get; private set; }       
        public UsersViewModel UserId { get; set; }  =  new UsersViewModel();
        public ProductsViewModel ProductId { get; set; } = new ProductsViewModel();
        public int Amount { get; set; }
    }
}
