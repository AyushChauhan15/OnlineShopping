using OnlineShoppingAPI.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;


namespace OnlineShoppingAPI.DTO.ShopCart
{
    public class ProductShopCart
    {
        /// <summary>
        /// product id from shopcart
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// quantity of product
        /// </summary>
        public int Quantity { get; set; } = 1;
        /// <summary>
        /// total price
        /// </summary>
        public string TotalPrice { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
    }

    public class shoppingcartDetails
    {
        public List<DTO.Shippers> shippers { get; set; }
        public List<DTO.ShopCart.ProductShopCart> cart { get; set; }
    }

    /// <summary>
    /// ProductShopCartDetailed have aditional information about the product as against ProductShopCart
    /// </summary>
    public class ProductShopCartDetailed : ProductShopCart
    {

        /// <summary>
        /// Get category of this product
        /// </summary>
        public string ProductName
        {
            get
            {
                return (new OnlineShoppingDbContext()).Products.Find(ID).ProductName;
            }
            set
            {

            }
        }

        /// <summary>
        /// get unit price of this product
        /// </summary>
        public decimal UnitPrice
        {
            get
            {
                return (new OnlineShoppingDbContext()).Products.Find(ID).UnitPrice ?? 99999999;
            }
            set
            {

            }
        }

        /// <summary>
        /// get the category of this product
        /// </summary>
        public string Category
        {
            get
            {
                return (new OnlineShoppingDbContext()).Products.Find(ID).Category.CategoryName;
            }
            set
            {

            }
        }

    }
}
