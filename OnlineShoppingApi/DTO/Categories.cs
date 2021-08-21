using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingAPI.DTO
{
    public partial class Categories
    {
        /// <summary>
        /// Default constructor. Initialises new empty instances for Products.
        /// </summary>
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        /// <summary>
        /// The ID through which we find the category.
        /// </summary>
       
        public int CategoryID { get; set; }

        /// <summary>
        /// The name through which we find the category.
        /// </summary>
        
        public string CategoryName { get; set; }

        /// <summary>
        /// The description through which we find the category.
        /// </summary>
        
        public string Description { get; set; }

        /// <summary>
        /// A category may contains more products.
        /// </summary>
        public virtual ICollection<Products> Products { get; }
    }
}
