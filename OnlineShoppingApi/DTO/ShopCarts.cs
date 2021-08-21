using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingAPI.DTO
{
    
    public partial class ShopCarts
    {
        /// <summary>
        /// The name of the user who added a product in the shopcart
        /// </summary>
       
        public string UserName { get; set; }

        /// <summary>
        /// The id of the product added.
        /// </summary>
       
        public int ProductID { get; set; }

        /// <summary>
        /// The quantity of the product.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The products contained by the shopcart
        /// </summary>
        public virtual Products Products { get; set; }
    }
   
    public partial class WishLists
    {
        /// <summary>
        /// The name of the user who added a product in the shopcart
        /// </summary>
       
        public string UserName { get; set; }

        /// <summary>
        /// The id of the product added.
        /// </summary>
       
        public int ProductID { get; set; }

        /// <summary>
        /// The quantity of the product.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The products contained by the shopcart
        /// </summary>
        public virtual Products Products { get; set; }
    }

    
    public partial class Transactions
    {
        /// <summary>
        /// The name of the user who added a product in the shopcart
        /// </summary>
       

        public int TransactionID { get; set; }

       
        public string Email { get; set; }

        /// <summary>
        /// The id of the product added.
        /// </summary>

        public string Amount { get; set; }

        /// <summary>
        /// The quantity of the product.
        /// </summary>
        public string CardNo { get; set; }

        public string CardHolderName { get; set; }

        public string CVV { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
        /// <summary>
        /// The products contained by the shopcart
        /// </summary>
        public virtual Transactions Transaction { get; set; }
    }
}
