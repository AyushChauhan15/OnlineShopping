﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingAPI.DTO
{
    
    public partial class Order_Details
    {
        /// <summary>
        /// The order id of the order-detail.
        /// </summary>
       
        public int OrderID { get; set; }

        /// <summary>
        /// The product id of the order-detail.
        /// </summary>
       
        public int ProductID { get; set; }

        /// <summary>
        /// The unit price of the product.
        /// </summary>
       
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The product's quantity.
        /// </summary>
        public short Quantity { get; set; }

        /// <summary>
        /// The product's discount.
        /// </summary>
        public float Discount { get; set; }

        /// <summary>
        /// The order of the order-detail.
        /// </summary>
        public virtual Orders Order { get; set; }

        /// <summary>
        /// The product of the order-detail.
        /// </summary>
        public virtual Products Product { get; set; }
    }
}
