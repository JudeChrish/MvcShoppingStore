﻿using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.WEBUI.Models
{
    public class CartIndexViewModel
    {
        public Cart cart { get; set; }
        public string ReturnUlr { get; set; }
    }
}