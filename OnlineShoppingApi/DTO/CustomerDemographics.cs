using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingAPI.DTO
{
    public partial class CustomerDemographics
    {

        /// <summary>
        /// Default constructor. Initialises new empty instances for Customers.
        /// </summary>
        public CustomerDemographics()
        {
            Customers = new HashSet<Customers>();
        }

        /// <summary>
        /// The id of the customer.
        /// </summary>
       
        public string CustomerTypeID { get; set; }


        /// <summary>
        /// The description of the customer.
        /// </summary>
        
        public string CustomerDesc { get; set; }

        /// <summary>
        /// The customers with demographics.
        /// </summary>
        public virtual ICollection<Customers> Customers { get; set; }
    }
}
