using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingAPI.DTO
{
    public partial class Shippers
    {

        /// <summary>
        ///  Default constructor. Initialises new empty instances for Orders.
        /// </summary>
        public Shippers()
        {
            Orders = new HashSet<Orders>();
        }


        /// <summary>
        /// The ID through which we find the shipper.
        /// </summary>
       
        public int ShipperID { get; set; }

        /// <summary>
        /// The CompanyName through which we find the shipper.
        /// </summary>
        
        public string CompanyName { get; set; }

        /// <summary>
        /// The Phone through which we find the shipper.
        /// </summary>
        
        public string Phone { get; set; }


        /// <summary>
        /// The shipper which contains more orders.
        /// </summary>
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
