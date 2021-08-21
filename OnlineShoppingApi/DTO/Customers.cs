using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingAPI.DTO
{
    public partial class Customers
    {

        /// <summary>
        /// Default constructor. Initialises new empty instances for Orders and CustomerDemographics..
        /// </summary>
        public Customers()
        {
            Orders = new HashSet<Orders>();
            CustomerDemographics = new HashSet<CustomerDemographics>();
        }

        /// <summary>
        /// The id of the customer.
        /// </summary>
       
        public string CustomerID { get; set; }

        /// <summary>
        /// The name of the company which is the customer.
        /// </summary>
       
        public string CompanyName { get; set; }

        /// <summary>
        /// The name of the contact person from the company.
        /// </summary>
      
        public string ContactName { get; set; }

        /// <summary>
        /// The function of the contact person.
        /// </summary>
       
        public string ContactTitle { get; set; }

        /// <summary>
        /// The adress of the customer.
        /// </summary>
       
        public string Address { get; set; }

        /// <summary>
        /// The customer's city.
        /// </summary>
        
        public string City { get; set; }

        /// <summary>
        /// The customer's region.
        /// </summary>
       
        public string Region { get; set; }

        /// <summary>
        /// The customer's postal code.
        /// </summary>
       
        public string PostalCode { get; set; }

        /// <summary>
        /// The customer's country.
        /// </summary>
       
        public string Country { get; set; }

        /// <summary>
        /// The phone number of the customer.
        /// </summary>
       
        public string Phone { get; set; }

        /// <summary>
        /// The fax of the customer.
        /// </summary>
        
        public string Fax { get; set; }

        /// <summary>
        /// The orders of the customer.
        /// </summary>
        public virtual ICollection<Orders> Orders { get; set; }

        /// <summary>
        /// The demography of the customer.
        /// </summary>
        public virtual ICollection<CustomerDemographics> CustomerDemographics { get; set; }
    }
}
